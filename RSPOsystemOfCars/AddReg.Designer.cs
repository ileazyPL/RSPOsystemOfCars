namespace RSPOsystemOfCars
{
    partial class AddReg
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddReg));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.avtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rSPOusersDataSet = new RSPOsystemOfCars.RSPOusersDataSet();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.colorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.avtoTableAdapter = new RSPOsystemOfCars.RSPOusersDataSetTableAdapters.AvtoTableAdapter();
            this.colorTableAdapter = new RSPOsystemOfCars.RSPOusersDataSetTableAdapters.ColorTableAdapter();
            this.textBox2 = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.regionBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.rSPOusersDataSet2 = new RSPOsystemOfCars.RSPOusersDataSet2();
            this.regionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rSPOusersDataSet1 = new RSPOsystemOfCars.RSPOusersDataSet1();
            this.regionTableAdapter = new RSPOsystemOfCars.RSPOusersDataSet1TableAdapters.regionTableAdapter();
            this.regionTableAdapter1 = new RSPOsystemOfCars.RSPOusersDataSet2TableAdapters.regionTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.avtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rSPOusersDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.regionBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rSPOusersDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.regionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rSPOusersDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите ФИО";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(214, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(218, 22);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(42, 305);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(387, 32);
            this.button1.TabIndex = 2;
            this.button1.Text = "Ок";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Введите номер авто";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Выберите марку авто";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.avtoBindingSource;
            this.comboBox1.DisplayMember = "marka";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(214, 53);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(218, 24);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.ValueMember = "id";
            // 
            // avtoBindingSource
            // 
            this.avtoBindingSource.DataMember = "Avto";
            this.avtoBindingSource.DataSource = this.rSPOusersDataSet;
            // 
            // rSPOusersDataSet
            // 
            this.rSPOusersDataSet.DataSetName = "RSPOusersDataSet";
            this.rSPOusersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Выберите цвет авто";
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.colorBindingSource;
            this.comboBox2.DisplayMember = "color";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(214, 103);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(218, 24);
            this.comboBox2.TabIndex = 8;
            this.comboBox2.ValueMember = "id";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // colorBindingSource
            // 
            this.colorBindingSource.DataMember = "Color";
            this.colorBindingSource.DataSource = this.rSPOusersDataSet;
            // 
            // avtoTableAdapter
            // 
            this.avtoTableAdapter.ClearBeforeFill = true;
            // 
            // colorTableAdapter
            // 
            this.colorTableAdapter.ClearBeforeFill = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(216, 155);
            this.textBox2.Mask = "0000-LL-0";
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(216, 22);
            this.textBox2.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "Введите регион";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(214, 260);
            this.textBox3.Mask = "0000099-L-999-pb-6";
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(216, 22);
            this.textBox3.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 266);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(172, 16);
            this.label6.TabIndex = 22;
            this.label6.Text = "Введите номер паспорта";
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.regionBindingSource1;
            this.comboBox3.DisplayMember = "name_region";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(214, 206);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(218, 24);
            this.comboBox3.TabIndex = 24;
            this.comboBox3.ValueMember = "id";
            // 
            // regionBindingSource1
            // 
            this.regionBindingSource1.DataMember = "region";
            this.regionBindingSource1.DataSource = this.rSPOusersDataSet2;
            // 
            // rSPOusersDataSet2
            // 
            this.rSPOusersDataSet2.DataSetName = "RSPOusersDataSet2";
            this.rSPOusersDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // regionBindingSource
            // 
            this.regionBindingSource.DataMember = "region";
            this.regionBindingSource.DataSource = this.rSPOusersDataSet1;
            // 
            // rSPOusersDataSet1
            // 
            this.rSPOusersDataSet1.DataSetName = "RSPOusersDataSet1";
            this.rSPOusersDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // regionTableAdapter
            // 
            this.regionTableAdapter.ClearBeforeFill = true;
            // 
            // regionTableAdapter1
            // 
            this.regionTableAdapter1.ClearBeforeFill = true;
            // 
            // AddReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(480, 366);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "AddReg";
            this.Text = "AddReg";
            this.Load += new System.EventHandler(this.AddReg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.avtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rSPOusersDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.regionBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rSPOusersDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.regionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rSPOusersDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox2;
        private RSPOusersDataSet rSPOusersDataSet;
        private System.Windows.Forms.BindingSource avtoBindingSource;
        private RSPOusersDataSetTableAdapters.AvtoTableAdapter avtoTableAdapter;
        private System.Windows.Forms.BindingSource colorBindingSource;
        private RSPOusersDataSetTableAdapters.ColorTableAdapter colorTableAdapter;
        private System.Windows.Forms.MaskedTextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox textBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox3;
        private RSPOusersDataSet1 rSPOusersDataSet1;
        private System.Windows.Forms.BindingSource regionBindingSource;
        private RSPOusersDataSet1TableAdapters.regionTableAdapter regionTableAdapter;
        private RSPOusersDataSet2 rSPOusersDataSet2;
        private System.Windows.Forms.BindingSource regionBindingSource1;
        private RSPOusersDataSet2TableAdapters.regionTableAdapter regionTableAdapter1;
    }
}