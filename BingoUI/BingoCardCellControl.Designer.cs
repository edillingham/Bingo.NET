namespace BingoUI
{
    partial class BingoCardCellControl
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
            this.CellContent = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CellContent
            // 
            this.CellContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CellContent.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CellContent.Location = new System.Drawing.Point(0, 0);
            this.CellContent.Margin = new System.Windows.Forms.Padding(0);
            this.CellContent.Name = "CellContent";
            this.CellContent.Size = new System.Drawing.Size(40, 40);
            this.CellContent.TabIndex = 0;
            this.CellContent.Text = "00";
            this.CellContent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BingoCardCellControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CausesValidation = false;
            this.Controls.Add(this.CellContent);
            this.Enabled = false;
            this.Name = "BingoCardCellControl";
            this.Size = new System.Drawing.Size(40, 40);
            this.MouseEnter += new System.EventHandler(this.BingoCardCellControl_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.BingoCardCellControl_MouseLeave);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label CellContent;
    }
}
