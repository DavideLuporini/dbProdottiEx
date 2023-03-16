namespace DB
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            comboBox1 = new ComboBox();
            btn_loadTable = new Button();
            dataGridView1 = new DataGridView();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            comboBox_Categories = new ComboBox();
            comboBox_brand = new ComboBox();
            textBox_Price = new TextBox();
            Price = new Label();
            Date = new Label();
            Salva = new Button();
            txt_data = new TextBox();
            dateTimePicker = new DateTimePicker();
            buttonMostra = new Button();
            dataGridView_products = new DataGridView();
            comboBox_order = new ComboBox();
            label4 = new Label();
            trackBar1 = new TrackBar();
            label5 = new Label();
            label6 = new Label();
            Label_PrezzoSelezionato = new Label();
            dataGridView2 = new DataGridView();
            Filtra = new Button();
            comboBox_city = new ComboBox();
            button_FilteredProduct = new Button();
            Categoria = new Label();
            comboBox_Categoria_filter = new ComboBox();
            label8 = new Label();
            comboBox_Brand_filter = new ComboBox();
            label9 = new Label();
            textBox_year = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_products).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(33, 356);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(165, 23);
            comboBox1.TabIndex = 0;
            // 
            // btn_loadTable
            // 
            btn_loadTable.Cursor = Cursors.Hand;
            btn_loadTable.Location = new Point(204, 355);
            btn_loadTable.Name = "btn_loadTable";
            btn_loadTable.Size = new Size(66, 23);
            btn_loadTable.TabIndex = 1;
            btn_loadTable.Text = "Cerca";
            btn_loadTable.UseVisualStyleBackColor = true;
            btn_loadTable.Click += btn_loadTable_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(33, 385);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(693, 141);
            dataGridView1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(33, 29);
            textBox2.Margin = new Padding(2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(226, 23);
            textBox2.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 12);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(90, 15);
            label1.TabIndex = 5;
            label1.Text = "Nome Prodotto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(287, 12);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 6;
            label2.Text = "Categorie";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(536, 12);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 7;
            label3.Text = "Brand";
            // 
            // comboBox_Categories
            // 
            comboBox_Categories.FormattingEnabled = true;
            comboBox_Categories.Location = new Point(287, 29);
            comboBox_Categories.Name = "comboBox_Categories";
            comboBox_Categories.Size = new Size(235, 23);
            comboBox_Categories.TabIndex = 8;
            comboBox_Categories.SelectedIndexChanged += comboBox_Categories_SelectedIndexChanged;
            // 
            // comboBox_brand
            // 
            comboBox_brand.FormattingEnabled = true;
            comboBox_brand.Location = new Point(536, 30);
            comboBox_brand.Name = "comboBox_brand";
            comboBox_brand.Size = new Size(190, 23);
            comboBox_brand.TabIndex = 9;
            // 
            // textBox_Price
            // 
            textBox_Price.Location = new Point(287, 74);
            textBox_Price.Margin = new Padding(2);
            textBox_Price.Name = "textBox_Price";
            textBox_Price.Size = new Size(235, 23);
            textBox_Price.TabIndex = 10;
            textBox_Price.TextChanged += textBox_Price_TextChanged;
            // 
            // Price
            // 
            Price.AutoSize = true;
            Price.Location = new Point(287, 57);
            Price.Margin = new Padding(2, 0, 2, 0);
            Price.Name = "Price";
            Price.Size = new Size(41, 15);
            Price.TabIndex = 11;
            Price.Text = "Prezzo";
            // 
            // Date
            // 
            Date.AutoSize = true;
            Date.Location = new Point(33, 57);
            Date.Margin = new Padding(2, 0, 2, 0);
            Date.Name = "Date";
            Date.Size = new Size(36, 15);
            Date.TabIndex = 13;
            Date.Text = "Anno";
            // 
            // Salva
            // 
            Salva.Cursor = Cursors.Hand;
            Salva.Location = new Point(593, 68);
            Salva.Margin = new Padding(2);
            Salva.Name = "Salva";
            Salva.Size = new Size(133, 33);
            Salva.TabIndex = 14;
            Salva.Text = "Salva";
            Salva.UseVisualStyleBackColor = true;
            Salva.Click += Salva_Click;
            // 
            // txt_data
            // 
            txt_data.Location = new Point(33, 74);
            txt_data.Margin = new Padding(2);
            txt_data.Name = "txt_data";
            txt_data.Size = new Size(226, 23);
            txt_data.TabIndex = 15;
            txt_data.TextChanged += txt_data_TextChanged;
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(224, 78);
            dateTimePicker.Margin = new Padding(2);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(1, 23);
            dateTimePicker.TabIndex = 12;
            dateTimePicker.ValueChanged += dateTimePicker_ValueChanged;
            // 
            // buttonMostra
            // 
            buttonMostra.Cursor = Cursors.Hand;
            buttonMostra.Location = new Point(579, 140);
            buttonMostra.Margin = new Padding(2);
            buttonMostra.Name = "buttonMostra";
            buttonMostra.Size = new Size(147, 25);
            buttonMostra.TabIndex = 16;
            buttonMostra.Text = "Mostra tutti i prodotti";
            buttonMostra.UseVisualStyleBackColor = true;
            buttonMostra.Click += buttonMostra_Click;
            // 
            // dataGridView_products
            // 
            dataGridView_products.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_products.Location = new Point(33, 179);
            dataGridView_products.Name = "dataGridView_products";
            dataGridView_products.RowHeadersWidth = 62;
            dataGridView_products.RowTemplate.Height = 25;
            dataGridView_products.Size = new Size(693, 156);
            dataGridView_products.TabIndex = 17;
            // 
            // comboBox_order
            // 
            comboBox_order.FormattingEnabled = true;
            comboBox_order.Location = new Point(89, 116);
            comboBox_order.Margin = new Padding(2);
            comboBox_order.Name = "comboBox_order";
            comboBox_order.Size = new Size(100, 23);
            comboBox_order.TabIndex = 18;
            comboBox_order.SelectedIndexChanged += comboBox_order_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 338);
            label4.Name = "label4";
            label4.Size = new Size(75, 15);
            label4.TabIndex = 19;
            label4.Text = "Cerca tabella";
            // 
            // trackBar1
            // 
            trackBar1.Cursor = Cursors.Hand;
            trackBar1.Location = new Point(428, 128);
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(104, 45);
            trackBar1.TabIndex = 20;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(381, 140);
            label5.Name = "label5";
            label5.Size = new Size(41, 15);
            label5.TabIndex = 21;
            label5.Text = "Prezzo";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(33, 124);
            label6.Name = "label6";
            label6.Size = new Size(43, 15);
            label6.TabIndex = 22;
            label6.Text = "Ordine";
            // 
            // Label_PrezzoSelezionato
            // 
            Label_PrezzoSelezionato.AutoSize = true;
            Label_PrezzoSelezionato.Location = new Point(475, 110);
            Label_PrezzoSelezionato.Name = "Label_PrezzoSelezionato";
            Label_PrezzoSelezionato.Size = new Size(13, 15);
            Label_PrezzoSelezionato.TabIndex = 23;
            Label_PrezzoSelezionato.Text = "0";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(732, 179);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(178, 156);
            dataGridView2.TabIndex = 24;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // Filtra
            // 
            Filtra.AccessibleRole = AccessibleRole.None;
            Filtra.Location = new Point(835, 150);
            Filtra.Name = "Filtra";
            Filtra.Size = new Size(75, 23);
            Filtra.TabIndex = 25;
            Filtra.Text = "FILTRA";
            Filtra.UseVisualStyleBackColor = true;
            Filtra.Click += Filtra_Click;
            // 
            // comboBox_city
            // 
            comboBox_city.FormattingEnabled = true;
            comboBox_city.Location = new Point(754, 121);
            comboBox_city.Name = "comboBox_city";
            comboBox_city.Size = new Size(156, 23);
            comboBox_city.TabIndex = 26;
            // 
            // button_FilteredProduct
            // 
            button_FilteredProduct.Location = new Point(579, 112);
            button_FilteredProduct.Name = "button_FilteredProduct";
            button_FilteredProduct.Size = new Size(147, 23);
            button_FilteredProduct.TabIndex = 27;
            button_FilteredProduct.Text = "Mostra prodotti filtrati";
            button_FilteredProduct.UseVisualStyleBackColor = true;
            button_FilteredProduct.Click += button_FilteredProduct_Click;
            // 
            // Categoria
            // 
            Categoria.AutoSize = true;
            Categoria.Location = new Point(26, 151);
            Categoria.Name = "Categoria";
            Categoria.Size = new Size(58, 15);
            Categoria.TabIndex = 29;
            Categoria.Text = "Categoria";
            // 
            // comboBox_Categoria_filter
            // 
            comboBox_Categoria_filter.FormattingEnabled = true;
            comboBox_Categoria_filter.Location = new Point(89, 148);
            comboBox_Categoria_filter.Margin = new Padding(2);
            comboBox_Categoria_filter.Name = "comboBox_Categoria_filter";
            comboBox_Categoria_filter.Size = new Size(100, 23);
            comboBox_Categoria_filter.TabIndex = 28;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(202, 150);
            label8.Name = "label8";
            label8.Size = new Size(38, 15);
            label8.TabIndex = 33;
            label8.Text = "Brand";
            // 
            // comboBox_Brand_filter
            // 
            comboBox_Brand_filter.FormattingEnabled = true;
            comboBox_Brand_filter.Location = new Point(257, 148);
            comboBox_Brand_filter.Margin = new Padding(2);
            comboBox_Brand_filter.Name = "comboBox_Brand_filter";
            comboBox_Brand_filter.Size = new Size(100, 23);
            comboBox_Brand_filter.TabIndex = 32;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(204, 124);
            label9.Name = "label9";
            label9.Size = new Size(36, 15);
            label9.TabIndex = 31;
            label9.Text = "Anno";
            label9.Click += label9_Click;
            // 
            // textBox_year
            // 
            textBox_year.Location = new Point(257, 121);
            textBox_year.Margin = new Padding(2);
            textBox_year.Name = "textBox_year";
            textBox_year.Size = new Size(100, 23);
            textBox_year.TabIndex = 34;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(922, 598);
            Controls.Add(textBox_year);
            Controls.Add(label8);
            Controls.Add(comboBox_Brand_filter);
            Controls.Add(label9);
            Controls.Add(Categoria);
            Controls.Add(comboBox_Categoria_filter);
            Controls.Add(button_FilteredProduct);
            Controls.Add(comboBox_city);
            Controls.Add(Filtra);
            Controls.Add(dataGridView2);
            Controls.Add(Label_PrezzoSelezionato);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(trackBar1);
            Controls.Add(label4);
            Controls.Add(comboBox_order);
            Controls.Add(dataGridView_products);
            Controls.Add(buttonMostra);
            Controls.Add(txt_data);
            Controls.Add(Salva);
            Controls.Add(Date);
            Controls.Add(dateTimePicker);
            Controls.Add(Price);
            Controls.Add(textBox_Price);
            Controls.Add(comboBox_brand);
            Controls.Add(comboBox_Categories);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(dataGridView1);
            Controls.Add(btn_loadTable);
            Controls.Add(comboBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_products).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Button btn_loadTable;
        private DataGridView dataGridView1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox comboBox_Categories;
        private ComboBox comboBox_brand;
        private TextBox textBox_Price;
        private Label Price;
        private Label Date;
        private Button Salva;
        private TextBox txt_data;
        private DateTimePicker dateTimePicker;
        private Button buttonMostra;
        private DataGridView dataGridView_products;
        private ComboBox comboBox_order;
        private Label label4;
        private TrackBar trackBar1;
        private Label label5;
        private Label label6;
        private Label Label_PrezzoSelezionato;
        private DataGridView dataGridView2;
        private Button Filtra;
        private ComboBox comboBox_city;
        private Button button_FilteredProduct;
        private Label Categoria;
        private ComboBox comboBox_Categoria_filter;
        private Label label8;
        private ComboBox comboBox_Brand_filter;
        private Label label9;
        private TextBox textBox_year;
    }
}