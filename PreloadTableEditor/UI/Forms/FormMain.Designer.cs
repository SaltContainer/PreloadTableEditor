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
            listAllFiles = new ListBox();
            listContainers = new ListBox();
            listFilesOfContainer = new ListBox();
            lbContainerName = new Label();
            tsToolStrip = new ToolStrip();
            tsbOpen = new ToolStripButton();
            tsbSave = new ToolStripButton();
            grpEditContainer = new GroupBox();
            lbFileCount = new Label();
            btnAddPath = new Button();
            btnRemovePath = new Button();
            lbPathID = new Label();
            txtPathID = new TextBox();
            lbFileID = new Label();
            txtFileID = new TextBox();
            tsToolStrip.SuspendLayout();
            grpEditContainer.SuspendLayout();
            SuspendLayout();
            // 
            // listAllFiles
            // 
            listAllFiles.FormattingEnabled = true;
            listAllFiles.ItemHeight = 15;
            listAllFiles.Location = new Point(12, 42);
            listAllFiles.Name = "listAllFiles";
            listAllFiles.Size = new Size(200, 394);
            listAllFiles.TabIndex = 0;
            // 
            // listContainers
            // 
            listContainers.FormattingEnabled = true;
            listContainers.ItemHeight = 15;
            listContainers.Location = new Point(218, 42);
            listContainers.Name = "listContainers";
            listContainers.Size = new Size(356, 109);
            listContainers.TabIndex = 1;
            listContainers.SelectedIndexChanged += listContainers_SelectedIndexChanged;
            // 
            // listFilesOfContainer
            // 
            listFilesOfContainer.FormattingEnabled = true;
            listFilesOfContainer.ItemHeight = 15;
            listFilesOfContainer.Location = new Point(362, 19);
            listFilesOfContainer.Name = "listFilesOfContainer";
            listFilesOfContainer.Size = new Size(200, 244);
            listFilesOfContainer.TabIndex = 2;
            // 
            // lbContainerName
            // 
            lbContainerName.Location = new Point(6, 19);
            lbContainerName.Name = "lbContainerName";
            lbContainerName.Size = new Size(352, 15);
            lbContainerName.TabIndex = 3;
            lbContainerName.Text = "Container Name";
            // 
            // tsToolStrip
            // 
            tsToolStrip.Items.AddRange(new ToolStripItem[] { tsbOpen, tsbSave });
            tsToolStrip.Location = new Point(0, 0);
            tsToolStrip.Name = "tsToolStrip";
            tsToolStrip.Size = new Size(800, 39);
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
            tsbSave.Image = Properties.Resources.save;
            tsbSave.ImageScaling = ToolStripItemImageScaling.None;
            tsbSave.ImageTransparentColor = Color.Magenta;
            tsbSave.Name = "tsbSave";
            tsbSave.Size = new Size(36, 36);
            tsbSave.Text = "toolStripButton2";
            tsbSave.ToolTipText = "Save";
            tsbSave.Click += tsbSave_Click;
            // 
            // grpEditContainer
            // 
            grpEditContainer.Controls.Add(lbFileCount);
            grpEditContainer.Controls.Add(btnAddPath);
            grpEditContainer.Controls.Add(btnRemovePath);
            grpEditContainer.Controls.Add(lbPathID);
            grpEditContainer.Controls.Add(txtPathID);
            grpEditContainer.Controls.Add(lbFileID);
            grpEditContainer.Controls.Add(txtFileID);
            grpEditContainer.Controls.Add(lbContainerName);
            grpEditContainer.Controls.Add(listFilesOfContainer);
            grpEditContainer.Location = new Point(218, 157);
            grpEditContainer.Name = "grpEditContainer";
            grpEditContainer.Size = new Size(570, 279);
            grpEditContainer.TabIndex = 5;
            grpEditContainer.TabStop = false;
            grpEditContainer.Text = "Container Editor";
            // 
            // lbFileCount
            // 
            lbFileCount.Location = new Point(6, 135);
            lbFileCount.Name = "lbFileCount";
            lbFileCount.Size = new Size(352, 15);
            lbFileCount.TabIndex = 10;
            lbFileCount.Text = "This container preloads x assets.";
            // 
            // btnAddPath
            // 
            btnAddPath.Location = new Point(171, 109);
            btnAddPath.Name = "btnAddPath";
            btnAddPath.Size = new Size(90, 23);
            btnAddPath.TabIndex = 9;
            btnAddPath.Text = "Add";
            btnAddPath.UseVisualStyleBackColor = true;
            btnAddPath.Click += btnAddPath_Click;
            // 
            // btnRemovePath
            // 
            btnRemovePath.Location = new Point(266, 109);
            btnRemovePath.Name = "btnRemovePath";
            btnRemovePath.Size = new Size(90, 23);
            btnRemovePath.TabIndex = 8;
            btnRemovePath.Text = "Remove";
            btnRemovePath.UseVisualStyleBackColor = true;
            btnRemovePath.Click += btnRemovePath_Click;
            // 
            // lbPathID
            // 
            lbPathID.AutoSize = true;
            lbPathID.Location = new Point(117, 83);
            lbPathID.Name = "lbPathID";
            lbPathID.Size = new Size(48, 15);
            lbPathID.TabIndex = 7;
            lbPathID.Text = "Path ID:";
            // 
            // txtPathID
            // 
            txtPathID.Location = new Point(171, 80);
            txtPathID.Name = "txtPathID";
            txtPathID.Size = new Size(185, 23);
            txtPathID.TabIndex = 5;
            // 
            // lbFileID
            // 
            lbFileID.AutoSize = true;
            lbFileID.Location = new Point(123, 54);
            lbFileID.Name = "lbFileID";
            lbFileID.Size = new Size(42, 15);
            lbFileID.TabIndex = 6;
            lbFileID.Text = "File ID:";
            // 
            // txtFileID
            // 
            txtFileID.Location = new Point(171, 51);
            txtFileID.Name = "txtFileID";
            txtFileID.Size = new Size(185, 23);
            txtFileID.TabIndex = 4;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(grpEditContainer);
            Controls.Add(tsToolStrip);
            Controls.Add(listContainers);
            Controls.Add(listAllFiles);
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

        private ListBox listAllFiles;
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
    }
}