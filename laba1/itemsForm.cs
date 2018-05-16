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
    public partial class itemsForm : Form
    {
        int counter;
        public itemsForm()
        {
            InitializeComponent();
            items.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        public itemsForm(BindingSource source)
        {
            InitializeComponent();
            items.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.itemsBindingSource.DataSource = source;
            this.itemsBindingSource.DataMember = "ordersitems";
        }

        private void itemsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbdemosDataSet.items' table. You can move, or remove it, as needed.
            this.itemsTableAdapter.Fill(this.dbdemosDataSet.items);

        }

        private void items_SelectionChanged(object sender, EventArgs e)
        {
            if (items.SelectedRows.Count > 0 && counter++ > 0)
            {
                partsForm parts = new partsForm(itemsBindingSource);
                parts.Activate();
                parts.ShowDialog();
            }
        }

        private void items_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Process.Start("itemsTable.html");
        }

        private void helpToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
