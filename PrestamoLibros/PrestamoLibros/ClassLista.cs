using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrestamoLibros
{
    class ClassLista
    {
        string nombreEstudiante;
        string nombreDelibro;
        DateTime fechaDevolucion;

        public string NombreEstudiante
        {
            get
            {
                return nombreEstudiante;
            }

            set
            {
                nombreEstudiante = value;
            }
        }

        public string NombreDelibro
        {
            get
            {
                return nombreDelibro;
            }

            set
            {
                nombreDelibro = value;
            }
        }

        public DateTime FechaDevolucion
        {
            get
            {
                return fechaDevolucion;
            }

            set
            {
                fechaDevolucion = value;
            }
        }
    }
}
