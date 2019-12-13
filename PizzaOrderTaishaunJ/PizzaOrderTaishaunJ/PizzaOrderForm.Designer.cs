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
            this.lblTax = new System.Windows.Forms.Label();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblMediumP = new System.Windows.Forms.Label();
            this.lblLargeP = new System.Windows.Forms.Label();
            this.lblExtraLP = new System.Windows.Forms.Label();
            this.lblSmallP = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmountofPizza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfToppings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.nudAmountofPizza.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nudAmountofPizza.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAmountofPizza.Name = "nudAmountofPizza";
            this.nudAmountofPizza.Size = new System.Drawing.Size(120, 30);
            this.nudAmountofPizza.TabIndex = 1;
            this.nudAmountofPizza.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
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
            this.nudNumberOfToppings.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nudNumberOfToppings.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNumberOfToppings.Name = "nudNumberOfToppings";
            this.nudNumberOfToppings.Size = new System.Drawing.Size(120, 30);
            this.nudNumberOfToppings.TabIndex = 3;
            this.nudNumberOfToppings.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
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
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTax.ForeColor = System.Drawing.Color.White;
            this.lblTax.Location = new System.Drawing.Point(172, 327);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(58, 24);
            this.lblTax.TabIndex = 5;
            this.lblTax.Text = "Tax =";
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCost.ForeColor = System.Drawing.Color.White;
            this.lblTotalCost.Location = new System.Drawing.Point(172, 369);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(67, 24);
            this.lblTotalCost.TabIndex = 7;
            this.lblTotalCost.Text = "Total =";
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
            // lblMediumP
            // 
            this.lblMediumP.AutoSize = true;
            this.lblMediumP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMediumP.ForeColor = System.Drawing.Color.White;
            this.lblMediumP.Location = new System.Drawing.Point(165, 118);
            this.lblMediumP.Name = "lblMediumP";
            this.lblMediumP.Size = new System.Drawing.Size(133, 20);
            this.lblMediumP.TabIndex = 9;
            this.lblMediumP.Text = "Medium Pizza = 2";
            // 
            // lblLargeP
            // 
            this.lblLargeP.AutoSize = true;
            this.lblLargeP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLargeP.ForeColor = System.Drawing.Color.White;
            this.lblLargeP.Location = new System.Drawing.Point(165, 159);
            this.lblLargeP.Name = "lblLargeP";
            this.lblLargeP.Size = new System.Drawing.Size(118, 20);
            this.lblLargeP.TabIndex = 10;
            this.lblLargeP.Text = "Large Pizza = 3";
            // 
            // lblExtraLP
            // 
            this.lblExtraLP.AutoSize = true;
            this.lblExtraLP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExtraLP.ForeColor = System.Drawing.Color.White;
            this.lblExtraLP.Location = new System.Drawing.Point(163, 201);
            this.lblExtraLP.Name = "lblExtraLP";
            this.lblExtraLP.Size = new System.Drawing.Size(163, 20);
            this.lblExtraLP.TabIndex = 11;
            this.lblExtraLP.Text = "Extra Large Pizza = 4 ";
            // 
            // lblSmallP
            // 
            this.lblSmallP.AutoSize = true;
            this.lblSmallP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSmallP.ForeColor = System.Drawing.Color.White;
            this.lblSmallP.Location = new System.Drawing.Point(165, 77);
            this.lblSmallP.Name = "lblSmallP";
            this.lblSmallP.Size = new System.Drawing.Size(116, 20);
            this.lblSmallP.TabIndex = 12;
            this.lblSmallP.Text = "Small Pizza = 1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PizzaOrderTaishaunJ.Properties.Resources.Pepperoni_pizza_2;
            this.pictureBox1.Location = new System.Drawing.Point(495, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(293, 151);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // PizzaOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblSmallP);
            this.Controls.Add(this.lblExtraLP);
            this.Controls.Add(this.lblLargeP);
            this.Controls.Add(this.lblMediumP);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblTotalCost);
            this.Controls.Add(this.lblTax);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.nudNumberOfToppings);
            this.Controls.Add(this.lblToppings);
            this.Controls.Add(this.nudAmountofPizza);
            this.Controls.Add(this.lblChooseSize);
            this.Name = "PizzaOrderForm";
            this.Text = "Pizza order by Taishaun Johsnon";
            ((System.ComponentModel.ISupportInitialize)(this.nudAmountofPizza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfToppings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblChooseSize;
        private System.Windows.Forms.NumericUpDown nudAmountofPizza;
        private System.Windows.Forms.Label lblToppings;
        private System.Windows.Forms.NumericUpDown nudNumberOfToppings;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblMediumP;
        private System.Windows.Forms.Label lblLargeP;
        private System.Windows.Forms.Label lblExtraLP;
        private System.Windows.Forms.Label lblSmallP;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

