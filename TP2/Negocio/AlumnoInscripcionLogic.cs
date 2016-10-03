using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Data.Database;

namespace Business.Logic
{
    public class AlumnoInscripcionLogic
    {
        AlumnoInscripcionAdapter AlumnoInscripcionData;
        public AlumnoInscripcionLogic()
        {
            AlumnoInscripcionData = new AlumnoInscripcionAdapter();
        }
        public List<AlumnoInscripcion> GetAll()
        {
            return AlumnoInscripcionData.GetAll();
        }
        public AlumnoInscripcion GetOne(int ID)
        {
            return AlumnoInscripcionData.GetOne(ID);
        }
        public void Save(AlumnoInscripcion ai)
        {
            AlumnoInscripcionData.Save(ai);
        }
        public void Delete(int ID)
        {
            AlumnoInscripcionData.Delete(ID);
        }
    }
}
