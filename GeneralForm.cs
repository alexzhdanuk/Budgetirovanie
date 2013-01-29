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
    public partial class GeneralForm : Form
    {
        public ShowData ShowDataWindow;
        public OptionsForm OptionsFormWindow;
        public DatabaseClass DataClass;
        public AddDataForm AddForm;
        public GistForm GistWindow;

        public AddArticleForm AddArticleWindow;


        //флаг для определения был ли коннект к базе
        public bool IsConnectToBase;
        
        public GeneralForm()
        {
            ShowDataWindow = new ShowData();
            OptionsFormWindow = null;
            DataClass  = new DatabaseClass();
            AddForm = null;
            GistWindow = null;

            IsConnectToBase = false;

            InitializeComponent();
        }
        
        //Изменение размеров формы
        private void Form1_Resize(object sender, EventArgs e)
        {
            //Изменение размера самостоятельно (из-за MenuStrip)
            if (ShowDataWindow != null)
            {
                ShowDataWindow.Location = new Point(0, GeneralMenu.Height);
                ShowDataWindow.Size = new Size(ClientSize.Width, ClientSize.Height - GeneralMenu.Height);
            }

        }

        //отображение списка плановых  затрат
        private void MenuItemDataShow_Click(object sender, EventArgs e)
        {
            //if (ShowDataWindow.Parent != null) return;
            if (!IsConnectToBase) return;

            ShowDataWindow = new ShowData();

            ShowDataWindow.Parent = this;
            ShowDataWindow.DataClass = DataClass;
            ShowDataWindow.DataGridView.DataSource = DataClass.GetData("SELECT * FROM costsplan");
            Form1_Resize(null, null);
        }


        //Отображение окна настроек
        private void OptionsMenuItem_Click(object sender, EventArgs e)
        {
            OptionsFormWindow = new OptionsForm();
            OptionsFormWindow.Data = DataClass;
            OptionsFormWindow.Show();

            OptionsFormWindow.Location = new Point(Location.X + 20, Location.Y + 70);
        }
        
        //Подключение к базе данных
        private void ConectFileMenuItem_Click(object sender, EventArgs e)
        {
            IsConnectToBase = DataClass.ConectToDatabase();
        }

        //отображение списка фактических затрат
        private void ShowDataMenuItem_Fact_Click(object sender, EventArgs e)
        {
            //if (ShowDataWindow.Parent != null) return;
            if (!IsConnectToBase) return;

            ShowDataWindow = new ShowData();

            ShowDataWindow.Parent = this;
            ShowDataWindow.DataClass = DataClass;
            ShowDataWindow.DataGridView.DataSource = DataClass.GetData("SELECT * FROM costsfact");
            Form1_Resize(null, null);
  
        }

        private void EditMenuItem_AddArticle_Click(object sender, EventArgs e)
        {
            if (!IsConnectToBase) return;

            AddArticleWindow = new AddArticleForm();
            AddArticleWindow.Data = DataClass;
            AddArticleWindow.Show();
            AddArticleWindow.Location = new Point(Location.X + 20, Location.Y + 70);

        }

        private void EditMenuItem_AddPlan_Click(object sender, EventArgs e)
        {
            if (!IsConnectToBase) return;

            AddForm = new  AddDataForm();
            AddForm.Data = DataClass;
            AddForm.Plan = true;
            AddForm.Show();

            AddForm.Location = new Point(Location.X + 20, Location.Y + 70);
        }

        private void EditMenuItem_AddFact_Click(object sender, EventArgs e)
        {
            if (!IsConnectToBase) return;

            AddForm = new AddDataForm();
            AddForm.Data = DataClass;
            AddForm.Plan = false;
            AddForm.Show();

            AddForm.Location = new Point(Location.X + 20, Location.Y + 70);
        }

        private void ShowGistMenuItem_Click(object sender, EventArgs e)
        {
            if (!IsConnectToBase) return;

            GistWindow = new GistForm();

            GistWindow.Show();

            GistWindow.Location = new Point(Location.X + 20, Location.Y + 70);
        }

        


    }
}
