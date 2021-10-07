using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UNACH.Biblioteca.Window
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BibliotecaServiceReference.LibrosServiceSoapClient ws = new
                BibliotecaServiceReference.LibrosServiceSoapClient();
            LibrosdataGridView.DataSource = ws.GetLibros();
        }

        private void Insertarbutton_Click(object sender, EventArgs e)
        {
            if(ISBNtextBox.Text!="" && TitulotextBox.Text!="" && AñotextBox.Text!="" &EditorialtextBox.Text!="")
            {
                BibliotecaServiceReference.LibrosServiceSoapClient ws = new
               BibliotecaServiceReference.LibrosServiceSoapClient();
                var resultado = ws.CreateLibro(ISBNtextBox.Text, TitulotextBox.Text,int.Parse( AñotextBox.Text), EditorialtextBox.Text);
                if(resultado)
                {
                    MessageBox.Show("Los datos se insertaron");
                    LibrosdataGridView.DataSource = ws.GetLibros();
                    ISBNtextBox.Text = "";
                }
                else
                {
                    MessageBox.Show("Ocurrio un error");
                }
            }
            else
            {
                MessageBox.Show("Faltan datos");
            }
        }
    }
}
