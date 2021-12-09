
namespace WindowManiaPlayer
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.playerplay = new System.Windows.Forms.Button();
            this.beatmap = new System.Windows.Forms.Button();
            this.filedialog = new System.Windows.Forms.OpenFileDialog();
            this.IsDebugMode = new System.Windows.Forms.CheckBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.link_github = new System.Windows.Forms.Button();
            this.link_twitter = new System.Windows.Forms.Button();
            this.link_repository = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(12, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(359, 19);
            this.textBox1.TabIndex = 0;
            // 
            // playerplay
            // 
            this.playerplay.Location = new System.Drawing.Point(377, 46);
            this.playerplay.Name = "playerplay";
            this.playerplay.Size = new System.Drawing.Size(75, 23);
            this.playerplay.TabIndex = 2;
            this.playerplay.Text = "再生";
            this.playerplay.UseVisualStyleBackColor = true;
            this.playerplay.Click += new System.EventHandler(this.playerplay_Click);
            // 
            // beatmap
            // 
            this.beatmap.Location = new System.Drawing.Point(377, 25);
            this.beatmap.Name = "beatmap";
            this.beatmap.Size = new System.Drawing.Size(75, 19);
            this.beatmap.TabIndex = 5;
            this.beatmap.Text = "譜面ファイル";
            this.beatmap.UseVisualStyleBackColor = true;
            this.beatmap.Click += new System.EventHandler(this.beatmap_Click);
            // 
            // IsDebugMode
            // 
            this.IsDebugMode.AutoSize = true;
            this.IsDebugMode.Location = new System.Drawing.Point(11, 51);
            this.IsDebugMode.Name = "IsDebugMode";
            this.IsDebugMode.Size = new System.Drawing.Size(88, 16);
            this.IsDebugMode.TabIndex = 6;
            this.IsDebugMode.Text = "デバッグモード";
            this.IsDebugMode.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(240, 50);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            9999,
            0,
            0,
            -2147483648});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(49, 19);
            this.numericUpDown1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(158, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "オフセット(ms) :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "このアプリの製作者 : 水咲(みさき)";
            // 
            // link_github
            // 
            this.link_github.Location = new System.Drawing.Point(182, 4);
            this.link_github.Name = "link_github";
            this.link_github.Size = new System.Drawing.Size(52, 21);
            this.link_github.TabIndex = 10;
            this.link_github.Text = "GitHub";
            this.link_github.UseVisualStyleBackColor = true;
            this.link_github.Click += new System.EventHandler(this.link_github_Click);
            // 
            // link_twitter
            // 
            this.link_twitter.Location = new System.Drawing.Point(237, 4);
            this.link_twitter.Name = "link_twitter";
            this.link_twitter.Size = new System.Drawing.Size(52, 21);
            this.link_twitter.TabIndex = 11;
            this.link_twitter.Text = "Twitter";
            this.link_twitter.UseVisualStyleBackColor = true;
            this.link_twitter.Click += new System.EventHandler(this.link_twitter_Click);
            // 
            // link_repository
            // 
            this.link_repository.Location = new System.Drawing.Point(295, 4);
            this.link_repository.Name = "link_repository";
            this.link_repository.Size = new System.Drawing.Size(76, 21);
            this.link_repository.TabIndex = 12;
            this.link_repository.Text = "Repository";
            this.link_repository.UseVisualStyleBackColor = true;
            this.link_repository.Click += new System.EventHandler(this.link_repository_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 80);
            this.Controls.Add(this.link_repository);
            this.Controls.Add(this.link_twitter);
            this.Controls.Add(this.link_github);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.IsDebugMode);
            this.Controls.Add(this.beatmap);
            this.Controls.Add(this.playerplay);
            this.Controls.Add(this.textBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Window Mania Player";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button playerplay;
        private System.Windows.Forms.Button beatmap;
        private System.Windows.Forms.OpenFileDialog filedialog;
        private System.Windows.Forms.CheckBox IsDebugMode;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button link_github;
        private System.Windows.Forms.Button link_twitter;
        private System.Windows.Forms.Button link_repository;
    }
}

