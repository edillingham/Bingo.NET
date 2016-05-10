namespace BingoUI
{
    partial class SekretCardGenerator
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
            this.txtCard = new System.Windows.Forms.TextBox();
            this.btnGenCard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCard
            // 
            this.txtCard.BackColor = System.Drawing.Color.White;
            this.txtCard.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCard.Location = new System.Drawing.Point(16, 48);
            this.txtCard.Multiline = true;
            this.txtCard.Name = "txtCard";
            this.txtCard.ReadOnly = true;
            this.txtCard.ShortcutsEnabled = false;
            this.txtCard.Size = new System.Drawing.Size(136, 110);
            this.txtCard.TabIndex = 4;
            // 
            // btnGenCard
            // 
            this.btnGenCard.Location = new System.Drawing.Point(16, 19);
            this.btnGenCard.Name = "btnGenCard";
            this.btnGenCard.Size = new System.Drawing.Size(134, 23);
            this.btnGenCard.TabIndex = 3;
            this.btnGenCard.Text = "Generate new card";
            this.btnGenCard.UseVisualStyleBackColor = true;
            this.btnGenCard.Click += new System.EventHandler(this.btnGenCard_Click);
            // 
            // SekretCardGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(169, 200);
            this.Controls.Add(this.txtCard);
            this.Controls.Add(this.btnGenCard);
            this.Name = "SekretCardGenerator";
            this.Text = "Sekret Card Generator";
            this.Load += new System.EventHandler(this.SekretCardGenerator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCard;
        private System.Windows.Forms.Button btnGenCard;
    }
}