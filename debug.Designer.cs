
namespace WindowManiaPlayer
{
    partial class debug
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
            this.displaytext = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // displaytext
            // 
            this.displaytext.AutoSize = true;
            this.displaytext.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.displaytext.Location = new System.Drawing.Point(0, 0);
            this.displaytext.Name = "displaytext";
            this.displaytext.Size = new System.Drawing.Size(281, 192);
            this.displaytext.TabIndex = 0;
            this.displaytext.Text = "Window : 300\r\nFPS : 0\r\n0:00/0:00\r\n0000/0000";
            // 
            // debug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 194);
            this.Controls.Add(this.displaytext);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "debug";
            this.ShowInTaskbar = false;
            this.Text = "debug";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.debug_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label displaytext;
    }
}