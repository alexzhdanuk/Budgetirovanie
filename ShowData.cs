using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//add to contorl version


namespace Budgetirovanie
{
    public partial class ShowData : UserControl
    {
        public DatabaseClass DataClass;

        public ShowData()
        {
            InitializeComponent();
        }

        public void ShowData_Resize(object sender, EventArgs e)
        {
            DataGridView.Size = new Size(ClientSize.Width, ClientSize.Height);
            Exit.Location = new Point(ClientSize.Width - 20, 2);
        }

        //Закрываем окно 
        private void Exit_Click(object sender, EventArgs e)
        {
            ((GeneralForm)this.Parent).ShowDataWindow.Dispose();
        }



        //получение кода активной строки
        public int GetCurrentItemKod() { return Convert.ToInt32(DataGridView[0,DataGridView.CurrentRow.Index].Value); }

        //установка контекстного меню
        public void SetContextMenu(ContextMenuStrip Item) { DataGridView.ContextMenuStrip = Item; }




    }
}
