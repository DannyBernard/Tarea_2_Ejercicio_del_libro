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

namespace RegistroLibros.UI.Consulta
{
    public partial class LibroConsulta : Form
    {
        public LibroConsulta()
        {
            InitializeComponent();
        }

        

        private void Consultabutton_Click(object sender, EventArgs e)
        {
            var listado = new List<Libros>();
            if(CriteriotextBox.Text.Trim().Length > 0)
            {
                switch (FiltrocomboBox.SelectedItem)
                {
                    case 0:
                        listado = LibrosBll.GetList(p => true);
                        break;
                }
            }


        }
    }
}
