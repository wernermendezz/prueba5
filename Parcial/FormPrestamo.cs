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
    public partial class FormPrestamo : Form
    {
        public FormPrestamo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClassPrestamos libroJson = new ClassPrestamos();

            libroJson.Carne1 = comboBox1.Text;
            libroJson.CodigoL1 = textBox1.Text;
           
            libroJson.FechaP1 = dateTimePicker1.Value.Date;
            libroJson.FechaD1 = dateTimePicker1.Value.Date;




            // convertir el objeto en una cadena de Json
            string salida = JsonConvert.SerializeObject(libroJson);
            //Guaradar el archivo de texto con extension Json 
            FileStream stream = new FileStream("prestamo.json", FileMode.Append, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);
            writer.WriteLine(salida);
            writer.Close();


            MessageBox.Show("INGRESADO EXITOSAMENTE!");
        }

        void guardar(ClassPrestamos p)
        {

            FileStream stream = new FileStream("prestamo.json", FileMode.Append, FileAccess.Write);

            StreamWriter writer = new StreamWriter(stream);

            writer.WriteLine(p.Carne1);
            writer.WriteLine(p.CodigoL1);
            writer.WriteLine(p.FechaP1);
            writer.WriteLine(p.FechaD1);



            writer.Close();

        }
        private void FormPrestamo_Load(object sender, EventArgs e)
        {
            //Una lista de objetos libro
            List<ClassAlumnos> listaAlumno = new List<ClassAlumnos>();
            //Leer el archivo
            FileStream stream = new FileStream("alumno.json", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);
            while (reader.Peek() > -1)
            {
                string lectura = reader.ReadLine();
                ClassAlumnos alumnoLeido = JsonConvert.DeserializeObject<ClassAlumnos>(lectura);
                listaAlumno.Add(alumnoLeido);
                comboBox1.Items.Add(reader.ReadLine());
            }

         

            reader.Close();
            

           






           

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
