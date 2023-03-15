using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace DB
{
    public partial class Form1 : Form
    {
        public Database db;
        public Form1()
        {
            InitializeComponent();
            db = new Database();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var table = db.GetTables();
            table.Columns.Add("FullName");
            for (int i = 0; i < table.Rows.Count; i++)
            {
                table.Rows[i]["FullName"] = $"{table.Rows[i]["TABLE_SCHEMA"]}.{table.Rows[i]["TABLE_NAME"]}";
            }
            var rows = table.DefaultView;
            
            comboBox1.DisplayMember = "FullName";
            comboBox1.DataSource = rows;
        }

        private void btn_loadTable_Click(object sender, EventArgs e)
        {
            var selItem = comboBox1.SelectedItem as DataRowView;
            var table = db.GetAllItems(selItem["FullName"].ToString());
            dataGridView1.DataSource = table;
        }
    }
}