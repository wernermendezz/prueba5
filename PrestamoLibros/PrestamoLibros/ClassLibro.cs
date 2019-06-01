using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrestamoLibros
{
    class ClassLibro
    {
        string titulo;
        string codigo;
        string autor;
        string fechapublicacion;

        public string Titulo
        {
            get
            {
                return titulo;
            }

            set
            {
                titulo = value;
            }
        }

        public string Codigo
        {
            get
            {
                return codigo;
            }

            set
            {
                codigo = value;
            }
        }

        public string Autor
        {
            get
            {
                return autor;
            }

            set
            {
                autor = value;
            }
        }

        public string Fechapublicacion
        {
            get
            {
                return fechapublicacion;
            }

            set
            {
                fechapublicacion = value;
            }
        }
    }
}
