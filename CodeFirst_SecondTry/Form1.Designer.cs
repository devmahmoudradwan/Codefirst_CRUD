
namespace CodeFirst_SecondTry
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IDD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.f_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.l_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.add_ress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_ity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTUDENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new CodeFirst_SecondTry.DataSet1();
            this.sTUDENTTableAdapter = new CodeFirst_SecondTry.DataSet1TableAdapters.STUDENTTableAdapter();
            this.ID = new System.Windows.Forms.Label();
            this.id_txt = new System.Windows.Forms.TextBox();
            this.insert_btn = new System.Windows.Forms.Button();
            this.f_name_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.l_name_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.address_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.city_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.update_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.reset_btn = new System.Windows.Forms.Button();
            this.ser_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDENTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.InfoText;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDD,
            this.f_name,
            this.l_name,
            this.add_ress,
            this.c_ity});
            this.dataGridView1.DataSource = this.sTUDENTBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(729, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(850, 479);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // IDD
            // 
            this.IDD.DataPropertyName = "ID";
            this.IDD.HeaderText = "ID";
            this.IDD.MinimumWidth = 10;
            this.IDD.Name = "IDD";
            this.IDD.ReadOnly = true;
            this.IDD.Width = 20;
            // 
            // f_name
            // 
            this.f_name.DataPropertyName = "FIRSTNAME";
            this.f_name.HeaderText = "FIRSTNAME";
            this.f_name.MinimumWidth = 10;
            this.f_name.Name = "f_name";
            this.f_name.ReadOnly = true;
            this.f_name.Width = 80;
            // 
            // l_name
            // 
            this.l_name.DataPropertyName = "LASTNAME";
            this.l_name.HeaderText = "LASTNAME";
            this.l_name.MinimumWidth = 10;
            this.l_name.Name = "l_name";
            this.l_name.ReadOnly = true;
            this.l_name.Width = 80;
            // 
            // add_ress
            // 
            this.add_ress.DataPropertyName = "ADDRESS";
            this.add_ress.HeaderText = "ADDRESS";
            this.add_ress.MinimumWidth = 10;
            this.add_ress.Name = "add_ress";
            this.add_ress.ReadOnly = true;
            this.add_ress.Width = 80;
            // 
            // c_ity
            // 
            this.c_ity.DataPropertyName = "CITY";
            this.c_ity.HeaderText = "CITY";
            this.c_ity.MinimumWidth = 10;
            this.c_ity.Name = "c_ity";
            this.c_ity.ReadOnly = true;
            this.c_ity.Width = 80;
            // 
            // sTUDENTBindingSource
            // 
            this.sTUDENTBindingSource.DataMember = "STUDENT";
            this.sTUDENTBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sTUDENTTableAdapter
            // 
            this.sTUDENTTableAdapter.ClearBeforeFill = true;
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(45, 35);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(32, 25);
            this.ID.TabIndex = 1;
            this.ID.Text = "ID";
            this.ID.Click += new System.EventHandler(this.ext);
            // 
            // id_txt
            // 
            this.id_txt.Location = new System.Drawing.Point(168, 29);
            this.id_txt.Name = "id_txt";
            this.id_txt.Size = new System.Drawing.Size(373, 31);
            this.id_txt.TabIndex = 2;
            // 
            // insert_btn
            // 
            this.insert_btn.ForeColor = System.Drawing.Color.Red;
            this.insert_btn.Location = new System.Drawing.Point(26, 357);
            this.insert_btn.Name = "insert_btn";
            this.insert_btn.Size = new System.Drawing.Size(178, 56);
            this.insert_btn.TabIndex = 3;
            this.insert_btn.Text = "Insert";
            this.insert_btn.UseVisualStyleBackColor = true;
            this.insert_btn.Click += new System.EventHandler(this.insert_btn_Click);
            // 
            // f_name_txt
            // 
            this.f_name_txt.Location = new System.Drawing.Point(168, 87);
            this.f_name_txt.Name = "f_name_txt";
            this.f_name_txt.Size = new System.Drawing.Size(373, 31);
            this.f_name_txt.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "First Name";
            // 
            // l_name_txt
            // 
            this.l_name_txt.Location = new System.Drawing.Point(168, 150);
            this.l_name_txt.Name = "l_name_txt";
            this.l_name_txt.Size = new System.Drawing.Size(373, 31);
            this.l_name_txt.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Last Name";
            // 
            // address_txt
            // 
            this.address_txt.Location = new System.Drawing.Point(168, 224);
            this.address_txt.Name = "address_txt";
            this.address_txt.Size = new System.Drawing.Size(373, 31);
            this.address_txt.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Address";
            // 
            // city_txt
            // 
            this.city_txt.Location = new System.Drawing.Point(168, 294);
            this.city_txt.Name = "city_txt";
            this.city_txt.Size = new System.Drawing.Size(373, 31);
            this.city_txt.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "City";
            // 
            // update_btn
            // 
            this.update_btn.ForeColor = System.Drawing.Color.Red;
            this.update_btn.Location = new System.Drawing.Point(254, 357);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(178, 56);
            this.update_btn.TabIndex = 12;
            this.update_btn.Text = "Update";
            this.update_btn.UseVisualStyleBackColor = true;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // delete_btn
            // 
            this.delete_btn.ForeColor = System.Drawing.Color.Red;
            this.delete_btn.Location = new System.Drawing.Point(493, 357);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(178, 56);
            this.delete_btn.TabIndex = 13;
            this.delete_btn.Text = "Delete";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // reset_btn
            // 
            this.reset_btn.ForeColor = System.Drawing.Color.Red;
            this.reset_btn.Location = new System.Drawing.Point(26, 435);
            this.reset_btn.Name = "reset_btn";
            this.reset_btn.Size = new System.Drawing.Size(178, 56);
            this.reset_btn.TabIndex = 14;
            this.reset_btn.Text = "Reset";
            this.reset_btn.UseVisualStyleBackColor = true;
            this.reset_btn.Click += new System.EventHandler(this.reset_btn_Click);
            // 
            // ser_btn
            // 
            this.ser_btn.ForeColor = System.Drawing.Color.Red;
            this.ser_btn.Location = new System.Drawing.Point(254, 435);
            this.ser_btn.Name = "ser_btn";
            this.ser_btn.Size = new System.Drawing.Size(178, 56);
            this.ser_btn.TabIndex = 15;
            this.ser_btn.Text = "Serialize";
            this.ser_btn.UseVisualStyleBackColor = true;
            this.ser_btn.Click += new System.EventHandler(this.ser_btn_Click);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(493, 435);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 56);
            this.button1.TabIndex = 16;
            this.button1.Text = "De Serialize";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1610, 530);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ser_btn);
            this.Controls.Add(this.reset_btn);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.city_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.address_txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.l_name_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.f_name_txt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.insert_btn);
            this.Controls.Add(this.id_txt);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDENTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource sTUDENTBindingSource;
        private DataSet1TableAdapters.STUDENTTableAdapter sTUDENTTableAdapter;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.TextBox id_txt;
        private System.Windows.Forms.Button insert_btn;
        private System.Windows.Forms.TextBox f_name_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox l_name_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox address_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox city_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Button reset_btn;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDD;
        private System.Windows.Forms.DataGridViewTextBoxColumn f_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn l_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn add_ress;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_ity;
        private System.Windows.Forms.Button ser_btn;
        private System.Windows.Forms.Button button1;
    }
}

