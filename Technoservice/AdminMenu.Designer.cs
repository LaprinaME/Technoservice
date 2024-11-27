namespace Technoservice
{
    partial class AdminMenu
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.remontDataSet = new Technoservice.RemontDataSet();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordersTableAdapter = new Technoservice.RemontDataSetTableAdapters.ordersTableAdapter();
            this.orderidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordertechtypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordertechmodelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderstartdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startproblemdescDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderstatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordercompdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emplidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxTechType = new System.Windows.Forms.TextBox();
            this.textBoxTechModel = new System.Windows.Forms.TextBox();
            this.textBoxStartDate = new System.Windows.Forms.TextBox();
            this.textBoxProblemDesc = new System.Windows.Forms.TextBox();
            this.textBoxOrderStatus = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.remontDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(31, 396);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderidDataGridViewTextBoxColumn,
            this.ordertechtypeDataGridViewTextBoxColumn,
            this.ordertechmodelDataGridViewTextBoxColumn,
            this.orderstartdateDataGridViewTextBoxColumn,
            this.startproblemdescDataGridViewTextBoxColumn,
            this.orderstatusDataGridViewTextBoxColumn,
            this.ordercompdateDataGridViewTextBoxColumn,
            this.clientidDataGridViewTextBoxColumn,
            this.emplidDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ordersBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(65, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(644, 150);
            this.dataGridView1.TabIndex = 4;
            // 
            // remontDataSet
            // 
            this.remontDataSet.DataSetName = "RemontDataSet";
            this.remontDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "orders";
            this.ordersBindingSource.DataSource = this.remontDataSet;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // orderidDataGridViewTextBoxColumn
            // 
            this.orderidDataGridViewTextBoxColumn.DataPropertyName = "order_id";
            this.orderidDataGridViewTextBoxColumn.HeaderText = "order_id";
            this.orderidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.orderidDataGridViewTextBoxColumn.Name = "orderidDataGridViewTextBoxColumn";
            this.orderidDataGridViewTextBoxColumn.ReadOnly = true;
            this.orderidDataGridViewTextBoxColumn.Width = 125;
            // 
            // ordertechtypeDataGridViewTextBoxColumn
            // 
            this.ordertechtypeDataGridViewTextBoxColumn.DataPropertyName = "order_techtype";
            this.ordertechtypeDataGridViewTextBoxColumn.HeaderText = "order_techtype";
            this.ordertechtypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ordertechtypeDataGridViewTextBoxColumn.Name = "ordertechtypeDataGridViewTextBoxColumn";
            this.ordertechtypeDataGridViewTextBoxColumn.Width = 125;
            // 
            // ordertechmodelDataGridViewTextBoxColumn
            // 
            this.ordertechmodelDataGridViewTextBoxColumn.DataPropertyName = "order_techmodel";
            this.ordertechmodelDataGridViewTextBoxColumn.HeaderText = "order_techmodel";
            this.ordertechmodelDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ordertechmodelDataGridViewTextBoxColumn.Name = "ordertechmodelDataGridViewTextBoxColumn";
            this.ordertechmodelDataGridViewTextBoxColumn.Width = 125;
            // 
            // orderstartdateDataGridViewTextBoxColumn
            // 
            this.orderstartdateDataGridViewTextBoxColumn.DataPropertyName = "order_startdate";
            this.orderstartdateDataGridViewTextBoxColumn.HeaderText = "order_startdate";
            this.orderstartdateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.orderstartdateDataGridViewTextBoxColumn.Name = "orderstartdateDataGridViewTextBoxColumn";
            this.orderstartdateDataGridViewTextBoxColumn.Width = 125;
            // 
            // startproblemdescDataGridViewTextBoxColumn
            // 
            this.startproblemdescDataGridViewTextBoxColumn.DataPropertyName = "start_problemdesc";
            this.startproblemdescDataGridViewTextBoxColumn.HeaderText = "start_problemdesc";
            this.startproblemdescDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.startproblemdescDataGridViewTextBoxColumn.Name = "startproblemdescDataGridViewTextBoxColumn";
            this.startproblemdescDataGridViewTextBoxColumn.Width = 125;
            // 
            // orderstatusDataGridViewTextBoxColumn
            // 
            this.orderstatusDataGridViewTextBoxColumn.DataPropertyName = "order_status";
            this.orderstatusDataGridViewTextBoxColumn.HeaderText = "order_status";
            this.orderstatusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.orderstatusDataGridViewTextBoxColumn.Name = "orderstatusDataGridViewTextBoxColumn";
            this.orderstatusDataGridViewTextBoxColumn.Width = 125;
            // 
            // ordercompdateDataGridViewTextBoxColumn
            // 
            this.ordercompdateDataGridViewTextBoxColumn.DataPropertyName = "order_compdate";
            this.ordercompdateDataGridViewTextBoxColumn.HeaderText = "order_compdate";
            this.ordercompdateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ordercompdateDataGridViewTextBoxColumn.Name = "ordercompdateDataGridViewTextBoxColumn";
            this.ordercompdateDataGridViewTextBoxColumn.Width = 125;
            // 
            // clientidDataGridViewTextBoxColumn
            // 
            this.clientidDataGridViewTextBoxColumn.DataPropertyName = "client_id";
            this.clientidDataGridViewTextBoxColumn.HeaderText = "client_id";
            this.clientidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.clientidDataGridViewTextBoxColumn.Name = "clientidDataGridViewTextBoxColumn";
            this.clientidDataGridViewTextBoxColumn.Width = 125;
            // 
            // emplidDataGridViewTextBoxColumn
            // 
            this.emplidDataGridViewTextBoxColumn.DataPropertyName = "empl_id";
            this.emplidDataGridViewTextBoxColumn.HeaderText = "empl_id";
            this.emplidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emplidDataGridViewTextBoxColumn.Name = "emplidDataGridViewTextBoxColumn";
            this.emplidDataGridViewTextBoxColumn.Width = 125;
            // 
            // textBoxTechType
            // 
            this.textBoxTechType.Location = new System.Drawing.Point(31, 229);
            this.textBoxTechType.Name = "textBoxTechType";
            this.textBoxTechType.Size = new System.Drawing.Size(100, 22);
            this.textBoxTechType.TabIndex = 5;
            // 
            // textBoxTechModel
            // 
            this.textBoxTechModel.Location = new System.Drawing.Point(31, 277);
            this.textBoxTechModel.Name = "textBoxTechModel";
            this.textBoxTechModel.Size = new System.Drawing.Size(100, 22);
            this.textBoxTechModel.TabIndex = 6;
            // 
            // textBoxStartDate
            // 
            this.textBoxStartDate.Location = new System.Drawing.Point(31, 334);
            this.textBoxStartDate.Name = "textBoxStartDate";
            this.textBoxStartDate.Size = new System.Drawing.Size(100, 22);
            this.textBoxStartDate.TabIndex = 7;
            // 
            // textBoxProblemDesc
            // 
            this.textBoxProblemDesc.Location = new System.Drawing.Point(176, 228);
            this.textBoxProblemDesc.Name = "textBoxProblemDesc";
            this.textBoxProblemDesc.Size = new System.Drawing.Size(100, 22);
            this.textBoxProblemDesc.TabIndex = 8;
            // 
            // textBoxOrderStatus
            // 
            this.textBoxOrderStatus.Location = new System.Drawing.Point(207, 268);
            this.textBoxOrderStatus.Name = "textBoxOrderStatus";
            this.textBoxOrderStatus.Size = new System.Drawing.Size(100, 22);
            this.textBoxOrderStatus.TabIndex = 9;
            // 
            // AdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxOrderStatus);
            this.Controls.Add(this.textBoxProblemDesc);
            this.Controls.Add(this.textBoxStartDate);
            this.Controls.Add(this.textBoxTechModel);
            this.Controls.Add(this.textBoxTechType);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "AdminMenu";
            this.Text = "AdminMenu";
            this.Load += new System.EventHandler(this.AdminMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.remontDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private RemontDataSet remontDataSet;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private RemontDataSetTableAdapters.ordersTableAdapter ordersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordertechtypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordertechmodelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderstartdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startproblemdescDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderstatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordercompdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emplidDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBoxTechType;
        private System.Windows.Forms.TextBox textBoxTechModel;
        private System.Windows.Forms.TextBox textBoxStartDate;
        private System.Windows.Forms.TextBox textBoxProblemDesc;
        private System.Windows.Forms.TextBox textBoxOrderStatus;
    }
}