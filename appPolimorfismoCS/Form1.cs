using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace appPolimorfismoCS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Guardar(1);
        }

        private void btnAlumno_Click(object sender, EventArgs e)
        {
            Guardar(2);
        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            Guardar(3);
        }

        public void Guardar(int k)
        {
            if (k == 1)
            {
                Contacto x = new Contacto();
                x.Nombre = textBox1.Text;
                x.FechaN = dateTimePicker1.Value;
                x.Telefono = textBox2.Text;
                x.Correo = textBox3.Text;
                listView1.Items.Add(x.ToString());
                return;
            }
            if (k == 2)
            {

                ContactoAlumno x = new ContactoAlumno();
                x.Nombre = textBox1.Text;
                x.FechaN = dateTimePicker1.Value;
                x.Telefono = textBox2.Text;
                x.Correo = textBox3.Text;
                listView1.Items.Add(x.ToString());
                return;
            }
            if (k == 3)
            {

                ContactoEmpleado x = new ContactoEmpleado();
                x.Nombre = textBox1.Text;
                x.FechaN = dateTimePicker1.Value;
                x.Telefono = textBox2.Text;
                x.Correo = textBox3.Text;
                listView1.Items.Add(x.ToString());
                return;
            }

        }
    }
}
