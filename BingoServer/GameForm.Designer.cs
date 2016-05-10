namespace Bingo
{
    partial class GameForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.scalableBingoCardControl1 = new BingoUI.ScalableBingoCardControl();
            this.SuspendLayout();
            // 
            // scalableBingoCardControl1
            // 
            this.scalableBingoCardControl1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("scalableBingoCardControl1.BackgroundImage")));
            this.scalableBingoCardControl1.Location = new System.Drawing.Point(13, 13);
            this.scalableBingoCardControl1.Name = "scalableBingoCardControl1";
            this.scalableBingoCardControl1.Size = new System.Drawing.Size(230, 255);
            this.scalableBingoCardControl1.TabIndex = 0;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 477);
            this.Controls.Add(this.scalableBingoCardControl1);
            this.Name = "GameForm";
            this.Text = "GameForm";
            this.ResumeLayout(false);

        }

        #endregion

        private BingoUI.ScalableBingoCardControl scalableBingoCardControl1;
    }
}