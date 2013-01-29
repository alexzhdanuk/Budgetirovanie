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
    public partial class AddDataForm : Form
    {
        public bool Plan;
        public DatabaseClass Data;

        public AddDataForm()
        {
            InitializeComponent();
            }

        private void AddDataForm_Shown(object sender, EventArgs e)
        {
            if (Plan) label2.Text = "Количество плановых средств";
            else label2.Text = "Количество потраченых средств";

            ArticleСomboBox.DataSource = Data. GetData("SELECT * FROM directory_articles");
            ArticleСomboBox.DisplayMember = "Name";
            ArticleСomboBox.ValueMember = "kod";
            
        }

        private void ButtonCansel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonOk_Click(object sender, EventArgs e)
        {
            if (!Proverka()) return;


            if (Plan)
            {
                Data.GetAddExecuteQuery("INSERT INTO  costsplan ( kod, KodArticle, CostsArticle, StartArticleDate, FinishArticleDate, DateAddRecord ) VALUES (  NULL, " + ArticleСomboBox.SelectedValue + " , " + MoneyTextBox.Text + ",  @StartDate, @EndDate, @CurrentDate ); ", StartDateTimePicker.Value, EndDateTimePicker.Value);
            }
            else
            {
                Data.GetAddExecuteQuery("INSERT INTO  costsfact  ( kod, KodArticle, CostsArticle, StartArticleDate, FinishArticleDate, DateAddRecord ) VALUES (  NULL,  " + ArticleСomboBox.SelectedValue + " , " + MoneyTextBox.Text + ",  @StartDate, @EndDate, @CurrentDate ); ", StartDateTimePicker.Value, EndDateTimePicker.Value);
            }
        }

        private bool Proverka() 
        {
            if (MoneyTextBox.Text == "") { MessageBox.Show("Введите количество средств"); MoneyTextBox.Focus(); return false; }
            if (StartDateTimePicker.Value == StartDateTimePicker.MinDate) { MessageBox.Show("Введите начальную дату"); StartDateTimePicker.Focus(); return false; }
            if (EndDateTimePicker.Value == EndDateTimePicker.MinDate) { MessageBox.Show("Введите конечную дату"); EndDateTimePicker.Focus(); return false; }

            return true;
        }


    }
}
