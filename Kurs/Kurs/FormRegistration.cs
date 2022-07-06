using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kurs
{
    public partial class FormRegistration : Form
    {
        public FormRegistration()
        {
            InitializeComponent();
        }

        private void table_vhodBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.table_vhodBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kursovoyDataSet);

        }

        private void FormRegistration_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursovoyDataSet.Table_vhod". При необходимости она может быть перемещена или удалена.
            this.table_vhodTableAdapter.Fill(this.kursovoyDataSet.Table_vhod);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox2.Text) && string.IsNullOrWhiteSpace(textBox3.Text) && string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Ошибка регистрации, проверьте введенные данные!");
            }
            else
            {
                table_vhodTableAdapter.Insert(textBox2.Text, textBox3.Text,textBox1.Text, "P");
                MessageBox.Show("Вы зарегистрированны!");
            }
        }
    }
}
