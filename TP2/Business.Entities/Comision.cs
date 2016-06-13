using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    class Comision : BusinessEntity
    {
        private int _AñoEspecialidad;
        public int AñoEspecialidad
        {
            get { return _AñoEspecialidad; }
            set { _AñoEspecialidad = value; }
        }
        private string _Descripcion;
        public string Descripcion
        {
            get { return _Descripcion; }
            set { _Descripcion = value; }
        }
        private int _IDPlan;
        public int IDPlan
        {
            get { return _IDPlan; }
            set { _IDPlan= value; }
        }
       
    }
}
