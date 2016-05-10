using System.Drawing;

namespace PatternMaskBuilder
{
    partial class WinPatternMaskBuilder
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
            this.btnAddPattern = new System.Windows.Forms.Button();
            this.cboName = new System.Windows.Forms.ComboBox();
            this.lstPatternSets = new System.Windows.Forms.ListBox();
            this.btnRemovePattern = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.picThumbnail = new System.Windows.Forms.PictureBox();
            this.grpProperties = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cboPayoutMultiplier = new System.Windows.Forms.ComboBox();
            this.btnClearGrid = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnLoad = new System.Windows.Forms.Button();
            this.tvPatterns = new System.Windows.Forms.TreeView();
            this.btnDebug = new System.Windows.Forms.Button();
            this.cellLabel2 = new PatternMaskBuilder.CellLabel();
            this.cellLabel1 = new PatternMaskBuilder.CellLabel();
            this.O3 = new PatternMaskBuilder.CellLabel();
            this.O4 = new PatternMaskBuilder.CellLabel();
            this.O2 = new PatternMaskBuilder.CellLabel();
            this.O1 = new PatternMaskBuilder.CellLabel();
            this.G3 = new PatternMaskBuilder.CellLabel();
            this.G4 = new PatternMaskBuilder.CellLabel();
            this.G2 = new PatternMaskBuilder.CellLabel();
            this.G1 = new PatternMaskBuilder.CellLabel();
            this.N3 = new PatternMaskBuilder.CellLabel();
            this.N4 = new PatternMaskBuilder.CellLabel();
            this.N2 = new PatternMaskBuilder.CellLabel();
            this.N1 = new PatternMaskBuilder.CellLabel();
            this.I3 = new PatternMaskBuilder.CellLabel();
            this.I4 = new PatternMaskBuilder.CellLabel();
            this.I2 = new PatternMaskBuilder.CellLabel();
            this.I1 = new PatternMaskBuilder.CellLabel();
            this.B3 = new PatternMaskBuilder.CellLabel();
            this.label25 = new PatternMaskBuilder.CellLabel();
            this.B4 = new PatternMaskBuilder.CellLabel();
            this.free9 = new PatternMaskBuilder.CellLabel();
            this.B2 = new PatternMaskBuilder.CellLabel();
            this.B1 = new PatternMaskBuilder.CellLabel();
            this.free2 = new PatternMaskBuilder.CellLabel();
            this.O0 = new PatternMaskBuilder.CellLabel();
            this.G0 = new PatternMaskBuilder.CellLabel();
            this.N0 = new PatternMaskBuilder.CellLabel();
            this.I0 = new PatternMaskBuilder.CellLabel();
            this.B0 = new PatternMaskBuilder.CellLabel();
            this.free = new PatternMaskBuilder.CellLabel();
            this.label31 = new PatternMaskBuilder.CellLabel();
            ((System.ComponentModel.ISupportInitialize)(this.picThumbnail)).BeginInit();
            this.grpProperties.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddPattern
            // 
            this.btnAddPattern.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddPattern.Location = new System.Drawing.Point(276, 352);
            this.btnAddPattern.Name = "btnAddPattern";
            this.btnAddPattern.Size = new System.Drawing.Size(70, 23);
            this.btnAddPattern.TabIndex = 42;
            this.btnAddPattern.Text = "&Add";
            this.btnAddPattern.UseVisualStyleBackColor = true;
            this.btnAddPattern.Click += new System.EventHandler(this.btnAddPattern_Click);
            // 
            // cboName
            // 
            this.cboName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cboName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboName.Location = new System.Drawing.Point(131, 354);
            this.cboName.Name = "cboName";
            this.cboName.Size = new System.Drawing.Size(139, 21);
            this.cboName.Sorted = true;
            this.cboName.TabIndex = 44;
            // 
            // lstPatternSets
            // 
            this.lstPatternSets.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.lstPatternSets.FormattingEnabled = true;
            this.lstPatternSets.Location = new System.Drawing.Point(475, 14);
            this.lstPatternSets.Name = "lstPatternSets";
            this.lstPatternSets.Size = new System.Drawing.Size(102, 121);
            this.lstPatternSets.TabIndex = 43;
            this.lstPatternSets.SelectedIndexChanged += new System.EventHandler(this.lstPatternSets_SelectedIndexChanged);
            // 
            // btnRemovePattern
            // 
            this.btnRemovePattern.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRemovePattern.Location = new System.Drawing.Point(363, 166);
            this.btnRemovePattern.Name = "btnRemovePattern";
            this.btnRemovePattern.Size = new System.Drawing.Size(75, 23);
            this.btnRemovePattern.TabIndex = 46;
            this.btnRemovePattern.Text = "&Remove";
            this.btnRemovePattern.UseVisualStyleBackColor = true;
            this.btnRemovePattern.Click += new System.EventHandler(this.btnRemovePattern_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.Location = new System.Drawing.Point(489, 170);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 47;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnExportList_Click);
            // 
            // picThumbnail
            // 
            this.picThumbnail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.picThumbnail.BackColor = System.Drawing.Color.White;
            this.picThumbnail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picThumbnail.Location = new System.Drawing.Point(583, 12);
            this.picThumbnail.Name = "picThumbnail";
            this.picThumbnail.Size = new System.Drawing.Size(150, 150);
            this.picThumbnail.TabIndex = 48;
            this.picThumbnail.TabStop = false;
            this.picThumbnail.Text = "thumbnail";
            // 
            // grpProperties
            // 
            this.grpProperties.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpProperties.Controls.Add(this.cellLabel2);
            this.grpProperties.Controls.Add(this.button2);
            this.grpProperties.Controls.Add(this.textBox1);
            this.grpProperties.Controls.Add(this.cellLabel1);
            this.grpProperties.Controls.Add(this.cboPayoutMultiplier);
            this.grpProperties.Location = new System.Drawing.Point(343, 195);
            this.grpProperties.Name = "grpProperties";
            this.grpProperties.Size = new System.Drawing.Size(396, 137);
            this.grpProperties.TabIndex = 49;
            this.grpProperties.TabStop = false;
            this.grpProperties.Text = "Properties";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(320, 44);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(70, 23);
            this.button2.TabIndex = 54;
            this.button2.Text = "Browse...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(55, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(259, 20);
            this.textBox1.TabIndex = 53;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(619, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 23);
            this.button1.TabIndex = 50;
            this.button1.Text = "&Update";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // cboPayoutMultiplier
            // 
            this.cboPayoutMultiplier.FormattingEnabled = true;
            this.cboPayoutMultiplier.Location = new System.Drawing.Point(55, 22);
            this.cboPayoutMultiplier.Name = "cboPayoutMultiplier";
            this.cboPayoutMultiplier.Size = new System.Drawing.Size(40, 21);
            this.cboPayoutMultiplier.TabIndex = 51;
            this.cboPayoutMultiplier.Text = "100";
            // 
            // btnClearGrid
            // 
            this.btnClearGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClearGrid.Location = new System.Drawing.Point(12, 349);
            this.btnClearGrid.Name = "btnClearGrid";
            this.btnClearGrid.Size = new System.Drawing.Size(75, 23);
            this.btnClearGrid.TabIndex = 53;
            this.btnClearGrid.Text = "&Clear";
            this.btnClearGrid.UseVisualStyleBackColor = true;
            this.btnClearGrid.Click += new System.EventHandler(this.btnClearGrid_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Title = "Select the image overlay";
            // 
            // btnLoad
            // 
            this.btnLoad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLoad.Location = new System.Drawing.Point(489, 141);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 54;
            this.btnLoad.Text = "&Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // tvPatterns
            // 
            this.tvPatterns.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.tvPatterns.HideSelection = false;
            this.tvPatterns.Location = new System.Drawing.Point(343, 9);
            this.tvPatterns.Name = "tvPatterns";
            this.tvPatterns.ShowNodeToolTips = true;
            this.tvPatterns.Size = new System.Drawing.Size(126, 151);
            this.tvPatterns.TabIndex = 55;
            this.tvPatterns.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // btnDebug
            // 
            this.btnDebug.Location = new System.Drawing.Point(664, 352);
            this.btnDebug.Name = "btnDebug";
            this.btnDebug.Size = new System.Drawing.Size(75, 23);
            this.btnDebug.TabIndex = 56;
            this.btnDebug.Tag = "serialize pattern tree";
            this.btnDebug.Text = "&Debug";
            this.btnDebug.UseVisualStyleBackColor = true;
            this.btnDebug.Click += new System.EventHandler(this.btnDebug_Click);
            // 
            // cellLabel2
            // 
            this.cellLabel2.AutoSize = true;
            this.cellLabel2.IsHighlighted = false;
            this.cellLabel2.IsSelected = false;
            this.cellLabel2.Location = new System.Drawing.Point(6, 49);
            this.cellLabel2.Name = "cellLabel2";
            this.cellLabel2.Size = new System.Drawing.Size(43, 13);
            this.cellLabel2.TabIndex = 55;
            this.cellLabel2.Text = "Overlay";
            // 
            // cellLabel1
            // 
            this.cellLabel1.AutoSize = true;
            this.cellLabel1.IsHighlighted = false;
            this.cellLabel1.IsSelected = false;
            this.cellLabel1.Location = new System.Drawing.Point(6, 25);
            this.cellLabel1.Name = "cellLabel1";
            this.cellLabel1.Size = new System.Drawing.Size(43, 13);
            this.cellLabel1.TabIndex = 52;
            this.cellLabel1.Text = "Payout:";
            // 
            // O3
            // 
            this.O3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.O3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.O3.IsHighlighted = false;
            this.O3.IsSelected = false;
            this.O3.Location = new System.Drawing.Point(276, 206);
            this.O3.Name = "O3";
            this.O3.Size = new System.Drawing.Size(60, 60);
            this.O3.TabIndex = 40;
            this.O3.Tag = "false";
            this.O3.MouseLeave += new System.EventHandler(this.cell_MouseLeave);
            this.O3.Click += new System.EventHandler(this.cell_Click);
            this.O3.MouseEnter += new System.EventHandler(this.cell_MouseEnter);
            // 
            // O4
            // 
            this.O4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.O4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.O4.IsHighlighted = false;
            this.O4.IsSelected = false;
            this.O4.Location = new System.Drawing.Point(276, 272);
            this.O4.Name = "O4";
            this.O4.Size = new System.Drawing.Size(60, 60);
            this.O4.TabIndex = 40;
            this.O4.Tag = "false";
            this.O4.MouseLeave += new System.EventHandler(this.cell_MouseLeave);
            this.O4.Click += new System.EventHandler(this.cell_Click);
            this.O4.MouseEnter += new System.EventHandler(this.cell_MouseEnter);
            // 
            // O2
            // 
            this.O2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.O2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.O2.IsHighlighted = false;
            this.O2.IsSelected = false;
            this.O2.Location = new System.Drawing.Point(276, 140);
            this.O2.Name = "O2";
            this.O2.Size = new System.Drawing.Size(60, 60);
            this.O2.TabIndex = 40;
            this.O2.Tag = "false";
            this.O2.MouseLeave += new System.EventHandler(this.cell_MouseLeave);
            this.O2.Click += new System.EventHandler(this.cell_Click);
            this.O2.MouseEnter += new System.EventHandler(this.cell_MouseEnter);
            // 
            // O1
            // 
            this.O1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.O1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.O1.IsHighlighted = false;
            this.O1.IsSelected = false;
            this.O1.Location = new System.Drawing.Point(276, 74);
            this.O1.Name = "O1";
            this.O1.Size = new System.Drawing.Size(60, 60);
            this.O1.TabIndex = 40;
            this.O1.Tag = "false";
            this.O1.MouseLeave += new System.EventHandler(this.cell_MouseLeave);
            this.O1.Click += new System.EventHandler(this.cell_Click);
            this.O1.MouseEnter += new System.EventHandler(this.cell_MouseEnter);
            // 
            // G3
            // 
            this.G3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.G3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.G3.IsHighlighted = false;
            this.G3.IsSelected = false;
            this.G3.Location = new System.Drawing.Point(210, 206);
            this.G3.Name = "G3";
            this.G3.Size = new System.Drawing.Size(60, 60);
            this.G3.TabIndex = 39;
            this.G3.Tag = "false";
            this.G3.MouseLeave += new System.EventHandler(this.cell_MouseLeave);
            this.G3.Click += new System.EventHandler(this.cell_Click);
            this.G3.MouseEnter += new System.EventHandler(this.cell_MouseEnter);
            // 
            // G4
            // 
            this.G4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.G4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.G4.IsHighlighted = false;
            this.G4.IsSelected = false;
            this.G4.Location = new System.Drawing.Point(210, 272);
            this.G4.Name = "G4";
            this.G4.Size = new System.Drawing.Size(60, 60);
            this.G4.TabIndex = 39;
            this.G4.Tag = "false";
            this.G4.MouseLeave += new System.EventHandler(this.cell_MouseLeave);
            this.G4.Click += new System.EventHandler(this.cell_Click);
            this.G4.MouseEnter += new System.EventHandler(this.cell_MouseEnter);
            // 
            // G2
            // 
            this.G2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.G2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.G2.IsHighlighted = false;
            this.G2.IsSelected = false;
            this.G2.Location = new System.Drawing.Point(210, 140);
            this.G2.Name = "G2";
            this.G2.Size = new System.Drawing.Size(60, 60);
            this.G2.TabIndex = 39;
            this.G2.Tag = "false";
            this.G2.MouseLeave += new System.EventHandler(this.cell_MouseLeave);
            this.G2.Click += new System.EventHandler(this.cell_Click);
            this.G2.MouseEnter += new System.EventHandler(this.cell_MouseEnter);
            // 
            // G1
            // 
            this.G1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.G1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.G1.IsHighlighted = false;
            this.G1.IsSelected = false;
            this.G1.Location = new System.Drawing.Point(210, 74);
            this.G1.Name = "G1";
            this.G1.Size = new System.Drawing.Size(60, 60);
            this.G1.TabIndex = 39;
            this.G1.Tag = "false";
            this.G1.MouseLeave += new System.EventHandler(this.cell_MouseLeave);
            this.G1.Click += new System.EventHandler(this.cell_Click);
            this.G1.MouseEnter += new System.EventHandler(this.cell_MouseEnter);
            // 
            // N3
            // 
            this.N3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.N3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.N3.IsHighlighted = false;
            this.N3.IsSelected = false;
            this.N3.Location = new System.Drawing.Point(144, 206);
            this.N3.Name = "N3";
            this.N3.Size = new System.Drawing.Size(60, 60);
            this.N3.TabIndex = 38;
            this.N3.Tag = "false";
            this.N3.MouseLeave += new System.EventHandler(this.cell_MouseLeave);
            this.N3.Click += new System.EventHandler(this.cell_Click);
            this.N3.MouseEnter += new System.EventHandler(this.cell_MouseEnter);
            // 
            // N4
            // 
            this.N4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.N4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.N4.IsHighlighted = false;
            this.N4.IsSelected = false;
            this.N4.Location = new System.Drawing.Point(144, 272);
            this.N4.Name = "N4";
            this.N4.Size = new System.Drawing.Size(60, 60);
            this.N4.TabIndex = 38;
            this.N4.Tag = "false";
            this.N4.MouseLeave += new System.EventHandler(this.cell_MouseLeave);
            this.N4.Click += new System.EventHandler(this.cell_Click);
            this.N4.MouseEnter += new System.EventHandler(this.cell_MouseEnter);
            // 
            // N2
            // 
            this.N2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.N2.Font = new System.Drawing.Font("Arial Black", 11F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.N2.IsHighlighted = false;
            this.N2.IsSelected = false;
            this.N2.Location = new System.Drawing.Point(144, 140);
            this.N2.Name = "N2";
            this.N2.Size = new System.Drawing.Size(60, 60);
            this.N2.TabIndex = 38;
            this.N2.Tag = "false";
            this.N2.Text = "FREE";
            this.N2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.N2.MouseLeave += new System.EventHandler(this.cell_MouseLeave);
            this.N2.Click += new System.EventHandler(this.cell_Click);
            this.N2.MouseEnter += new System.EventHandler(this.cell_MouseEnter);
            // 
            // N1
            // 
            this.N1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.N1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.N1.IsHighlighted = false;
            this.N1.IsSelected = false;
            this.N1.Location = new System.Drawing.Point(144, 74);
            this.N1.Name = "N1";
            this.N1.Size = new System.Drawing.Size(60, 60);
            this.N1.TabIndex = 38;
            this.N1.Tag = "false";
            this.N1.MouseLeave += new System.EventHandler(this.cell_MouseLeave);
            this.N1.Click += new System.EventHandler(this.cell_Click);
            this.N1.MouseEnter += new System.EventHandler(this.cell_MouseEnter);
            // 
            // I3
            // 
            this.I3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.I3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.I3.IsHighlighted = false;
            this.I3.IsSelected = false;
            this.I3.Location = new System.Drawing.Point(78, 206);
            this.I3.Name = "I3";
            this.I3.Size = new System.Drawing.Size(60, 60);
            this.I3.TabIndex = 37;
            this.I3.Tag = "false";
            this.I3.MouseLeave += new System.EventHandler(this.cell_MouseLeave);
            this.I3.Click += new System.EventHandler(this.cell_Click);
            this.I3.MouseEnter += new System.EventHandler(this.cell_MouseEnter);
            // 
            // I4
            // 
            this.I4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.I4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.I4.IsHighlighted = false;
            this.I4.IsSelected = false;
            this.I4.Location = new System.Drawing.Point(78, 272);
            this.I4.Name = "I4";
            this.I4.Size = new System.Drawing.Size(60, 60);
            this.I4.TabIndex = 37;
            this.I4.Tag = "false";
            this.I4.MouseLeave += new System.EventHandler(this.cell_MouseLeave);
            this.I4.Click += new System.EventHandler(this.cell_Click);
            this.I4.MouseEnter += new System.EventHandler(this.cell_MouseEnter);
            // 
            // I2
            // 
            this.I2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.I2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.I2.IsHighlighted = false;
            this.I2.IsSelected = false;
            this.I2.Location = new System.Drawing.Point(78, 140);
            this.I2.Name = "I2";
            this.I2.Size = new System.Drawing.Size(60, 60);
            this.I2.TabIndex = 37;
            this.I2.Tag = "false";
            this.I2.MouseLeave += new System.EventHandler(this.cell_MouseLeave);
            this.I2.Click += new System.EventHandler(this.cell_Click);
            this.I2.MouseEnter += new System.EventHandler(this.cell_MouseEnter);
            // 
            // I1
            // 
            this.I1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.I1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.I1.IsHighlighted = false;
            this.I1.IsSelected = false;
            this.I1.Location = new System.Drawing.Point(78, 74);
            this.I1.Name = "I1";
            this.I1.Size = new System.Drawing.Size(60, 60);
            this.I1.TabIndex = 37;
            this.I1.Tag = "false";
            this.I1.MouseLeave += new System.EventHandler(this.cell_MouseLeave);
            this.I1.Click += new System.EventHandler(this.cell_Click);
            this.I1.MouseEnter += new System.EventHandler(this.cell_MouseEnter);
            // 
            // B3
            // 
            this.B3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.B3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.B3.IsHighlighted = false;
            this.B3.IsSelected = false;
            this.B3.Location = new System.Drawing.Point(12, 206);
            this.B3.Name = "B3";
            this.B3.Size = new System.Drawing.Size(60, 60);
            this.B3.TabIndex = 36;
            this.B3.Tag = "false";
            this.B3.MouseLeave += new System.EventHandler(this.cell_MouseLeave);
            this.B3.Click += new System.EventHandler(this.cell_Click);
            this.B3.MouseEnter += new System.EventHandler(this.cell_MouseEnter);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label25.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label25.IsHighlighted = false;
            this.label25.IsSelected = false;
            this.label25.Location = new System.Drawing.Point(12, 206);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(2, 15);
            this.label25.TabIndex = 34;
            this.label25.Tag = "false";
            this.label25.MouseLeave += new System.EventHandler(this.cell_MouseLeave);
            this.label25.Click += new System.EventHandler(this.cell_Click);
            this.label25.MouseEnter += new System.EventHandler(this.cell_MouseEnter);
            // 
            // B4
            // 
            this.B4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.B4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.B4.IsHighlighted = false;
            this.B4.IsSelected = false;
            this.B4.Location = new System.Drawing.Point(12, 272);
            this.B4.Name = "B4";
            this.B4.Size = new System.Drawing.Size(60, 60);
            this.B4.TabIndex = 36;
            this.B4.Tag = "false";
            this.B4.MouseLeave += new System.EventHandler(this.cell_MouseLeave);
            this.B4.Click += new System.EventHandler(this.cell_Click);
            this.B4.MouseEnter += new System.EventHandler(this.cell_MouseEnter);
            // 
            // free9
            // 
            this.free9.AutoSize = true;
            this.free9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.free9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.free9.IsHighlighted = false;
            this.free9.IsSelected = false;
            this.free9.Location = new System.Drawing.Point(12, 272);
            this.free9.Name = "free9";
            this.free9.Size = new System.Drawing.Size(2, 15);
            this.free9.TabIndex = 34;
            this.free9.Tag = "false";
            this.free9.MouseLeave += new System.EventHandler(this.cell_MouseLeave);
            this.free9.Click += new System.EventHandler(this.cell_Click);
            this.free9.MouseEnter += new System.EventHandler(this.cell_MouseEnter);
            // 
            // B2
            // 
            this.B2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.B2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.B2.IsHighlighted = false;
            this.B2.IsSelected = false;
            this.B2.Location = new System.Drawing.Point(12, 140);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(60, 60);
            this.B2.TabIndex = 36;
            this.B2.Tag = "false";
            this.B2.MouseLeave += new System.EventHandler(this.cell_MouseLeave);
            this.B2.Click += new System.EventHandler(this.cell_Click);
            this.B2.MouseEnter += new System.EventHandler(this.cell_MouseEnter);
            // 
            // B1
            // 
            this.B1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.B1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.B1.IsHighlighted = false;
            this.B1.IsSelected = false;
            this.B1.Location = new System.Drawing.Point(12, 74);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(60, 60);
            this.B1.TabIndex = 36;
            this.B1.Tag = "false";
            this.B1.MouseLeave += new System.EventHandler(this.cell_MouseLeave);
            this.B1.Click += new System.EventHandler(this.cell_Click);
            this.B1.MouseEnter += new System.EventHandler(this.cell_MouseEnter);
            // 
            // free2
            // 
            this.free2.AutoSize = true;
            this.free2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.free2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.free2.IsHighlighted = false;
            this.free2.IsSelected = false;
            this.free2.Location = new System.Drawing.Point(12, 74);
            this.free2.Name = "free2";
            this.free2.Size = new System.Drawing.Size(2, 15);
            this.free2.TabIndex = 34;
            this.free2.Tag = "false";
            this.free2.MouseLeave += new System.EventHandler(this.cell_MouseLeave);
            this.free2.Click += new System.EventHandler(this.cell_Click);
            this.free2.MouseEnter += new System.EventHandler(this.cell_MouseEnter);
            // 
            // O0
            // 
            this.O0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.O0.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.O0.IsHighlighted = false;
            this.O0.IsSelected = false;
            this.O0.Location = new System.Drawing.Point(276, 9);
            this.O0.Name = "O0";
            this.O0.Size = new System.Drawing.Size(60, 60);
            this.O0.TabIndex = 33;
            this.O0.Tag = "false";
            this.O0.MouseLeave += new System.EventHandler(this.cell_MouseLeave);
            this.O0.Click += new System.EventHandler(this.cell_Click);
            this.O0.MouseEnter += new System.EventHandler(this.cell_MouseEnter);
            // 
            // G0
            // 
            this.G0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.G0.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.G0.IsHighlighted = false;
            this.G0.IsSelected = false;
            this.G0.Location = new System.Drawing.Point(210, 9);
            this.G0.Name = "G0";
            this.G0.Size = new System.Drawing.Size(60, 60);
            this.G0.TabIndex = 32;
            this.G0.Tag = "false";
            this.G0.MouseLeave += new System.EventHandler(this.cell_MouseLeave);
            this.G0.Click += new System.EventHandler(this.cell_Click);
            this.G0.MouseEnter += new System.EventHandler(this.cell_MouseEnter);
            // 
            // N0
            // 
            this.N0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.N0.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.N0.IsHighlighted = false;
            this.N0.IsSelected = false;
            this.N0.Location = new System.Drawing.Point(144, 9);
            this.N0.Name = "N0";
            this.N0.Size = new System.Drawing.Size(60, 60);
            this.N0.TabIndex = 31;
            this.N0.Tag = "false";
            this.N0.MouseLeave += new System.EventHandler(this.cell_MouseLeave);
            this.N0.Click += new System.EventHandler(this.cell_Click);
            this.N0.MouseEnter += new System.EventHandler(this.cell_MouseEnter);
            // 
            // I0
            // 
            this.I0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.I0.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.I0.IsHighlighted = false;
            this.I0.IsSelected = false;
            this.I0.Location = new System.Drawing.Point(78, 9);
            this.I0.Name = "I0";
            this.I0.Size = new System.Drawing.Size(60, 60);
            this.I0.TabIndex = 30;
            this.I0.Tag = "false";
            this.I0.MouseLeave += new System.EventHandler(this.cell_MouseLeave);
            this.I0.Click += new System.EventHandler(this.cell_Click);
            this.I0.MouseEnter += new System.EventHandler(this.cell_MouseEnter);
            // 
            // B0
            // 
            this.B0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.B0.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.B0.IsHighlighted = false;
            this.B0.IsSelected = false;
            this.B0.Location = new System.Drawing.Point(12, 9);
            this.B0.Name = "B0";
            this.B0.Size = new System.Drawing.Size(60, 60);
            this.B0.TabIndex = 29;
            this.B0.Tag = "false";
            this.B0.MouseLeave += new System.EventHandler(this.cell_MouseLeave);
            this.B0.Click += new System.EventHandler(this.cell_Click);
            this.B0.MouseEnter += new System.EventHandler(this.cell_MouseEnter);
            // 
            // free
            // 
            this.free.AutoSize = true;
            this.free.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.free.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.free.IsHighlighted = false;
            this.free.IsSelected = false;
            this.free.Location = new System.Drawing.Point(12, 9);
            this.free.Name = "free";
            this.free.Size = new System.Drawing.Size(2, 15);
            this.free.TabIndex = 0;
            this.free.Tag = "false";
            this.free.MouseLeave += new System.EventHandler(this.cell_MouseLeave);
            this.free.Click += new System.EventHandler(this.cell_Click);
            this.free.MouseEnter += new System.EventHandler(this.cell_MouseEnter);
            // 
            // label31
            // 
            this.label31.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label31.AutoSize = true;
            this.label31.IsHighlighted = false;
            this.label31.IsSelected = false;
            this.label31.Location = new System.Drawing.Point(128, 338);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(63, 13);
            this.label31.TabIndex = 45;
            this.label31.Text = "Pattern Set:";
            // 
            // WinPatternMaskBuilder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(751, 387);
            this.Controls.Add(this.btnDebug);
            this.Controls.Add(this.tvPatterns);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnClearGrid);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grpProperties);
            this.Controls.Add(this.picThumbnail);
            this.Controls.Add(this.O3);
            this.Controls.Add(this.O4);
            this.Controls.Add(this.O2);
            this.Controls.Add(this.O1);
            this.Controls.Add(this.G3);
            this.Controls.Add(this.G4);
            this.Controls.Add(this.G2);
            this.Controls.Add(this.G1);
            this.Controls.Add(this.N3);
            this.Controls.Add(this.N4);
            this.Controls.Add(this.N2);
            this.Controls.Add(this.N1);
            this.Controls.Add(this.I3);
            this.Controls.Add(this.I4);
            this.Controls.Add(this.I2);
            this.Controls.Add(this.I1);
            this.Controls.Add(this.B3);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.B4);
            this.Controls.Add(this.free9);
            this.Controls.Add(this.B2);
            this.Controls.Add(this.B1);
            this.Controls.Add(this.free2);
            this.Controls.Add(this.O0);
            this.Controls.Add(this.G0);
            this.Controls.Add(this.N0);
            this.Controls.Add(this.I0);
            this.Controls.Add(this.B0);
            this.Controls.Add(this.free);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnRemovePattern);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.cboName);
            this.Controls.Add(this.lstPatternSets);
            this.Controls.Add(this.btnAddPattern);
            this.Name = "WinPatternMaskBuilder";
            this.Text = "Pattern Mask Builder";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picThumbnail)).EndInit();
            this.grpProperties.ResumeLayout(false);
            this.grpProperties.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CellLabel free;
        private CellLabel B0;
        private CellLabel I0;
        private CellLabel N0;
        private CellLabel G0;
        private CellLabel O0;
        private CellLabel O1;
        private CellLabel G1;
        private CellLabel N1;
        private CellLabel I1;
        private CellLabel B1;
        private CellLabel free2;
        private CellLabel B2;
        private CellLabel I2;
        private CellLabel N2;
        private CellLabel G2;
        private CellLabel O2;
        private CellLabel free9;
        private CellLabel B4;
        private CellLabel I4;
        private CellLabel N4;
        private CellLabel G4;
        private CellLabel O4;
        private CellLabel label25;
        private CellLabel B3;
        private CellLabel I3;
        private CellLabel N3;
        private CellLabel G3;
        private CellLabel O3;
        private System.Windows.Forms.Button btnAddPattern;
        private System.Windows.Forms.ComboBox cboName;
        private CellLabel label31;
        private System.Windows.Forms.ListBox lstPatternSets;
        private System.Windows.Forms.Button btnRemovePattern;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.PictureBox picThumbnail;
        private System.Windows.Forms.GroupBox grpProperties;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cboPayoutMultiplier;
        private CellLabel cellLabel1;
        private System.Windows.Forms.Button btnClearGrid;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private CellLabel cellLabel2;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.TreeView tvPatterns;
        private System.Windows.Forms.Button btnDebug;
    }
}

