using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Data.Database;

namespace Business.Logic
{
    public class InscripcionLogic
    {
        public List<Materia> getMaterias(int plan)
        {
            List<Materia> materias = new MateriaAdapter().GetAll();
            int index = 0;
            foreach (Materia m in materias)
            {
                if (m.IDPlan != plan)
                {
                    materias.RemoveAt(index);
                }
                index++;
            }
            return materias;
        }
        public List<Comision> getComisiones(int plan)
        {
            List<Comision> comisiones = new ComisionAdapter().GetAll();
            int index = 0;
            foreach (Comision c in comisiones)
            {
                if (c.IDPlan != plan)
                {
                    comisiones.RemoveAt(index);
                }
                index++;
            }
            return comisiones;
        }
        public List<Curso> getCursos(int idComision, int idMateria)
        {
            List<Curso> cursos = new CursoAdapter().GetAll();
            int index = 0;
            foreach (Curso c in cursos)
            {
                if (c.IDComision != idComision || c.IDMateria != idMateria)
                {
                    cursos.RemoveAt(index);
                }
                index++;
            }
            return cursos;
        }
        public void creaInscripcion(AlumnoInscripcion ai)
        {
            new AlumnoInscripcionAdapter().Save(ai);
        }
    }
}
