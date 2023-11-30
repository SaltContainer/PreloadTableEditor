namespace PreloadTableEditor.UI.Forms
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listContainers = new ListBox();
            listFilesOfContainer = new ListBox();
            lbContainerName = new Label();
            tsToolStrip = new ToolStrip();
            tsbOpen = new ToolStripButton();
            tsbSave = new ToolStripButton();
            tss1 = new ToolStripSeparator();
            tscomboFormat = new ToolStripComboBox();
            grpEditContainer = new GroupBox();
            lbMainAsset = new Label();
            lbFileCount = new Label();
            btnMainPath = new Button();
            btnAddPath = new Button();
            btnRemovePath = new Button();
            lbPathID = new Label();
            txtPathID = new TextBox();
            lbFileID = new Label();
            txtFileID = new TextBox();
            btnRenameContainer = new Button();
            txtContainerName = new TextBox();
            btnAddContainer = new Button();
            btnRemoveContainer = new Button();
            tsToolStrip.SuspendLayout();
            grpEditContainer.SuspendLayout();
            SuspendLayout();
            // 
            // listContainers
            // 
            listContainers.Enabled = false;
            listContainers.FormattingEnabled = true;
            listContainers.ItemHeight = 15;
            listContainers.Location = new Point(12, 42);
            listContainers.Name = "listContainers";
            listContainers.Size = new Size(436, 109);
            listContainers.TabIndex = 1;
            listContainers.SelectedIndexChanged += listContainers_SelectedIndexChanged;
            // 
            // listFilesOfContainer
            // 
            listFilesOfContainer.Enabled = false;
            listFilesOfContainer.FormattingEnabled = true;
            listFilesOfContainer.ItemHeight = 15;
            listFilesOfContainer.Location = new Point(362, 19);
            listFilesOfContainer.Name = "listFilesOfContainer";
            listFilesOfContainer.Size = new Size(200, 244);
            listFilesOfContainer.TabIndex = 2;
            // 
            // lbContainerName
            // 
            lbContainerName.AutoSize = true;
            lbContainerName.Location = new Point(6, 25);
            lbContainerName.Name = "lbContainerName";
            lbContainerName.Size = new Size(97, 15);
            lbContainerName.TabIndex = 3;
            lbContainerName.Text = "Container Name:";
            // 
            // tsToolStrip
            // 
            tsToolStrip.Items.AddRange(new ToolStripItem[] { tsbOpen, tsbSave, tss1, tscomboFormat });
            tsToolStrip.Location = new Point(0, 0);
            tsToolStrip.Name = "tsToolStrip";
            tsToolStrip.Size = new Size(594, 39);
            tsToolStrip.TabIndex = 4;
            tsToolStrip.Text = "toolStrip1";
            // 
            // tsbOpen
            // 
            tsbOpen.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbOpen.Image = Properties.Resources.folder;
            tsbOpen.ImageScaling = ToolStripItemImageScaling.None;
            tsbOpen.ImageTransparentColor = Color.Magenta;
            tsbOpen.Name = "tsbOpen";
            tsbOpen.Size = new Size(36, 36);
            tsbOpen.Text = "toolStripButton1";
            tsbOpen.ToolTipText = "Open";
            tsbOpen.Click += tsbOpen_Click;
            // 
            // tsbSave
            // 
            tsbSave.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbSave.Enabled = false;
            tsbSave.Image = Properties.Resources.save;
            tsbSave.ImageScaling = ToolStripItemImageScaling.None;
            tsbSave.ImageTransparentColor = Color.Magenta;
            tsbSave.Name = "tsbSave";
            tsbSave.Size = new Size(36, 36);
            tsbSave.Text = "toolStripButton2";
            tsbSave.ToolTipText = "Save";
            tsbSave.Click += tsbSave_Click;
            // 
            // tss1
            // 
            tss1.Name = "tss1";
            tss1.Size = new Size(6, 39);
            // 
            // tscomboFormat
            // 
            tscomboFormat.DropDownStyle = ComboBoxStyle.DropDownList;
            tscomboFormat.Items.AddRange(new object[] { "BDSP Repacker Format (No Array field)", "UABEA Format (With Array field)" });
            tscomboFormat.Name = "tscomboFormat";
            tscomboFormat.Size = new Size(250, 39);
            // 
            // grpEditContainer
            // 
            grpEditContainer.Controls.Add(lbMainAsset);
            grpEditContainer.Controls.Add(lbFileCount);
            grpEditContainer.Controls.Add(btnMainPath);
            grpEditContainer.Controls.Add(btnAddPath);
            grpEditContainer.Controls.Add(btnRemovePath);
            grpEditContainer.Controls.Add(lbPathID);
            grpEditContainer.Controls.Add(txtPathID);
            grpEditContainer.Controls.Add(lbFileID);
            grpEditContainer.Controls.Add(txtFileID);
            grpEditContainer.Controls.Add(btnRenameContainer);
            grpEditContainer.Controls.Add(lbContainerName);
            grpEditContainer.Controls.Add(txtContainerName);
            grpEditContainer.Controls.Add(listFilesOfContainer);
            grpEditContainer.Location = new Point(12, 157);
            grpEditContainer.Name = "grpEditContainer";
            grpEditContainer.Size = new Size(570, 279);
            grpEditContainer.TabIndex = 5;
            grpEditContainer.TabStop = false;
            grpEditContainer.Text = "Container Editor";
            // 
            // lbMainAsset
            // 
            lbMainAsset.Location = new Point(4, 217);
            lbMainAsset.Name = "lbMainAsset";
            lbMainAsset.Size = new Size(352, 15);
            lbMainAsset.TabIndex = 14;
            lbMainAsset.Text = "Main Asset: x - x";
            // 
            // lbFileCount
            // 
            lbFileCount.Location = new Point(4, 248);
            lbFileCount.Name = "lbFileCount";
            lbFileCount.Size = new Size(352, 15);
            lbFileCount.TabIndex = 10;
            lbFileCount.Text = "This container preloads x assets.";
            // 
            // btnMainPath
            // 
            btnMainPath.Enabled = false;
            btnMainPath.Location = new Point(109, 173);
            btnMainPath.Name = "btnMainPath";
            btnMainPath.Size = new Size(247, 23);
            btnMainPath.TabIndex = 13;
            btnMainPath.Text = "Make Asset the Main Asset";
            btnMainPath.UseVisualStyleBackColor = true;
            btnMainPath.Click += btnMainPath_Click;
            // 
            // btnAddPath
            // 
            btnAddPath.Enabled = false;
            btnAddPath.Location = new Point(109, 144);
            btnAddPath.Name = "btnAddPath";
            btnAddPath.Size = new Size(120, 23);
            btnAddPath.TabIndex = 9;
            btnAddPath.Text = "Add Asset";
            btnAddPath.UseVisualStyleBackColor = true;
            btnAddPath.Click += btnAddPath_Click;
            // 
            // btnRemovePath
            // 
            btnRemovePath.Enabled = false;
            btnRemovePath.Location = new Point(236, 144);
            btnRemovePath.Name = "btnRemovePath";
            btnRemovePath.Size = new Size(120, 23);
            btnRemovePath.TabIndex = 8;
            btnRemovePath.Text = "Remove Asset";
            btnRemovePath.UseVisualStyleBackColor = true;
            btnRemovePath.Click += btnRemovePath_Click;
            // 
            // lbPathID
            // 
            lbPathID.AutoSize = true;
            lbPathID.Location = new Point(55, 118);
            lbPathID.Name = "lbPathID";
            lbPathID.Size = new Size(48, 15);
            lbPathID.TabIndex = 7;
            lbPathID.Text = "Path ID:";
            // 
            // txtPathID
            // 
            txtPathID.Enabled = false;
            txtPathID.Location = new Point(109, 115);
            txtPathID.Name = "txtPathID";
            txtPathID.Size = new Size(247, 23);
            txtPathID.TabIndex = 5;
            // 
            // lbFileID
            // 
            lbFileID.AutoSize = true;
            lbFileID.Location = new Point(61, 89);
            lbFileID.Name = "lbFileID";
            lbFileID.Size = new Size(42, 15);
            lbFileID.TabIndex = 6;
            lbFileID.Text = "File ID:";
            // 
            // txtFileID
            // 
            txtFileID.Enabled = false;
            txtFileID.Location = new Point(109, 86);
            txtFileID.Name = "txtFileID";
            txtFileID.Size = new Size(247, 23);
            txtFileID.TabIndex = 4;
            // 
            // btnRenameContainer
            // 
            btnRenameContainer.Enabled = false;
            btnRenameContainer.Location = new Point(236, 51);
            btnRenameContainer.Name = "btnRenameContainer";
            btnRenameContainer.Size = new Size(120, 23);
            btnRenameContainer.TabIndex = 12;
            btnRenameContainer.Text = "Rename Container";
            btnRenameContainer.UseVisualStyleBackColor = true;
            btnRenameContainer.Click += btnRenameContainer_Click;
            // 
            // txtContainerName
            // 
            txtContainerName.Enabled = false;
            txtContainerName.Location = new Point(109, 22);
            txtContainerName.Name = "txtContainerName";
            txtContainerName.Size = new Size(247, 23);
            txtContainerName.TabIndex = 11;
            // 
            // btnAddContainer
            // 
            btnAddContainer.Enabled = false;
            btnAddContainer.Location = new Point(454, 42);
            btnAddContainer.Name = "btnAddContainer";
            btnAddContainer.Size = new Size(128, 23);
            btnAddContainer.TabIndex = 13;
            btnAddContainer.Text = "Add Container";
            btnAddContainer.UseVisualStyleBackColor = true;
            btnAddContainer.Click += btnAddContainer_Click;
            // 
            // btnRemoveContainer
            // 
            btnRemoveContainer.Enabled = false;
            btnRemoveContainer.Location = new Point(454, 71);
            btnRemoveContainer.Name = "btnRemoveContainer";
            btnRemoveContainer.Size = new Size(128, 23);
            btnRemoveContainer.TabIndex = 14;
            btnRemoveContainer.Text = "Remove Container";
            btnRemoveContainer.UseVisualStyleBackColor = true;
            btnRemoveContainer.Click += btnRemoveContainer_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(594, 450);
            Controls.Add(btnRemoveContainer);
            Controls.Add(btnAddContainer);
            Controls.Add(grpEditContainer);
            Controls.Add(tsToolStrip);
            Controls.Add(listContainers);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MaximumSize = new Size(610, 489);
            MinimumSize = new Size(610, 489);
            Name = "FormMain";
            Text = "Preload Table Editor";
            tsToolStrip.ResumeLayout(false);
            tsToolStrip.PerformLayout();
            grpEditContainer.ResumeLayout(false);
            grpEditContainer.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListBox listContainers;
        private ListBox listFilesOfContainer;
        private Label lbContainerName;
        private ToolStrip tsToolStrip;
        private ToolStripButton tsbOpen;
        private ToolStripButton tsbSave;
        private GroupBox grpEditContainer;
        private Button btnAddPath;
        private Button btnRemovePath;
        private Label lbPathID;
        private TextBox txtPathID;
        private Label lbFileID;
        private TextBox txtFileID;
        private Label lbFileCount;
        private TextBox txtContainerName;
        private Button btnRenameContainer;
        private Button btnAddContainer;
        private Button btnRemoveContainer;
        private Button btnMainPath;
        private Label lbMainAsset;
        private ToolStripSeparator tss1;
        private ToolStripComboBox tscomboFormat;
    }
}