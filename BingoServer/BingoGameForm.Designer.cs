namespace Bingo
{
    partial class BingoTestForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BingoTestForm));
            this.btnPullBalls = new System.Windows.Forms.Button();
            this.txtBalls = new System.Windows.Forms.TextBox();
            this.ballTimer = new System.Windows.Forms.Timer(this.components);
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.flashTimer = new System.Windows.Forms.Timer(this.components);
            this.btnUseNickels = new System.Windows.Forms.Button();
            this.btnUseDimes = new System.Windows.Forms.Button();
            this.btnUseHalfDollars = new System.Windows.Forms.Button();
            this.btnUseQuarters = new System.Windows.Forms.Button();
            this.btnUseDollars = new System.Windows.Forms.Button();
            this.txtBalance = new System.Windows.Forms.Label();
            this.txtBet = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.resizableBingoCardControl9 = new BingoUI.ResizableBingoCardControl();
            this.resizableBingoCardControl8 = new BingoUI.ResizableBingoCardControl();
            this.resizableBingoCardControl7 = new BingoUI.ResizableBingoCardControl();
            this.resizableBingoCardControl6 = new BingoUI.ResizableBingoCardControl();
            this.resizableBingoCardControl5 = new BingoUI.ResizableBingoCardControl();
            this.resizableBingoCardControl4 = new BingoUI.ResizableBingoCardControl();
            this.resizableBingoCardControl3 = new BingoUI.ResizableBingoCardControl();
            this.resizableBingoCardControl2 = new BingoUI.ResizableBingoCardControl();
            this.resizableBingoCardControl1 = new BingoUI.ResizableBingoCardControl();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPullBalls
            // 
            this.btnPullBalls.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPullBalls.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPullBalls.BackColor = System.Drawing.SystemColors.Control;
            this.btnPullBalls.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPullBalls.BackgroundImage")));
            this.btnPullBalls.Font = new System.Drawing.Font("Comic Sans MS", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPullBalls.Location = new System.Drawing.Point(736, 636);
            this.btnPullBalls.Name = "btnPullBalls";
            this.btnPullBalls.Size = new System.Drawing.Size(273, 123);
            this.btnPullBalls.TabIndex = 1;
            this.btnPullBalls.Text = "DAUB";
            this.btnPullBalls.UseVisualStyleBackColor = false;
            this.btnPullBalls.Click += new System.EventHandler(this.btnPullBalls_Click);
            // 
            // txtBalls
            // 
            this.txtBalls.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtBalls.CausesValidation = false;
            this.txtBalls.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBalls.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtBalls.Font = new System.Drawing.Font("Courier New", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBalls.Location = new System.Drawing.Point(664, 3);
            this.txtBalls.Margin = new System.Windows.Forms.Padding(2);
            this.txtBalls.Multiline = true;
            this.txtBalls.Name = "txtBalls";
            this.txtBalls.ReadOnly = true;
            this.txtBalls.ShortcutsEnabled = false;
            this.txtBalls.Size = new System.Drawing.Size(172, 438);
            this.txtBalls.TabIndex = 4;
            this.txtBalls.TabStop = false;
            this.txtBalls.Text = "B01 I15 N30 G45 O60 B02 I16 N31 G46 O61 B03 I17 N32 G47 O62 B04 I18 N33 G48 O63 B" +
                "05 I19 N34 G49 ";
            this.txtBalls.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ballTimer
            // 
            this.ballTimer.Interval = 500;
            this.ballTimer.Tick += new System.EventHandler(this.ballTimer_Tick);
            // 
            // trackBar1
            // 
            this.trackBar1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.trackBar1.AutoSize = false;
            this.trackBar1.Cursor = System.Windows.Forms.Cursors.NoMoveVert;
            this.trackBar1.LargeChange = 250;
            this.trackBar1.Location = new System.Drawing.Point(688, 682);
            this.trackBar1.Maximum = 3;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar1.Size = new System.Drawing.Size(42, 74);
            this.trackBar1.SmallChange = 250;
            this.trackBar1.TabIndex = 9;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBar1.Value = 1;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(688, 665);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "MAX!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSpeed
            // 
            this.lblSpeed.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpeed.Location = new System.Drawing.Point(663, 665);
            this.lblSpeed.Margin = new System.Windows.Forms.Padding(0);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(25, 91);
            this.lblSpeed.TabIndex = 18;
            this.lblSpeed.Text = "S P E E D";
            this.lblSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flashTimer
            // 
            this.flashTimer.Tick += new System.EventHandler(this.flashTimer_Tick);
            // 
            // btnUseNickels
            // 
            this.btnUseNickels.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnUseNickels.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.btnUseNickels.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnUseNickels.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btnUseNickels.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUseNickels.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUseNickels.Location = new System.Drawing.Point(666, 491);
            this.btnUseNickels.Margin = new System.Windows.Forms.Padding(2);
            this.btnUseNickels.Name = "btnUseNickels";
            this.btnUseNickels.Size = new System.Drawing.Size(66, 60);
            this.btnUseNickels.TabIndex = 28;
            this.btnUseNickels.Text = "5c";
            this.btnUseNickels.UseVisualStyleBackColor = true;
            this.btnUseNickels.Click += new System.EventHandler(this.btnUseNickels_Click);
            // 
            // btnUseDimes
            // 
            this.btnUseDimes.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnUseDimes.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.btnUseDimes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnUseDimes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btnUseDimes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUseDimes.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUseDimes.Location = new System.Drawing.Point(735, 491);
            this.btnUseDimes.Margin = new System.Windows.Forms.Padding(2);
            this.btnUseDimes.Name = "btnUseDimes";
            this.btnUseDimes.Size = new System.Drawing.Size(66, 60);
            this.btnUseDimes.TabIndex = 29;
            this.btnUseDimes.Text = "10c";
            this.btnUseDimes.UseVisualStyleBackColor = true;
            this.btnUseDimes.Click += new System.EventHandler(this.btnUseDimes_Click);
            // 
            // btnUseHalfDollars
            // 
            this.btnUseHalfDollars.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnUseHalfDollars.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.btnUseHalfDollars.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnUseHalfDollars.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btnUseHalfDollars.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUseHalfDollars.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUseHalfDollars.Location = new System.Drawing.Point(873, 491);
            this.btnUseHalfDollars.Margin = new System.Windows.Forms.Padding(2);
            this.btnUseHalfDollars.Name = "btnUseHalfDollars";
            this.btnUseHalfDollars.Size = new System.Drawing.Size(66, 60);
            this.btnUseHalfDollars.TabIndex = 31;
            this.btnUseHalfDollars.Text = "50c";
            this.btnUseHalfDollars.UseVisualStyleBackColor = true;
            this.btnUseHalfDollars.Click += new System.EventHandler(this.btnUseHalfDollars_Click);
            // 
            // btnUseQuarters
            // 
            this.btnUseQuarters.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnUseQuarters.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.btnUseQuarters.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnUseQuarters.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btnUseQuarters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUseQuarters.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUseQuarters.Location = new System.Drawing.Point(804, 491);
            this.btnUseQuarters.Margin = new System.Windows.Forms.Padding(2);
            this.btnUseQuarters.Name = "btnUseQuarters";
            this.btnUseQuarters.Size = new System.Drawing.Size(66, 60);
            this.btnUseQuarters.TabIndex = 30;
            this.btnUseQuarters.Text = "25c";
            this.btnUseQuarters.UseVisualStyleBackColor = true;
            this.btnUseQuarters.Click += new System.EventHandler(this.btnUseQuarters_Click);
            // 
            // btnUseDollars
            // 
            this.btnUseDollars.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnUseDollars.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.btnUseDollars.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnUseDollars.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btnUseDollars.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUseDollars.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUseDollars.Location = new System.Drawing.Point(942, 491);
            this.btnUseDollars.Margin = new System.Windows.Forms.Padding(2);
            this.btnUseDollars.Name = "btnUseDollars";
            this.btnUseDollars.Size = new System.Drawing.Size(66, 60);
            this.btnUseDollars.TabIndex = 32;
            this.btnUseDollars.Text = "$1";
            this.btnUseDollars.UseVisualStyleBackColor = true;
            this.btnUseDollars.Click += new System.EventHandler(this.btnUseDollars_Click);
            // 
            // txtBalance
            // 
            this.txtBalance.BackColor = System.Drawing.Color.Black;
            this.txtBalance.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtBalance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtBalance.Font = new System.Drawing.Font("Arial Black", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBalance.ForeColor = System.Drawing.Color.Blue;
            this.txtBalance.Location = new System.Drawing.Point(837, 595);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(169, 37);
            this.txtBalance.TabIndex = 33;
            this.txtBalance.Text = "$0.00";
            this.txtBalance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBet
            // 
            this.txtBet.BackColor = System.Drawing.Color.Black;
            this.txtBet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtBet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtBet.Font = new System.Drawing.Font("Arial Black", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBet.ForeColor = System.Drawing.Color.Blue;
            this.txtBet.Location = new System.Drawing.Point(837, 554);
            this.txtBet.Name = "txtBet";
            this.txtBet.Size = new System.Drawing.Size(169, 37);
            this.txtBet.TabIndex = 34;
            this.txtBet.Text = "$0.00";
            this.txtBet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Arial Black", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(664, 554);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 37);
            this.label4.TabIndex = 36;
            this.label4.Text = "Bet:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Arial Black", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(664, 595);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 37);
            this.label5.TabIndex = 35;
            this.label5.Text = "Balance:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textBox1.CausesValidation = false;
            this.textBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(840, 3);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ShortcutsEnabled = false;
            this.textBox1.Size = new System.Drawing.Size(169, 438);
            this.textBox1.TabIndex = 37;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "winning patterns shown here...";
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button2.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(664, 636);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(68, 26);
            this.button2.TabIndex = 38;
            this.button2.Text = "&Options";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Stencil", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(664, 443);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(345, 46);
            this.label2.TabIndex = 39;
            this.label2.Text = "xx-Cite Bingo";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // resizableBingoCardControl9
            // 
            this.resizableBingoCardControl9.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.resizableBingoCardControl9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("resizableBingoCardControl9.BackgroundImage")));
            this.resizableBingoCardControl9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.resizableBingoCardControl9.Cursor = System.Windows.Forms.Cursors.Default;
            this.resizableBingoCardControl9.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resizableBingoCardControl9.Location = new System.Drawing.Point(443, 509);
            this.resizableBingoCardControl9.Margin = new System.Windows.Forms.Padding(1);
            this.resizableBingoCardControl9.MaximumSize = new System.Drawing.Size(217, 262);
            this.resizableBingoCardControl9.MinimumSize = new System.Drawing.Size(217, 250);
            this.resizableBingoCardControl9.Name = "resizableBingoCardControl9";
            this.resizableBingoCardControl9.Size = new System.Drawing.Size(217, 250);
            this.resizableBingoCardControl9.TabIndex = 27;
            this.resizableBingoCardControl9.CellDaubbed += new System.EventHandler<BingoUI.CellDaubbedEventArgs>(this.ResizableBingoCardControl_CellDaubbed);
            // 
            // resizableBingoCardControl8
            // 
            this.resizableBingoCardControl8.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.resizableBingoCardControl8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("resizableBingoCardControl8.BackgroundImage")));
            this.resizableBingoCardControl8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.resizableBingoCardControl8.Cursor = System.Windows.Forms.Cursors.Default;
            this.resizableBingoCardControl8.Location = new System.Drawing.Point(223, 509);
            this.resizableBingoCardControl8.Margin = new System.Windows.Forms.Padding(1);
            this.resizableBingoCardControl8.MaximumSize = new System.Drawing.Size(217, 262);
            this.resizableBingoCardControl8.MinimumSize = new System.Drawing.Size(217, 250);
            this.resizableBingoCardControl8.Name = "resizableBingoCardControl8";
            this.resizableBingoCardControl8.Size = new System.Drawing.Size(217, 250);
            this.resizableBingoCardControl8.TabIndex = 26;
            this.resizableBingoCardControl8.CellDaubbed += new System.EventHandler<BingoUI.CellDaubbedEventArgs>(this.ResizableBingoCardControl_CellDaubbed);
            // 
            // resizableBingoCardControl7
            // 
            this.resizableBingoCardControl7.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.resizableBingoCardControl7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("resizableBingoCardControl7.BackgroundImage")));
            this.resizableBingoCardControl7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.resizableBingoCardControl7.Cursor = System.Windows.Forms.Cursors.Default;
            this.resizableBingoCardControl7.Location = new System.Drawing.Point(3, 509);
            this.resizableBingoCardControl7.Margin = new System.Windows.Forms.Padding(1);
            this.resizableBingoCardControl7.MaximumSize = new System.Drawing.Size(217, 262);
            this.resizableBingoCardControl7.MinimumSize = new System.Drawing.Size(217, 250);
            this.resizableBingoCardControl7.Name = "resizableBingoCardControl7";
            this.resizableBingoCardControl7.Size = new System.Drawing.Size(217, 250);
            this.resizableBingoCardControl7.TabIndex = 25;
            this.resizableBingoCardControl7.CellDaubbed += new System.EventHandler<BingoUI.CellDaubbedEventArgs>(this.ResizableBingoCardControl_CellDaubbed);
            // 
            // resizableBingoCardControl6
            // 
            this.resizableBingoCardControl6.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.resizableBingoCardControl6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("resizableBingoCardControl6.BackgroundImage")));
            this.resizableBingoCardControl6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.resizableBingoCardControl6.Cursor = System.Windows.Forms.Cursors.Default;
            this.resizableBingoCardControl6.Location = new System.Drawing.Point(443, 256);
            this.resizableBingoCardControl6.Margin = new System.Windows.Forms.Padding(1);
            this.resizableBingoCardControl6.MaximumSize = new System.Drawing.Size(217, 262);
            this.resizableBingoCardControl6.MinimumSize = new System.Drawing.Size(217, 250);
            this.resizableBingoCardControl6.Name = "resizableBingoCardControl6";
            this.resizableBingoCardControl6.Size = new System.Drawing.Size(217, 250);
            this.resizableBingoCardControl6.TabIndex = 24;
            this.resizableBingoCardControl6.CellDaubbed += new System.EventHandler<BingoUI.CellDaubbedEventArgs>(this.ResizableBingoCardControl_CellDaubbed);
            // 
            // resizableBingoCardControl5
            // 
            this.resizableBingoCardControl5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.resizableBingoCardControl5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("resizableBingoCardControl5.BackgroundImage")));
            this.resizableBingoCardControl5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.resizableBingoCardControl5.Cursor = System.Windows.Forms.Cursors.Default;
            this.resizableBingoCardControl5.Location = new System.Drawing.Point(223, 256);
            this.resizableBingoCardControl5.Margin = new System.Windows.Forms.Padding(1);
            this.resizableBingoCardControl5.MaximumSize = new System.Drawing.Size(217, 262);
            this.resizableBingoCardControl5.MinimumSize = new System.Drawing.Size(217, 250);
            this.resizableBingoCardControl5.Name = "resizableBingoCardControl5";
            this.resizableBingoCardControl5.Size = new System.Drawing.Size(217, 250);
            this.resizableBingoCardControl5.TabIndex = 23;
            this.resizableBingoCardControl5.CellDaubbed += new System.EventHandler<BingoUI.CellDaubbedEventArgs>(this.ResizableBingoCardControl_CellDaubbed);
            // 
            // resizableBingoCardControl4
            // 
            this.resizableBingoCardControl4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.resizableBingoCardControl4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("resizableBingoCardControl4.BackgroundImage")));
            this.resizableBingoCardControl4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.resizableBingoCardControl4.Cursor = System.Windows.Forms.Cursors.Default;
            this.resizableBingoCardControl4.Location = new System.Drawing.Point(3, 256);
            this.resizableBingoCardControl4.Margin = new System.Windows.Forms.Padding(1);
            this.resizableBingoCardControl4.MaximumSize = new System.Drawing.Size(217, 262);
            this.resizableBingoCardControl4.MinimumSize = new System.Drawing.Size(217, 250);
            this.resizableBingoCardControl4.Name = "resizableBingoCardControl4";
            this.resizableBingoCardControl4.Size = new System.Drawing.Size(217, 250);
            this.resizableBingoCardControl4.TabIndex = 22;
            this.resizableBingoCardControl4.CellDaubbed += new System.EventHandler<BingoUI.CellDaubbedEventArgs>(this.ResizableBingoCardControl_CellDaubbed);
            // 
            // resizableBingoCardControl3
            // 
            this.resizableBingoCardControl3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.resizableBingoCardControl3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("resizableBingoCardControl3.BackgroundImage")));
            this.resizableBingoCardControl3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.resizableBingoCardControl3.Cursor = System.Windows.Forms.Cursors.Default;
            this.resizableBingoCardControl3.Location = new System.Drawing.Point(443, 3);
            this.resizableBingoCardControl3.Margin = new System.Windows.Forms.Padding(1);
            this.resizableBingoCardControl3.MaximumSize = new System.Drawing.Size(217, 262);
            this.resizableBingoCardControl3.MinimumSize = new System.Drawing.Size(217, 250);
            this.resizableBingoCardControl3.Name = "resizableBingoCardControl3";
            this.resizableBingoCardControl3.Size = new System.Drawing.Size(217, 250);
            this.resizableBingoCardControl3.TabIndex = 21;
            this.resizableBingoCardControl3.CellDaubbed += new System.EventHandler<BingoUI.CellDaubbedEventArgs>(this.ResizableBingoCardControl_CellDaubbed);
            // 
            // resizableBingoCardControl2
            // 
            this.resizableBingoCardControl2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.resizableBingoCardControl2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("resizableBingoCardControl2.BackgroundImage")));
            this.resizableBingoCardControl2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.resizableBingoCardControl2.Cursor = System.Windows.Forms.Cursors.Default;
            this.resizableBingoCardControl2.Location = new System.Drawing.Point(223, 3);
            this.resizableBingoCardControl2.Margin = new System.Windows.Forms.Padding(1);
            this.resizableBingoCardControl2.MaximumSize = new System.Drawing.Size(217, 262);
            this.resizableBingoCardControl2.MinimumSize = new System.Drawing.Size(217, 250);
            this.resizableBingoCardControl2.Name = "resizableBingoCardControl2";
            this.resizableBingoCardControl2.Size = new System.Drawing.Size(217, 250);
            this.resizableBingoCardControl2.TabIndex = 20;
            this.resizableBingoCardControl2.CellDaubbed += new System.EventHandler<BingoUI.CellDaubbedEventArgs>(this.ResizableBingoCardControl_CellDaubbed);
            // 
            // resizableBingoCardControl1
            // 
            this.resizableBingoCardControl1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.resizableBingoCardControl1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("resizableBingoCardControl1.BackgroundImage")));
            this.resizableBingoCardControl1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.resizableBingoCardControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.resizableBingoCardControl1.Location = new System.Drawing.Point(3, 3);
            this.resizableBingoCardControl1.Margin = new System.Windows.Forms.Padding(1);
            this.resizableBingoCardControl1.MaximumSize = new System.Drawing.Size(217, 262);
            this.resizableBingoCardControl1.MinimumSize = new System.Drawing.Size(217, 250);
            this.resizableBingoCardControl1.Name = "resizableBingoCardControl1";
            this.resizableBingoCardControl1.Size = new System.Drawing.Size(217, 250);
            this.resizableBingoCardControl1.TabIndex = 19;
            this.resizableBingoCardControl1.CellDaubbed += new System.EventHandler<BingoUI.CellDaubbedEventArgs>(this.ResizableBingoCardControl_CellDaubbed);
            // 
            // BingoTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1014, 763);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBet);
            this.Controls.Add(this.txtBalance);
            this.Controls.Add(this.btnUseDollars);
            this.Controls.Add(this.btnUseHalfDollars);
            this.Controls.Add(this.btnUseQuarters);
            this.Controls.Add(this.btnUseDimes);
            this.Controls.Add(this.btnUseNickels);
            this.Controls.Add(this.resizableBingoCardControl9);
            this.Controls.Add(this.resizableBingoCardControl8);
            this.Controls.Add(this.resizableBingoCardControl7);
            this.Controls.Add(this.resizableBingoCardControl6);
            this.Controls.Add(this.resizableBingoCardControl5);
            this.Controls.Add(this.resizableBingoCardControl4);
            this.Controls.Add(this.resizableBingoCardControl3);
            this.Controls.Add(this.resizableBingoCardControl2);
            this.Controls.Add(this.resizableBingoCardControl1);
            this.Controls.Add(this.lblSpeed);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.txtBalls);
            this.Controls.Add(this.btnPullBalls);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BingoTestForm";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Bingo Logic Tests";
            this.Load += new System.EventHandler(this.BingoTestForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPullBalls;
        private System.Windows.Forms.TextBox txtBalls;
        private System.Windows.Forms.Timer ballTimer;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSpeed;
        private BingoUI.ResizableBingoCardControl resizableBingoCardControl1;
        private BingoUI.ResizableBingoCardControl resizableBingoCardControl2;
        private BingoUI.ResizableBingoCardControl resizableBingoCardControl3;
        private BingoUI.ResizableBingoCardControl resizableBingoCardControl4;
        private BingoUI.ResizableBingoCardControl resizableBingoCardControl5;
        private BingoUI.ResizableBingoCardControl resizableBingoCardControl6;
        private BingoUI.ResizableBingoCardControl resizableBingoCardControl7;
        private BingoUI.ResizableBingoCardControl resizableBingoCardControl8;
        private BingoUI.ResizableBingoCardControl resizableBingoCardControl9;
        protected System.Windows.Forms.Timer flashTimer;
        private System.Windows.Forms.Button btnUseNickels;
        private System.Windows.Forms.Button btnUseDimes;
        private System.Windows.Forms.Button btnUseHalfDollars;
        private System.Windows.Forms.Button btnUseQuarters;
        private System.Windows.Forms.Button btnUseDollars;
        private System.Windows.Forms.Label txtBalance;
        private System.Windows.Forms.Label txtBet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
    }
}