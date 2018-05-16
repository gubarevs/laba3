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
    public partial class partsForm : Form
    {
        public partsForm()
        {
            InitializeComponent();
            parts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        public partsForm(BindingSource source)
        {
            InitializeComponent();
            this.partsBindingSource.DataSource = source;
            parts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void partsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbdemosDataSet.parts' table. You can move, or remove it, as needed.
            this.partsTableAdapter.Fill(this.dbdemosDataSet.parts);

        }

        private void parts_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Process.Start("partsTable.html");
        }
    }
}
