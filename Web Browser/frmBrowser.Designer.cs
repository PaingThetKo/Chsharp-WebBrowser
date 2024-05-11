namespace Web_Browser
{
    partial class frmWebBrowser
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtAddress = new TextBox();
            browser = new Microsoft.Web.WebView2.WinForms.WebView2();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            btnGo = new Button();
            ((System.ComponentModel.ISupportInitialize)browser).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(12, 39);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(755, 27);
            txtAddress.TabIndex = 2;
            txtAddress.KeyDown += txtAddress_KeyDown;
            // 
            // browser
            // 
            browser.AllowExternalDrop = true;
            browser.CreationProperties = null;
            browser.DefaultBackgroundColor = Color.White;
            browser.Location = new Point(11, 79);
            browser.Name = "browser";
            browser.Size = new Size(848, 548);
            browser.TabIndex = 3;
            browser.ZoomFactor = 1D;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, exitToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(871, 28);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(47, 24);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // btnGo
            // 
            btnGo.Location = new Point(773, 31);
            btnGo.Name = "btnGo";
            btnGo.Size = new Size(86, 42);
            btnGo.TabIndex = 5;
            btnGo.Text = "Go!";
            btnGo.UseVisualStyleBackColor = true;
            btnGo.Click += btnGo_Click;
            // 
            // frmWebBrowser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(871, 639);
            Controls.Add(btnGo);
            Controls.Add(browser);
            Controls.Add(txtAddress);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmWebBrowser";
            Text = "Web Browsing";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)browser).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private TextBox txtAddress;
        private Microsoft.Web.WebView2.WinForms.WebView2 browser;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private Button btnGo;
    }
}
