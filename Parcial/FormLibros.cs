using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial
{
    public partial class FormLibros : Form
    {
        public FormLibros()
        {
            InitializeComponent();
        }



        void guardar(ClassLibros p)
        {

            FileStream stream = new FileStream("libros.json", FileMode.Append, FileAccess.Write);

            StreamWriter writer = new StreamWriter(stream);

            writer.WriteLine(p.Codigo1);
            writer.WriteLine(p.Titulo1);
            writer.WriteLine(p.Autor1);
            writer.WriteLine(p.AñoP1);



            writer.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            ClassLibros libroJson = new ClassLibros();
        
            libroJson.Codigo1 = textBox1.Text;
            libroJson.Titulo1 = textBox2.Text;
            libroJson.Autor1 = textBox3.Text;
            libroJson.AñoP1 = dateTimePicker1.Value.Date;
            



            // convertir el objeto en una cadena de Json
            string salida = JsonConvert.SerializeObject(libroJson);
            //Guaradar el archivo de texto con extension Json 
            FileStream stream = new FileStream("libros.json", FileMode.Append, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);
            writer.WriteLine(salida);
            writer.Close();


            MessageBox.Show("INGRESADO EXITOSAMENTE!");

        }
    }
}
