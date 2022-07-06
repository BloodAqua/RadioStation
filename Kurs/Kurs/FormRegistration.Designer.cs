namespace Kurs
{
    partial class FormRegistration
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Fio = new System.Windows.Forms.Label();
            this.Log = new System.Windows.Forms.Label();
            this.Pas = new System.Windows.Forms.Label();
            this.kursovoyDataSet = new Kurs.KursovoyDataSet();
            this.table_vhodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.table_vhodTableAdapter = new Kurs.KursovoyDataSetTableAdapters.Table_vhodTableAdapter();
            this.tableAdapterManager = new Kurs.KursovoyDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.kursovoyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_vhodBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(7, 117);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(204, 32);
            this.button1.TabIndex = 4;
            this.button1.Text = "Регистрация";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(75, 6);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(136, 30);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(75, 41);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(136, 30);
            this.textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(75, 79);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(136, 30);
            this.textBox3.TabIndex = 3;
            // 
            // Fio
            // 
            this.Fio.AutoSize = true;
            this.Fio.Location = new System.Drawing.Point(13, 9);
            this.Fio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Fio.Name = "Fio";
            this.Fio.Size = new System.Drawing.Size(54, 22);
            this.Fio.TabIndex = 2;
            this.Fio.Text = "ФИО";
            // 
            // Log
            // 
            this.Log.AutoSize = true;
            this.Log.Location = new System.Drawing.Point(3, 44);
            this.Log.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Log.Name = "Log";
            this.Log.Size = new System.Drawing.Size(64, 22);
            this.Log.TabIndex = 2;
            this.Log.Text = "Логин";
            // 
            // Pas
            // 
            this.Pas.AutoSize = true;
            this.Pas.Location = new System.Drawing.Point(3, 85);
            this.Pas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Pas.Name = "Pas";
            this.Pas.Size = new System.Drawing.Size(72, 22);
            this.Pas.TabIndex = 2;
            this.Pas.Text = "Пароль";
            // 
            // kursovoyDataSet
            // 
            this.kursovoyDataSet.DataSetName = "KursovoyDataSet";
            this.kursovoyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // table_vhodBindingSource
            // 
            this.table_vhodBindingSource.DataMember = "Table_vhod";
            this.table_vhodBindingSource.DataSource = this.kursovoyDataSet;
            // 
            // table_vhodTableAdapter
            // 
            this.table_vhodTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Table_vhodTableAdapter = this.table_vhodTableAdapter;
            this.tableAdapterManager.UpdateOrder = Kurs.KursovoyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.График_работыTableAdapter = null;
            this.tableAdapterManager.ДолжностиTableAdapter = null;
            this.tableAdapterManager.ЖанрыTableAdapter = null;
            this.tableAdapterManager.ЗаписиTableAdapter = null;
            this.tableAdapterManager.ИсполнителиTableAdapter = null;
            this.tableAdapterManager.СотрудникиTableAdapter = null;
            // 
            // FormRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 157);
            this.Controls.Add(this.Pas);
            this.Controls.Add(this.Log);
            this.Controls.Add(this.Fio);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormRegistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация";
            this.Load += new System.EventHandler(this.FormRegistration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kursovoyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_vhodBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label Fio;
        private System.Windows.Forms.Label Log;
        private System.Windows.Forms.Label Pas;
        private KursovoyDataSet kursovoyDataSet;
        private System.Windows.Forms.BindingSource table_vhodBindingSource;
        private KursovoyDataSetTableAdapters.Table_vhodTableAdapter table_vhodTableAdapter;
        private KursovoyDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}