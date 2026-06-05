namespace WordCards
{
    partial class frmWordCards
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timPlayer = new System.Windows.Forms.Timer(this.components);
            this.sssWord = new System.Windows.Forms.StatusStrip();
            this.tsslMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.lstWordList = new System.Windows.Forms.ListBox();
            this.palMain = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.txtWord = new System.Windows.Forms.TextBox();
            this.lblPhonogram = new System.Windows.Forms.Label();
            this.txtPhonogram = new System.Windows.Forms.TextBox();
            this.lblExplain = new System.Windows.Forms.Label();
            this.txtExplain = new System.Windows.Forms.TextBox();
            this.btnAutoPlay = new System.Windows.Forms.Button();
            this.txtHelp = new System.Windows.Forms.TextBox();
            this.palDivider = new System.Windows.Forms.Panel();
            this.sssWord.SuspendLayout();
            this.palMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // timPlayer
            // 
            this.timPlayer.Interval = 2000;
            this.timPlayer.Tick += new System.EventHandler(this.timPlayer_Tick);
            // 
            // sssWord
            // 
            this.sssWord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.sssWord.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.sssWord.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslMessage});
            this.sssWord.Location = new System.Drawing.Point(0, 474);
            this.sssWord.Name = "sssWord";
            this.sssWord.Size = new System.Drawing.Size(800, 26);
            this.sssWord.TabIndex = 0;
            // 
            // tsslMessage
            // 
            this.tsslMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.tsslMessage.Name = "tsslMessage";
            this.tsslMessage.Size = new System.Drawing.Size(69, 20);
            this.tsslMessage.Text = "載入中…";
            // 
            // lstWordList
            // 
            this.lstWordList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.lstWordList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstWordList.Dock = System.Windows.Forms.DockStyle.Left;
            this.lstWordList.Font = new System.Drawing.Font("Consolas", 10.5F);
            this.lstWordList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.lstWordList.FormattingEnabled = true;
            this.lstWordList.ItemHeight = 20;
            this.lstWordList.Location = new System.Drawing.Point(0, 0);
            this.lstWordList.Name = "lstWordList";
            this.lstWordList.Size = new System.Drawing.Size(180, 474);
            this.lstWordList.TabIndex = 1;
            this.lstWordList.Click += new System.EventHandler(this.lstWordList_Click);
            // 
            // palMain
            // 
            this.palMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.palMain.Controls.Add(this.picLogo);
            this.palMain.Controls.Add(this.txtWord);
            this.palMain.Controls.Add(this.lblPhonogram);
            this.palMain.Controls.Add(this.txtPhonogram);
            this.palMain.Controls.Add(this.lblExplain);
            this.palMain.Controls.Add(this.txtExplain);
            this.palMain.Controls.Add(this.btnAutoPlay);
            this.palMain.Controls.Add(this.txtHelp);
            this.palMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.palMain.Location = new System.Drawing.Point(182, 0);
            this.palMain.Name = "palMain";
            this.palMain.Size = new System.Drawing.Size(618, 474);
            this.palMain.TabIndex = 3;
            // 
            // picLogo
            // 
            this.picLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picLogo.Image = global::WordCards.Properties.Resources.WordCards_Logo;
            this.picLogo.Location = new System.Drawing.Point(496, 20);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(100, 100);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // txtWord
            // 
            this.txtWord.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtWord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.txtWord.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtWord.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.txtWord.Location = new System.Drawing.Point(28, 28);
            this.txtWord.Name = "txtWord";
            this.txtWord.ReadOnly = true;
            this.txtWord.Size = new System.Drawing.Size(440, 80);
            this.txtWord.TabIndex = 1;
            this.txtWord.TabStop = false;
            // 
            // lblPhonogram
            // 
            this.lblPhonogram.AutoSize = true;
            this.lblPhonogram.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhonogram.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.lblPhonogram.Location = new System.Drawing.Point(28, 111);
            this.lblPhonogram.Name = "lblPhonogram";
            this.lblPhonogram.Size = new System.Drawing.Size(46, 23);
            this.lblPhonogram.TabIndex = 2;
            this.lblPhonogram.Text = "音標";
            // 
            // txtPhonogram
            // 
            this.txtPhonogram.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPhonogram.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.txtPhonogram.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPhonogram.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhonogram.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.txtPhonogram.Location = new System.Drawing.Point(28, 137);
            this.txtPhonogram.Name = "txtPhonogram";
            this.txtPhonogram.ReadOnly = true;
            this.txtPhonogram.Size = new System.Drawing.Size(440, 32);
            this.txtPhonogram.TabIndex = 2;
            this.txtPhonogram.TabStop = false;
            // 
            // lblExplain
            // 
            this.lblExplain.AutoSize = true;
            this.lblExplain.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExplain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.lblExplain.Location = new System.Drawing.Point(28, 172);
            this.lblExplain.Name = "lblExplain";
            this.lblExplain.Size = new System.Drawing.Size(46, 23);
            this.lblExplain.TabIndex = 3;
            this.lblExplain.Text = "解釋";
            // 
            // txtExplain
            // 
            this.txtExplain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtExplain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.txtExplain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtExplain.Font = new System.Drawing.Font("Microsoft JhengHei UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtExplain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.txtExplain.Location = new System.Drawing.Point(28, 198);
            this.txtExplain.Multiline = true;
            this.txtExplain.Name = "txtExplain";
            this.txtExplain.ReadOnly = true;
            this.txtExplain.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtExplain.Size = new System.Drawing.Size(550, 210);
            this.txtExplain.TabIndex = 3;
            this.txtExplain.TabStop = false;
            // 
            // btnAutoPlay
            // 
            this.btnAutoPlay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAutoPlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnAutoPlay.FlatAppearance.BorderSize = 0;
            this.btnAutoPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAutoPlay.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnAutoPlay.ForeColor = System.Drawing.Color.White;
            this.btnAutoPlay.Location = new System.Drawing.Point(490, 420);
            this.btnAutoPlay.Name = "btnAutoPlay";
            this.btnAutoPlay.Size = new System.Drawing.Size(100, 36);
            this.btnAutoPlay.TabIndex = 4;
            this.btnAutoPlay.Text = "▶  Play";
            this.btnAutoPlay.UseVisualStyleBackColor = false;
            this.btnAutoPlay.Click += new System.EventHandler(this.btnAutoPlay_Click);
            // 
            // txtHelp
            // 
            this.txtHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.txtHelp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHelp.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHelp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.txtHelp.Location = new System.Drawing.Point(28, 420);
            this.txtHelp.Multiline = true;
            this.txtHelp.Name = "txtHelp";
            this.txtHelp.ReadOnly = true;
            this.txtHelp.Size = new System.Drawing.Size(170, 51);
            this.txtHelp.TabIndex = 5;
            this.txtHelp.TabStop = false;
            this.txtHelp.Text = "Enter → 下一個　Space → 重複播放";
            // 
            // palDivider
            // 
            this.palDivider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.palDivider.Dock = System.Windows.Forms.DockStyle.Left;
            this.palDivider.Location = new System.Drawing.Point(180, 0);
            this.palDivider.Name = "palDivider";
            this.palDivider.Size = new System.Drawing.Size(2, 474);
            this.palDivider.TabIndex = 2;
            // 
            // frmWordCards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.palMain);
            this.Controls.Add(this.palDivider);
            this.Controls.Add(this.lstWordList);
            this.Controls.Add(this.sssWord);
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(700, 480);
            this.Name = "frmWordCards";
            this.Text = "WordCards — 單字學習";
            this.Load += new System.EventHandler(this.frmWordCards_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmWordCards_KeyPress);
            this.sssWord.ResumeLayout(false);
            this.sssWord.PerformLayout();
            this.palMain.ResumeLayout(false);
            this.palMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timPlayer;
        private System.Windows.Forms.StatusStrip sssWord;
        private System.Windows.Forms.ToolStripStatusLabel tsslMessage;
        private System.Windows.Forms.ListBox lstWordList;
        private System.Windows.Forms.Panel palMain;
        private System.Windows.Forms.Panel palDivider;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.TextBox txtWord;
        private System.Windows.Forms.Label lblPhonogram;
        private System.Windows.Forms.TextBox txtPhonogram;
        private System.Windows.Forms.Label lblExplain;
        private System.Windows.Forms.TextBox txtExplain;
        private System.Windows.Forms.Button btnAutoPlay;
        private System.Windows.Forms.TextBox txtHelp;
    }
}