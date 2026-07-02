using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto2
{
    partial class libro
    {
        protected string titulo;
        protected string autor;
        protected int paginas;

        public string Titulo
        {
            set { titulo = value; }
            get { return titulo; }
        }

        public string Autor
        {
            set { autor = value; }
            get { return autor; }
        }

        public int Paginas
        {
            set { paginas = value; }
            get { return paginas; }
        }
    }
}