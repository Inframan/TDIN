namespace Client
{
    partial class mainWindow
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
            this.nameInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.emailInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.quantity_number_slider = new System.Windows.Forms.NumericUpDown();
            this.submit_btn = new System.Windows.Forms.Button();
            this.order_type_combobox = new System.Windows.Forms.ComboBox();
            this.companies_combobox = new System.Windows.Forms.ComboBox();
            this.loading = new System.Windows.Forms.PictureBox();
            this.ordersList = new System.Windows.Forms.DataGridView();
            this.type_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.value_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.company_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.request_date_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.execution_date_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.email_list_input = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.name_list_input = new System.Windows.Forms.TextBox();
            this.list_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.quantity_number_slider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersList)).BeginInit();
            this.SuspendLayout();
            // 
            // nameInput
            // 
            this.nameInput.AcceptsTab = true;
            this.nameInput.Location = new System.Drawing.Point(293, 68);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(291, 20);
            this.nameInput.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(198, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Client Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(198, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Client Email";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // emailInput
            // 
            this.emailInput.AcceptsTab = true;
            this.emailInput.Location = new System.Drawing.Point(293, 113);
            this.emailInput.Name = "emailInput";
            this.emailInput.Size = new System.Drawing.Size(291, 20);
            this.emailInput.TabIndex = 2;
            this.emailInput.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(198, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Order Type";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(199, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Company";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(199, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Quantity";
            // 
            // quantity_number_slider
            // 
            this.quantity_number_slider.Location = new System.Drawing.Point(294, 233);
            this.quantity_number_slider.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.quantity_number_slider.Name = "quantity_number_slider";
            this.quantity_number_slider.Size = new System.Drawing.Size(291, 20);
            this.quantity_number_slider.TabIndex = 11;
            this.quantity_number_slider.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // submit_btn
            // 
            this.submit_btn.Location = new System.Drawing.Point(342, 281);
            this.submit_btn.Name = "submit_btn";
            this.submit_btn.Size = new System.Drawing.Size(110, 38);
            this.submit_btn.TabIndex = 12;
            this.submit_btn.Text = "Submit";
            this.submit_btn.UseVisualStyleBackColor = true;
            this.submit_btn.Click += new System.EventHandler(this.sendOrderRequest);
            // 
            // order_type_combobox
            // 
            this.order_type_combobox.FormattingEnabled = true;
            this.order_type_combobox.Location = new System.Drawing.Point(293, 154);
            this.order_type_combobox.Name = "order_type_combobox";
            this.order_type_combobox.Size = new System.Drawing.Size(292, 21);
            this.order_type_combobox.TabIndex = 13;
            // 
            // companies_combobox
            // 
            this.companies_combobox.FormattingEnabled = true;
            this.companies_combobox.Location = new System.Drawing.Point(293, 196);
            this.companies_combobox.Name = "companies_combobox";
            this.companies_combobox.Size = new System.Drawing.Size(292, 21);
            this.companies_combobox.TabIndex = 14;
            // 
            // loading
            // 
            this.loading.BackgroundImage = global::Client.Properties.Resources.loading;
            this.loading.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.loading.Location = new System.Drawing.Point(458, 281);
            this.loading.Name = "loading";
            this.loading.Size = new System.Drawing.Size(38, 38);
            this.loading.TabIndex = 15;
            this.loading.TabStop = false;
            this.loading.Visible = false;
            // 
            // ordersList
            // 
            this.ordersList.AllowUserToOrderColumns = true;
            this.ordersList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordersList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.type_column,
            this.quantity_column,
            this.value_column,
            this.company_column,
            this.request_date_column,
            this.status_column,
            this.execution_date_column});
            this.ordersList.Location = new System.Drawing.Point(21, 442);
            this.ordersList.Name = "ordersList";
            this.ordersList.Size = new System.Drawing.Size(743, 309);
            this.ordersList.TabIndex = 16;
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
            // value_column
            // 
            this.value_column.HeaderText = "Value";
            this.value_column.Name = "value_column";
            this.value_column.ReadOnly = true;
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
            // status_column
            // 
            this.status_column.HeaderText = "Status";
            this.status_column.Name = "status_column";
            this.status_column.ReadOnly = true;
            // 
            // execution_date_column
            // 
            this.execution_date_column.HeaderText = "Exeution Date";
            this.execution_date_column.Name = "execution_date_column";
            this.execution_date_column.ReadOnly = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(307, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(195, 26);
            this.label6.TabIndex = 17;
            this.label6.Text = "Request new order";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(347, 349);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 26);
            this.label7.TabIndex = 18;
            this.label7.Text = "List orders";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(344, 403);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 18);
            this.label8.TabIndex = 22;
            this.label8.Text = "Client Email";
            // 
            // email_list_input
            // 
            this.email_list_input.AcceptsTab = true;
            this.email_list_input.Location = new System.Drawing.Point(439, 404);
            this.email_list_input.Name = "email_list_input";
            this.email_list_input.Size = new System.Drawing.Size(202, 20);
            this.email_list_input.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(21, 403);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 18);
            this.label9.TabIndex = 20;
            this.label9.Text = "Client Name";
            // 
            // name_list_input
            // 
            this.name_list_input.AcceptsTab = true;
            this.name_list_input.Location = new System.Drawing.Point(116, 404);
            this.name_list_input.Name = "name_list_input";
            this.name_list_input.Size = new System.Drawing.Size(207, 20);
            this.name_list_input.TabIndex = 19;
            // 
            // list_btn
            // 
            this.list_btn.Location = new System.Drawing.Point(654, 404);
            this.list_btn.Name = "list_btn";
            this.list_btn.Size = new System.Drawing.Size(110, 20);
            this.list_btn.TabIndex = 23;
            this.list_btn.Text = "Get Orders";
            this.list_btn.UseVisualStyleBackColor = true;
            this.list_btn.Click += new System.EventHandler(this.getOrdersFromUser);
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(784, 761);
            this.Controls.Add(this.list_btn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.email_list_input);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.name_list_input);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ordersList);
            this.Controls.Add(this.loading);
            this.Controls.Add(this.companies_combobox);
            this.Controls.Add(this.order_type_combobox);
            this.Controls.Add(this.submit_btn);
            this.Controls.Add(this.quantity_number_slider);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.emailInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameInput);
            this.MaximumSize = new System.Drawing.Size(800, 800);
            this.MinimumSize = new System.Drawing.Size(800, 800);
            this.Name = "mainWindow";
            this.Text = "eBanking";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.exit);
            ((System.ComponentModel.ISupportInitialize)(this.quantity_number_slider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox emailInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown quantity_number_slider;
        private System.Windows.Forms.Button submit_btn;
        private System.Windows.Forms.ComboBox order_type_combobox;
        private System.Windows.Forms.ComboBox companies_combobox;
        private System.Windows.Forms.PictureBox loading;
        private System.Windows.Forms.DataGridView ordersList;
        private System.Windows.Forms.DataGridViewTextBoxColumn type_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn value_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn company_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn request_date_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn status_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn execution_date_column;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox email_list_input;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox name_list_input;
        private System.Windows.Forms.Button list_btn;
    }
}