using System;

namespace Supervisor
{
    partial class MainWindow
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
            this.ordersList = new System.Windows.Forms.DataGridView();
            this.id_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.client_id_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.company_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.request_date_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.value_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.action_column = new System.Windows.Forms.DataGridViewButtonColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ordersList)).BeginInit();
            this.SuspendLayout();
            // 
            // ordersList
            // 
            this.ordersList.AllowUserToAddRows = false;
            this.ordersList.AllowUserToDeleteRows = false;
            this.ordersList.AllowUserToOrderColumns = true;
            this.ordersList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordersList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_column,
            this.client_id_column,
            this.type_column,
            this.quantity_column,
            this.company_column,
            this.request_date_column,
            this.value_column,
            this.status_column,
            this.action_column});
            this.ordersList.Location = new System.Drawing.Point(12, 49);
            this.ordersList.Name = "ordersList";
            this.ordersList.Size = new System.Drawing.Size(950, 383);
            this.ordersList.TabIndex = 0;
            this.ordersList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ordersList_CellContentClick);
            // 
            // id_column
            // 
            this.id_column.HeaderText = "ID";
            this.id_column.Name = "id_column";
            this.id_column.ReadOnly = true;
            // 
            // client_id_column
            // 
            this.client_id_column.HeaderText = "Client ID";
            this.client_id_column.Name = "client_id_column";
            this.client_id_column.ReadOnly = true;
            // 
            // type_column
            // 
            this.type_column.HeaderText = "Type";
            this.type_column.Name = "type_column";
            this.type_column.ReadOnly = true;
            // 
            // quantity_column
            // 
            this.quantity_column.HeaderText = "Quantity";
            this.quantity_column.Name = "quantity_column";
            this.quantity_column.ReadOnly = true;
            // 
            // company_column
            // 
            this.company_column.HeaderText = "Company";
            this.company_column.Name = "company_column";
            this.company_column.ReadOnly = true;
            // 
            // request_date_column
            // 
            this.request_date_column.HeaderText = "Request Date";
            this.request_date_column.Name = "request_date_column";
            this.request_date_column.ReadOnly = true;
            // 
            // value_column
            // 
            this.value_column.HeaderText = "Value";
            this.value_column.Name = "value_column";
            // 
            // status_column
            // 
            this.status_column.HeaderText = "Status";
            this.status_column.Name = "status_column";
            this.status_column.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.status_column.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // action_column
            // 
            this.action_column.HeaderText = "Action";
            this.action_column.Name = "action_column";
            this.action_column.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.action_column.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(887, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 31);
            this.button1.TabIndex = 1;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.refreshTable);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(974, 444);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ordersList);
            this.MaximumSize = new System.Drawing.Size(990, 483);
            this.MinimumSize = new System.Drawing.Size(990, 483);
            this.Name = "MainWindow";
            this.Text = "Stocks";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.exit);
            ((System.ComponentModel.ISupportInitialize)(this.ordersList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ordersList;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn client_id_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn type_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn company_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn request_date_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn value_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn status_column;
        private System.Windows.Forms.DataGridViewButtonColumn action_column;
        private System.Windows.Forms.Button button1;
    }
}