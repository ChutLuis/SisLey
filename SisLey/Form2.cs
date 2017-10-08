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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
           
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Parlamentario> cx = new List<Parlamentario>();
            Form3 fm3 = new Form3();
            this.Hide();
            fm3.Show();
        }
    }
}
