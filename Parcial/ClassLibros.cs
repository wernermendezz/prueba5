using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial
{
    class ClassLibros
    {
        string Codigo;
        string Titulo;
        string Autor;
        DateTime AñoP;

        public string Codigo1
        {
            get
            {
                return Codigo;
            }

            set
            {
                Codigo = value;
            }
        }

        public string Titulo1
        {
            get
            {
                return Titulo;
            }

            set
            {
                Titulo = value;
            }
        }

        public string Autor1
        {
            get
            {
                return Autor;
            }

            set
            {
                Autor = value;
            }
        }

        public DateTime AñoP1
        {
            get
            {
                return AñoP;
            }

            set
            {
                AñoP = value;
            }
        }
    }
}
