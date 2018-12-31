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
    public partial class Buscar : Form
    {

        Producto info;
        public Buscar()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                using (PracticaPistolaEntities entorno = new PracticaPistolaEntities())
                {
                    var cosa = entorno.Producto.Where(x => x.CodBarra == txtCodigo.Text).FirstOrDefault();

                    if (cosa!=null)
                    {
                        txtMarca.Text = cosa.Marca;
                        txtTipo.Text = cosa.Tipo;
                        MessageBox.Show("Producto encontrado");
                    }
                    else
                    {
                        MessageBox.Show("Producto no encontrado");
                        txtCodigo.Clear();
                    }
                }
            }
        }

        

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void Buscar_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (PracticaPistolaEntities algo = new PracticaPistolaEntities())
            {
                var coso = algo.Producto.Where(x => x.CodBarra == txtCodigo.Text);

                foreach (Producto bar in coso)
                {
                    algo.Producto.Remove(bar);
                }
                algo.SaveChanges();
                eliminar();
                MessageBox.Show("Producto eliminado");
            }
        }

        private void eliminar()
        {
            txtCodigo.Clear();
            txtMarca.Clear();
            txtTipo.Clear();
        }
    }
}
