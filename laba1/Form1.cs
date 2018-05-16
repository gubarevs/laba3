using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba1
{
    public partial class Form1 : Form
    {
        int counter=0;
        public Form1()
        {
            InitializeComponent();

            employees.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            
            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbdemosDataSet.orders". При необходимости она может быть перемещена или удалена.
            this.ordersTableAdapter.Fill(this.dbdemosDataSet.orders);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbdemosDataSet.employee". При необходимости она может быть перемещена или удалена.
            this.employeeTableAdapter.Fill(this.dbdemosDataSet.employee);
            this.partsTableAdapter.Fill(this.dbdemosDataSet.parts);
            this.itemsTableAdapter.Fill(this.dbdemosDataSet.items);
            this.ordersTableAdapter.Fill(this.dbdemosDataSet.orders);
            this.employeeTableAdapter.Fill(this.dbdemosDataSet.employee);

        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        

        private void employees_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Process.Start("employees.html");
        }

        private void bindingNavigator1_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Process.Start("navigator.html");
        }

        private void employees_SelectionChanged(object sender, EventArgs e)
        {

            if (employees.SelectedRows.Count > 0 && counter++>1)
            {
                int empId = (int)employees.SelectedRows[0].Cells[0].Value;
                OrdersForm orders = new OrdersForm(employeeBindingSource);
                orders.Activate();
                orders.ShowDialog();
            }
        }

        private void helpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Process.Start("main.html");
        }
    }
}
