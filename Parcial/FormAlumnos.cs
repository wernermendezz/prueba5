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
    public partial class FormAlumnos : Form
    {
        public FormAlumnos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClassAlumnos alumnoJson = new ClassAlumnos();

            alumnoJson.Carne1= textBox1.Text;
            alumnoJson.Nombre1 = textBox2.Text;




            // convertir el objeto en una cadena de Json
            string salida = JsonConvert.SerializeObject(alumnoJson);
            //Guaradar el archivo de texto con extension Json 
            FileStream stream = new FileStream("alumno.json", FileMode.Append, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);
            writer.WriteLine(salida);
            writer.Close();


            MessageBox.Show("INGRESADO EXITOSAMENTE!");
        }
    }
}
