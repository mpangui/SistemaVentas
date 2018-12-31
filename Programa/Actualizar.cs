using Acceder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa
{
    public partial class Actualizar : Form
    {
        Producto materia;
        public Actualizar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (PracticaPistolaEntities entorno = new PracticaPistolaEntities())
            {
                materia.Marca = txtMarca.Text;
                materia.Tipo = txtTipo.Text;
                materia.Precio = Convert.ToInt32(txtPrecio.Text);

                entorno.Entry(materia).State = System.Data.Entity.EntityState.Modified;
                entorno.SaveChanges();
            }
        }

        private void Actualizar_Load(object sender, EventArgs e)
        {

        }

        Ca
    }
}
