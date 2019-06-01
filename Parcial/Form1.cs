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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Una lista de objetos alquilado
            List<ClassPrestamos> listaPrestamos = new List<ClassPrestamos>();
            List<ClassAlumnos> listaAlumno = new List<ClassAlumnos>();
            //Leer el archivo
            FileStream stream = new FileStream("prestamo.json", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);


           
            //Leer el archivo
            FileStream stream1 = new FileStream("alumno.json", FileMode.Open, FileAccess.Read);
            StreamReader reader1 = new StreamReader(stream1);
            while (reader.Peek() > -1)
            {
                string lectura = reader.ReadLine();
                ClassPrestamos prestamoLeido = JsonConvert.DeserializeObject<ClassPrestamos>(lectura);
                listaPrestamos.Add(prestamoLeido);
              
                ClassAlumnos alumnoLeido = JsonConvert.DeserializeObject<ClassAlumnos>(lectura);
                listaAlumno.Add(alumnoLeido);
            }
            
        
         
            reader.Close();
            //Mostrar la lista de libros en el gridview
            dataGridView1.DataSource = listaPrestamos;
            dataGridView1.Refresh();
        }
    }
}
