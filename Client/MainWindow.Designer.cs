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
            ((System.ComponentModel.ISupportInitialize)(this.quantity_number_slider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loading)).BeginInit();
            this.SuspendLayout();
            // 
            // nameInput
            // 
            this.nameInput.AcceptsTab = true;
            this.nameInput.Location = new System.Drawing.Point(121, 31);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(291, 20);
            this.nameInput.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(26, 30);
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
            this.label2.Location = new System.Drawing.Point(26, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Client Email";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // emailInput
            // 
            this.emailInput.AcceptsTab = true;
            this.emailInput.Location = new System.Drawing.Point(121, 76);
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
            this.label3.Location = new System.Drawing.Point(26, 120);
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
            this.label4.Location = new System.Drawing.Point(27, 159);
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
            this.label5.Location = new System.Drawing.Point(27, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Quantity";
            // 
            // quantity_number_slider
            // 
            this.quantity_number_slider.Location = new System.Drawing.Point(122, 196);
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
            this.submit_btn.Location = new System.Drawing.Point(160, 271);
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
            this.order_type_combobox.Location = new System.Drawing.Point(121, 117);
            this.order_type_combobox.Name = "order_type_combobox";
            this.order_type_combobox.Size = new System.Drawing.Size(292, 21);
            this.order_type_combobox.TabIndex = 13;
            // 
            // companies_combobox
            // 
            this.companies_combobox.FormattingEnabled = true;
            this.companies_combobox.Location = new System.Drawing.Point(121, 159);
            this.companies_combobox.Name = "companies_combobox";
            this.companies_combobox.Size = new System.Drawing.Size(292, 21);
            this.companies_combobox.TabIndex = 14;
            // 
            // loading
            // 
            this.loading.BackgroundImage = global::Client.Properties.Resources.loading;
            this.loading.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.loading.Location = new System.Drawing.Point(276, 271);
            this.loading.Name = "loading";
            this.loading.Size = new System.Drawing.Size(38, 38);
            this.loading.TabIndex = 15;
            this.loading.TabStop = false;
            this.loading.Visible = false;
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(449, 351);
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
            this.MaximumSize = new System.Drawing.Size(465, 390);
            this.MinimumSize = new System.Drawing.Size(465, 390);
            this.Name = "mainWindow";
            this.Text = "eBanking";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.exit);
            ((System.ComponentModel.ISupportInitialize)(this.quantity_number_slider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loading)).EndInit();
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
    }
}