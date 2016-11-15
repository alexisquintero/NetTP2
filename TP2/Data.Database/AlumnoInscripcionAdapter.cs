using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using System.Data;
using System.Data.SqlClient;

namespace Data.Database
{
    public class AlumnoInscripcionAdapter:Adapter
    {
        public List<AlumnoInscripcion> GetAll()
        {
            List<AlumnoInscripcion> alumnos = new List<AlumnoInscripcion>();
            try
            {
                this.OpenConnection();
                SqlCommand cmdAlumnos = new SqlCommand("SELECT * FROM alumnos_inscripciones", SqlConn);
                SqlDataReader drAlumnos = cmdAlumnos.ExecuteReader();
                while (drAlumnos.Read())
                {
                    AlumnoInscripcion ai = new AlumnoInscripcion();

                    ai.ID = (int)drAlumnos["id_inscripcion"];
                    ai.IDAlumno = (int)drAlumnos["id_alumno"];
                    ai.IDCurso = (int)drAlumnos["id_curso"];
                    ai.Condicion = (string)drAlumnos["condicion"];
                    ai.Nota = (int)drAlumnos["nota"];

                    alumnos.Add(ai);
                }
                drAlumnos.Close();
            }
            catch(Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar lista de inscripciones", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return alumnos;
        }

        public AlumnoInscripcion GetOne(int ID)
        {
            AlumnoInscripcion ai = new AlumnoInscripcion();
            try
            {
                this.OpenConnection();
                SqlCommand cmdAlumno = new SqlCommand("SELECT * FROM alumnos_inscripciones WHERE id_inscripcion = @id", SqlConn);
                cmdAlumno.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                SqlDataReader drAlumno = cmdAlumno.ExecuteReader();
                if (drAlumno.Read())
                {
                    ai.ID = (int)drAlumno["id_inscripcion"];
                    ai.IDAlumno = (int)drAlumno["id_alumno"];
                    ai.IDCurso = (int)drAlumno["id_curso"];
                    ai.Condicion = (string)drAlumno["condicion"];
                    ai.Nota = (int)drAlumno["nota"];
                }
                drAlumno.Close();
            }
            catch(Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar datos de inscripción", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return ai;
        }

        public void Delete(int ID)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdDelete = new SqlCommand("DELETE alumnos_inscripciones  WHERE id_inscripcion = @id", SqlConn);
                cmdDelete.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                cmdDelete.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al eliminar inscripción", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public void Update(AlumnoInscripcion ai)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdSave = new SqlCommand("UPDATE alumnos_inscripciones SET id_alumno = @id_a, " +
                    "id_curso = @id_c, condicion = @cond, nota = @not WHERE id_inscripcion = @id", SqlConn);
                cmdSave.Parameters.Add("@id", SqlDbType.Int).Value = ai.ID;
                cmdSave.Parameters.Add("@id_a", SqlDbType.Int).Value = ai.IDAlumno;
                cmdSave.Parameters.Add("@id_c", SqlDbType.Int).Value = ai.IDCurso;
                cmdSave.Parameters.Add("@cond", SqlDbType.VarChar, 50).Value = ai.Condicion;
                cmdSave.Parameters.Add("@nota", SqlDbType.Int).Value = ai.Nota;
                cmdSave.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al modificar datos de inscripción", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }
        

        public void Insert(AlumnoInscripcion ai)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdSave = new SqlCommand("INSERT INTO alumnos_inscripciones(id_alumno, " +
                    "id_curso, condicion, nota) VALUES (@id_a, @id_c, @cond, @nota) " +
                    "SELECT @@identity", SqlConn);
                cmdSave.Parameters.Add("@id_a", SqlDbType.Int).Value = ai.IDAlumno;
                cmdSave.Parameters.Add("@id_c", SqlDbType.Int).Value = ai.IDCurso;
                cmdSave.Parameters.Add("@cond", SqlDbType.VarChar, 50).Value = ai.Condicion;
                cmdSave.Parameters.Add("@nota", SqlDbType.Int).Value = ai.Nota;
                ai.ID = Decimal.ToInt32((decimal)cmdSave.ExecuteScalar());
            }
            catch(Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al crear inscripción", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public void Save(AlumnoInscripcion ai)
        {
            if (ai.State == BusinessEntity.States.Deleted)
            {
                this.Delete(ai.ID);
            }
            else if (ai.State == BusinessEntity.States.New)
            {
                this.Insert(ai);
            }
            else if (ai.State == BusinessEntity.States.Modified)
            {
                this.Update(ai);
            }
            ai.State = BusinessEntity.States.Unmodified;
        }
    }
}
