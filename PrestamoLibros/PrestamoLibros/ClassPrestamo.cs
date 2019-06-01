using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrestamoLibros
{
    class ClassPrestamo
    {
        string carnetAlumno;
        string codigoLibro;
        DateTime fechaDevolucion;
        DateTime fechaPrestamo;

        public string CarnetAlumno
        {
            get
            {
                return carnetAlumno;
            }

            set
            {
                carnetAlumno = value;
            }
        }

        public string CodigoLibro
        {
            get
            {
                return codigoLibro;
            }

            set
            {
                codigoLibro = value;
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

        public DateTime FechaPrestamo
        {
            get
            {
                return fechaPrestamo;
            }

            set
            {
                fechaPrestamo = value;
            }
        }
    }
}
