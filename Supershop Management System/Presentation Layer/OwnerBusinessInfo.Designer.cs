﻿namespace Supershop_Management_System.Presentation_Layer
{
    partial class OwnerBusinessInfo
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
            this.businessInfo_Listview = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.profit_label = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // businessInfo_Listview
            // 
            this.businessInfo_Listview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.businessInfo_Listview.Location = new System.Drawing.Point(1, 12);
            this.businessInfo_Listview.Name = "businessInfo_Listview";
            this.businessInfo_Listview.Size = new System.Drawing.Size(696, 526);
            this.businessInfo_Listview.TabIndex = 0;
            this.businessInfo_Listview.UseCompatibleStateImageBehavior = false;
            this.businessInfo_Listview.View = System.Windows.Forms.View.Details;
            this.businessInfo_Listview.SelectedIndexChanged += new System.EventHandler(this.businessInfo_Listview_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Product Name";
            this.columnHeader1.Width = 162;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Sold Quantity";
            this.columnHeader2.Width = 214;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Unit Profit";
            this.columnHeader3.Width = 204;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Profit";
            this.columnHeader4.Width = 87;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 560);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total Profit: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // profit_label
            // 
            this.profit_label.AutoSize = true;
            this.profit_label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profit_label.Location = new System.Drawing.Point(102, 560);
            this.profit_label.Name = "profit_label";
            this.profit_label.Size = new System.Drawing.Size(0, 19);
            this.profit_label.TabIndex = 2;
            this.profit_label.Click += new System.EventHandler(this.profit_label_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1074, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 41);
            this.button1.TabIndex = 3;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(492, 544);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(205, 62);
            this.button2.TabIndex = 4;
            this.button2.Text = "Property Depreciation";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // OwnerBusinessInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 712);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.profit_label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.businessInfo_Listview);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "OwnerBusinessInfo";
            this.Text = "OwnerBusinessInfo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OwnerBusinessInfo_FormClosing);
            this.Load += new System.EventHandler(this.OwnerBusinessInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView businessInfo_Listview;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label profit_label;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}