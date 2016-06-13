using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    class ModuloUsuario : BusinessEntity
    {
        private int _IDModulo;
        public int IDModulo
        {
            get { return _IDModulo; }
            set { _IDModulo = value; }
        }

        private int _IDUsuario;
        public int IDUsuario
        {
            get { return _IDUsuario; }
            set { _IDUsuario = value; }
        }
    }
}
