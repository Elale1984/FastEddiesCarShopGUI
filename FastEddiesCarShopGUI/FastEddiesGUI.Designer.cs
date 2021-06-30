
namespace FastEddiesCarShopGUI
{
    partial class FastEddiesGUI
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_TotalCost = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_CheckOut = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.gb_ShopCart = new System.Windows.Forms.GroupBox();
            this.lb_ShoppingCart = new System.Windows.Forms.ListBox();
            this.gb_ShowFloor = new System.Windows.Forms.GroupBox();
            this.lb_CarList = new System.Windows.Forms.ListBox();
            this.gb_AddCar = new System.Windows.Forms.GroupBox();
            this.btn_AddCar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_Price = new System.Windows.Forms.TextBox();
            this.tb_Miles = new System.Windows.Forms.TextBox();
            this.tb_Color = new System.Windows.Forms.TextBox();
            this.tb_Model = new System.Windows.Forms.TextBox();
            this.tb_Make = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gb_ShopCart.SuspendLayout();
            this.gb_ShowFloor.SuspendLayout();
            this.gb_AddCar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_TotalCost
            // 
            this.lbl_TotalCost.AutoSize = true;
            this.lbl_TotalCost.BackColor = System.Drawing.Color.Transparent;
            this.lbl_TotalCost.Font = new System.Drawing.Font("Magneto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_TotalCost.ForeColor = System.Drawing.Color.Lime;
            this.lbl_TotalCost.Location = new System.Drawing.Point(877, 576);
            this.lbl_TotalCost.Name = "lbl_TotalCost";
            this.lbl_TotalCost.Size = new System.Drawing.Size(58, 32);
            this.lbl_TotalCost.TabIndex = 22;
            this.lbl_TotalCost.Text = "$0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Magneto", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Lime;
            this.label7.Location = new System.Drawing.Point(654, 576);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(178, 32);
            this.label7.TabIndex = 21;
            this.label7.Text = "Total Cost:";
            // 
            // btn_CheckOut
            // 
            this.btn_CheckOut.BackColor = System.Drawing.Color.SpringGreen;
            this.btn_CheckOut.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_CheckOut.ForeColor = System.Drawing.Color.OrangeRed;
            this.btn_CheckOut.Location = new System.Drawing.Point(454, 562);
            this.btn_CheckOut.Name = "btn_CheckOut";
            this.btn_CheckOut.Size = new System.Drawing.Size(173, 53);
            this.btn_CheckOut.TabIndex = 17;
            this.btn_CheckOut.Text = "Check Out";
            this.btn_CheckOut.UseVisualStyleBackColor = false;
            this.btn_CheckOut.Click += new System.EventHandler(this.btn_CheckOut_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SpringGreen;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.OrangeRed;
            this.button1.Location = new System.Drawing.Point(730, 362);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 42);
            this.button1.TabIndex = 20;
            this.button1.Text = "Add To Cart >>";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gb_ShopCart
            // 
            this.gb_ShopCart.Controls.Add(this.lb_ShoppingCart);
            this.gb_ShopCart.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gb_ShopCart.ForeColor = System.Drawing.Color.Lime;
            this.gb_ShopCart.Location = new System.Drawing.Point(932, 164);
            this.gb_ShopCart.Name = "gb_ShopCart";
            this.gb_ShopCart.Size = new System.Drawing.Size(297, 357);
            this.gb_ShopCart.TabIndex = 19;
            this.gb_ShopCart.TabStop = false;
            this.gb_ShopCart.Text = "Shopping Cart";
            // 
            // lb_ShoppingCart
            // 
            this.lb_ShoppingCart.BackColor = System.Drawing.Color.Thistle;
            this.lb_ShoppingCart.FormattingEnabled = true;
            this.lb_ShoppingCart.ItemHeight = 28;
            this.lb_ShoppingCart.Location = new System.Drawing.Point(16, 39);
            this.lb_ShoppingCart.Name = "lb_ShoppingCart";
            this.lb_ShoppingCart.Size = new System.Drawing.Size(263, 284);
            this.lb_ShoppingCart.TabIndex = 1;
            // 
            // gb_ShowFloor
            // 
            this.gb_ShowFloor.Controls.Add(this.lb_CarList);
            this.gb_ShowFloor.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gb_ShowFloor.ForeColor = System.Drawing.Color.Lime;
            this.gb_ShowFloor.Location = new System.Drawing.Point(408, 164);
            this.gb_ShowFloor.Name = "gb_ShowFloor";
            this.gb_ShowFloor.Size = new System.Drawing.Size(300, 357);
            this.gb_ShowFloor.TabIndex = 18;
            this.gb_ShowFloor.TabStop = false;
            this.gb_ShowFloor.Text = "Showroom Floor";
            // 
            // lb_CarList
            // 
            this.lb_CarList.BackColor = System.Drawing.Color.Thistle;
            this.lb_CarList.FormattingEnabled = true;
            this.lb_CarList.ItemHeight = 28;
            this.lb_CarList.Location = new System.Drawing.Point(18, 39);
            this.lb_CarList.Name = "lb_CarList";
            this.lb_CarList.Size = new System.Drawing.Size(263, 284);
            this.lb_CarList.TabIndex = 0;
            // 
            // gb_AddCar
            // 
            this.gb_AddCar.Controls.Add(this.btn_AddCar);
            this.gb_AddCar.Controls.Add(this.label6);
            this.gb_AddCar.Controls.Add(this.label5);
            this.gb_AddCar.Controls.Add(this.label4);
            this.gb_AddCar.Controls.Add(this.label3);
            this.gb_AddCar.Controls.Add(this.label2);
            this.gb_AddCar.Controls.Add(this.tb_Price);
            this.gb_AddCar.Controls.Add(this.tb_Miles);
            this.gb_AddCar.Controls.Add(this.tb_Color);
            this.gb_AddCar.Controls.Add(this.tb_Model);
            this.gb_AddCar.Controls.Add(this.tb_Make);
            this.gb_AddCar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gb_AddCar.ForeColor = System.Drawing.Color.Lime;
            this.gb_AddCar.Location = new System.Drawing.Point(66, 164);
            this.gb_AddCar.Name = "gb_AddCar";
            this.gb_AddCar.Size = new System.Drawing.Size(300, 357);
            this.gb_AddCar.TabIndex = 16;
            this.gb_AddCar.TabStop = false;
            this.gb_AddCar.Text = "Create A Car";
            // 
            // btn_AddCar
            // 
            this.btn_AddCar.BackColor = System.Drawing.Color.SpringGreen;
            this.btn_AddCar.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_AddCar.ForeColor = System.Drawing.Color.OrangeRed;
            this.btn_AddCar.Location = new System.Drawing.Point(120, 247);
            this.btn_AddCar.Name = "btn_AddCar";
            this.btn_AddCar.Size = new System.Drawing.Size(143, 49);
            this.btn_AddCar.TabIndex = 11;
            this.btn_AddCar.Text = "Add Car";
            this.btn_AddCar.UseVisualStyleBackColor = false;
            this.btn_AddCar.Click += new System.EventHandler(this.btn_AddCar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.DeepPink;
            this.label6.Location = new System.Drawing.Point(30, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Price:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.DeepPink;
            this.label5.Location = new System.Drawing.Point(30, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Miles:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.DeepPink;
            this.label4.Location = new System.Drawing.Point(30, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Color:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.DeepPink;
            this.label3.Location = new System.Drawing.Point(30, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Model:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.DeepPink;
            this.label2.Location = new System.Drawing.Point(30, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Make:";
            // 
            // tb_Price
            // 
            this.tb_Price.BackColor = System.Drawing.Color.Thistle;
            this.tb_Price.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_Price.Location = new System.Drawing.Point(120, 195);
            this.tb_Price.Name = "tb_Price";
            this.tb_Price.PlaceholderText = "$5000.00";
            this.tb_Price.Size = new System.Drawing.Size(150, 31);
            this.tb_Price.TabIndex = 5;
            this.tb_Price.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tb_Miles
            // 
            this.tb_Miles.BackColor = System.Drawing.Color.Thistle;
            this.tb_Miles.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_Miles.Location = new System.Drawing.Point(120, 158);
            this.tb_Miles.Name = "tb_Miles";
            this.tb_Miles.PlaceholderText = "10000...";
            this.tb_Miles.Size = new System.Drawing.Size(150, 31);
            this.tb_Miles.TabIndex = 3;
            this.tb_Miles.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tb_Color
            // 
            this.tb_Color.BackColor = System.Drawing.Color.Thistle;
            this.tb_Color.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_Color.Location = new System.Drawing.Point(120, 121);
            this.tb_Color.Name = "tb_Color";
            this.tb_Color.PlaceholderText = "Green, Blue...";
            this.tb_Color.Size = new System.Drawing.Size(150, 31);
            this.tb_Color.TabIndex = 2;
            this.tb_Color.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tb_Model
            // 
            this.tb_Model.BackColor = System.Drawing.Color.Thistle;
            this.tb_Model.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_Model.Location = new System.Drawing.Point(120, 84);
            this.tb_Model.Name = "tb_Model";
            this.tb_Model.PlaceholderText = "F-150, Civic...";
            this.tb_Model.Size = new System.Drawing.Size(150, 31);
            this.tb_Model.TabIndex = 1;
            this.tb_Model.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tb_Make
            // 
            this.tb_Make.BackColor = System.Drawing.Color.Thistle;
            this.tb_Make.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_Make.Location = new System.Drawing.Point(120, 47);
            this.tb_Make.Name = "tb_Make";
            this.tb_Make.PlaceholderText = "Ford, Honda...";
            this.tb_Make.Size = new System.Drawing.Size(150, 31);
            this.tb_Make.TabIndex = 0;
            this.tb_Make.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.LawnGreen;
            this.label1.Location = new System.Drawing.Point(216, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(797, 106);
            this.label1.TabIndex = 15;
            this.label1.Text = "Fast Eddie\'s Car Shop";
            // 
            // FastEddiesGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(1272, 719);
            this.Controls.Add(this.lbl_TotalCost);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_CheckOut);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gb_ShopCart);
            this.Controls.Add(this.gb_ShowFloor);
            this.Controls.Add(this.gb_AddCar);
            this.Controls.Add(this.label1);
            this.Name = "FastEddiesGUI";
            this.Text = "FastEddiesGUI";
            this.gb_ShopCart.ResumeLayout(false);
            this.gb_ShowFloor.ResumeLayout(false);
            this.gb_AddCar.ResumeLayout(false);
            this.gb_AddCar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_TotalCost;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_CheckOut;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox gb_ShopCart;
        private System.Windows.Forms.GroupBox gb_ShowFloor;
        private System.Windows.Forms.GroupBox gb_AddCar;
        private System.Windows.Forms.Button btn_AddCar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_Price;
        private System.Windows.Forms.TextBox tb_Miles;
        private System.Windows.Forms.TextBox tb_Color;
        private System.Windows.Forms.TextBox tb_Model;
        private System.Windows.Forms.TextBox tb_Make;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lb_ShoppingCart;
        private System.Windows.Forms.ListBox lb_CarList;
    }
}

