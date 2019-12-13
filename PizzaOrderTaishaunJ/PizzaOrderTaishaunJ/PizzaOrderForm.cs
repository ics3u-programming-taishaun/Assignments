/*
 * Created by: Taishaun Johnson
 * Created on: Nov 12,2019
 * Created for: ICS3U Programming
 * Assignment #4b - Pizza Order
 * This program shows pizza cost and topings.
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaOrderTaishaunJ
{
    public partial class PizzaOrderForm : Form
    {
        public PizzaOrderForm()
        {
            InitializeComponent();
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            // declare local variables 
            double total;
            double tax;
            double subtotal; 
            int pizzaSize;
            double pizzacost;
            double toppingscost; 
            int numtoppings;

            // Convert int to make it equal to the correct numupdown value 
            pizzaSize = Convert.ToInt32(this.nudAmountofPizza.Value);
            numtoppings = Convert.ToInt32(this.nudNumberOfToppings.Value);

            // Make S,M,L,Xl equal to a cost 
            if (pizzaSize == 1)
                pizzacost = 5.99;
            else if (pizzaSize == 2)
                pizzacost = 7.99;
            else if (pizzaSize == 3)
                pizzacost = 9.99;
            else
                pizzacost = 12.99;
            
            // Make different num of toppings equal cost 
            if (numtoppings == 1)
                toppingscost = 0.75;
            else if (numtoppings == 2)
                toppingscost = 1.35;
            else if (numtoppings == 3)
                toppingscost = 2.15;
            else
                toppingscost = 2.75;

            // declare what subtotal is equal to.
            subtotal = pizzacost + toppingscost;

            // display the subtotal 
            this.lblSubtotal.Text = "The subtotal is: $" + String.Format("{0:0.00}", subtotal);

            // declare what tax is equal to and display the tax. 
            tax = subtotal * 1.13;
            this.lblTax.Text = "The tax is: $" + String.Format("{0:0.00}", tax);

            // declare what toatl is equal to and display the total.
            total = subtotal + tax;
            this.lblTotalCost.Text = "the total is: $" + String.Format("{0:0.00}", total);
        }
    }
}
