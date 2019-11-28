/*
 * Created by: Taishaun Johnson
 * Created on: Oct. 21, 2019
 * Created for: ICS3U Programming
 * Daily Assignment – Assingment #2 - Falling Objects
 * This program...
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

namespace FallingObjectsTaishaunJ
{
    public partial class FallingObjectsForm : Form
    {
        public FallingObjectsForm()
        {
            InitializeComponent();
        }

        private void FallingObjectsForm_Load(object sender, EventArgs e)
        {

        }

        private void LblGravityQ_Click(object sender, EventArgs e)
        {
            // Hide the label displayA and label state gravity
            this.lblStateGravity.Hide();
            this.lblDisplayA.Hide();
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            // Call variables
            double second;
            double gravity;

            // Change seconds from a text to a double
            second = double.Parse(txtSeconds.Text);

            // Make gravity = its formula
            gravity = 100 - 0.5 * 9.81 * Math.Pow(second,2);

            // Convert text to a string.
            this.lblDisplayA.Text = Convert.ToString(gravity) + " meters";

            // Show the State gravity and answer
            this.lblStateGravity.Show();
            this.lblDisplayA.Show();


        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Closes the program
            this.Close();
        }
    }

}
