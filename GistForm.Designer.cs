namespace Budgetirovanie
{
    partial class GistForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GistForm));
            this.ActiveXOpenGl = new AxActiveXOpenGlLib.AxActiveXOpenGl();
            ((System.ComponentModel.ISupportInitialize)(this.ActiveXOpenGl)).BeginInit();
            this.SuspendLayout();
            // 
            // ActiveXOpenGl
            // 
            this.ActiveXOpenGl.Enabled = true;
            this.ActiveXOpenGl.Location = new System.Drawing.Point(2, 2);
            this.ActiveXOpenGl.Name = "ActiveXOpenGl";
            this.ActiveXOpenGl.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("ActiveXOpenGl.OcxState")));
            this.ActiveXOpenGl.Size = new System.Drawing.Size(850, 468);
            this.ActiveXOpenGl.TabIndex = 0;
            this.ActiveXOpenGl.UseWaitCursor = true;
            // 
            // GistForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 475);
            this.Controls.Add(this.ActiveXOpenGl);
            this.KeyPreview = true;
            this.Name = "GistForm";
            this.Text = "GistForm";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.GistForm_Load);
            this.Shown += new System.EventHandler(this.GistForm_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GistForm_KeyDown);
            this.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.GistForm_MouseWheel);
            this.Resize += new System.EventHandler(this.GistForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.ActiveXOpenGl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxActiveXOpenGlLib.AxActiveXOpenGl ActiveXOpenGl;
    }
}