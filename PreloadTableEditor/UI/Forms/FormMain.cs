using Newtonsoft.Json;
using PreloadTableEditor.Data;
using PreloadTableEditor.JSON.Converters;
using PreloadTableEditor.JSON.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

            openFileDialog = new OpenFileDialog();
            saveFileDialog = new SaveFileDialog();
            assetBundleFile = null;
            containers = new BindingList<Data.Container>();
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
                        assetBundleFile = JsonConvert.DeserializeObject<AssetBundle>(json, new JSON.Converters.ContainerConverter());
                        UpdateAll();
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
                        string json = JsonConvert.SerializeObject(assetBundleFile, new JSON.Converters.ContainerConverter());
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

        private void CreateContainerList()
        {
            containers.Clear();
            containers = new BindingList<Data.Container>(Data.Converters.ContainerConverter.ConvertAssetBundleToContainers(assetBundleFile));
        }

        private void ApplyContainerListChanges()
        {
            Data.Converters.ContainerConverter.UpdateContainersToAssetBundle(assetBundleFile, containers.ToList());
        }

        private void UpdateAll()
        {
            CreateContainerList();
            UpdateFullList();
            UpdateContainerList();
            UpdateContainerEditing((Data.Container)listContainers.SelectedItem);
        }

        private void UpdateFullList()
        {
            listAllFiles.DataSource = new BindingList<JSON.Data.UnityFile>(assetBundleFile.PreloadTable);
        }

        private void UpdateContainerList()
        {
            listContainers.DataSource = containers;
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
            lbContainerName.Text = container.Name;
            lbFileCount.Text = string.Format("This container preloads {0} assets.", container.Assets.Count);
        }

        private void btnAddPath_Click(object sender, EventArgs e)
        {
            if (!long.TryParse(txtFileID.Text, out var fileID))
            {
                MessageBox.Show("Error when parsing the file ID!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (!long.TryParse(txtPathID.Text, out var pathID))
            {
                MessageBox.Show("Error when parsing the path ID!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
    }
}
