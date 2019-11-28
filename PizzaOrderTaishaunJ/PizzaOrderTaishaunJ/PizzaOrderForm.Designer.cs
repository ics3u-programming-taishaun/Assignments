namespace PizzaOrderTaishaunJ
{
    partial class PizzaOrderForm
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
            this.lblChooseSize = new System.Windows.Forms.Label();
            this.nudAmountofPizza = new System.Windows.Forms.NumericUpDown();
            this.lblToppings = new System.Windows.Forms.Label();
            this.nudNumberOfToppings = new System.Windows.Forms.NumericUpDown();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblPstTax = new System.Windows.Forms.Label();
            this.lblGstTax = new System.Windows.Forms.Label();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmountofPizza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfToppings)).BeginInit();
            this.SuspendLayout();
            // 
            // lblChooseSize
            // 
            this.lblChooseSize.AutoSize = true;
            this.lblChooseSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChooseSize.ForeColor = System.Drawing.Color.White;
            this.lblChooseSize.Location = new System.Drawing.Point(44, 23);
            this.lblChooseSize.Name = "lblChooseSize";
            this.lblChooseSize.Size = new System.Drawing.Size(466, 30);
            this.lblChooseSize.TabIndex = 0;
            this.lblChooseSize.Text = "Choose the size of pizza you would like:";
            // 
            // nudAmountofPizza
            // 
            this.nudAmountofPizza.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudAmountofPizza.Location = new System.Drawing.Point(648, 34);
            this.nudAmountofPizza.Name = "nudAmountofPizza";
            this.nudAmountofPizza.Size = new System.Drawing.Size(120, 30);
            this.nudAmountofPizza.TabIndex = 1;
            // 
            // lblToppings
            // 
            this.lblToppings.AutoSize = true;
            this.lblToppings.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToppings.ForeColor = System.Drawing.Color.White;
            this.lblToppings.Location = new System.Drawing.Point(44, 229);
            this.lblToppings.Name = "lblToppings";
            this.lblToppings.Size = new System.Drawing.Size(496, 30);
            this.lblToppings.TabIndex = 2;
            this.lblToppings.Text = "Chose how many toppings you would like: ";
            // 
            // nudNumberOfToppings
            // 
            this.nudNumberOfToppings.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudNumberOfToppings.Location = new System.Drawing.Point(648, 240);
            this.nudNumberOfToppings.Name = "nudNumberOfToppings";
            this.nudNumberOfToppings.Size = new System.Drawing.Size(120, 30);
            this.nudNumberOfToppings.TabIndex = 3;
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.ForeColor = System.Drawing.Color.White;
            this.lblSubtotal.Location = new System.Drawing.Point(172, 287);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(93, 24);
            this.lblSubtotal.TabIndex = 4;
            this.lblSubtotal.Text = "Subtotal =";
            // 
            // lblPstTax
            // 
            this.lblPstTax.AutoSize = true;
            this.lblPstTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPstTax.ForeColor = System.Drawing.Color.White;
            this.lblPstTax.Location = new System.Drawing.Point(172, 327);
            this.lblPstTax.Name = "lblPstTax";
            this.lblPstTax.Size = new System.Drawing.Size(62, 24);
            this.lblPstTax.TabIndex = 5;
            this.lblPstTax.Text = "PST =";
            // 
            // lblGstTax
            // 
            this.lblGstTax.AutoSize = true;
            this.lblGstTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGstTax.ForeColor = System.Drawing.Color.White;
            this.lblGstTax.Location = new System.Drawing.Point(172, 370);
            this.lblGstTax.Name = "lblGstTax";
            this.lblGstTax.Size = new System.Drawing.Size(64, 24);
            this.lblGstTax.TabIndex = 6;
            this.lblGstTax.Text = "GST =";
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCost.ForeColor = System.Drawing.Color.White;
            this.lblTotalCost.Location = new System.Drawing.Point(172, 417);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(104, 24);
            this.lblTotalCost.TabIndex = 7;
            this.lblTotalCost.Text = "TotalCost =";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(630, 327);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(138, 37);
            this.btnCalculate.TabIndex = 8;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(165, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Medium Pizza =";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(165, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Large Pizza =";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(163, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Extra Large Pizza = ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(165, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Small Pizza =";
            // 
            // PizzaOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblTotalCost);
            this.Controls.Add(this.lblGstTax);
            this.Controls.Add(this.lblPstTax);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.nudNumberOfToppings);
            this.Controls.Add(this.lblToppings);
            this.Controls.Add(this.nudAmountofPizza);
            this.Controls.Add(this.lblChooseSize);
            this.Name = "PizzaOrderForm";
            this.Text = "Pizza order by Taishaun Johsnon";
            ((System.ComponentModel.ISupportInitialize)(this.nudAmountofPizza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfToppings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblChooseSize;
        private System.Windows.Forms.NumericUpDown nudAmountofPizza;
        private System.Windows.Forms.Label lblToppings;
        private System.Windows.Forms.NumericUpDown nudNumberOfToppings;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblPstTax;
        private System.Windows.Forms.Label lblGstTax;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

