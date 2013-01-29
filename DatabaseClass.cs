using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Data;
using System.Windows.Forms;

//add to contorl version

///dmnsfbnmdbfnm
namespace Budgetirovanie
{
    
    public class DatabaseClass
    {
        //Переменные текущей БД, сервера и пользователя
        private string ServerName;
        private string UserName;
        private string  Pass;
        private string DatabaseName;

        //Объект Connection с драйвером ODBC
        private OdbcConnection Connection;
        private OdbcDataAdapter DataAdapter;
        private OdbcCommand Command;
        private DataSet dataSet;

        //флаг для определения были ли изменены настройки
        

        public DatabaseClass()
        {
            ServerName = "localhost";
            UserName = "root";
            Pass = "";
            DatabaseName = "budgetirovanie";

            Connection = null;
            DataAdapter = null;
            Command = null;
            dataSet = null;

        }
        
        //Подключение к базе данных
        public bool ConectToDatabase()
        {
            try
            {
                if (Connection != null) { Connection.Close(); Connection = null; }
                string source = "DRIVER=MySQL ODBC 5.2w Driver;UID=" + UserName + ";SERVER=" + ServerName + ";PORT=0;OPTION=0;DATABASE="+DatabaseName;
                
                Connection = new OdbcConnection(source);

                MessageBox.Show(source, "Начальная строка подключения", MessageBoxButtons.OK,
                                  MessageBoxIcon.Information);

                Connection.Open();
                return true;

            }

            catch (Exception ex)
            {
                Connection = null;
                MessageBox.Show(ex.Message);
                return false;

            }

        }

        //изменение настроек подключение к базе
        public void ChangeSettings(string NewServerName, string newUserName, string newPass, string newDatabaseName)
        {
            ServerName = NewServerName;
            UserName = newUserName;
            Pass = newPass;
            DatabaseName = newDatabaseName;

            this.ConectToDatabase();
        }

        //функция для наполнение GridView
        public DataTable GetData(string strQuery)
        {
            try
            {
                //Создание объекта Recordset
                if (DataAdapter != null) DataAdapter.Dispose();
                
                DataAdapter = new OdbcDataAdapter(strQuery, Connection);

                if (dataSet != null) dataSet.Dispose();
                dataSet = new DataSet();
                DataAdapter.Fill(dataSet);
                
                return dataSet.Tables[0];
            }
            catch (Exception ex)
            {
                Connection = null;
                MessageBox.Show(ex.Message);
                return new DataTable();
            }

        }

        //возвращает имя текущего сервера
        public string GetServerName() { return ServerName;}

        //возврат имени текущего пользователя
        public string GetUserName()   { return UserName; }

        //возврат имени текущего пароля
        public string GetPass()       { return Pass; }

        //возврат имени текущей базы данных
        public string GetDatabaseName() { return DatabaseName; }

        //Выполняет запрос и возвращает результат
        public bool ExecuteQuery(string query)
        {
            try
            {
                if (Command != null) DataAdapter.Dispose();

                //создание обьекта OdbcCommand
                Command = new OdbcCommand(query,Connection);

                Command.ExecuteNonQuery();
                return true;

            }
            catch (Exception ex)
            {
                Connection = null;
                MessageBox.Show(ex.Message);
                return false;
            }

        }

        public bool GetAddExecuteQuery(string query, DateTime StartDate, DateTime EndDate)
        {
            try
            {
                if (Command != null) DataAdapter.Dispose();

                //создание обьекта OdbcCommand
                Command = new OdbcCommand(query, Connection);
                Command.Parameters.AddWithValue("@StartDate", StartDate);
                Command.Parameters.AddWithValue("@EndDate", EndDate);
                Command.Parameters.AddWithValue("@CurrentDate", DateTime.Now);


                Command.ExecuteNonQuery();
                return true;

            }
            catch (Exception ex)
            {
                Connection = null;
                MessageBox.Show(ex.Message);
                return false;
            }
        
        }

    }
    
}
