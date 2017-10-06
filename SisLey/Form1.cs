using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SisLey
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Usuarios User = new Usuarios();

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text==User.getUser())
            {
                if (textBox2.Text==User.getPass())
                {
                    Form2 sc = new Form2();
                    sc.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong PassWord");

                }
            }
            else 
            {
                MessageBox.Show("Wrong User");
            }
        

            
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
