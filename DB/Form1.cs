using System.Data;
using System.Data.Common;
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
            // query to take all the tables 
            var table = db.GetTables();
            table.Columns.Add("FullName");
            for (int i = 0; i < table.Rows.Count; i++)
            {
                table.Rows[i]["FullName"] = $"{table.Rows[i]["TABLE_SCHEMA"]}.{table.Rows[i]["TABLE_NAME"]}";
            }
            var rows = table.DefaultView;

            comboBox1.DisplayMember = "FullName";
            comboBox1.DataSource = rows;

            //SELECT * FROM production.categories c
            var categories = db.GetCategories().DefaultView;
            comboBox_Categories.DisplayMember = "category_name";
            comboBox_Categories.ValueMember = "category_id";
            comboBox_Categories.DataSource = categories;

            //SELECT * FROM production.brand c
            var brands = db.GetBrands().DefaultView;
            comboBox_brand.DisplayMember = "brand_name";
            comboBox_brand.ValueMember = "brand_id";
            comboBox_brand.DataSource = brands;


        }

        private void btn_loadTable_Click(object sender, EventArgs e)
        {
            var selItem = comboBox1.SelectedItem as DataRowView;
            var table = db.GetAllItems(selItem["FullName"].ToString());
            dataGridView1.DataSource = table;
        }


        private void comboBox_Categories_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Price_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Salva_Click(object sender, EventArgs e)
        {
            var NomeProdotto = textBox2.Text;
            decimal Prezzo = decimal.Parse(Price.Text);
            int Brand = int.Parse(comboBox_brand.ValueMember);
            int Categories = int.Parse(comboBox_brand.ValueMember);
            int data = dateTimePicker.Value.Year;
            db.AddProduct(NomeProdotto, Prezzo, Categories, Brand, data);
        }
    }
}