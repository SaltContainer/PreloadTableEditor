using Newtonsoft.Json;
using PreloadTableEditor.Data;
using PreloadTableEditor.JSON.Converters;
using PreloadTableEditor.JSON.Data;
using PreloadTableEditor.UI.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PreloadTableEditor.UI.Forms
{
    public partial class FormMain : Form
    {
        private OpenFileDialog openFileDialog;
        private SaveFileDialog saveFileDialog;
        private AssetBundle assetBundleFile;
        private BindingList<Data.Container> containers;

        public FormMain()
        {
            InitializeComponent();
            ToggleControls(false);

            tscomboFormat.SelectedIndex = (int)PreloadTableFileFormat.NoArrayField;

            openFileDialog = new OpenFileDialog();
            saveFileDialog = new SaveFileDialog();
            assetBundleFile = null;
            containers = new BindingList<Data.Container>();
        }

        private void CreateContainerList()
        {
            containers.Clear();
            containers = new BindingList<Data.Container>(Data.Converters.ContainerConverter.ConvertAssetBundleToContainers(assetBundleFile));
        }

        private void ApplyContainerListChanges()
        {
            Data.Converters.ContainerConverter.UpdateContainersToAssetBundle(assetBundleFile, containers.ToList());
        }

        private void AddBindings()
        {
            listContainers.DataSource = containers;
        }

        private void UpdateAll()
        {
            CreateContainerList();
            AddBindings();
            UpdateContainerList();
            UpdateContainerEditing((Data.Container)listContainers.SelectedItem);
        }

        private void UpdateContainerList()
        {
            containers.ResetBindings();
        }

        private void UpdateFilesOfContainerList(Data.Container container)
        {
            listFilesOfContainer.DataSource = GetListOfFilesOfContainer(container);
        }

        private BindingList<Data.UnityFile> GetListOfFilesOfContainer(Data.Container container)
        {
            return new BindingList<Data.UnityFile>(container.Assets);
        }

        private void UpdateContainerEditing(Data.Container container)
        {
            UpdateFilesOfContainerList(container);
            txtContainerName.Text = container.Name;
            lbMainAsset.Text = string.Format("Main Asset: File {0} : {1}", container.MainAsset.FileID, container.MainAsset.PathID);
            lbFileCount.Text = string.Format("This container preloads {0} assets.", container.Assets.Count);
        }

        private void ToggleControls(bool state)
        {
            tsbSave.Enabled = state;

            listContainers.Enabled = state;
            btnAddContainer.Enabled = state;
            btnRemoveContainer.Enabled = state;

            txtContainerName.Enabled = state;
            btnRenameContainer.Enabled = state;
            txtFileID.Enabled = state;
            txtPathID.Enabled = state;
            btnAddPath.Enabled = state;
            btnRemovePath.Enabled = state;
            btnMainPath.Enabled = state;
            listFilesOfContainer.Enabled = state;
        }

        private void tsbOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamReader r = new StreamReader(openFileDialog.FileName))
                    {
                        string json = r.ReadToEnd();

                        switch ((PreloadTableFileFormat)tscomboFormat.SelectedIndex)
                        {
                            case PreloadTableFileFormat.NoArrayField:
                            default:
                                assetBundleFile = JsonConvert.DeserializeObject<AssetBundle>(json, new JSON.Converters.ContainerConverter());
                                break;

                            case PreloadTableFileFormat.WithArrayField:
                                ArrayFieldAssetBundle tempBundle = JsonConvert.DeserializeObject<ArrayFieldAssetBundle>(json);
                                assetBundleFile = Data.Converters.ContainerConverter.ConvertFromArrayFieldBundle(tempBundle);
                                break;
                        }

                        UpdateAll();
                        ToggleControls(true);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(string.Format("An exception occurred when reading this file. Full exception: {0}", ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamWriter w = new StreamWriter(saveFileDialog.FileName))
                    {
                        ApplyContainerListChanges();

                        string json = "";

                        switch ((PreloadTableFileFormat)tscomboFormat.SelectedIndex)
                        {
                            case PreloadTableFileFormat.NoArrayField:
                            default:
                                json = JsonConvert.SerializeObject(assetBundleFile, Formatting.Indented, new JSON.Converters.ContainerConverter());
                                break;

                            case PreloadTableFileFormat.WithArrayField:
                                ArrayFieldAssetBundle tempBundle = Data.Converters.ContainerConverter.ConvertToArrayFieldBundle(assetBundleFile);
                                json = JsonConvert.SerializeObject(tempBundle, Formatting.Indented);
                                break;
                        }

                        w.WriteLine(json);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(string.Format("An exception occurred when writing to this file. Full exception: {0}", ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void listContainers_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateContainerEditing((Data.Container)listContainers.SelectedItem);
        }

        private void btnAddPath_Click(object sender, EventArgs e)
        {
            if (!long.TryParse(txtFileID.Text, out var fileID))
            {
                MessageBox.Show("Error when parsing the file ID!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!long.TryParse(txtPathID.Text, out var pathID))
            {
                MessageBox.Show("Error when parsing the path ID!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ((Data.Container)listContainers.SelectedItem).Assets.Add(new Data.UnityFile()
            {
                FileID = fileID,
                PathID = pathID
            });
            UpdateContainerEditing((Data.Container)listContainers.SelectedItem);
        }

        private void btnRemovePath_Click(object sender, EventArgs e)
        {
            ((BindingList<Data.UnityFile>)listFilesOfContainer.DataSource).RemoveAt(listFilesOfContainer.SelectedIndex);
            UpdateContainerEditing((Data.Container)listContainers.SelectedItem);
        }

        private void btnRenameContainer_Click(object sender, EventArgs e)
        {
            ((Data.Container)listContainers.SelectedItem).Name = txtContainerName.Text;
            UpdateContainerList();
        }

        private void btnAddContainer_Click(object sender, EventArgs e)
        {
            Data.Container container = new Data.Container();
            container.Name = "new/added/container.prefab";
            container.Assets = new List<Data.UnityFile>();
            container.MainAsset = new Data.UnityFile()
            {
                FileID = 0,
                PathID = 0
            };

            containers.Add(container);
            UpdateContainerList();
            listContainers.SelectedIndex = containers.Count - 1;
            UpdateContainerEditing(container);
        }

        private void btnRemoveContainer_Click(object sender, EventArgs e)
        {
            containers.Remove((Data.Container)listContainers.SelectedItem);
            UpdateContainerList();
            UpdateContainerEditing((Data.Container)listContainers.SelectedItem);
        }

        private void btnMainPath_Click(object sender, EventArgs e)
        {
            if (!long.TryParse(txtFileID.Text, out var fileID))
            {
                MessageBox.Show("Error when parsing the file ID!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!long.TryParse(txtPathID.Text, out var pathID))
            {
                MessageBox.Show("Error when parsing the path ID!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ((Data.Container)listContainers.SelectedItem).MainAsset = new Data.UnityFile()
            {
                FileID = fileID,
                PathID = pathID
            };
            UpdateContainerEditing((Data.Container)listContainers.SelectedItem);
        }
    }
}
