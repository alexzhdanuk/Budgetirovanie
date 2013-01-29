namespace Budgetirovanie
{
    partial class GeneralForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.GeneralMenu = new System.Windows.Forms.MenuStrip();
            this.FileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ConectFileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditMenuItem_AddArticle = new System.Windows.Forms.ToolStripMenuItem();
            this.EditMenuItem_AddPlan = new System.Windows.Forms.ToolStripMenuItem();
            this.EditMenuItem_AddFact = new System.Windows.Forms.ToolStripMenuItem();
            this.DataMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowDataMenuItem_Plan = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowDataMenuItem_Fact = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ShowGistMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ServiceMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OptionsServiceMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GeneralMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // GeneralMenu
            // 
            this.GeneralMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenuItem,
            this.EditMenuItem,
            this.DataMenuItem,
            this.ServiceMenuItem,
            this.HelpMenuItem});
            this.GeneralMenu.Location = new System.Drawing.Point(0, 0);
            this.GeneralMenu.Name = "GeneralMenu";
            this.GeneralMenu.Size = new System.Drawing.Size(563, 24);
            this.GeneralMenu.TabIndex = 0;
            this.GeneralMenu.Text = "menuStrip1";
            // 
            // FileMenuItem
            // 
            this.FileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ConectFileMenuItem});
            this.FileMenuItem.Name = "FileMenuItem";
            this.FileMenuItem.Size = new System.Drawing.Size(48, 20);
            this.FileMenuItem.Text = "Файл";
            // 
            // ConectFileMenuItem
            // 
            this.ConectFileMenuItem.Name = "ConectFileMenuItem";
            this.ConectFileMenuItem.Size = new System.Drawing.Size(229, 22);
            this.ConectFileMenuItem.Text = "Подключится к базе данных";
            this.ConectFileMenuItem.Click += new System.EventHandler(this.ConectFileMenuItem_Click);
            // 
            // EditMenuItem
            // 
            this.EditMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EditMenuItem_AddArticle,
            this.EditMenuItem_AddPlan,
            this.EditMenuItem_AddFact});
            this.EditMenuItem.Name = "EditMenuItem";
            this.EditMenuItem.Size = new System.Drawing.Size(59, 20);
            this.EditMenuItem.Text = "Правка";
            // 
            // EditMenuItem_AddArticle
            // 
            this.EditMenuItem_AddArticle.Name = "EditMenuItem_AddArticle";
            this.EditMenuItem_AddArticle.Size = new System.Drawing.Size(259, 22);
            this.EditMenuItem_AddArticle.Text = "Добавить статью затрат";
            this.EditMenuItem_AddArticle.Click += new System.EventHandler(this.EditMenuItem_AddArticle_Click);
            // 
            // EditMenuItem_AddPlan
            // 
            this.EditMenuItem_AddPlan.Name = "EditMenuItem_AddPlan";
            this.EditMenuItem_AddPlan.Size = new System.Drawing.Size(259, 22);
            this.EditMenuItem_AddPlan.Text = "Запланировать затраты";
            this.EditMenuItem_AddPlan.Click += new System.EventHandler(this.EditMenuItem_AddPlan_Click);
            // 
            // EditMenuItem_AddFact
            // 
            this.EditMenuItem_AddFact.Name = "EditMenuItem_AddFact";
            this.EditMenuItem_AddFact.Size = new System.Drawing.Size(259, 22);
            this.EditMenuItem_AddFact.Text = "Отнести затраты на статью затрат";
            this.EditMenuItem_AddFact.Click += new System.EventHandler(this.EditMenuItem_AddFact_Click);
            // 
            // DataMenuItem
            // 
            this.DataMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowDataMenuItem_Plan,
            this.ShowDataMenuItem_Fact,
            this.toolStripSeparator1,
            this.ShowGistMenuItem});
            this.DataMenuItem.Name = "DataMenuItem";
            this.DataMenuItem.Size = new System.Drawing.Size(62, 20);
            this.DataMenuItem.Text = "Данные";
            // 
            // ShowDataMenuItem_Plan
            // 
            this.ShowDataMenuItem_Plan.Name = "ShowDataMenuItem_Plan";
            this.ShowDataMenuItem_Plan.Size = new System.Drawing.Size(264, 22);
            this.ShowDataMenuItem_Plan.Text = "План затрат";
            this.ShowDataMenuItem_Plan.Click += new System.EventHandler(this.MenuItemDataShow_Click);
            // 
            // ShowDataMenuItem_Fact
            // 
            this.ShowDataMenuItem_Fact.Name = "ShowDataMenuItem_Fact";
            this.ShowDataMenuItem_Fact.Size = new System.Drawing.Size(264, 22);
            this.ShowDataMenuItem_Fact.Text = "Факт затрат";
            this.ShowDataMenuItem_Fact.Click += new System.EventHandler(this.ShowDataMenuItem_Fact_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(261, 6);
            // 
            // ShowGistMenuItem
            // 
            this.ShowGistMenuItem.Name = "ShowGistMenuItem";
            this.ShowGistMenuItem.Size = new System.Drawing.Size(264, 22);
            this.ShowGistMenuItem.Text = "Отобразить данные на гистограме";
            this.ShowGistMenuItem.Click += new System.EventHandler(this.ShowGistMenuItem_Click);
            // 
            // ServiceMenuItem
            // 
            this.ServiceMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OptionsServiceMenuItem});
            this.ServiceMenuItem.Name = "ServiceMenuItem";
            this.ServiceMenuItem.Size = new System.Drawing.Size(59, 20);
            this.ServiceMenuItem.Text = "Сервис";
            // 
            // OptionsServiceMenuItem
            // 
            this.OptionsServiceMenuItem.Name = "OptionsServiceMenuItem";
            this.OptionsServiceMenuItem.Size = new System.Drawing.Size(134, 22);
            this.OptionsServiceMenuItem.Text = "Настройки";
            this.OptionsServiceMenuItem.Click += new System.EventHandler(this.OptionsMenuItem_Click);
            // 
            // HelpMenuItem
            // 
            this.HelpMenuItem.Name = "HelpMenuItem";
            this.HelpMenuItem.Size = new System.Drawing.Size(65, 20);
            this.HelpMenuItem.Text = "Справка";
            // 
            // GeneralForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 341);
            this.Controls.Add(this.GeneralMenu);
            this.MainMenuStrip = this.GeneralMenu;
            this.Name = "GeneralForm";
            this.Text = "Form1";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.GeneralMenu.ResumeLayout(false);
            this.GeneralMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip GeneralMenu;
        private System.Windows.Forms.ToolStripMenuItem FileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DataMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ShowDataMenuItem_Plan;
        private System.Windows.Forms.ToolStripMenuItem ServiceMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OptionsServiceMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ConectFileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ShowDataMenuItem_Fact;
        private System.Windows.Forms.ToolStripMenuItem EditMenuItem_AddArticle;
        private System.Windows.Forms.ToolStripMenuItem EditMenuItem_AddPlan;
        private System.Windows.Forms.ToolStripMenuItem EditMenuItem_AddFact;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ShowGistMenuItem;
    }
}

