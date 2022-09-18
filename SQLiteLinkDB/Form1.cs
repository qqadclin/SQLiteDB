using System;
using System.Windows.Forms;
using System.Data.SQLite;
using SQLiteAccess;
using System.Data;
using System.Text;
using System.Collections.Generic;

namespace SQLiteLinkDBTest
{
    public partial class Form1 : Form
    {
        public static int Index { get; set; }
        public static string ParaName { get; set; }
        public static int Price { get; set; }

        public static string dbName = "DataBase.sqlite";
        public static string dateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        public static string tableName ;
       // public static SQLiteConnection conn = new SQLiteConnection($"Data Source={dbName}");

        AccessDB acc = new AccessDB(dbName);

        public Form1()
        {
            InitializeComponent();
        }       

        private void Form1_Load(object sender, EventArgs e)
        {
            acc.OpenDB();
        }

        private void UpSert_Click(object sender, EventArgs e)
        {
            acc.Transaction();

            Index = int.Parse(NOBox.Text);
            ParaName = NameBox.Text;
            Price = int.Parse(PriceBox.Text);

            var query = $"REPLACE INTO {tableName}(NO,NAME,PRICE,DATETIME)VALUES({Index},'{ParaName}',{Price},'{dateTime}')";

            string judement = acc.ExeNonQuery(query).ToString();
            ShowMessage(judement);
        }

        private void ShowMessage(string judement)
        {
            if (judement != null)
            {
                MessageBox.Show(judement);
            }
        }

        DataTable dt = new DataTable();
        DataTable dt2 = new DataTable();

        protected override void OnLoad(EventArgs e)
        {
            dataGridView1.DataSource = dt;
            dataGridView2.DataSource = dt2;

            base.OnLoad(e);
        }

        private void ShowTable_Click(object sender, EventArgs e)
        {
            var query = $"SELECT * FROM {tableName}";
            acc.SetData(query,dt);
            //using(SQLiteConnection co=new SQLiteConnection($"Data Source={dbName}"))
            //using(SQLiteDataAdapter sqlada=new SQLiteDataAdapter($"SELECT * FROM {tableName}",co))
            //{
            //    sqlada.Fill(dt);
            //}   
        }

        private void Selete_Click(object sender, EventArgs e)
        {
            acc.Transaction();
            acc.RollBack();
            ParaName = NameBox.Text;

            var query = $"SELECT * FROM {tableName}WHERE Name='{ParaName}' ORDER BY NO ASC";

            var (para, reader) = acc.GetSQLiteData(query);

            int indexNO = 0;
            string para1 = null;
            int para2 = 0;
            string datetime = null;

            var result = new List<DataReader>();

            using (reader)
            {
                while (reader.Read())
                {
                    indexNO = int.Parse(reader["NO"].ToString());
                    para1 = (string)reader["NAME"];
                    para2 = int.Parse(reader["PRICE"].ToString());
                    datetime = reader["DATETIME"].ToString();
                    
                    result.Add(new DataReader(indexNO,para1,para2,datetime));
                }
            }

            reader.Close();

            var query2 = $"SELECT *FROM {tableName} WHERE Name='{ParaName}' ORDER BY NO ASC";

            acc.SetData(query2,dt2); 
        }

        private void UpTable_Click(object sender, EventArgs e)
        {
            StringBuilder query = new StringBuilder();
            tableName = TableNameBox.Text;            
            query.Clear();
            query.Append($"CREATE TABLE IF NOT EXISTS {tableName} (");
            query.Append(" NO INTEGER NOT NULL");
            query.Append(" ,NAME TEXT NOT NULL");
            query.Append(" ,PRICE INTEGER NOT NULL");
            query.Append(" ,DATETIME TEXT NOT NULL");
            query.Append(" ,primary key (NO)");
            query.Append(")");

            acc.Transaction();
            // クエリー実行
            acc.ExeNonQuery(query.ToString());
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            acc.Transaction();

            Index = int.Parse(NOBox.Text);

            var query = $"DELETE FROM {tableName} WHERE NO='{Index}'";

            string judement = acc.ExeNonQuery(query).ToString();
            ShowMessage(judement);
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            acc.Transaction();

            Index = int.Parse(NOBox.Text);
            ParaName = NameBox.Text;
            Price = int.Parse(PriceBox.Text);

            var query = $"INSERT INTO {tableName}(NO,NAME,PRICE,DATETIME)VALUES({Index},'{ParaName}',{Price},'{dateTime}')";

            string judement = acc.ExeNonQuery(query).ToString();
            ShowMessage(judement);
        }
    }
}
