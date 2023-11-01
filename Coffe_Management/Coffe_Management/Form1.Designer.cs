
namespace Coffe_Management
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tb_Name_input = new System.Windows.Forms.TextBox();
            this.tb_Details_input = new System.Windows.Forms.TextBox();
            this.tb_Price_input = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Add = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.tb_Find = new System.Windows.Forms.TextBox();
            this.btn_show_menu = new System.Windows.Forms.Button();
            this.cb_box_Menu = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(38, 186);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(893, 218);
            this.dataGridView1.TabIndex = 0;
            // 
            // tb_Name_input
            // 
            this.tb_Name_input.Location = new System.Drawing.Point(89, 33);
            this.tb_Name_input.Name = "tb_Name_input";
            this.tb_Name_input.Size = new System.Drawing.Size(202, 20);
            this.tb_Name_input.TabIndex = 1;
            // 
            // tb_Details_input
            // 
            this.tb_Details_input.Location = new System.Drawing.Point(89, 71);
            this.tb_Details_input.Name = "tb_Details_input";
            this.tb_Details_input.Size = new System.Drawing.Size(202, 20);
            this.tb_Details_input.TabIndex = 1;
            // 
            // tb_Price_input
            // 
            this.tb_Price_input.Location = new System.Drawing.Point(89, 110);
            this.tb_Price_input.Name = "tb_Price_input";
            this.tb_Price_input.Size = new System.Drawing.Size(202, 20);
            this.tb_Price_input.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Details";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Price";
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(487, 124);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(111, 44);
            this.Add.TabIndex = 3;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(789, 124);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(111, 44);
            this.Delete.TabIndex = 3;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // tb_Find
            // 
            this.tb_Find.Location = new System.Drawing.Point(666, 67);
            this.tb_Find.Name = "tb_Find";
            this.tb_Find.Size = new System.Drawing.Size(201, 20);
            this.tb_Find.TabIndex = 1;
            this.tb_Find.Text = "Input Name To Delete";
            // 
            // btn_show_menu
            // 
            this.btn_show_menu.Location = new System.Drawing.Point(641, 124);
            this.btn_show_menu.Name = "btn_show_menu";
            this.btn_show_menu.Size = new System.Drawing.Size(111, 44);
            this.btn_show_menu.TabIndex = 3;
            this.btn_show_menu.Text = "Show Menu Of Category";
            this.btn_show_menu.UseVisualStyleBackColor = true;
            this.btn_show_menu.Click += new System.EventHandler(this.btn_show_menu_Click);
            // 
            // cb_box_Menu
            // 
            this.cb_box_Menu.FormattingEnabled = true;
            this.cb_box_Menu.Location = new System.Drawing.Point(666, 32);
            this.cb_box_Menu.Name = "cb_box_Menu";
            this.cb_box_Menu.Size = new System.Drawing.Size(201, 21);
            this.cb_box_Menu.TabIndex = 4;
            this.cb_box_Menu.SelectedIndexChanged += new System.EventHandler(this.cb_box_Menu_SelectedIndexChanged);
            this.cb_box_Menu.Click += new System.EventHandler(this.cb_box_Menu_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(585, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Category";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 551);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cb_box_Menu);
            this.Controls.Add(this.btn_show_menu);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_Price_input);
            this.Controls.Add(this.tb_Details_input);
            this.Controls.Add(this.tb_Find);
            this.Controls.Add(this.tb_Name_input);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tb_Name_input;
        private System.Windows.Forms.TextBox tb_Details_input;
        private System.Windows.Forms.TextBox tb_Price_input;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.TextBox tb_Find;
        private System.Windows.Forms.Button btn_show_menu;
        private System.Windows.Forms.ComboBox cb_box_Menu;
        private System.Windows.Forms.Label label4;
    }
}

