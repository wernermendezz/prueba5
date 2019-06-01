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
    public partial class FormMostrarPrestamo : Form
    {
        public FormMostrarPrestamo()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        List<ClassEstudiante> listaMEstudiantes = new List<ClassEstudiante>();
        List<ClassLibro> listaMLibro = new List<ClassLibro>();
        List<ClassLista> listaMlista = new List<ClassLista>();
        List<ClassPrestamo> listaMPrestamo= new List<ClassPrestamo>();
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void FormMostrarPrestamo_Load(object sender, EventArgs e)
        {
            //Una lista de objetos alquilado
           
            //Leer el archivo
            FileStream stream = new FileStream("Estudiante.json", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);
            while (reader.Peek() > -1)
            {
                string lectura = reader.ReadLine();
                ClassEstudiante estudianteLeido = JsonConvert.DeserializeObject<ClassEstudiante>(lectura);
                listaMEstudiantes.Add(estudianteLeido);
            }
            reader.Close();
            //Mostrar la lista de libros en el gridview

            //_____________________________________________________________-
            stream = new FileStream("Libros.json", FileMode.Open, FileAccess.Read);
            reader = new StreamReader(stream);
            while (reader.Peek() > -1)
            {
                string lectura = reader.ReadLine();
                ClassLibro estudianteLeido = JsonConvert.DeserializeObject<ClassLibro>(lectura);
                listaMLibro.Add(estudianteLeido);
            }
            reader.Close();

            //__________________________________________________________________________________

            stream = new FileStream("prestamo.json", FileMode.Open, FileAccess.Read);
            reader = new StreamReader(stream);
            while (reader.Peek() > -1)
            {
                string lectura = reader.ReadLine();
                ClassPrestamo estudianteLeido = JsonConvert.DeserializeObject<ClassPrestamo>(lectura);
                listaMPrestamo.Add(estudianteLeido);
            }
            reader.Close();
            //______________________________________________________________________

            for (int i = 0; i < listaMPrestamo.Count; i++)
            {
                ClassLista listaTemp = new ClassLista();

                //por cada empleado recorrer todas las asistencias
                for (int j = 0; j < listaMEstudiantes.Count; j++)
                {
                    //si coincide el empleado y la asistencia hacer el calculo
                    if (listaMPrestamo[i].CarnetAlumno == listaMEstudiantes[j].Carnet)
                    {
                        //para llenar la vista se obtienen datos del empleado y de la asistencia
                        listaTemp.NombreEstudiante = listaMEstudiantes[j].Nombre;
                    }
                }

                for (int j = 0; j < listaMLibro.Count; j++)
                {
                    //si coincide el empleado y la asistencia hacer el calculo
                    if (listaMPrestamo[i].CodigoLibro == listaMLibro[j].Codigo)
                    {
                        //para llenar la vista se obtienen datos del empleado y de la asistencia
                        listaTemp.NombreDelibro = listaMLibro[j].Titulo;
                    }
                }

                listaTemp.FechaDevolucion = listaMPrestamo[i].FechaDevolucion;
                listaMlista.Add(listaTemp);
                




            }
            dataGridView1.DataSource = listaMlista;
            dataGridView1.Refresh();

        }
    }
}
