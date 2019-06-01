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

namespace PrestamoLibros
{
    public partial class FormPrestamo : Form
    {
        public FormPrestamo()
        {
            InitializeComponent();
        }

        private void FormPrestamo_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClassPrestamo prestamoJson = new ClassPrestamo();
            // asignarle valores al objeto cliente
            prestamoJson.CarnetAlumno = textBox1.Text;
            prestamoJson.CodigoLibro = textBox2.Text;
            prestamoJson.FechaPrestamo = DateTime.Now;
            prestamoJson.FechaDevolucion = dateTimePicker1.Value.Date;

          



            // convertir el objeto en una cadena de Json
            string salida = JsonConvert.SerializeObject(prestamoJson);
            //Guaradar el archivo de texto con extension Json 
            FileStream stream = new FileStream("prestamo.json", FileMode.Append, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);
            writer.WriteLine(salida);
            writer.Close();


            MessageBox.Show("INGRESADO EXITOSAMENTE!");
        }
    }
}
