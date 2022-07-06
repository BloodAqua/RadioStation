namespace Kurs
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label рольLabel;
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.kursovoyDataSet = new Kurs.KursovoyDataSet();
            this.table_vhodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.table_vhodTableAdapter = new Kurs.KursovoyDataSetTableAdapters.Table_vhodTableAdapter();
            this.tableAdapterManager = new Kurs.KursovoyDataSetTableAdapters.TableAdapterManager();
            this.процедураВходаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.процедураВходаTableAdapter = new Kurs.KursovoyDataSetTableAdapters.ПроцедураВходаTableAdapter();
            this.рольLabel1 = new System.Windows.Forms.Label();
            рольLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.kursovoyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_vhodBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.процедураВходаBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // рольLabel
            // 
            рольLabel.AutoSize = true;
            рольLabel.Location = new System.Drawing.Point(468, 498);
            рольLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            рольLabel.Name = "рольLabel";
            рольLabel.Size = new System.Drawing.Size(56, 22);
            рольLabel.TabIndex = 8;
            рольLabel.Text = "Роль:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(91, 11);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(136, 30);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(91, 46);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(136, 30);
            this.textBox2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Пароль";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 84);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(210, 32);
            this.button1.TabIndex = 3;
            this.button1.Text = "Вход";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(17, 124);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(210, 32);
            this.button2.TabIndex = 4;
            this.button2.Text = "Регистрация";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            // процедураВходаBindingSource
            // 
            this.процедураВходаBindingSource.DataMember = "ПроцедураВхода";
            this.процедураВходаBindingSource.DataSource = this.kursovoyDataSet;
            // 
            // процедураВходаTableAdapter
            // 
            this.процедураВходаTableAdapter.ClearBeforeFill = true;
            // 
            // рольLabel1
            // 
            this.рольLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.процедураВходаBindingSource, "Роль", true));
            this.рольLabel1.Location = new System.Drawing.Point(534, 498);
            this.рольLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.рольLabel1.Name = "рольLabel1";
            this.рольLabel1.Size = new System.Drawing.Size(138, 32);
            this.рольLabel1.TabIndex = 9;
            this.рольLabel1.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 158);
            this.Controls.Add(рольLabel);
            this.Controls.Add(this.рольLabel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вход";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kursovoyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_vhodBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.процедураВходаBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private KursovoyDataSet kursovoyDataSet;
        private System.Windows.Forms.BindingSource table_vhodBindingSource;
        private KursovoyDataSetTableAdapters.Table_vhodTableAdapter table_vhodTableAdapter;
        private KursovoyDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource процедураВходаBindingSource;
        private KursovoyDataSetTableAdapters.ПроцедураВходаTableAdapter процедураВходаTableAdapter;
        private System.Windows.Forms.Label рольLabel1;
    }
}

