namespace Bingo
{
    partial class GameOptions
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
            this.components = new System.ComponentModel.Container();
            this.trackFlashSpeed = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bingoTestFormBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.trackFlashSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bingoTestFormBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // trackFlashSpeed
            // 
            this.trackFlashSpeed.AutoSize = false;
            this.trackFlashSpeed.LargeChange = 100;
            this.trackFlashSpeed.Location = new System.Drawing.Point(12, 35);
            this.trackFlashSpeed.Maximum = 1000;
            this.trackFlashSpeed.Minimum = 1;
            this.trackFlashSpeed.Name = "trackFlashSpeed";
            this.trackFlashSpeed.Size = new System.Drawing.Size(267, 42);
            this.trackFlashSpeed.SmallChange = 10;
            this.trackFlashSpeed.TabIndex = 0;
            this.trackFlashSpeed.TickFrequency = 50;
            this.trackFlashSpeed.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackFlashSpeed.Value = 1;
            this.trackFlashSpeed.ValueChanged += new System.EventHandler(this.trackFlashSpeed_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Winning Card Flash Speed:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fastest";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(238, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Slowest";
            // 
            // bingoTestFormBindingSource
            // 
            this.bingoTestFormBindingSource.DataSource = typeof(Bingo.BingoTestForm);
            // 
            // GameOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 101);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackFlashSpeed);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GameOptions";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Game Options";
            ((System.ComponentModel.ISupportInitialize)(this.trackFlashSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bingoTestFormBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trackFlashSpeed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource bingoTestFormBindingSource;
    }
}