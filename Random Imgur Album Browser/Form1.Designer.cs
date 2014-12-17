namespace Random_Imgur_Album_Browser
{
    partial class Form1
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
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.txt_URL = new System.Windows.Forms.TextBox();
            this.btn_Next = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lbl_CurrentID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // webBrowser
            // 
            this.webBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser.Location = new System.Drawing.Point(0, 26);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.ScriptErrorsSuppressed = true;
            this.webBrowser.Size = new System.Drawing.Size(696, 420);
            this.webBrowser.TabIndex = 0;
            // 
            // txt_URL
            // 
            this.txt_URL.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_URL.Location = new System.Drawing.Point(0, 0);
            this.txt_URL.Name = "txt_URL";
            this.txt_URL.ReadOnly = true;
            this.txt_URL.Size = new System.Drawing.Size(696, 20);
            this.txt_URL.TabIndex = 1;
            // 
            // btn_Next
            // 
            this.btn_Next.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_Next.Location = new System.Drawing.Point(0, 446);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(696, 23);
            this.btn_Next.TabIndex = 2;
            this.btn_Next.Text = "Next!";
            this.btn_Next.UseVisualStyleBackColor = true;
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar1.Location = new System.Drawing.Point(0, 423);
            this.progressBar1.Maximum = 1000;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(696, 23);
            this.progressBar1.TabIndex = 3;
            this.progressBar1.Visible = false;
            // 
            // lbl_CurrentID
            // 
            this.lbl_CurrentID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_CurrentID.AutoSize = true;
            this.lbl_CurrentID.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_CurrentID.Location = new System.Drawing.Point(601, 430);
            this.lbl_CurrentID.Name = "lbl_CurrentID";
            this.lbl_CurrentID.Size = new System.Drawing.Size(86, 13);
            this.lbl_CurrentID.TabIndex = 4;
            this.lbl_CurrentID.Text = "Trying ID: 00000";
            this.lbl_CurrentID.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 469);
            this.Controls.Add(this.lbl_CurrentID);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btn_Next);
            this.Controls.Add(this.txt_URL);
            this.Controls.Add(this.webBrowser);
            this.Name = "Form1";
            this.Text = "Random imgur Album Browser";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.TextBox txt_URL;
        private System.Windows.Forms.Button btn_Next;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lbl_CurrentID;
    }
}

