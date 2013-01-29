using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Budgetirovanie
{
    public partial class AddArticleForm : Form
    {
        public DatabaseClass Data;
        private ShowData ShowDataWindow;

        public AddArticleForm()
        {
            InitializeComponent();
        }

        //Добавление новой записи
        private void AddArticle_Click(object sender, EventArgs e)
        {
            if (NameArticle.Text == "") return;
            if (Data.ExecuteQuery("INSERT INTO  directory_articles ( Kod, Name ) VALUES (NULL ,  '" + NameArticle.Text + "'); "))
            {
                NameArticle.Text = "";
                AddArticleForm_Shown(null, null);
            }
        }
        
        //Изщменение размеров формы
        private void AddArticleForm_Resize(object sender, EventArgs e)
        {
            //Изменение размера самостоятельно (из-за MenuStrip)
            if (ShowDataWindow != null)
            {
                ShowDataWindow.Location = new Point(0, 40);
                ShowDataWindow.Size = new Size(ClientSize.Width, ClientSize.Height - 40);
            }
        }

        //Отображение данных
        private void AddArticleForm_Shown(object sender, EventArgs e)
        {
            if (ShowDataWindow != null) ShowDataWindow.Dispose();
            ShowDataWindow = new ShowData();

            ShowDataWindow.SetContextMenu(MenuStrip);
            ShowDataWindow.Parent = this;
            ShowDataWindow.DataClass = Data;
            ShowDataWindow.DataGridView.DataSource = Data.GetData("SELECT * FROM directory_articles");
            AddArticleForm_Resize(null, null);
        }
        
        //удаление записей с помощью контекстного меню
        private void DellMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (ShowDataWindow == null) return;
                int DelKod = ShowDataWindow.GetCurrentItemKod();
                Data.ExecuteQuery("DELETE FROM  directory_articles WHERE Kod =  '" + DelKod + "'");
                AddArticleForm_Shown(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
