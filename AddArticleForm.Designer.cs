namespace Budgetirovanie
{
    partial class AddArticleForm
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
            this.NameArticle = new System.Windows.Forms.TextBox();
            this.AddArticle = new System.Windows.Forms.Button();
            this.MenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.DellMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // NameArticle
            // 
            this.NameArticle.Location = new System.Drawing.Point(12, 15);
            this.NameArticle.Name = "NameArticle";
            this.NameArticle.Size = new System.Drawing.Size(110, 20);
            this.NameArticle.TabIndex = 0;
            // 
            // AddArticle
            // 
            this.AddArticle.Location = new System.Drawing.Point(163, 15);
            this.AddArticle.Name = "AddArticle";
            this.AddArticle.Size = new System.Drawing.Size(110, 20);
            this.AddArticle.TabIndex = 1;
            this.AddArticle.Text = "Добавить статью";
            this.AddArticle.UseVisualStyleBackColor = true;
            this.AddArticle.Click += new System.EventHandler(this.AddArticle_Click);
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DellMenuItem});
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(153, 48);
            // 
            // DellMenuItem
            // 
            this.DellMenuItem.Name = "DellMenuItem";
            this.DellMenuItem.Size = new System.Drawing.Size(152, 22);
            this.DellMenuItem.Text = "Удалить";
            this.DellMenuItem.Click += new System.EventHandler(this.DellMenuItem_Click);
            // 
            // AddArticleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.AddArticle);
            this.Controls.Add(this.NameArticle);
            this.Name = "AddArticleForm";
            this.Text = "Добавить статью ";
            this.Shown += new System.EventHandler(this.AddArticleForm_Shown);
            this.Resize += new System.EventHandler(this.AddArticleForm_Resize);
            this.MenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameArticle;
        private System.Windows.Forms.Button AddArticle;
        private System.Windows.Forms.ContextMenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem DellMenuItem;
    }
}