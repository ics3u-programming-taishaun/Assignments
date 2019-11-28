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
            int pizzaSize;
            int toppings;
            pizzaSize = Convert.ToInt32(this.nudAmountofPizza.Value);
            toppings = Convert.ToInt32(this.nudNumberOfToppings.Value);



        }
    }
}
