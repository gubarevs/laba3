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
    public partial class OrdersForm : Form
    {
        int counter;

        BindingSource source;

        public OrdersForm()
        {
            InitializeComponent();
            orders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        public OrdersForm(BindingSource source)
        {
            this.source = source;
            InitializeComponent();
            this.ordersBindingSource.DataSource = source;
            this.ordersBindingSource.DataMember = "employeeorders";
            orders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.Activate();
        }

        private void ordersForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbdemosDataSet.items". При необходимости она может быть перемещена или удалена.
            this.itemsTableAdapter.Fill(this.dbdemosDataSet.items);
            //orders.DataSource = ordersBindingSource;
        }

        private void orders_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            
        }

        private void orders_SelectionChanged(object sender, EventArgs e)
        {
            if (orders.SelectedRows.Count > 0 && counter++ > 0)
            {
                itemsForm items = new itemsForm(ordersBindingSource);
                items.Activate();
                items.ShowDialog();
            }
        }

        private void orders_HelpRequested_1(object sender, HelpEventArgs hlpevent)
        {
            Process.Start("ordersTable.html");
        }
    }
}
