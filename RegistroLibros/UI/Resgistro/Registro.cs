using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RegistroLibros.Entidades;
using RegistroLibros.BLL;
using RegistroLibros.DAL;

namespace RegistroLibros
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        //Metodo para limpiar los componestes
        private void Limpiar()
        {
            IDnumericUpDown.Value = 0;
            NombretextBox.Text = string.Empty;
            DescripciontextBox.Text = string.Empty;
            SiglatextBox.Text = string.Empty;
            TipotextBox.Text = string.Empty;
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private Libros LlenaClase()
        {
            Libros libros = new Libros();
            libros.Id = Convert.ToInt32(IDnumericUpDown.Value);
            libros.Nombre = NombretextBox.Text;
            libros.Descricion = DescripciontextBox.Text;
            libros.Siglas = SiglatextBox.Text;
            libros.Tipo = TipotextBox.Text;
            return libros;
        }

        private bool ExiteEnBaseDeDatos()
        {
            Libros libros = LibrosBll.Buscar((int)IDnumericUpDown.Value);
            return (libros != null);
        }

        

        private void Guardarbutton_Click_1(object sender, EventArgs e)
        {
            Libros libros;
            bool paso = false;

            if (!Validar())
                return;

            

            libros = LlenaClase();
            if (IDnumericUpDown.Value == 0)
            {
               
                paso = LibrosBll.Guardar(libros);
            }
            else
            {
                if (!ExiteEnBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar  una persona que no exite", "fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                paso = LibrosBll.Modificar(libros);

            }
            Limpiar();
            if (paso)
                MessageBox.Show("Guardado con Exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                MessageBox.Show("No  se pudo Guardar", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            int id;
            int.TryParse(IDnumericUpDown.Text, out id);
            if (LibrosBll.Eliminar(id))
            {
                MessageBox.Show("Eliminado");
                Limpiar();
            }
            else
                MessageBox.Show("no se pudo eliminar");
        }

        private void LlenaCampo(Libros libros)
        {
            IDnumericUpDown.Value = libros.Id;
            NombretextBox.Text = libros.Nombre;
            DescripciontextBox.Text = libros.Descricion;
            SiglatextBox.Text = libros.Siglas;
            TipotextBox.Text = libros.Tipo;

        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            int id;
            Libros libros = new Libros();
            int.TryParse(IDnumericUpDown.Text, out id);
            libros = LibrosBll.Buscar(id);
            if(libros != null)
            {
                MessageBox.Show("Persona  Encotrada");
                LlenaCampo(libros);

            }
            else
            {
                MessageBox.Show("Persona no Encotrada");

            }
        }

        private bool Validar()
        {
            bool paso = true;
            if (NombretextBox.Text.Trim() == string.Empty|| DescripciontextBox.Text.Trim() ==string.Empty ||SiglatextBox.Text.Trim()== string.Empty||TipotextBox.Text.Trim() == string.Empty)
            {
             if(NombretextBox.Text.Trim()== string.Empty)
                {
                    errorProvider1.SetError(NombretextBox, "No dejar campo vacio");
                    NombretextBox.Focus();
                }
             if(DescripciontextBox.Text.Trim() == string.Empty)
                {
                    errorProvider1.SetError(DescripciontextBox, "No dejar campo vacio");
                    DescripciontextBox.Focus();
                }
             if(SiglatextBox.Text.Trim() == string.Empty)
                {
                    errorProvider1.SetError(SiglatextBox, "No dejar campo vacio");
                    DescripciontextBox.Focus();
                }
                if (TipotextBox.Text.Trim() == string.Empty)
                {
                    errorProvider1.SetError(TipotextBox, "No dejar campo vacio");
                }

                paso = false;
            }
            return paso;
        }
         
    }

    
}
