using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrestamoLibros
{
    class ClassEstudiante
    {
        string carnet;
        string nombre;

        public string Carnet
        {
            get
            {
                return carnet;
            }

            set
            {
                carnet = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }
    }
}
