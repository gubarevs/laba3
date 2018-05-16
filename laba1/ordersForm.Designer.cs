using System.Windows.Forms;

namespace laba1
{
    partial class OrdersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrdersForm));
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbdemosDataSet = new laba1.dbdemosDataSet();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ordersTableAdapter = new laba1.dbdemosDataSetTableAdapters.ordersTableAdapter();
            this.itemsTableAdapter = new laba1.dbdemosDataSetTableAdapters.itemsTableAdapter();
            this.orders = new System.Windows.Forms.DataGridView();
            this.orderNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saleDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shipDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shipToContactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shipToAddr1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shipToAddr2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shipToCityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shipToStateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shipToZipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shipToCountryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shipToPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shipVIADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.termsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentMethodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemsTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taxRateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.freightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountPaidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbdemosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orders)).BeginInit();
            this.SuspendLayout();
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "orders";
            this.ordersBindingSource.DataSource = this.dbdemosDataSet;
            // 
            // dbdemosDataSet
            // 
            this.dbdemosDataSet.DataSetName = "dbdemosDataSet";
            this.dbdemosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 467);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(1156, 25);
            this.bindingNavigator1.TabIndex = 10;
            this.bindingNavigator1.Text = "bindingNavigator1";
            this.toolTip1.SetToolTip(this.bindingNavigator1, "панель навигации для таблицы заказов");
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1156, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.helpToolStripMenuItem1});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.helpToolStripMenuItem1.Text = "Help";
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // itemsTableAdapter
            // 
            this.itemsTableAdapter.ClearBeforeFill = true;
            // 
            // orders
            // 
            this.orders.AllowUserToAddRows = false;
            this.orders.AllowUserToDeleteRows = false;
            this.orders.AutoGenerateColumns = false;
            this.orders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderNoDataGridViewTextBoxColumn,
            this.custNoDataGridViewTextBoxColumn,
            this.saleDateDataGridViewTextBoxColumn,
            this.shipDateDataGridViewTextBoxColumn,
            this.empNoDataGridViewTextBoxColumn,
            this.shipToContactDataGridViewTextBoxColumn,
            this.shipToAddr1DataGridViewTextBoxColumn,
            this.shipToAddr2DataGridViewTextBoxColumn,
            this.shipToCityDataGridViewTextBoxColumn,
            this.shipToStateDataGridViewTextBoxColumn,
            this.shipToZipDataGridViewTextBoxColumn,
            this.shipToCountryDataGridViewTextBoxColumn,
            this.shipToPhoneDataGridViewTextBoxColumn,
            this.shipVIADataGridViewTextBoxColumn,
            this.pODataGridViewTextBoxColumn,
            this.termsDataGridViewTextBoxColumn,
            this.paymentMethodDataGridViewTextBoxColumn,
            this.itemsTotalDataGridViewTextBoxColumn,
            this.taxRateDataGridViewTextBoxColumn,
            this.freightDataGridViewTextBoxColumn,
            this.amountPaidDataGridViewTextBoxColumn});
            this.orders.DataSource = this.ordersBindingSource;
            this.orders.Location = new System.Drawing.Point(12, 44);
            this.orders.Name = "orders";
            this.orders.ReadOnly = true;
            this.orders.Size = new System.Drawing.Size(1017, 392);
            this.orders.TabIndex = 12;
            this.toolTip1.SetToolTip(this.orders, "таблица заказов");
            this.orders.SelectionChanged += new System.EventHandler(this.orders_SelectionChanged);
            this.orders.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.orders_HelpRequested_1);
            // 
            // orderNoDataGridViewTextBoxColumn
            // 
            this.orderNoDataGridViewTextBoxColumn.DataPropertyName = "OrderNo";
            this.orderNoDataGridViewTextBoxColumn.HeaderText = "OrderNo";
            this.orderNoDataGridViewTextBoxColumn.Name = "orderNoDataGridViewTextBoxColumn";
            this.orderNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // custNoDataGridViewTextBoxColumn
            // 
            this.custNoDataGridViewTextBoxColumn.DataPropertyName = "CustNo";
            this.custNoDataGridViewTextBoxColumn.HeaderText = "CustNo";
            this.custNoDataGridViewTextBoxColumn.Name = "custNoDataGridViewTextBoxColumn";
            this.custNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // saleDateDataGridViewTextBoxColumn
            // 
            this.saleDateDataGridViewTextBoxColumn.DataPropertyName = "SaleDate";
            this.saleDateDataGridViewTextBoxColumn.HeaderText = "SaleDate";
            this.saleDateDataGridViewTextBoxColumn.Name = "saleDateDataGridViewTextBoxColumn";
            this.saleDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // shipDateDataGridViewTextBoxColumn
            // 
            this.shipDateDataGridViewTextBoxColumn.DataPropertyName = "ShipDate";
            this.shipDateDataGridViewTextBoxColumn.HeaderText = "ShipDate";
            this.shipDateDataGridViewTextBoxColumn.Name = "shipDateDataGridViewTextBoxColumn";
            this.shipDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // empNoDataGridViewTextBoxColumn
            // 
            this.empNoDataGridViewTextBoxColumn.DataPropertyName = "EmpNo";
            this.empNoDataGridViewTextBoxColumn.HeaderText = "EmpNo";
            this.empNoDataGridViewTextBoxColumn.Name = "empNoDataGridViewTextBoxColumn";
            this.empNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // shipToContactDataGridViewTextBoxColumn
            // 
            this.shipToContactDataGridViewTextBoxColumn.DataPropertyName = "ShipToContact";
            this.shipToContactDataGridViewTextBoxColumn.HeaderText = "ShipToContact";
            this.shipToContactDataGridViewTextBoxColumn.Name = "shipToContactDataGridViewTextBoxColumn";
            this.shipToContactDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // shipToAddr1DataGridViewTextBoxColumn
            // 
            this.shipToAddr1DataGridViewTextBoxColumn.DataPropertyName = "ShipToAddr1";
            this.shipToAddr1DataGridViewTextBoxColumn.HeaderText = "ShipToAddr1";
            this.shipToAddr1DataGridViewTextBoxColumn.Name = "shipToAddr1DataGridViewTextBoxColumn";
            this.shipToAddr1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // shipToAddr2DataGridViewTextBoxColumn
            // 
            this.shipToAddr2DataGridViewTextBoxColumn.DataPropertyName = "ShipToAddr2";
            this.shipToAddr2DataGridViewTextBoxColumn.HeaderText = "ShipToAddr2";
            this.shipToAddr2DataGridViewTextBoxColumn.Name = "shipToAddr2DataGridViewTextBoxColumn";
            this.shipToAddr2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // shipToCityDataGridViewTextBoxColumn
            // 
            this.shipToCityDataGridViewTextBoxColumn.DataPropertyName = "ShipToCity";
            this.shipToCityDataGridViewTextBoxColumn.HeaderText = "ShipToCity";
            this.shipToCityDataGridViewTextBoxColumn.Name = "shipToCityDataGridViewTextBoxColumn";
            this.shipToCityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // shipToStateDataGridViewTextBoxColumn
            // 
            this.shipToStateDataGridViewTextBoxColumn.DataPropertyName = "ShipToState";
            this.shipToStateDataGridViewTextBoxColumn.HeaderText = "ShipToState";
            this.shipToStateDataGridViewTextBoxColumn.Name = "shipToStateDataGridViewTextBoxColumn";
            this.shipToStateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // shipToZipDataGridViewTextBoxColumn
            // 
            this.shipToZipDataGridViewTextBoxColumn.DataPropertyName = "ShipToZip";
            this.shipToZipDataGridViewTextBoxColumn.HeaderText = "ShipToZip";
            this.shipToZipDataGridViewTextBoxColumn.Name = "shipToZipDataGridViewTextBoxColumn";
            this.shipToZipDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // shipToCountryDataGridViewTextBoxColumn
            // 
            this.shipToCountryDataGridViewTextBoxColumn.DataPropertyName = "ShipToCountry";
            this.shipToCountryDataGridViewTextBoxColumn.HeaderText = "ShipToCountry";
            this.shipToCountryDataGridViewTextBoxColumn.Name = "shipToCountryDataGridViewTextBoxColumn";
            this.shipToCountryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // shipToPhoneDataGridViewTextBoxColumn
            // 
            this.shipToPhoneDataGridViewTextBoxColumn.DataPropertyName = "ShipToPhone";
            this.shipToPhoneDataGridViewTextBoxColumn.HeaderText = "ShipToPhone";
            this.shipToPhoneDataGridViewTextBoxColumn.Name = "shipToPhoneDataGridViewTextBoxColumn";
            this.shipToPhoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // shipVIADataGridViewTextBoxColumn
            // 
            this.shipVIADataGridViewTextBoxColumn.DataPropertyName = "ShipVIA";
            this.shipVIADataGridViewTextBoxColumn.HeaderText = "ShipVIA";
            this.shipVIADataGridViewTextBoxColumn.Name = "shipVIADataGridViewTextBoxColumn";
            this.shipVIADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pODataGridViewTextBoxColumn
            // 
            this.pODataGridViewTextBoxColumn.DataPropertyName = "PO";
            this.pODataGridViewTextBoxColumn.HeaderText = "PO";
            this.pODataGridViewTextBoxColumn.Name = "pODataGridViewTextBoxColumn";
            this.pODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // termsDataGridViewTextBoxColumn
            // 
            this.termsDataGridViewTextBoxColumn.DataPropertyName = "Terms";
            this.termsDataGridViewTextBoxColumn.HeaderText = "Terms";
            this.termsDataGridViewTextBoxColumn.Name = "termsDataGridViewTextBoxColumn";
            this.termsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // paymentMethodDataGridViewTextBoxColumn
            // 
            this.paymentMethodDataGridViewTextBoxColumn.DataPropertyName = "PaymentMethod";
            this.paymentMethodDataGridViewTextBoxColumn.HeaderText = "PaymentMethod";
            this.paymentMethodDataGridViewTextBoxColumn.Name = "paymentMethodDataGridViewTextBoxColumn";
            this.paymentMethodDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // itemsTotalDataGridViewTextBoxColumn
            // 
            this.itemsTotalDataGridViewTextBoxColumn.DataPropertyName = "ItemsTotal";
            this.itemsTotalDataGridViewTextBoxColumn.HeaderText = "ItemsTotal";
            this.itemsTotalDataGridViewTextBoxColumn.Name = "itemsTotalDataGridViewTextBoxColumn";
            this.itemsTotalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // taxRateDataGridViewTextBoxColumn
            // 
            this.taxRateDataGridViewTextBoxColumn.DataPropertyName = "TaxRate";
            this.taxRateDataGridViewTextBoxColumn.HeaderText = "TaxRate";
            this.taxRateDataGridViewTextBoxColumn.Name = "taxRateDataGridViewTextBoxColumn";
            this.taxRateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // freightDataGridViewTextBoxColumn
            // 
            this.freightDataGridViewTextBoxColumn.DataPropertyName = "Freight";
            this.freightDataGridViewTextBoxColumn.HeaderText = "Freight";
            this.freightDataGridViewTextBoxColumn.Name = "freightDataGridViewTextBoxColumn";
            this.freightDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // amountPaidDataGridViewTextBoxColumn
            // 
            this.amountPaidDataGridViewTextBoxColumn.DataPropertyName = "AmountPaid";
            this.amountPaidDataGridViewTextBoxColumn.HeaderText = "AmountPaid";
            this.amountPaidDataGridViewTextBoxColumn.Name = "amountPaidDataGridViewTextBoxColumn";
            this.amountPaidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // OrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 492);
            this.Controls.Add(this.orders);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "OrdersForm";
            this.Text = "ordersForm";
            this.Load += new System.EventHandler(this.ordersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbdemosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private dbdemosDataSet dbdemosDataSet;
        private dbdemosDataSetTableAdapters.ordersTableAdapter ordersTableAdapter;
        private dbdemosDataSetTableAdapters.itemsTableAdapter itemsTableAdapter;
        private BindingSource ordersBindingSource;
        private DataGridView orders;
        private DataGridViewTextBoxColumn orderNoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn custNoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn saleDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn shipDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn empNoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn shipToContactDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn shipToAddr1DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn shipToAddr2DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn shipToCityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn shipToStateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn shipToZipDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn shipToCountryDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn shipToPhoneDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn shipVIADataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn pODataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn termsDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn paymentMethodDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn itemsTotalDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn taxRateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn freightDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn amountPaidDataGridViewTextBoxColumn;
        private ToolTip toolTip1;
    }
}