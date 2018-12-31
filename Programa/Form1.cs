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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var entorno = new PracticaPistolaEntities())
            {
                entorno.Producto.Add(new Producto()
                {
                    CodBarra = txtCodBarra.Text,
                    Tipo = txtTipo.Text,
                    Marca = txtMarca.Text,
                    Precio = Convert.ToInt32(txtPrecio.Text)
                });

                entorno.SaveChanges();

                if (entorno.SaveChanges() != 1)
                {
                    MessageBox.Show("Producto guardado exitosamente");
                }
                else
                {
                    MessageBox.Show("Error al guardar producto");
                }

                limpiar();
            }
        }

        private void limpiar()
        {
            txtCodBarra.Clear();
            txtMarca.Clear();
            txtTipo.Clear();
            txtPrecio.Clear();
        }

        private void txtCodBarra_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtCodBarra_Validated(object sender, EventArgs e)
        {

        }

        private void txtCodBarra_Validating(object sender, CancelEventArgs e)
        {

        }

        private void txtCodBarra_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }
    }
}
