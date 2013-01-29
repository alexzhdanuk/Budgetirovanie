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
    public partial class OptionsForm : Form
    {
        //обьект класа данных
        public DatabaseClass Data;

        public OptionsForm()
        {
            Data = null;
            InitializeComponent();
        }
        //сохранение настроек для подключения к серверу
        private void Ok_Click(object sender, EventArgs e)
        {
            String ServerName = Data.GetServerName();
            String UserName = Data.GetUserName();
            String PassName = Data.GetPass();
            String BaseName = Data.GetDatabaseName();

            if (Server.Modified) ServerName = Server.Text;
            if (User.Modified) UserName = User.Text;
            if (Pass.Modified) PassName = Pass.Text;
            if (NameDatabase.Modified) BaseName = NameDatabase.Text;
            
            //изменение настроек подключения к серверу
            Data.ChangeSettings(ServerName, UserName, PassName, BaseName);
            
            this.Close();

        }
        
        //заполнение формы стандартными настройками
        private void OptionsForm_Shown(object sender, EventArgs e)
        {
            if (Data == null) return;
            Server.Text = Data.GetServerName();
            User.Text = Data.GetUserName();
            Pass.Text = Data.GetPass();
            NameDatabase.Text = Data.GetDatabaseName();
        }

       

    }
}
