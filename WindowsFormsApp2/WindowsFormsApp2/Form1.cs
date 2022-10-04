using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        private double Number1 { get; set; } = 0;
        private double Number2 { get; set; } = 0;
        private string Action { get; set; } = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnNum_Click(object sender, EventArgs e)
        {
            textBox1.Text += ((Button)sender).Text;
        }

        private void BtnAction_Click(object sender, EventArgs e)
        {
            try
            {
                Number1 = Convert.ToDouble(textBox1.Text);
                Action = ((Button)sender).Text;
                textBox1.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nНеверно введены данные!");
            }
            
        }

        private void BtnResult_Click(object sender, EventArgs e)
        {
            try
            {
                Number2 = Convert.ToDouble(textBox1.Text);
                double result = 0;
                switch (Action)
                {
                    case "+":
                        result = Number1 + Number2;
                        break;
                    case "-":
                        result = Number1 - Number2;
                        break;
                    case "*":
                        result = Number1 * Number2;
                        break;
                    case "/":
                        result = Number1 / Number2;
                        break;
                }
                textBox1.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nНеверно введены данные!");
            }
            
        }
    }
}
