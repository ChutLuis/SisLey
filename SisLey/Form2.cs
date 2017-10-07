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
        Conexion conect = new Conexion();
        private void button1_Click(object sender, EventArgs e)
        {
            
            conect.realizarconexion();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            conect.cerrarconexion();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Sistem sis1 = new Sistem();
            String nombre;
            nombre = txtNombre.Text;
            MessageBox.Show(nombre);
            sis1.setNombre(nombre);
            sis1.insertarSistema(sis1);

        }

    }
}
