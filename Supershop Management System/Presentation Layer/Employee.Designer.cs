namespace Supershop_Management_System.Presentation_Layer
{
    partial class Employee
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
            this.label1 = new System.Windows.Forms.Label();
            this.emp_items_datagridview = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.emp_searchitem_textbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.emp_rem_button = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.emp_total_sales_label = new System.Windows.Forms.Label();
            this.emp_vat_label = new System.Windows.Forms.Label();
            this.emp_net_total_label = new System.Windows.Forms.Label();
            this.emp_sell_button = new System.Windows.Forms.Button();
            this.emp_update_personal_info_button = new System.Windows.Forms.Button();
            this.emp_search_button = new System.Windows.Forms.Button();
            this.emp_added_items = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.quantity_textbox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.price_label = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.product_id_label = new System.Windows.Forms.Label();
            this.productname_label = new System.Windows.Forms.Label();
            this.Calculate_button = new System.Windows.Forms.Button();
            this.Add_button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.emp_load_button = new System.Windows.Forms.Button();
            this.emp_upd_personal_info = new System.Windows.Forms.Button();
            this.emp_logout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.emp_items_datagridview)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(597, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sales Dashboard";
            // 
            // emp_items_datagridview
            // 
            this.emp_items_datagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.emp_items_datagridview.Location = new System.Drawing.Point(15, 68);
            this.emp_items_datagridview.Name = "emp_items_datagridview";
            this.emp_items_datagridview.Size = new System.Drawing.Size(669, 388);
            this.emp_items_datagridview.TabIndex = 2;
            this.emp_items_datagridview.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.emp_items_datagridview_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(276, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Available Items";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 508);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Search Items: ";
            // 
            // emp_searchitem_textbox
            // 
            this.emp_searchitem_textbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.emp_searchitem_textbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.emp_searchitem_textbox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emp_searchitem_textbox.Location = new System.Drawing.Point(115, 505);
            this.emp_searchitem_textbox.Name = "emp_searchitem_textbox";
            this.emp_searchitem_textbox.Size = new System.Drawing.Size(245, 23);
            this.emp_searchitem_textbox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(968, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Added Items";
            // 
            // emp_rem_button
            // 
            this.emp_rem_button.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emp_rem_button.Location = new System.Drawing.Point(1220, 493);
            this.emp_rem_button.Name = "emp_rem_button";
            this.emp_rem_button.Size = new System.Drawing.Size(110, 35);
            this.emp_rem_button.TabIndex = 8;
            this.emp_rem_button.Text = "Clear";
            this.emp_rem_button.UseVisualStyleBackColor = true;
            this.emp_rem_button.Click += new System.EventHandler(this.emp_rem_button_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(748, 508);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Invoice";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(748, 551);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Total";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(748, 584);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Vat";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(747, 613);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "Net Total";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(919, 551);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 20);
            this.label9.TabIndex = 13;
            this.label9.Text = "=";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(919, 584);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(18, 20);
            this.label10.TabIndex = 14;
            this.label10.Text = "=";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(919, 613);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(18, 20);
            this.label11.TabIndex = 15;
            this.label11.Text = "=";
            // 
            // emp_total_sales_label
            // 
            this.emp_total_sales_label.AutoSize = true;
            this.emp_total_sales_label.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emp_total_sales_label.Location = new System.Drawing.Point(974, 551);
            this.emp_total_sales_label.Name = "emp_total_sales_label";
            this.emp_total_sales_label.Size = new System.Drawing.Size(17, 20);
            this.emp_total_sales_label.TabIndex = 16;
            this.emp_total_sales_label.Text = "0";
            // 
            // emp_vat_label
            // 
            this.emp_vat_label.AutoSize = true;
            this.emp_vat_label.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emp_vat_label.Location = new System.Drawing.Point(974, 584);
            this.emp_vat_label.Name = "emp_vat_label";
            this.emp_vat_label.Size = new System.Drawing.Size(17, 20);
            this.emp_vat_label.TabIndex = 17;
            this.emp_vat_label.Text = "0";
            // 
            // emp_net_total_label
            // 
            this.emp_net_total_label.AutoSize = true;
            this.emp_net_total_label.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emp_net_total_label.Location = new System.Drawing.Point(974, 613);
            this.emp_net_total_label.Name = "emp_net_total_label";
            this.emp_net_total_label.Size = new System.Drawing.Size(17, 20);
            this.emp_net_total_label.TabIndex = 18;
            this.emp_net_total_label.Text = "0";
            // 
            // emp_sell_button
            // 
            this.emp_sell_button.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emp_sell_button.Location = new System.Drawing.Point(1169, 604);
            this.emp_sell_button.Name = "emp_sell_button";
            this.emp_sell_button.Size = new System.Drawing.Size(120, 46);
            this.emp_sell_button.TabIndex = 19;
            this.emp_sell_button.Text = "Sell";
            this.emp_sell_button.UseVisualStyleBackColor = true;
            this.emp_sell_button.Click += new System.EventHandler(this.emp_sell_button_Click);
            // 
            // emp_update_personal_info_button
            // 
            this.emp_update_personal_info_button.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emp_update_personal_info_button.Location = new System.Drawing.Point(5, 785);
            this.emp_update_personal_info_button.Name = "emp_update_personal_info_button";
            this.emp_update_personal_info_button.Size = new System.Drawing.Size(176, 40);
            this.emp_update_personal_info_button.TabIndex = 20;
            this.emp_update_personal_info_button.Text = "Update Personal Info";
            this.emp_update_personal_info_button.UseVisualStyleBackColor = true;
            this.emp_update_personal_info_button.Click += new System.EventHandler(this.emp_update_personal_info_button_Click);
            // 
            // emp_search_button
            // 
            this.emp_search_button.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emp_search_button.Location = new System.Drawing.Point(366, 505);
            this.emp_search_button.Name = "emp_search_button";
            this.emp_search_button.Size = new System.Drawing.Size(111, 23);
            this.emp_search_button.TabIndex = 21;
            this.emp_search_button.Text = "Search";
            this.emp_search_button.UseVisualStyleBackColor = true;
            this.emp_search_button.Click += new System.EventHandler(this.emp_search_button_Click);
            // 
            // emp_added_items
            // 
            this.emp_added_items.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.emp_added_items.Location = new System.Drawing.Point(701, 68);
            this.emp_added_items.Name = "emp_added_items";
            this.emp_added_items.Size = new System.Drawing.Size(629, 388);
            this.emp_added_items.TabIndex = 22;
            this.emp_added_items.UseCompatibleStateImageBehavior = false;
            this.emp_added_items.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Product ID";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Product Name";
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Quantity";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Price";
            this.columnHeader4.Width = 80;
            // 
            // quantity_textbox
            // 
            this.quantity_textbox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantity_textbox.Location = new System.Drawing.Point(115, 608);
            this.quantity_textbox.Name = "quantity_textbox";
            this.quantity_textbox.Size = new System.Drawing.Size(245, 23);
            this.quantity_textbox.TabIndex = 25;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(-2, 572);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(111, 17);
            this.label12.TabIndex = 26;
            this.label12.Text = "Product Name: ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(29, 611);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 17);
            this.label13.TabIndex = 27;
            this.label13.Text = "Quantity:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(53, 653);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(43, 17);
            this.label16.TabIndex = 30;
            this.label16.Text = "Price:";
            // 
            // price_label
            // 
            this.price_label.AutoSize = true;
            this.price_label.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price_label.Location = new System.Drawing.Point(115, 653);
            this.price_label.Name = "price_label";
            this.price_label.Size = new System.Drawing.Size(0, 17);
            this.price_label.TabIndex = 31;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(25, 542);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(84, 17);
            this.label14.TabIndex = 32;
            this.label14.Text = "Product ID: ";
            // 
            // product_id_label
            // 
            this.product_id_label.AutoSize = true;
            this.product_id_label.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_id_label.Location = new System.Drawing.Point(115, 542);
            this.product_id_label.Name = "product_id_label";
            this.product_id_label.Size = new System.Drawing.Size(0, 17);
            this.product_id_label.TabIndex = 33;
            // 
            // productname_label
            // 
            this.productname_label.AutoSize = true;
            this.productname_label.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productname_label.Location = new System.Drawing.Point(112, 572);
            this.productname_label.Name = "productname_label";
            this.productname_label.Size = new System.Drawing.Size(0, 17);
            this.productname_label.TabIndex = 34;
            // 
            // Calculate_button
            // 
            this.Calculate_button.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calculate_button.Location = new System.Drawing.Point(65, 677);
            this.Calculate_button.Name = "Calculate_button";
            this.Calculate_button.Size = new System.Drawing.Size(116, 33);
            this.Calculate_button.TabIndex = 35;
            this.Calculate_button.Text = "Calculate";
            this.Calculate_button.UseVisualStyleBackColor = true;
            this.Calculate_button.Click += new System.EventHandler(this.Calculate_button_Click);
            // 
            // Add_button
            // 
            this.Add_button.Location = new System.Drawing.Point(244, 677);
            this.Add_button.Name = "Add_button";
            this.Add_button.Size = new System.Drawing.Size(116, 33);
            this.Add_button.TabIndex = 36;
            this.Add_button.Text = "Add";
            this.Add_button.UseVisualStyleBackColor = true;
            this.Add_button.Click += new System.EventHandler(this.Add_button_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(244, 785);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 38);
            this.button1.TabIndex = 37;
            this.button1.Text = "Logout";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // emp_load_button
            // 
            this.emp_load_button.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emp_load_button.Location = new System.Drawing.Point(484, 505);
            this.emp_load_button.Name = "emp_load_button";
            this.emp_load_button.Size = new System.Drawing.Size(112, 23);
            this.emp_load_button.TabIndex = 38;
            this.emp_load_button.Text = "Load All";
            this.emp_load_button.UseVisualStyleBackColor = true;
            this.emp_load_button.Click += new System.EventHandler(this.emp_load_button_Click);
            // 
            // emp_upd_personal_info
            // 
            this.emp_upd_personal_info.Location = new System.Drawing.Point(1035, 4);
            this.emp_upd_personal_info.Name = "emp_upd_personal_info";
            this.emp_upd_personal_info.Size = new System.Drawing.Size(295, 29);
            this.emp_upd_personal_info.TabIndex = 39;
            this.emp_upd_personal_info.Text = "Update Personal Info";
            this.emp_upd_personal_info.UseVisualStyleBackColor = true;
            this.emp_upd_personal_info.Click += new System.EventHandler(this.emp_upd_personal_info_Click);
            // 
            // emp_logout
            // 
            this.emp_logout.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emp_logout.Location = new System.Drawing.Point(1, 4);
            this.emp_logout.Name = "emp_logout";
            this.emp_logout.Size = new System.Drawing.Size(126, 29);
            this.emp_logout.TabIndex = 40;
            this.emp_logout.Text = "Log Out";
            this.emp_logout.UseVisualStyleBackColor = true;
            this.emp_logout.Click += new System.EventHandler(this.emp_logout_Click);
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1342, 749);
            this.Controls.Add(this.emp_logout);
            this.Controls.Add(this.emp_upd_personal_info);
            this.Controls.Add(this.emp_load_button);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Add_button);
            this.Controls.Add(this.Calculate_button);
            this.Controls.Add(this.productname_label);
            this.Controls.Add(this.product_id_label);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.price_label);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.quantity_textbox);
            this.Controls.Add(this.emp_added_items);
            this.Controls.Add(this.emp_search_button);
            this.Controls.Add(this.emp_update_personal_info_button);
            this.Controls.Add(this.emp_sell_button);
            this.Controls.Add(this.emp_net_total_label);
            this.Controls.Add(this.emp_vat_label);
            this.Controls.Add(this.emp_total_sales_label);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.emp_rem_button);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.emp_searchitem_textbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.emp_items_datagridview);
            this.Controls.Add(this.label1);
            this.Name = "Employee";
            this.Text = "Employee";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Employee_FormClosing);
            this.Load += new System.EventHandler(this.Employee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.emp_items_datagridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView emp_items_datagridview;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox emp_searchitem_textbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button emp_rem_button;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label emp_total_sales_label;
        private System.Windows.Forms.Label emp_vat_label;
        private System.Windows.Forms.Label emp_net_total_label;
        private System.Windows.Forms.Button emp_sell_button;
        private System.Windows.Forms.Button emp_update_personal_info_button;
        private System.Windows.Forms.Button emp_search_button;
        private System.Windows.Forms.ListView emp_added_items;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TextBox quantity_textbox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label price_label;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label product_id_label;
        private System.Windows.Forms.Label productname_label;
        private System.Windows.Forms.Button Calculate_button;
        private System.Windows.Forms.Button Add_button;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button emp_load_button;
        private System.Windows.Forms.Button emp_upd_personal_info;
        private System.Windows.Forms.Button emp_logout;
    }
}