using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    class AlumnoInscripcion : BusinessEntity
    {
        private string _Condicion;
        public string Condicion
        {
            get { return _Condicion; }
            set { _Condicion = value; }
        }
        private string _IDAlumno;
        public string IDAlumno
        {
            get { return _IDAlumno; }
            set { _IDAlumno = value; }
        }
        private string _IDCurso;
        public string IDCurso
        {
            get { return _IDCurso; }
            set { _IDCurso = value; }
        }
        private int _Nota;
        public int Nota
        {
            get { return _Nota; }
            set { _Nota = value; }
        }
        
    }
}
