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
            dateTimePicker = new DateTimePicker();
            Date = new Label();
            Salva = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(84, 341);
            comboBox1.Margin = new Padding(4, 5, 4, 5);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(321, 33);
            comboBox1.TabIndex = 0;
            // 
            // btn_loadTable
            // 
            btn_loadTable.Location = new Point(287, 397);
            btn_loadTable.Margin = new Padding(4, 5, 4, 5);
            btn_loadTable.Name = "btn_loadTable";
            btn_loadTable.Size = new Size(107, 38);
            btn_loadTable.TabIndex = 1;
            btn_loadTable.Text = "button1";
            btn_loadTable.UseVisualStyleBackColor = true;
            btn_loadTable.Click += btn_loadTable_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(440, 220);
            dataGridView1.Margin = new Padding(4, 5, 4, 5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(659, 402);
            dataGridView1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(94, 48);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(321, 31);
            textBox2.TabIndex = 4;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(94, 20);
            label1.Name = "label1";
            label1.Size = new Size(138, 25);
            label1.TabIndex = 5;
            label1.Text = "Nome Prodotto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(489, 20);
            label2.Name = "label2";
            label2.Size = new Size(88, 25);
            label2.TabIndex = 6;
            label2.Text = "Categorie";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(829, 20);
            label3.Name = "label3";
            label3.Size = new Size(58, 25);
            label3.TabIndex = 7;
            label3.Text = "Brand";
            // 
            // comboBox_Categories
            // 
            comboBox_Categories.FormattingEnabled = true;
            comboBox_Categories.Location = new Point(487, 48);
            comboBox_Categories.Margin = new Padding(4, 5, 4, 5);
            comboBox_Categories.Name = "comboBox_Categories";
            comboBox_Categories.Size = new Size(334, 33);
            comboBox_Categories.TabIndex = 8;
            comboBox_Categories.SelectedIndexChanged += comboBox_Categories_SelectedIndexChanged;
            // 
            // comboBox_brand
            // 
            comboBox_brand.FormattingEnabled = true;
            comboBox_brand.Location = new Point(829, 46);
            comboBox_brand.Margin = new Padding(4, 5, 4, 5);
            comboBox_brand.Name = "comboBox_brand";
            comboBox_brand.Size = new Size(270, 33);
            comboBox_brand.TabIndex = 9;
            // 
            // textBox_Price
            // 
            textBox_Price.Location = new Point(750, 114);
            textBox_Price.Name = "textBox_Price";
            textBox_Price.Size = new Size(321, 31);
            textBox_Price.TabIndex = 10;
            textBox_Price.TextChanged += textBox_Price_TextChanged;
            // 
            // Price
            // 
            Price.AutoSize = true;
            Price.Location = new Point(750, 86);
            Price.Name = "Price";
            Price.Size = new Size(49, 25);
            Price.TabIndex = 11;
            Price.Text = "Price";
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(94, 114);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(300, 31);
            dateTimePicker.TabIndex = 12;
            dateTimePicker.ValueChanged += dateTimePicker_ValueChanged;
            // 
            // Date
            // 
            Date.AutoSize = true;
            Date.Location = new Point(94, 86);
            Date.Name = "Date";
            Date.Size = new Size(49, 25);
            Date.TabIndex = 13;
            Date.Text = "Data";
            // 
            // Salva
            // 
            Salva.Location = new Point(987, 178);
            Salva.Name = "Salva";
            Salva.Size = new Size(112, 34);
            Salva.TabIndex = 14;
            Salva.Text = "Salva";
            Salva.UseVisualStyleBackColor = true;
            Salva.Click += Salva_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1236, 838);
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
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private DateTimePicker dateTimePicker;
        private Label Date;
        private Button Salva;
    }
}