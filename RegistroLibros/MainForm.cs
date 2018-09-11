using RegistroLibros.UI.Consulta;
using System;
using System.Windows.Forms;

namespace RegistroLibros
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registro registroLibros = new Registro();
            registroLibros.Show();


        }

        private void lIstarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LibroConsulta consulta = new LibroConsulta();
            consulta.Show();
        }
    }
}
