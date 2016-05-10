namespace BingoUI
{
    partial class ScalableBingoCardControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cellLabel1 = new BingoUI.CellLabel();
            this.SuspendLayout();
            // 
            // cellLabel1
            // 
            this.cellLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cellLabel1.AutoSize = true;
            this.cellLabel1.BackColor = System.Drawing.Color.White;
            this.cellLabel1.Font = new System.Drawing.Font("Arial Black", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cellLabel1.Location = new System.Drawing.Point(4, 4);
            this.cellLabel1.Margin = new System.Windows.Forms.Padding(0);
            this.cellLabel1.Name = "cellLabel1";
            this.cellLabel1.Size = new System.Drawing.Size(121, 27);
            this.cellLabel1.TabIndex = 0;
            this.cellLabel1.Text = "cellLabel1";
            this.cellLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cellLabel1.Value = 0;
            // 
            // ScalableBingoCardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BingoUI.BingoCardResource.marble;
            this.Controls.Add(this.cellLabel1);
            this.Name = "ScalableBingoCardControl";
            this.Size = new System.Drawing.Size(230, 255);
            this.Load += new System.EventHandler(this.ScalableBingoCardControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CellLabel cellLabel1;

    }
}
