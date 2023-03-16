using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            //SELECT * FROM production.categories c
            var categories = db.GetCategories().DefaultView;
            comboBox_Categories.DisplayMember = "category_name";
            comboBox_Categories.DataSource = categories;


            //SELECT * FROM production.brand c
            var brands = db.GetBrands().DefaultView;
            comboBox_brand.DisplayMember = "brand_name";
            comboBox_brand.DataSource = brands;

            //city of customer
            var cities = db.GetCities().DefaultView;
            comboBox_city.DisplayMember = "city";
            comboBox_city.DataSource = cities;

            // categories filter
            comboBox_Categoria_filter.DisplayMember = "category_name";
            comboBox_Categoria_filter.DataSource = categories;

            //brand filter
            comboBox_Brand_filter.DisplayMember = "brand_name";
            comboBox_Brand_filter.DataSource = brands;



            //order asc dec 
            string[] order = new string[] { "ASC", "DESC" };
            comboBox_order.DataSource = order;

            Label_PrezzoSelezionato.Text = trackBar1.Value.ToString();

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

        private void Salva_Click(object sender, EventArgs e)
        {
            string nome;
            DataRowView brand, category;
            int brand_id, category_id, year;
            decimal list_price;
            try
            {
                nome = textBox2.Text.ToString().Trim();
                brand = comboBox_brand.SelectedItem as DataRowView;
                brand_id = int.Parse($"{brand["brand_id"]}");
                category = comboBox_Categories.SelectedItem as DataRowView;
                category_id = int.Parse($"{category["category_id"]}");
                year = int.Parse(txt_data.Text);
                list_price = decimal.Parse(textBox_Price.Text);
                db.AddProduct(nome, brand_id, category_id, year, list_price);
            }
            catch (FormatException)
            {
                // vedere come si fa a controllare che una stringa sia concenvtibile in int ---> questo è un if che lo verifica if(int.TryParse(x, out int value))
                MessageBox.Show("hai inserito un dato sbagliato e/o non hai inserito un campo");
            }
        }

        private void txt_data_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonMostra_Click(object sender, EventArgs e)
        {
            //var order = comboBox_order.SelectedItem.ToString();
            //var table = db.GetAllProducts(order, trackBar1.Value);
            //dataGridView_products.DataSource = table;
            var table = db.getStaff();
            dataGridView_products.DataSource = table;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            trackBar1.Maximum = 10000;
            trackBar1.Minimum = 0;
            Label_PrezzoSelezionato.Text = trackBar1.Value.ToString();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Filtra_Click(object sender, EventArgs e)
        {
            var table = db.GetCustomers(comboBox_city.Text);
            dataGridView2.DataSource = table;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void comboBox_order_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_FilteredProduct_Click(object sender, EventArgs e)
        {
             var  brand = comboBox_Brand_filter.SelectedItem as DataRowView;
            var brand_id = int.Parse($"{brand["brand_id"]}");
            var category = comboBox_Categoria_filter.SelectedItem as DataRowView;
            var category_id = int.Parse($"{category["category_id"]}");
            var year = textBox_year.Text;
            var table = db.GetFilteredProduct(int.Parse(year) ,brand_id , category_id , trackBar1.Value);
            dataGridView_products.DataSource = table;
        }
    }
}