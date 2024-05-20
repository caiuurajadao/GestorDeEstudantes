using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorDeEstudantes
{
    public partial class FormInserirEstudante : Form
    {
        public FormInserirEstudante()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            OpenFileDialog procurarFoto = new OpenFileDialog();

            procurarFoto.Filter = "Selecione a foto (*.jpg,*.png,*.jpeg,*.gif)|*.jpg,*.png,*.jpeg,*.gif";
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormInserirEstudante_Load(object sender, EventArgs e)
        {

        }

        private void textBoxEnviar_TextChanged(object sender, EventArgs e)
        {
            
                
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
