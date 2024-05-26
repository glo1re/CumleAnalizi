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
        public Form1()
        {
            InitializeComponent();
        }
        int b = 0;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int upperCaseCount = 0;
            int lowerCaseCount = 0;
            int digitCount = 0;
            for (int i = 0; i < textBox1.Text.Length; i++)
            {
                if (char.IsUpper(textBox1.Text[i]))
                {
                    upperCaseCount++;
                }
                else if (char.IsLower(textBox1.Text[i]))
                {
                    lowerCaseCount++;
                }
                else if (char.IsDigit(textBox1.Text[i]))
                {
                    digitCount++;
                }
            }
            label2.Text ="Büyük Harf :"+ upperCaseCount.ToString();
            label3.Text ="Küçük Harf :"+ lowerCaseCount.ToString();    
            label4.Text ="Sayı :"+ digitCount.ToString();
        }
    }
    
}
