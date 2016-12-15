using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;

namespace Util
{
    public class ControlAccesoWeb
    {
        public static bool controlAlumnos(Personas.TiposPersonas tipo)   
        {
            return (tipo == Personas.TiposPersonas.Alumno || tipo == Personas.TiposPersonas.Administrativo);
        }
        public static bool controlComisiones(Personas.TiposPersonas tipo)
        {
            return (tipo == Personas.TiposPersonas.Docente || tipo == Personas.TiposPersonas.Administrativo);
        }
        public static bool controlCursos(Personas.TiposPersonas tipo)
        {
            return (tipo == Personas.TiposPersonas.Docente || tipo == Personas.TiposPersonas.Administrativo);
        }
        public static bool controlEspecialidades(Personas.TiposPersonas tipo)
        {
            return (tipo == Personas.TiposPersonas.Administrativo);
        }
        public static bool controlMaterias(Personas.TiposPersonas tipo)
        {
            return (tipo == Personas.TiposPersonas.Alumno || tipo == Personas.TiposPersonas.Administrativo);
        }
        public static bool controlPlanes(Personas.TiposPersonas tipo)
        {
            return (tipo == Personas.TiposPersonas.Administrativo);
        }
        public static bool controlProfesores(Personas.TiposPersonas tipo)
        {
            return (tipo == Personas.TiposPersonas.Administrativo);
        }
        public static bool controlUsuarios(Personas.TiposPersonas tipo)
        {
            return (tipo == Personas.TiposPersonas.Administrativo);
        }
    }
}
