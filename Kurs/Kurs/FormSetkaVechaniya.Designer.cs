namespace Kurs
{
    partial class FormSetkaVechaniya
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.сеткаВещанияDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.сеткаВещанияBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kursovoyDataSet = new Kurs.KursovoyDataSet();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.сотрудникиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.фильтрПоСотрудникамDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фильтрПоСотрудникамBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.сеткаВещанияTableAdapter = new Kurs.KursovoyDataSetTableAdapters.СеткаВещанияTableAdapter();
            this.tableAdapterManager = new Kurs.KursovoyDataSetTableAdapters.TableAdapterManager();
            this.сотрудникиTableAdapter = new Kurs.KursovoyDataSetTableAdapters.СотрудникиTableAdapter();
            this.фильтрПоСотрудникамTableAdapter = new Kurs.KursovoyDataSetTableAdapters.ФильтрПоСотрудникамTableAdapter();
            this.фильтрПоДатамBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.фильтрПоДатамTableAdapter = new Kurs.KursovoyDataSetTableAdapters.ФильтрПоДатамTableAdapter();
            this.фильтрПоДатамBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.сеткаВещанияDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сеткаВещанияBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kursovoyDataSet)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.фильтрПоСотрудникамDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.фильтрПоСотрудникамBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.фильтрПоДатамBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.фильтрПоДатамBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(815, 342);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.сеткаВещанияDataGridView);
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(807, 307);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Сетка вещания";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // сеткаВещанияDataGridView
            // 
            this.сеткаВещанияDataGridView.AutoGenerateColumns = false;
            this.сеткаВещанияDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.сеткаВещанияDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.сеткаВещанияDataGridView.DataSource = this.сеткаВещанияBindingSource;
            this.сеткаВещанияDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.сеткаВещанияDataGridView.Location = new System.Drawing.Point(4, 4);
            this.сеткаВещанияDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.сеткаВещанияDataGridView.Name = "сеткаВещанияDataGridView";
            this.сеткаВещанияDataGridView.RowHeadersWidth = 51;
            this.сеткаВещанияDataGridView.RowTemplate.Height = 24;
            this.сеткаВещанияDataGridView.Size = new System.Drawing.Size(799, 299);
            this.сеткаВещанияDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ФИО";
            this.dataGridViewTextBoxColumn1.HeaderText = "ФИО";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Дата";
            this.dataGridViewTextBoxColumn2.HeaderText = "Дата";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Время1";
            this.dataGridViewTextBoxColumn3.HeaderText = "Время1";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Время2";
            this.dataGridViewTextBoxColumn4.HeaderText = "Время2";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Время3";
            this.dataGridViewTextBoxColumn5.HeaderText = "Время3";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // сеткаВещанияBindingSource
            // 
            this.сеткаВещанияBindingSource.DataMember = "СеткаВещания";
            this.сеткаВещанияBindingSource.DataSource = this.kursovoyDataSet;
            // 
            // kursovoyDataSet
            // 
            this.kursovoyDataSet.DataSetName = "KursovoyDataSet";
            this.kursovoyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.Controls.Add(this.comboBox1);
            this.tabPage2.Controls.Add(this.фильтрПоСотрудникамDataGridView);
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Size = new System.Drawing.Size(807, 307);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Фильтр по сотрудникам";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.сотрудникиBindingSource;
            this.comboBox1.DisplayMember = "ФИО";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(29, 327);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(165, 30);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.ValueMember = "ФИО";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // сотрудникиBindingSource
            // 
            this.сотрудникиBindingSource.DataMember = "Сотрудники";
            this.сотрудникиBindingSource.DataSource = this.kursovoyDataSet;
            // 
            // фильтрПоСотрудникамDataGridView
            // 
            this.фильтрПоСотрудникамDataGridView.AutoGenerateColumns = false;
            this.фильтрПоСотрудникамDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.фильтрПоСотрудникамDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.фильтрПоСотрудникамDataGridView.DataSource = this.фильтрПоСотрудникамBindingSource;
            this.фильтрПоСотрудникамDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.фильтрПоСотрудникамDataGridView.Location = new System.Drawing.Point(4, 4);
            this.фильтрПоСотрудникамDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.фильтрПоСотрудникамDataGridView.Name = "фильтрПоСотрудникамDataGridView";
            this.фильтрПоСотрудникамDataGridView.RowHeadersWidth = 51;
            this.фильтрПоСотрудникамDataGridView.RowTemplate.Height = 24;
            this.фильтрПоСотрудникамDataGridView.Size = new System.Drawing.Size(778, 302);
            this.фильтрПоСотрудникамDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ФИО";
            this.dataGridViewTextBoxColumn6.HeaderText = "ФИО";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Дата";
            this.dataGridViewTextBoxColumn7.HeaderText = "Дата";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Время1";
            this.dataGridViewTextBoxColumn8.HeaderText = "Время1";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Время2";
            this.dataGridViewTextBoxColumn9.HeaderText = "Время2";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 125;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Время3";
            this.dataGridViewTextBoxColumn10.HeaderText = "Время3";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 125;
            // 
            // фильтрПоСотрудникамBindingSource
            // 
            this.фильтрПоСотрудникамBindingSource.DataMember = "ФильтрПоСотрудникам";
            this.фильтрПоСотрудникамBindingSource.DataSource = this.kursovoyDataSet;
            // 
            // сеткаВещанияTableAdapter
            // 
            this.сеткаВещанияTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Table_vhodTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Kurs.KursovoyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.График_работыTableAdapter = null;
            this.tableAdapterManager.ДолжностиTableAdapter = null;
            this.tableAdapterManager.ЖанрыTableAdapter = null;
            this.tableAdapterManager.ЗаписиTableAdapter = null;
            this.tableAdapterManager.ИсполнителиTableAdapter = null;
            this.tableAdapterManager.СотрудникиTableAdapter = this.сотрудникиTableAdapter;
            // 
            // сотрудникиTableAdapter
            // 
            this.сотрудникиTableAdapter.ClearBeforeFill = true;
            // 
            // фильтрПоСотрудникамTableAdapter
            // 
            this.фильтрПоСотрудникамTableAdapter.ClearBeforeFill = true;
            // 
            // фильтрПоДатамBindingSource
            // 
            this.фильтрПоДатамBindingSource.DataMember = "ФильтрПоДатам";
            this.фильтрПоДатамBindingSource.DataSource = this.kursovoyDataSet;
            // 
            // фильтрПоДатамTableAdapter
            // 
            this.фильтрПоДатамTableAdapter.ClearBeforeFill = true;
            // 
            // фильтрПоДатамBindingSource1
            // 
            this.фильтрПоДатамBindingSource1.DataMember = "ФильтрПоДатам";
            this.фильтрПоДатамBindingSource1.DataSource = this.kursovoyDataSet;
            // 
            // FormSetkaVechaniya
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 342);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormSetkaVechaniya";
            this.Text = "Сетка вещания";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormSetkaVechaniya_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.сеткаВещанияDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сеткаВещанияBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kursovoyDataSet)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.фильтрПоСотрудникамDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.фильтрПоСотрудникамBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.фильтрПоДатамBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.фильтрПоДатамBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private KursovoyDataSet kursovoyDataSet;
        private System.Windows.Forms.BindingSource сеткаВещанияBindingSource;
        private KursovoyDataSetTableAdapters.СеткаВещанияTableAdapter сеткаВещанияTableAdapter;
        private KursovoyDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView сеткаВещанияDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.BindingSource фильтрПоСотрудникамBindingSource;
        private KursovoyDataSetTableAdapters.ФильтрПоСотрудникамTableAdapter фильтрПоСотрудникамTableAdapter;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView фильтрПоСотрудникамDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private KursovoyDataSetTableAdapters.СотрудникиTableAdapter сотрудникиTableAdapter;
        private System.Windows.Forms.BindingSource сотрудникиBindingSource;
        private System.Windows.Forms.BindingSource фильтрПоДатамBindingSource;
        private KursovoyDataSetTableAdapters.ФильтрПоДатамTableAdapter фильтрПоДатамTableAdapter;
        private System.Windows.Forms.BindingSource фильтрПоДатамBindingSource1;
    }
}