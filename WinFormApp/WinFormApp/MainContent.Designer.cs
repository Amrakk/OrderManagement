﻿namespace GUI
{
    partial class MainContent
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
            components = new System.ComponentModel.Container();
            customersBindingSource = new System.Windows.Forms.BindingSource(components);
            itemsBindingSource = new System.Windows.Forms.BindingSource(components);
            ordersBindingSource = new System.Windows.Forms.BindingSource(components);
            gridControl1 = new DevExpress.XtraGrid.GridControl();
            gridViewCustomer = new DevExpress.XtraGrid.Views.Grid.GridView();
            colCustId = new DevExpress.XtraGrid.Columns.GridColumn();
            colCustName = new DevExpress.XtraGrid.Columns.GridColumn();
            colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            colAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            delete = new DevExpress.XtraGrid.Columns.GridColumn();
            btnCustomerDelete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            groupCustomer = new DevExpress.XtraEditors.GroupControl();
            layoutControl3 = new DevExpress.XtraLayout.LayoutControl();
            btnCustomerClear = new DevExpress.XtraEditors.SimpleButton();
            btnCustomerAdd = new DevExpress.XtraEditors.SimpleButton();
            txtCustomerAddress = new DevExpress.XtraEditors.TextEdit();
            txtCustomerEmail = new DevExpress.XtraEditors.TextEdit();
            txtCustomerName = new DevExpress.XtraEditors.TextEdit();
            txtCustomerID = new DevExpress.XtraEditors.TextEdit();
            layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            layoutControlItem23 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem18 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem16 = new DevExpress.XtraLayout.LayoutControlItem();
            emptySpaceItem8 = new DevExpress.XtraLayout.EmptySpaceItem();
            layoutControlItem17 = new DevExpress.XtraLayout.LayoutControlItem();
            emptySpaceItem9 = new DevExpress.XtraLayout.EmptySpaceItem();
            emptySpaceItem10 = new DevExpress.XtraLayout.EmptySpaceItem();
            emptySpaceItem11 = new DevExpress.XtraLayout.EmptySpaceItem();
            layoutControlItem20 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem21 = new DevExpress.XtraLayout.LayoutControlItem();
            emptySpaceItem4 = new DevExpress.XtraLayout.EmptySpaceItem();
            emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            groupOrder = new DevExpress.XtraEditors.GroupControl();
            layoutControl2 = new DevExpress.XtraLayout.LayoutControl();
            btnOrderAdd = new DevExpress.XtraEditors.SimpleButton();
            gridOrder = new DevExpress.XtraGrid.GridControl();
            gridViewOrder = new DevExpress.XtraGrid.Views.Grid.GridView();
            colOrderId = new DevExpress.XtraGrid.Columns.GridColumn();
            colOrderDate = new DevExpress.XtraGrid.Columns.GridColumn();
            colCustId1 = new DevExpress.XtraGrid.Columns.GridColumn();
            colOrderDelete = new DevExpress.XtraGrid.Columns.GridColumn();
            btnOrderDelete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            layoutControlItem14 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            emptySpaceItem20 = new DevExpress.XtraLayout.EmptySpaceItem();
            emptySpaceItem23 = new DevExpress.XtraLayout.EmptySpaceItem();
            groupItem = new DevExpress.XtraEditors.GroupControl();
            layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            btnItemClear = new DevExpress.XtraEditors.SimpleButton();
            gridControl2 = new DevExpress.XtraGrid.GridControl();
            gridViewItem = new DevExpress.XtraGrid.Views.Grid.GridView();
            colItemId1 = new DevExpress.XtraGrid.Columns.GridColumn();
            colItemName1 = new DevExpress.XtraGrid.Columns.GridColumn();
            colColor1 = new DevExpress.XtraGrid.Columns.GridColumn();
            colItemDelete = new DevExpress.XtraGrid.Columns.GridColumn();
            btnItemDelete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            btnItemAdd = new DevExpress.XtraEditors.SimpleButton();
            txtItemColor = new DevExpress.XtraEditors.TextEdit();
            txtItemName = new DevExpress.XtraEditors.TextEdit();
            txtItemID = new DevExpress.XtraEditors.TextEdit();
            Root = new DevExpress.XtraLayout.LayoutControlGroup();
            layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            emptySpaceItem12 = new DevExpress.XtraLayout.EmptySpaceItem();
            layoutControlItem12 = new DevExpress.XtraLayout.LayoutControlItem();
            colItemId = new DevExpress.XtraGrid.Columns.GridColumn();
            colItemName = new DevExpress.XtraGrid.Columns.GridColumn();
            colColor = new DevExpress.XtraGrid.Columns.GridColumn();
            layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            groupOrderDetail = new DevExpress.XtraEditors.GroupControl();
            layoutControl4 = new DevExpress.XtraLayout.LayoutControl();
            gridOrderDetail = new DevExpress.XtraGrid.GridControl();
            orderDetailsBindingSource = new System.Windows.Forms.BindingSource(components);
            gridViewOrderDetail = new DevExpress.XtraGrid.Views.Grid.GridView();
            colItemId2 = new DevExpress.XtraGrid.Columns.GridColumn();
            colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            colUnitAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            colOrderItemDelete = new DevExpress.XtraGrid.Columns.GridColumn();
            btnOrderItemDelete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            btnOrderItemAdd = new DevExpress.XtraEditors.SimpleButton();
            textEdit11 = new DevExpress.XtraEditors.TextEdit();
            textEdit12 = new DevExpress.XtraEditors.SearchLookUpEdit();
            searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            textEdit13 = new DevExpress.XtraEditors.DateTimeOffsetEdit();
            layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            layoutControlItem11 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem25 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem34 = new DevExpress.XtraLayout.LayoutControlItem();
            emptySpaceItem5 = new DevExpress.XtraLayout.EmptySpaceItem();
            emptySpaceItem7 = new DevExpress.XtraLayout.EmptySpaceItem();
            emptySpaceItem13 = new DevExpress.XtraLayout.EmptySpaceItem();
            emptySpaceItem21 = new DevExpress.XtraLayout.EmptySpaceItem();
            layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            emptySpaceItem22 = new DevExpress.XtraLayout.EmptySpaceItem();
            layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            emptySpaceItem14 = new DevExpress.XtraLayout.EmptySpaceItem();
            emptySpaceItem15 = new DevExpress.XtraLayout.EmptySpaceItem();
            emptySpaceItem16 = new DevExpress.XtraLayout.EmptySpaceItem();
            emptySpaceItem17 = new DevExpress.XtraLayout.EmptySpaceItem();
            emptySpaceItem18 = new DevExpress.XtraLayout.EmptySpaceItem();
            emptySpaceItem19 = new DevExpress.XtraLayout.EmptySpaceItem();
            emptySpaceItem6 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)customersBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)itemsBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ordersBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridViewCustomer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCustomerDelete).BeginInit();
            ((System.ComponentModel.ISupportInitialize)groupCustomer).BeginInit();
            groupCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)layoutControl3).BeginInit();
            layoutControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtCustomerAddress.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtCustomerEmail.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtCustomerName.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtCustomerID.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlGroup2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem23).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem18).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem16).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem17).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem11).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem20).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem21).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)groupOrder).BeginInit();
            groupOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)layoutControl2).BeginInit();
            layoutControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridOrder).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridViewOrder).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnOrderDelete).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlGroup1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem14).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem20).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem23).BeginInit();
            ((System.ComponentModel.ISupportInitialize)groupItem).BeginInit();
            groupItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)layoutControl1).BeginInit();
            layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridControl2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridViewItem).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnItemDelete).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtItemColor.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtItemName.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtItemID.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Root).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem12).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem12).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)groupOrderDetail).BeginInit();
            groupOrderDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)layoutControl4).BeginInit();
            layoutControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridOrderDetail).BeginInit();
            ((System.ComponentModel.ISupportInitialize)orderDetailsBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridViewOrderDetail).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnOrderItemDelete).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit11.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit12.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)searchLookUpEdit1View).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit13.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlGroup3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem11).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem25).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem34).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem13).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem21).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem22).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem14).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem15).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem16).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem17).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem18).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem19).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem6).BeginInit();
            SuspendLayout();
            // 
            // customersBindingSource
            // 
            customersBindingSource.DataSource = typeof(Models.Customer);
            // 
            // itemsBindingSource
            // 
            itemsBindingSource.DataSource = typeof(Models.Item);
            // 
            // ordersBindingSource
            // 
            ordersBindingSource.DataSource = typeof(Models.Order);
            // 
            // gridControl1
            // 
            gridControl1.DataSource = customersBindingSource;
            gridControl1.Location = new System.Drawing.Point(12, 130);
            gridControl1.MainView = gridViewCustomer;
            gridControl1.Name = "gridControl1";
            gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] { btnCustomerDelete });
            gridControl1.Size = new System.Drawing.Size(641, 273);
            gridControl1.TabIndex = 7;
            gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridViewCustomer });
            gridControl1.Load += gridCustomer_Load;
            // 
            // gridViewCustomer
            // 
            gridViewCustomer.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colCustId, colCustName, colEmail, colAddress, delete });
            gridViewCustomer.GridControl = gridControl1;
            gridViewCustomer.Name = "gridViewCustomer";
            gridViewCustomer.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] { new DevExpress.XtraGrid.Columns.GridColumnSortInfo(colCustId, DevExpress.Data.ColumnSortOrder.Ascending) });
            // 
            // colCustId
            // 
            colCustId.FieldName = "CustId";
            colCustId.Name = "colCustId";
            colCustId.OptionsColumn.AllowEdit = false;
            colCustId.Visible = true;
            colCustId.VisibleIndex = 0;
            colCustId.Width = 97;
            // 
            // colCustName
            // 
            colCustName.FieldName = "CustName";
            colCustName.Name = "colCustName";
            colCustName.Visible = true;
            colCustName.VisibleIndex = 1;
            colCustName.Width = 171;
            // 
            // colEmail
            // 
            colEmail.FieldName = "Email";
            colEmail.Name = "colEmail";
            colEmail.Visible = true;
            colEmail.VisibleIndex = 2;
            colEmail.Width = 192;
            // 
            // colAddress
            // 
            colAddress.FieldName = "Address";
            colAddress.Name = "colAddress";
            colAddress.Visible = true;
            colAddress.VisibleIndex = 3;
            colAddress.Width = 205;
            // 
            // delete
            // 
            delete.Caption = "Delete";
            delete.ColumnEdit = btnCustomerDelete;
            delete.Name = "delete";
            delete.Visible = true;
            delete.VisibleIndex = 4;
            delete.Width = 51;
            // 
            // btnCustomerDelete
            // 
            btnCustomerDelete.AutoHeight = false;
            btnCustomerDelete.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete) });
            btnCustomerDelete.Name = "btnCustomerDelete";
            btnCustomerDelete.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            btnCustomerDelete.Click += btnCustomerDelete_Click;
            // 
            // groupCustomer
            // 
            groupCustomer.Controls.Add(layoutControl3);
            groupCustomer.Location = new System.Drawing.Point(37, 27);
            groupCustomer.Name = "groupCustomer";
            groupCustomer.Size = new System.Drawing.Size(669, 440);
            groupCustomer.TabIndex = 1;
            groupCustomer.Text = "Customers";
            // 
            // layoutControl3
            // 
            layoutControl3.Controls.Add(btnCustomerClear);
            layoutControl3.Controls.Add(gridControl1);
            layoutControl3.Controls.Add(btnCustomerAdd);
            layoutControl3.Controls.Add(txtCustomerAddress);
            layoutControl3.Controls.Add(txtCustomerEmail);
            layoutControl3.Controls.Add(txtCustomerName);
            layoutControl3.Controls.Add(txtCustomerID);
            layoutControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            layoutControl3.Location = new System.Drawing.Point(2, 23);
            layoutControl3.Name = "layoutControl3";
            layoutControl3.Root = layoutControlGroup2;
            layoutControl3.Size = new System.Drawing.Size(665, 415);
            layoutControl3.TabIndex = 0;
            layoutControl3.Text = "layoutControl3";
            // 
            // btnCustomerClear
            // 
            btnCustomerClear.Location = new System.Drawing.Point(386, 94);
            btnCustomerClear.Name = "btnCustomerClear";
            btnCustomerClear.Size = new System.Drawing.Size(122, 22);
            btnCustomerClear.StyleController = layoutControl3;
            btnCustomerClear.TabIndex = 8;
            btnCustomerClear.Text = "Clear";
            btnCustomerClear.Click += btnCustomerClear_Click;
            // 
            // btnCustomerAdd
            // 
            btnCustomerAdd.Location = new System.Drawing.Point(512, 94);
            btnCustomerAdd.Name = "btnCustomerAdd";
            btnCustomerAdd.Size = new System.Drawing.Size(141, 22);
            btnCustomerAdd.StyleController = layoutControl3;
            btnCustomerAdd.TabIndex = 5;
            btnCustomerAdd.Text = "Add";
            btnCustomerAdd.Click += btnCustomerAdd_Click;
            // 
            // txtCustomerAddress
            // 
            txtCustomerAddress.Location = new System.Drawing.Point(63, 60);
            txtCustomerAddress.Name = "txtCustomerAddress";
            txtCustomerAddress.Size = new System.Drawing.Size(202, 20);
            txtCustomerAddress.StyleController = layoutControl3;
            txtCustomerAddress.TabIndex = 4;
            // 
            // txtCustomerEmail
            // 
            txtCustomerEmail.Location = new System.Drawing.Point(368, 36);
            txtCustomerEmail.Name = "txtCustomerEmail";
            txtCustomerEmail.Size = new System.Drawing.Size(285, 20);
            txtCustomerEmail.StyleController = layoutControl3;
            txtCustomerEmail.TabIndex = 3;
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new System.Drawing.Point(63, 36);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new System.Drawing.Size(202, 20);
            txtCustomerName.StyleController = layoutControl3;
            txtCustomerName.TabIndex = 2;
            // 
            // txtCustomerID
            // 
            txtCustomerID.Location = new System.Drawing.Point(63, 12);
            txtCustomerID.Name = "txtCustomerID";
            txtCustomerID.Size = new System.Drawing.Size(124, 20);
            txtCustomerID.StyleController = layoutControl3;
            txtCustomerID.TabIndex = 0;
            // 
            // layoutControlGroup2
            // 
            layoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            layoutControlGroup2.GroupBordersVisible = false;
            layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem23, layoutControlItem18, layoutControlItem16, emptySpaceItem8, layoutControlItem17, emptySpaceItem9, emptySpaceItem10, emptySpaceItem11, layoutControlItem20, layoutControlItem21, emptySpaceItem4, emptySpaceItem3, layoutControlItem9 });
            layoutControlGroup2.Name = "layoutControlGroup2";
            layoutControlGroup2.Size = new System.Drawing.Size(665, 415);
            layoutControlGroup2.TextVisible = false;
            // 
            // layoutControlItem23
            // 
            layoutControlItem23.Control = txtCustomerID;
            layoutControlItem23.Location = new System.Drawing.Point(0, 0);
            layoutControlItem23.Name = "layoutControlItem23";
            layoutControlItem23.Size = new System.Drawing.Size(179, 24);
            layoutControlItem23.Text = "ID:";
            layoutControlItem23.TextSize = new System.Drawing.Size(39, 13);
            // 
            // layoutControlItem18
            // 
            layoutControlItem18.Control = txtCustomerAddress;
            layoutControlItem18.Location = new System.Drawing.Point(0, 48);
            layoutControlItem18.Name = "layoutControlItem18";
            layoutControlItem18.Size = new System.Drawing.Size(257, 24);
            layoutControlItem18.Text = "Address";
            layoutControlItem18.TextSize = new System.Drawing.Size(39, 13);
            // 
            // layoutControlItem16
            // 
            layoutControlItem16.Control = txtCustomerName;
            layoutControlItem16.Location = new System.Drawing.Point(0, 24);
            layoutControlItem16.Name = "layoutControlItem16";
            layoutControlItem16.Size = new System.Drawing.Size(257, 24);
            layoutControlItem16.Text = "Name:";
            layoutControlItem16.TextSize = new System.Drawing.Size(39, 13);
            // 
            // emptySpaceItem8
            // 
            emptySpaceItem8.AllowHotTrack = false;
            emptySpaceItem8.Location = new System.Drawing.Point(179, 0);
            emptySpaceItem8.Name = "emptySpaceItem8";
            emptySpaceItem8.Size = new System.Drawing.Size(466, 24);
            emptySpaceItem8.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem17
            // 
            layoutControlItem17.Control = txtCustomerEmail;
            layoutControlItem17.Location = new System.Drawing.Point(305, 24);
            layoutControlItem17.Name = "layoutControlItem17";
            layoutControlItem17.Size = new System.Drawing.Size(340, 24);
            layoutControlItem17.Text = "Email:";
            layoutControlItem17.TextSize = new System.Drawing.Size(39, 13);
            // 
            // emptySpaceItem9
            // 
            emptySpaceItem9.AllowHotTrack = false;
            emptySpaceItem9.Location = new System.Drawing.Point(257, 48);
            emptySpaceItem9.Name = "emptySpaceItem9";
            emptySpaceItem9.Size = new System.Drawing.Size(388, 24);
            emptySpaceItem9.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem10
            // 
            emptySpaceItem10.AllowHotTrack = false;
            emptySpaceItem10.Location = new System.Drawing.Point(257, 24);
            emptySpaceItem10.Name = "emptySpaceItem10";
            emptySpaceItem10.Size = new System.Drawing.Size(48, 24);
            emptySpaceItem10.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem11
            // 
            emptySpaceItem11.AllowHotTrack = false;
            emptySpaceItem11.Location = new System.Drawing.Point(0, 82);
            emptySpaceItem11.Name = "emptySpaceItem11";
            emptySpaceItem11.Size = new System.Drawing.Size(374, 26);
            emptySpaceItem11.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem20
            // 
            layoutControlItem20.Control = btnCustomerAdd;
            layoutControlItem20.Location = new System.Drawing.Point(500, 82);
            layoutControlItem20.Name = "layoutControlItem20";
            layoutControlItem20.Size = new System.Drawing.Size(145, 26);
            layoutControlItem20.TextSize = new System.Drawing.Size(0, 0);
            layoutControlItem20.TextVisible = false;
            // 
            // layoutControlItem21
            // 
            layoutControlItem21.Control = gridControl1;
            layoutControlItem21.Location = new System.Drawing.Point(0, 118);
            layoutControlItem21.Name = "layoutControlItem21";
            layoutControlItem21.Size = new System.Drawing.Size(645, 277);
            layoutControlItem21.TextSize = new System.Drawing.Size(0, 0);
            layoutControlItem21.TextVisible = false;
            // 
            // emptySpaceItem4
            // 
            emptySpaceItem4.AllowHotTrack = false;
            emptySpaceItem4.Location = new System.Drawing.Point(0, 72);
            emptySpaceItem4.Name = "emptySpaceItem4";
            emptySpaceItem4.Size = new System.Drawing.Size(645, 10);
            emptySpaceItem4.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem3
            // 
            emptySpaceItem3.AllowHotTrack = false;
            emptySpaceItem3.Location = new System.Drawing.Point(0, 108);
            emptySpaceItem3.Name = "emptySpaceItem3";
            emptySpaceItem3.Size = new System.Drawing.Size(645, 10);
            emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem9
            // 
            layoutControlItem9.Control = btnCustomerClear;
            layoutControlItem9.Location = new System.Drawing.Point(374, 82);
            layoutControlItem9.Name = "layoutControlItem9";
            layoutControlItem9.Size = new System.Drawing.Size(126, 26);
            layoutControlItem9.TextSize = new System.Drawing.Size(0, 0);
            layoutControlItem9.TextVisible = false;
            // 
            // groupOrder
            // 
            groupOrder.Controls.Add(layoutControl2);
            groupOrder.Location = new System.Drawing.Point(760, 27);
            groupOrder.Name = "groupOrder";
            groupOrder.Size = new System.Drawing.Size(669, 280);
            groupOrder.TabIndex = 2;
            groupOrder.Text = "Orders";
            // 
            // layoutControl2
            // 
            layoutControl2.Controls.Add(btnOrderAdd);
            layoutControl2.Controls.Add(gridOrder);
            layoutControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            layoutControl2.Location = new System.Drawing.Point(2, 23);
            layoutControl2.Name = "layoutControl2";
            layoutControl2.Root = layoutControlGroup1;
            layoutControl2.Size = new System.Drawing.Size(665, 255);
            layoutControl2.TabIndex = 0;
            layoutControl2.Text = "layoutControl2";
            // 
            // btnOrderAdd
            // 
            btnOrderAdd.Location = new System.Drawing.Point(514, 221);
            btnOrderAdd.Name = "btnOrderAdd";
            btnOrderAdd.Size = new System.Drawing.Size(139, 22);
            btnOrderAdd.StyleController = layoutControl2;
            btnOrderAdd.TabIndex = 2;
            btnOrderAdd.Text = "Add";
            // 
            // gridOrder
            // 
            gridOrder.DataSource = ordersBindingSource;
            gridOrder.Location = new System.Drawing.Point(12, 12);
            gridOrder.MainView = gridViewOrder;
            gridOrder.Name = "gridOrder";
            gridOrder.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] { btnOrderDelete });
            gridOrder.Size = new System.Drawing.Size(641, 194);
            gridOrder.TabIndex = 0;
            gridOrder.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridViewOrder });
            gridOrder.Load += gridOrder_Load;
            // 
            // gridViewOrder
            // 
            gridViewOrder.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colOrderId, colOrderDate, colCustId1, colOrderDelete });
            gridViewOrder.GridControl = gridOrder;
            gridViewOrder.Name = "gridViewOrder";
            // 
            // colOrderId
            // 
            colOrderId.FieldName = "OrderId";
            colOrderId.Name = "colOrderId";
            colOrderId.OptionsColumn.AllowEdit = false;
            colOrderId.Visible = true;
            colOrderId.VisibleIndex = 0;
            colOrderId.Width = 174;
            // 
            // colOrderDate
            // 
            colOrderDate.FieldName = "OrderDate";
            colOrderDate.Name = "colOrderDate";
            colOrderDate.OptionsColumn.AllowEdit = false;
            colOrderDate.Visible = true;
            colOrderDate.VisibleIndex = 1;
            colOrderDate.Width = 254;
            // 
            // colCustId1
            // 
            colCustId1.FieldName = "CustId";
            colCustId1.Name = "colCustId1";
            colCustId1.OptionsColumn.AllowEdit = false;
            colCustId1.Visible = true;
            colCustId1.VisibleIndex = 2;
            colCustId1.Width = 240;
            // 
            // colOrderDelete
            // 
            colOrderDelete.Caption = "Delete";
            colOrderDelete.ColumnEdit = btnOrderDelete;
            colOrderDelete.Name = "colOrderDelete";
            colOrderDelete.Visible = true;
            colOrderDelete.VisibleIndex = 3;
            colOrderDelete.Width = 48;
            // 
            // btnOrderDelete
            // 
            btnOrderDelete.AutoHeight = false;
            btnOrderDelete.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete) });
            btnOrderDelete.Name = "btnOrderDelete";
            btnOrderDelete.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            btnOrderDelete.Click += btnOrderDelete_Click;
            // 
            // layoutControlGroup1
            // 
            layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            layoutControlGroup1.GroupBordersVisible = false;
            layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem14, layoutControlItem5, emptySpaceItem20, emptySpaceItem23 });
            layoutControlGroup1.Name = "layoutControlGroup1";
            layoutControlGroup1.Size = new System.Drawing.Size(665, 255);
            layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem14
            // 
            layoutControlItem14.Control = gridOrder;
            layoutControlItem14.Location = new System.Drawing.Point(0, 0);
            layoutControlItem14.Name = "layoutControlItem14";
            layoutControlItem14.Size = new System.Drawing.Size(645, 198);
            layoutControlItem14.TextSize = new System.Drawing.Size(0, 0);
            layoutControlItem14.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            layoutControlItem5.Control = btnOrderAdd;
            layoutControlItem5.Location = new System.Drawing.Point(502, 209);
            layoutControlItem5.Name = "layoutControlItem5";
            layoutControlItem5.Size = new System.Drawing.Size(143, 26);
            layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            layoutControlItem5.TextVisible = false;
            // 
            // emptySpaceItem20
            // 
            emptySpaceItem20.AllowHotTrack = false;
            emptySpaceItem20.Location = new System.Drawing.Point(0, 209);
            emptySpaceItem20.Name = "emptySpaceItem20";
            emptySpaceItem20.Size = new System.Drawing.Size(502, 26);
            emptySpaceItem20.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem23
            // 
            emptySpaceItem23.AllowHotTrack = false;
            emptySpaceItem23.Location = new System.Drawing.Point(0, 198);
            emptySpaceItem23.Name = "emptySpaceItem23";
            emptySpaceItem23.Size = new System.Drawing.Size(645, 11);
            emptySpaceItem23.TextSize = new System.Drawing.Size(0, 0);
            // 
            // groupItem
            // 
            groupItem.Controls.Add(layoutControl1);
            groupItem.Location = new System.Drawing.Point(37, 495);
            groupItem.Name = "groupItem";
            groupItem.Size = new System.Drawing.Size(669, 426);
            groupItem.TabIndex = 4;
            groupItem.Text = "Items";
            // 
            // layoutControl1
            // 
            layoutControl1.Controls.Add(btnItemClear);
            layoutControl1.Controls.Add(gridControl2);
            layoutControl1.Controls.Add(btnItemAdd);
            layoutControl1.Controls.Add(txtItemColor);
            layoutControl1.Controls.Add(txtItemName);
            layoutControl1.Controls.Add(txtItemID);
            layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            layoutControl1.Location = new System.Drawing.Point(2, 23);
            layoutControl1.Name = "layoutControl1";
            layoutControl1.Root = Root;
            layoutControl1.Size = new System.Drawing.Size(665, 401);
            layoutControl1.TabIndex = 0;
            layoutControl1.Text = "layoutControl1";
            // 
            // btnItemClear
            // 
            btnItemClear.Location = new System.Drawing.Point(392, 46);
            btnItemClear.Name = "btnItemClear";
            btnItemClear.Size = new System.Drawing.Size(108, 22);
            btnItemClear.StyleController = layoutControl1;
            btnItemClear.TabIndex = 7;
            btnItemClear.Text = "Clear";
            btnItemClear.Click += btnItemClear_Click;
            // 
            // gridControl2
            // 
            gridControl2.DataSource = itemsBindingSource;
            gridControl2.Location = new System.Drawing.Point(12, 82);
            gridControl2.MainView = gridViewItem;
            gridControl2.Name = "gridControl2";
            gridControl2.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] { btnItemDelete });
            gridControl2.Size = new System.Drawing.Size(641, 307);
            gridControl2.TabIndex = 6;
            gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridViewItem });
            gridControl2.Load += gridItem_Load;
            // 
            // gridViewItem
            // 
            gridViewItem.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colItemId1, colItemName1, colColor1, colItemDelete });
            gridViewItem.GridControl = gridControl2;
            gridViewItem.Name = "gridViewItem";
            // 
            // colItemId1
            // 
            colItemId1.FieldName = "ItemId";
            colItemId1.Name = "colItemId1";
            colItemId1.OptionsColumn.AllowEdit = false;
            colItemId1.Visible = true;
            colItemId1.VisibleIndex = 0;
            colItemId1.Width = 154;
            // 
            // colItemName1
            // 
            colItemName1.FieldName = "ItemName";
            colItemName1.Name = "colItemName1";
            colItemName1.Visible = true;
            colItemName1.VisibleIndex = 1;
            colItemName1.Width = 305;
            // 
            // colColor1
            // 
            colColor1.FieldName = "Color";
            colColor1.Name = "colColor1";
            colColor1.Visible = true;
            colColor1.VisibleIndex = 2;
            colColor1.Width = 207;
            // 
            // colItemDelete
            // 
            colItemDelete.Caption = "Delete";
            colItemDelete.ColumnEdit = btnItemDelete;
            colItemDelete.Name = "colItemDelete";
            colItemDelete.Visible = true;
            colItemDelete.VisibleIndex = 3;
            colItemDelete.Width = 50;
            // 
            // btnItemDelete
            // 
            btnItemDelete.AutoHeight = false;
            btnItemDelete.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete) });
            btnItemDelete.Name = "btnItemDelete";
            btnItemDelete.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            btnItemDelete.Click += btnItemDelete_Click;
            // 
            // btnItemAdd
            // 
            btnItemAdd.Location = new System.Drawing.Point(504, 46);
            btnItemAdd.Name = "btnItemAdd";
            btnItemAdd.Size = new System.Drawing.Size(149, 22);
            btnItemAdd.StyleController = layoutControl1;
            btnItemAdd.TabIndex = 4;
            btnItemAdd.Text = "Add";
            btnItemAdd.Click += btnItemAdd_Click;
            // 
            // txtItemColor
            // 
            txtItemColor.Location = new System.Drawing.Point(485, 12);
            txtItemColor.Name = "txtItemColor";
            txtItemColor.Size = new System.Drawing.Size(168, 20);
            txtItemColor.StyleController = layoutControl1;
            txtItemColor.TabIndex = 3;
            // 
            // txtItemName
            // 
            txtItemName.Location = new System.Drawing.Point(215, 12);
            txtItemName.Name = "txtItemName";
            txtItemName.Size = new System.Drawing.Size(223, 20);
            txtItemName.StyleController = layoutControl1;
            txtItemName.TabIndex = 2;
            // 
            // txtItemID
            // 
            txtItemID.Location = new System.Drawing.Point(55, 12);
            txtItemID.Name = "txtItemID";
            txtItemID.Size = new System.Drawing.Size(113, 20);
            txtItemID.StyleController = layoutControl1;
            txtItemID.TabIndex = 0;
            // 
            // Root
            // 
            Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            Root.GroupBordersVisible = false;
            Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem1, layoutControlItem2, layoutControlItem4, emptySpaceItem1, layoutControlItem6, layoutControlItem7, emptySpaceItem2, emptySpaceItem12, layoutControlItem12 });
            Root.Name = "Root";
            Root.Size = new System.Drawing.Size(665, 401);
            Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            layoutControlItem1.Control = txtItemID;
            layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            layoutControlItem1.Name = "layoutControlItem1";
            layoutControlItem1.Size = new System.Drawing.Size(160, 24);
            layoutControlItem1.Text = "ID:";
            layoutControlItem1.TextSize = new System.Drawing.Size(31, 13);
            // 
            // layoutControlItem2
            // 
            layoutControlItem2.Control = txtItemName;
            layoutControlItem2.Location = new System.Drawing.Point(160, 0);
            layoutControlItem2.Name = "layoutControlItem2";
            layoutControlItem2.Size = new System.Drawing.Size(270, 24);
            layoutControlItem2.Text = "Name:";
            layoutControlItem2.TextSize = new System.Drawing.Size(31, 13);
            // 
            // layoutControlItem4
            // 
            layoutControlItem4.Control = txtItemColor;
            layoutControlItem4.Location = new System.Drawing.Point(430, 0);
            layoutControlItem4.Name = "layoutControlItem4";
            layoutControlItem4.Size = new System.Drawing.Size(215, 24);
            layoutControlItem4.Text = "Color:";
            layoutControlItem4.TextSize = new System.Drawing.Size(31, 13);
            // 
            // emptySpaceItem1
            // 
            emptySpaceItem1.AllowHotTrack = false;
            emptySpaceItem1.Location = new System.Drawing.Point(0, 34);
            emptySpaceItem1.Name = "emptySpaceItem1";
            emptySpaceItem1.Size = new System.Drawing.Size(380, 26);
            emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem6
            // 
            layoutControlItem6.Control = btnItemAdd;
            layoutControlItem6.Location = new System.Drawing.Point(492, 34);
            layoutControlItem6.Name = "layoutControlItem6";
            layoutControlItem6.Size = new System.Drawing.Size(153, 26);
            layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            layoutControlItem6.TextVisible = false;
            // 
            // layoutControlItem7
            // 
            layoutControlItem7.Control = gridControl2;
            layoutControlItem7.Location = new System.Drawing.Point(0, 70);
            layoutControlItem7.Name = "layoutControlItem7";
            layoutControlItem7.Size = new System.Drawing.Size(645, 311);
            layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            layoutControlItem7.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            emptySpaceItem2.AllowHotTrack = false;
            emptySpaceItem2.Location = new System.Drawing.Point(0, 24);
            emptySpaceItem2.Name = "emptySpaceItem2";
            emptySpaceItem2.Size = new System.Drawing.Size(645, 10);
            emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem12
            // 
            emptySpaceItem12.AllowHotTrack = false;
            emptySpaceItem12.Location = new System.Drawing.Point(0, 60);
            emptySpaceItem12.Name = "emptySpaceItem12";
            emptySpaceItem12.Size = new System.Drawing.Size(645, 10);
            emptySpaceItem12.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem12
            // 
            layoutControlItem12.Control = btnItemClear;
            layoutControlItem12.Location = new System.Drawing.Point(380, 34);
            layoutControlItem12.Name = "layoutControlItem12";
            layoutControlItem12.Size = new System.Drawing.Size(112, 26);
            layoutControlItem12.TextSize = new System.Drawing.Size(0, 0);
            layoutControlItem12.TextVisible = false;
            // 
            // colItemId
            // 
            colItemId.FieldName = "ItemId";
            colItemId.Name = "colItemId";
            colItemId.OptionsColumn.AllowEdit = false;
            colItemId.Visible = true;
            colItemId.VisibleIndex = 0;
            colItemId.Width = 161;
            // 
            // colItemName
            // 
            colItemName.FieldName = "ItemName";
            colItemName.Name = "colItemName";
            colItemName.Visible = true;
            colItemName.VisibleIndex = 1;
            colItemName.Width = 356;
            // 
            // colColor
            // 
            colColor.FieldName = "Color";
            colColor.Name = "colColor";
            colColor.Visible = true;
            colColor.VisibleIndex = 2;
            colColor.Width = 199;
            // 
            // layoutControlItem3
            // 
            layoutControlItem3.Location = new System.Drawing.Point(0, 235);
            layoutControlItem3.Name = "layoutControlItem3";
            layoutControlItem3.Size = new System.Drawing.Size(645, 25);
            layoutControlItem3.TextSize = new System.Drawing.Size(50, 20);
            // 
            // groupOrderDetail
            // 
            groupOrderDetail.Controls.Add(layoutControl4);
            groupOrderDetail.Location = new System.Drawing.Point(760, 331);
            groupOrderDetail.Name = "groupOrderDetail";
            groupOrderDetail.Size = new System.Drawing.Size(669, 590);
            groupOrderDetail.TabIndex = 5;
            groupOrderDetail.Text = "Order Details";
            // 
            // layoutControl4
            // 
            layoutControl4.Controls.Add(gridOrderDetail);
            layoutControl4.Controls.Add(btnOrderItemAdd);
            layoutControl4.Controls.Add(textEdit11);
            layoutControl4.Controls.Add(textEdit12);
            layoutControl4.Controls.Add(textEdit13);
            layoutControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            layoutControl4.Location = new System.Drawing.Point(2, 23);
            layoutControl4.Name = "layoutControl4";
            layoutControl4.Root = layoutControlGroup3;
            layoutControl4.Size = new System.Drawing.Size(665, 565);
            layoutControl4.TabIndex = 0;
            layoutControl4.Text = "layoutControl4";
            // 
            // gridOrderDetail
            // 
            gridOrderDetail.DataSource = orderDetailsBindingSource;
            gridOrderDetail.Location = new System.Drawing.Point(12, 82);
            gridOrderDetail.MainView = gridViewOrderDetail;
            gridOrderDetail.Name = "gridOrderDetail";
            gridOrderDetail.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] { btnOrderItemDelete });
            gridOrderDetail.Size = new System.Drawing.Size(641, 471);
            gridOrderDetail.TabIndex = 6;
            gridOrderDetail.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridViewOrderDetail });
            gridOrderDetail.Load += gridOrderDetail_Load;
            // 
            // orderDetailsBindingSource
            // 
            orderDetailsBindingSource.DataSource = typeof(Models.OrderDetail);
            // 
            // gridViewOrderDetail
            // 
            gridViewOrderDetail.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colItemId2, colQuantity, colUnitAmount, colOrderItemDelete });
            gridViewOrderDetail.GridControl = gridOrderDetail;
            gridViewOrderDetail.Name = "gridViewOrderDetail";
            // 
            // colItemId2
            // 
            colItemId2.FieldName = "ItemId";
            colItemId2.Name = "colItemId2";
            colItemId2.Visible = true;
            colItemId2.VisibleIndex = 0;
            colItemId2.Width = 179;
            // 
            // colQuantity
            // 
            colQuantity.FieldName = "Quantity";
            colQuantity.Name = "colQuantity";
            colQuantity.Visible = true;
            colQuantity.VisibleIndex = 1;
            colQuantity.Width = 179;
            // 
            // colUnitAmount
            // 
            colUnitAmount.FieldName = "UnitAmount";
            colUnitAmount.Name = "colUnitAmount";
            colUnitAmount.Visible = true;
            colUnitAmount.VisibleIndex = 2;
            colUnitAmount.Width = 301;
            // 
            // colOrderItemDelete
            // 
            colOrderItemDelete.Caption = "Delete";
            colOrderItemDelete.ColumnEdit = btnOrderItemDelete;
            colOrderItemDelete.Name = "colOrderItemDelete";
            colOrderItemDelete.Visible = true;
            colOrderItemDelete.VisibleIndex = 3;
            colOrderItemDelete.Width = 57;
            // 
            // btnOrderItemDelete
            // 
            btnOrderItemDelete.AutoHeight = false;
            btnOrderItemDelete.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete) });
            btnOrderItemDelete.Name = "btnOrderItemDelete";
            btnOrderItemDelete.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            btnOrderItemDelete.Click += btnOrderItemDelete_Click;
            // 
            // btnOrderItemAdd
            // 
            btnOrderItemAdd.Location = new System.Drawing.Point(515, 46);
            btnOrderItemAdd.Name = "btnOrderItemAdd";
            btnOrderItemAdd.Size = new System.Drawing.Size(138, 22);
            btnOrderItemAdd.StyleController = layoutControl4;
            btnOrderItemAdd.TabIndex = 4;
            btnOrderItemAdd.Text = "Add";
            // 
            // textEdit11
            // 
            textEdit11.Location = new System.Drawing.Point(70, 12);
            textEdit11.Name = "textEdit11";
            textEdit11.Size = new System.Drawing.Size(120, 20);
            textEdit11.StyleController = layoutControl4;
            textEdit11.TabIndex = 0;
            // 
            // textEdit12
            // 
            textEdit12.Location = new System.Drawing.Point(268, 12);
            textEdit12.Name = "textEdit12";
            textEdit12.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            textEdit12.Properties.DataSource = customersBindingSource;
            textEdit12.Properties.DisplayMember = "CustId";
            textEdit12.Properties.NullText = "";
            textEdit12.Properties.PopupView = searchLookUpEdit1View;
            textEdit12.Properties.ValueMember = "CustId";
            textEdit12.Size = new System.Drawing.Size(149, 20);
            textEdit12.StyleController = layoutControl4;
            textEdit12.TabIndex = 2;
            // 
            // searchLookUpEdit1View
            // 
            searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // textEdit13
            // 
            textEdit13.EditValue = null;
            textEdit13.Location = new System.Drawing.Point(497, 12);
            textEdit13.Name = "textEdit13";
            textEdit13.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            textEdit13.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            textEdit13.Size = new System.Drawing.Size(156, 20);
            textEdit13.StyleController = layoutControl4;
            textEdit13.TabIndex = 3;
            // 
            // layoutControlGroup3
            // 
            layoutControlGroup3.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            layoutControlGroup3.GroupBordersVisible = false;
            layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem11, layoutControlItem25, layoutControlItem34, emptySpaceItem5, emptySpaceItem7, emptySpaceItem13, emptySpaceItem21, layoutControlItem8, emptySpaceItem22, layoutControlItem10 });
            layoutControlGroup3.Name = "layoutControlGroup3";
            layoutControlGroup3.Size = new System.Drawing.Size(665, 565);
            layoutControlGroup3.TextVisible = false;
            // 
            // layoutControlItem11
            // 
            layoutControlItem11.Control = textEdit11;
            layoutControlItem11.Location = new System.Drawing.Point(0, 0);
            layoutControlItem11.Name = "layoutControlItem11";
            layoutControlItem11.Size = new System.Drawing.Size(182, 24);
            layoutControlItem11.Text = "Order ID:";
            layoutControlItem11.TextSize = new System.Drawing.Size(46, 13);
            // 
            // layoutControlItem25
            // 
            layoutControlItem25.Control = textEdit12;
            layoutControlItem25.Location = new System.Drawing.Point(198, 0);
            layoutControlItem25.Name = "layoutControlItem25";
            layoutControlItem25.Size = new System.Drawing.Size(211, 24);
            layoutControlItem25.Text = "Cust ID:";
            layoutControlItem25.TextSize = new System.Drawing.Size(46, 13);
            // 
            // layoutControlItem34
            // 
            layoutControlItem34.Control = textEdit13;
            layoutControlItem34.Location = new System.Drawing.Point(427, 0);
            layoutControlItem34.Name = "layoutControlItem34";
            layoutControlItem34.Size = new System.Drawing.Size(218, 24);
            layoutControlItem34.Text = "Date:";
            layoutControlItem34.TextSize = new System.Drawing.Size(46, 13);
            // 
            // emptySpaceItem5
            // 
            emptySpaceItem5.AllowHotTrack = false;
            emptySpaceItem5.Location = new System.Drawing.Point(182, 0);
            emptySpaceItem5.Name = "emptySpaceItem5";
            emptySpaceItem5.Size = new System.Drawing.Size(16, 24);
            emptySpaceItem5.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem7
            // 
            emptySpaceItem7.AllowHotTrack = false;
            emptySpaceItem7.Location = new System.Drawing.Point(409, 0);
            emptySpaceItem7.Name = "emptySpaceItem7";
            emptySpaceItem7.Size = new System.Drawing.Size(18, 24);
            emptySpaceItem7.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem13
            // 
            emptySpaceItem13.AllowHotTrack = false;
            emptySpaceItem13.Location = new System.Drawing.Point(0, 24);
            emptySpaceItem13.Name = "emptySpaceItem13";
            emptySpaceItem13.Size = new System.Drawing.Size(645, 10);
            emptySpaceItem13.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem21
            // 
            emptySpaceItem21.AllowHotTrack = false;
            emptySpaceItem21.Location = new System.Drawing.Point(0, 34);
            emptySpaceItem21.Name = "emptySpaceItem21";
            emptySpaceItem21.Size = new System.Drawing.Size(503, 26);
            emptySpaceItem21.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem8
            // 
            layoutControlItem8.Control = btnOrderItemAdd;
            layoutControlItem8.Location = new System.Drawing.Point(503, 34);
            layoutControlItem8.Name = "layoutControlItem8";
            layoutControlItem8.Size = new System.Drawing.Size(142, 26);
            layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            layoutControlItem8.TextVisible = false;
            // 
            // emptySpaceItem22
            // 
            emptySpaceItem22.AllowHotTrack = false;
            emptySpaceItem22.Location = new System.Drawing.Point(0, 60);
            emptySpaceItem22.Name = "emptySpaceItem22";
            emptySpaceItem22.Size = new System.Drawing.Size(645, 10);
            emptySpaceItem22.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem10
            // 
            layoutControlItem10.Control = gridOrderDetail;
            layoutControlItem10.Location = new System.Drawing.Point(0, 70);
            layoutControlItem10.Name = "layoutControlItem10";
            layoutControlItem10.Size = new System.Drawing.Size(645, 475);
            layoutControlItem10.TextSize = new System.Drawing.Size(0, 0);
            layoutControlItem10.TextVisible = false;
            // 
            // emptySpaceItem14
            // 
            emptySpaceItem14.AllowHotTrack = false;
            emptySpaceItem14.Location = new System.Drawing.Point(0, 24);
            emptySpaceItem14.Name = "emptySpaceItem6";
            emptySpaceItem14.Size = new System.Drawing.Size(645, 10);
            emptySpaceItem14.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem15
            // 
            emptySpaceItem15.AllowHotTrack = false;
            emptySpaceItem15.Location = new System.Drawing.Point(0, 34);
            emptySpaceItem15.Name = "emptySpaceItem5";
            emptySpaceItem15.Size = new System.Drawing.Size(362, 26);
            emptySpaceItem15.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem16
            // 
            emptySpaceItem16.AllowHotTrack = false;
            emptySpaceItem16.Location = new System.Drawing.Point(0, 60);
            emptySpaceItem16.Name = "emptySpaceItem7";
            emptySpaceItem16.Size = new System.Drawing.Size(645, 10);
            emptySpaceItem16.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem17
            // 
            emptySpaceItem17.AllowHotTrack = false;
            emptySpaceItem17.Location = new System.Drawing.Point(0, 24);
            emptySpaceItem17.Name = "emptySpaceItem6";
            emptySpaceItem17.Size = new System.Drawing.Size(645, 10);
            emptySpaceItem17.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem18
            // 
            emptySpaceItem18.AllowHotTrack = false;
            emptySpaceItem18.Location = new System.Drawing.Point(0, 34);
            emptySpaceItem18.Name = "emptySpaceItem5";
            emptySpaceItem18.Size = new System.Drawing.Size(362, 26);
            emptySpaceItem18.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem19
            // 
            emptySpaceItem19.AllowHotTrack = false;
            emptySpaceItem19.Location = new System.Drawing.Point(0, 60);
            emptySpaceItem19.Name = "emptySpaceItem7";
            emptySpaceItem19.Size = new System.Drawing.Size(645, 10);
            emptySpaceItem19.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem6
            // 
            emptySpaceItem6.AllowHotTrack = false;
            emptySpaceItem6.Location = new System.Drawing.Point(181, 0);
            emptySpaceItem6.Name = "emptySpaceItem5";
            emptySpaceItem6.Size = new System.Drawing.Size(16, 24);
            emptySpaceItem6.TextSize = new System.Drawing.Size(0, 0);
            // 
            // MainContent
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1460, 944);
            Controls.Add(groupOrderDetail);
            Controls.Add(groupItem);
            Controls.Add(groupOrder);
            Controls.Add(groupCustomer);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "MainContent";
            Text = "MainContent";
            ((System.ComponentModel.ISupportInitialize)customersBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)itemsBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)ordersBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridViewCustomer).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCustomerDelete).EndInit();
            ((System.ComponentModel.ISupportInitialize)groupCustomer).EndInit();
            groupCustomer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)layoutControl3).EndInit();
            layoutControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)txtCustomerAddress.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtCustomerEmail.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtCustomerName.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtCustomerID.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlGroup2).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem23).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem18).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem16).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem8).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem17).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem9).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem10).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem11).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem20).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem21).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem4).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem3).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem9).EndInit();
            ((System.ComponentModel.ISupportInitialize)groupOrder).EndInit();
            groupOrder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)layoutControl2).EndInit();
            layoutControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridOrder).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridViewOrder).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnOrderDelete).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlGroup1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem14).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem5).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem20).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem23).EndInit();
            ((System.ComponentModel.ISupportInitialize)groupItem).EndInit();
            groupItem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)layoutControl1).EndInit();
            layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridControl2).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridViewItem).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnItemDelete).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtItemColor.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtItemName.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtItemID.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)Root).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem4).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem6).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem7).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem2).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem12).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem12).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).EndInit();
            ((System.ComponentModel.ISupportInitialize)groupOrderDetail).EndInit();
            groupOrderDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)layoutControl4).EndInit();
            layoutControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridOrderDetail).EndInit();
            ((System.ComponentModel.ISupportInitialize)orderDetailsBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridViewOrderDetail).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnOrderItemDelete).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit11.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit12.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)searchLookUpEdit1View).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit13.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlGroup3).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem11).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem25).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem34).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem5).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem7).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem13).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem21).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem8).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem22).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem10).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem14).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem15).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem16).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem17).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem18).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem19).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem6).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.BindingSource customersBindingSource;
        private System.Windows.Forms.BindingSource itemsBindingSource;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewCustomer;
        private DevExpress.XtraGrid.Columns.GridColumn colCustId;
        private DevExpress.XtraGrid.Columns.GridColumn colCustName;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colAddress;
        private DevExpress.XtraEditors.GroupControl groupCustomer;
        private DevExpress.XtraEditors.GroupControl groupOrder;
        private DevExpress.XtraGrid.GridControl gridOrder;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewOrder;
        private DevExpress.XtraGrid.Columns.GridColumn colOrderId;
        private DevExpress.XtraGrid.Columns.GridColumn colOrderDate;
        private DevExpress.XtraGrid.Columns.GridColumn colCustId1;
        private DevExpress.XtraEditors.GroupControl groupItem;
        private DevExpress.XtraGrid.Columns.GridColumn colItemId;
        private DevExpress.XtraGrid.Columns.GridColumn colItemName;
        private DevExpress.XtraGrid.Columns.GridColumn colColor;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.SimpleButton btnItemAdd;
        private DevExpress.XtraEditors.TextEdit txtItemColor;
        private DevExpress.XtraEditors.TextEdit txtItemName;
        private DevExpress.XtraEditors.TextEdit txtItemID;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewItem;
        private DevExpress.XtraGrid.Columns.GridColumn colItemId1;
        private DevExpress.XtraGrid.Columns.GridColumn colItemName1;
        private DevExpress.XtraGrid.Columns.GridColumn colColor1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControl layoutControl2;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem14;
        private DevExpress.XtraLayout.LayoutControl layoutControl3;
        private DevExpress.XtraEditors.SimpleButton btnCustomerAdd;
        private DevExpress.XtraEditors.TextEdit txtCustomerAddress;
        private DevExpress.XtraEditors.TextEdit txtCustomerEmail;
        private DevExpress.XtraEditors.TextEdit txtCustomerName;
        private DevExpress.XtraEditors.TextEdit txtCustomerID;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem23;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem18;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem16;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem8;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem17;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem9;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem10;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem11;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem20;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem21;
        private DevExpress.XtraEditors.GroupControl groupOrderDetail;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem4;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem12;
        private DevExpress.XtraLayout.LayoutControl layoutControl4;
        private DevExpress.XtraEditors.TextEdit textEdit11;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem11;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem13;
        private DevExpress.XtraEditors.SearchLookUpEdit textEdit12;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.DateTimeOffsetEdit textEdit13;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem25;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem34;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem14;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem15;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem16;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem17;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem18;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem19;
        private DevExpress.XtraGrid.GridControl gridOrderDetail;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewOrderDetail;
        private DevExpress.XtraEditors.SimpleButton btnOrderItemAdd;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem5;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem7;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem21;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem22;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem10;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem6;
        private DevExpress.XtraGrid.Columns.GridColumn colItemId2;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colUnitAmount;
        private System.Windows.Forms.BindingSource orderDetailsBindingSource;
        private DevExpress.XtraEditors.SimpleButton btnOrderAdd;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem20;
        private DevExpress.XtraGrid.Columns.GridColumn delete;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnCustomerDelete;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem23;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnItemDelete;
        private DevExpress.XtraGrid.Columns.GridColumn colItemDelete;
        private DevExpress.XtraGrid.Columns.GridColumn colOrderDelete;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnOrderDelete;
        private DevExpress.XtraGrid.Columns.GridColumn colOrderItemDelete;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnOrderItemDelete;
        private DevExpress.XtraEditors.SimpleButton btnCustomerClear;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraEditors.SimpleButton btnItemClear;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem12;
    }
}