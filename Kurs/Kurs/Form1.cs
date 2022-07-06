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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void table_vhodBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.table_vhodBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kursovoyDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursovoyDataSet.Table_vhod". При необходимости она может быть перемещена или удалена.
            this.table_vhodTableAdapter.Fill(this.kursovoyDataSet.Table_vhod);

        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.процедураВходаTableAdapter.Fill(this.kursovoyDataSet.ПроцедураВхода, textBox1.Text, textBox2.Text);
                if (рольLabel1.Text == "A")
                {
                    FormAdmin formAdmin = new FormAdmin();
                    рольLabel1.Text = "";
                    formAdmin.ShowDialog();
                }
                else if (рольLabel1.Text == "P")
                {
                    FormMenu formMenu = new FormMenu();
                    рольLabel1.Text = "";
                    formMenu.ShowDialog();
                }
                else if (true)
                {
                    MessageBox.Show("Ошибка, проверьте введенные данные!");
                    рольLabel1.Text = "";
                }
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormRegistration formRegistration = new FormRegistration();
            formRegistration.ShowDialog();
        }
    }
}
