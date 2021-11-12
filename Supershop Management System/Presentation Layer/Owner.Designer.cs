namespace Supershop_Management_System.Presentation_Layer
{
    partial class Owner
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.owner_logout_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.owner_add_product_button = new System.Windows.Forms.Button();
            this.owner_add_emp_button = new System.Windows.Forms.Button();
            this.owner_comp_info_button = new System.Windows.Forms.Button();
            this.owner_emp_info_button = new System.Windows.Forms.Button();
            this.owner_profile_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.owner_logout_button);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(168, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(941, 43);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(683, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 43);
            this.button1.TabIndex = 3;
            this.button1.Text = "Log Out";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // owner_logout_button
            // 
            this.owner_logout_button.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.owner_logout_button.Location = new System.Drawing.Point(830, 0);
            this.owner_logout_button.Name = "owner_logout_button";
            this.owner_logout_button.Size = new System.Drawing.Size(108, 43);
            this.owner_logout_button.TabIndex = 2;
            this.owner_logout_button.Text = "Log Out";
            this.owner_logout_button.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(248, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Owner Dashboard";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.owner_add_product_button);
            this.panel2.Controls.Add(this.owner_add_emp_button);
            this.panel2.Controls.Add(this.owner_comp_info_button);
            this.panel2.Controls.Add(this.owner_emp_info_button);
            this.panel2.Controls.Add(this.owner_profile_button);
            this.panel2.Location = new System.Drawing.Point(-1, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(163, 694);
            this.panel2.TabIndex = 1;
            // 
            // owner_add_product_button
            // 
            this.owner_add_product_button.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.owner_add_product_button.Location = new System.Drawing.Point(-3, 509);
            this.owner_add_product_button.Name = "owner_add_product_button";
            this.owner_add_product_button.Size = new System.Drawing.Size(166, 119);
            this.owner_add_product_button.TabIndex = 5;
            this.owner_add_product_button.Text = "Add Product";
            this.owner_add_product_button.UseVisualStyleBackColor = true;
            this.owner_add_product_button.Click += new System.EventHandler(this.owner_add_product_button_Click);
            // 
            // owner_add_emp_button
            // 
            this.owner_add_emp_button.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.owner_add_emp_button.Location = new System.Drawing.Point(-3, 392);
            this.owner_add_emp_button.Name = "owner_add_emp_button";
            this.owner_add_emp_button.Size = new System.Drawing.Size(166, 119);
            this.owner_add_emp_button.TabIndex = 3;
            this.owner_add_emp_button.Text = "Add Employee";
            this.owner_add_emp_button.UseVisualStyleBackColor = true;
            this.owner_add_emp_button.Click += new System.EventHandler(this.owner_add_emp_button_Click);
            // 
            // owner_comp_info_button
            // 
            this.owner_comp_info_button.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.owner_comp_info_button.Location = new System.Drawing.Point(-3, 165);
            this.owner_comp_info_button.Name = "owner_comp_info_button";
            this.owner_comp_info_button.Size = new System.Drawing.Size(166, 126);
            this.owner_comp_info_button.TabIndex = 2;
            this.owner_comp_info_button.Text = "Business Information";
            this.owner_comp_info_button.UseVisualStyleBackColor = true;
            this.owner_comp_info_button.Click += new System.EventHandler(this.owner_comp_info_button_Click);
            // 
            // owner_emp_info_button
            // 
            this.owner_emp_info_button.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.owner_emp_info_button.Location = new System.Drawing.Point(-3, 288);
            this.owner_emp_info_button.Name = "owner_emp_info_button";
            this.owner_emp_info_button.Size = new System.Drawing.Size(166, 106);
            this.owner_emp_info_button.TabIndex = 1;
            this.owner_emp_info_button.Text = "Employee Information";
            this.owner_emp_info_button.UseVisualStyleBackColor = true;
            this.owner_emp_info_button.Click += new System.EventHandler(this.owner_emp_info_button_Click);
            // 
            // owner_profile_button
            // 
            this.owner_profile_button.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.owner_profile_button.Location = new System.Drawing.Point(-3, 59);
            this.owner_profile_button.Name = "owner_profile_button";
            this.owner_profile_button.Size = new System.Drawing.Size(166, 108);
            this.owner_profile_button.TabIndex = 0;
            this.owner_profile_button.Text = "Profile";
            this.owner_profile_button.UseVisualStyleBackColor = true;
            this.owner_profile_button.Click += new System.EventHandler(this.owner_profile_button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(441, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sale History";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(168, 147);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(782, 534);
            this.dataGridView1.TabIndex = 4;
            // 
            // Owner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(962, 693);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Owner";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Owner";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Owner_FormClosing);
            this.Load += new System.EventHandler(this.Owner_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button owner_add_emp_button;
        private System.Windows.Forms.Button owner_comp_info_button;
        private System.Windows.Forms.Button owner_emp_info_button;
        private System.Windows.Forms.Button owner_profile_button;
        private System.Windows.Forms.Button owner_logout_button;
        private System.Windows.Forms.Button owner_add_product_button;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}