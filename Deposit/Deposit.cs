using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DataHelper;
namespace Problem1
{
    public partial class Deposit : Form
    {
        public Deposit()
        {
            InitializeComponent();
        }
        DataAccess myData = new DataAccess();

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
        public void Output(object anyObject)
        {
            if (anyObject != null)
                richTextBox1.AppendText(anyObject + "\n");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            myData.AccountNumber = textBox1.Text;
            myData.firstName = textBox2.Text;
            if (radioButton1.Checked == true)
                myData.AccntType = radioButton1.Text;
            if (radioButton2.Checked == true)
                myData.AccntType = radioButton2.Text;
            myData.InitDeposit = numericUpDown1.Value;
            myData.Years = numericUpDown2.Value;
            Output("Account Number " + myData.AccountNumber);
            Output("First Name: " + myData.firstName);
            Output("Interest: " + myData.ComputeInterest().ToString("#,###.00"));
            Output("=================================");
        }
    }
}
