namespace Kursach_TRPK
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.article = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manufacturer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.material = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dimensions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.place = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.booking_category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.booking_article = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.booking_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.booking_model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.booking_material = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.booking_color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.booking_quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.booking_place = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.booking_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.CausesValidation = false;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(10, 10);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1194, 647);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1186, 621);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Мебель";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.article,
            this.name,
            this.model,
            this.manufacturer,
            this.material,
            this.color,
            this.dimensions,
            this.price,
            this.place});
            this.dataGridView1.Location = new System.Drawing.Point(7, 7);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(950, 600);
            this.dataGridView1.TabIndex = 0;
            // 
            // article
            // 
            this.article.HeaderText = "Артикул";
            this.article.Name = "article";
            // 
            // name
            // 
            this.name.HeaderText = "Название";
            this.name.Name = "name";
            // 
            // model
            // 
            this.model.HeaderText = "Модель";
            this.model.Name = "model";
            // 
            // manufacturer
            // 
            this.manufacturer.HeaderText = "Изготовитель";
            this.manufacturer.Name = "manufacturer";
            // 
            // material
            // 
            this.material.HeaderText = "Материал";
            this.material.Name = "material";
            // 
            // color
            // 
            this.color.HeaderText = "Цвет";
            this.color.Name = "color";
            // 
            // dimensions
            // 
            this.dimensions.HeaderText = "Габариты";
            this.dimensions.Name = "dimensions";
            // 
            // price
            // 
            this.price.HeaderText = "Цена";
            this.price.Name = "price";
            // 
            // place
            // 
            this.place.HeaderText = "Расположение";
            this.place.Name = "place";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1186, 621);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Бронь";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.booking_category,
            this.booking_article,
            this.booking_name,
            this.booking_model,
            this.booking_material,
            this.booking_color,
            this.booking_quantity,
            this.booking_place,
            this.booking_date});
            this.dataGridView2.Location = new System.Drawing.Point(7, 7);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(1048, 600);
            this.dataGridView2.TabIndex = 0;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            // 
            // booking_category
            // 
            this.booking_category.HeaderText = "Категория";
            this.booking_category.Name = "booking_category";
            // 
            // booking_article
            // 
            this.booking_article.HeaderText = "Артикул";
            this.booking_article.Name = "booking_article";
            // 
            // booking_name
            // 
            this.booking_name.HeaderText = "Название";
            this.booking_name.Name = "booking_name";
            // 
            // booking_model
            // 
            this.booking_model.HeaderText = "Модель";
            this.booking_model.Name = "booking_model";
            // 
            // booking_material
            // 
            this.booking_material.HeaderText = "Материал";
            this.booking_material.Name = "booking_material";
            // 
            // booking_color
            // 
            this.booking_color.HeaderText = "Цвет";
            this.booking_color.Name = "booking_color";
            // 
            // booking_quantity
            // 
            this.booking_quantity.HeaderText = "Кол-во";
            this.booking_quantity.Name = "booking_quantity";
            // 
            // booking_place
            // 
            this.booking_place.HeaderText = "Расположение";
            this.booking_place.Name = "booking_place";
            // 
            // booking_date
            // 
            this.booking_date.HeaderText = "Дата";
            this.booking_date.Name = "booking_date";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 672);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn article;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn model;
        private System.Windows.Forms.DataGridViewTextBoxColumn manufacturer;
        private System.Windows.Forms.DataGridViewTextBoxColumn material;
        private System.Windows.Forms.DataGridViewTextBoxColumn color;
        private System.Windows.Forms.DataGridViewTextBoxColumn dimensions;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn place;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn booking_category;
        private System.Windows.Forms.DataGridViewTextBoxColumn booking_article;
        private System.Windows.Forms.DataGridViewTextBoxColumn booking_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn booking_model;
        private System.Windows.Forms.DataGridViewTextBoxColumn booking_material;
        private System.Windows.Forms.DataGridViewTextBoxColumn booking_color;
        private System.Windows.Forms.DataGridViewTextBoxColumn booking_quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn booking_place;
        private System.Windows.Forms.DataGridViewTextBoxColumn booking_date;
    }
}

