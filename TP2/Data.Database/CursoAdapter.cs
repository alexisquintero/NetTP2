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
    class CursoAdapter:Adapter
    {
        public List<Curso> GetAll()
        {
            List<Curso> cursos = new List<Curso>();
            try
            {
                this.OpenConnection();
                SqlCommand cmdCursos = new SqlCommand("SELECT * FROM cursos", SqlConn);
                SqlDataReader drCursos = cmdCursos.ExecuteReader();
                while (drCursos.Read())
                {
                    Curso cur = new Curso();

                    cur.ID = (int)drCursos["id_curso"];
                    cur.IDMateria = (int)drCursos["id_materia"];
                    cur.IDComision = (int)drCursos["id_comision"];
                    cur.AñoCalendario = (int)drCursos["anio_calendario"];
                    cur.Cupo = (int)drCursos["cupo"];

                    cursos.Add(cur);
                }
                drCursos.Close();
            }
            catch(Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar lista de cursos", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return cursos;
        }

        public Curso GetOne(int ID)
        {
            Curso cur = new Curso();
            try
            {
                SqlCommand cmdCurso = new SqlCommand("SELECT * FROM cursos WHERE id_curso = @id", SqlConn);
                cmdCurso.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                SqlDataReader drCurso = cmdCurso.ExecuteReader();
                if (drCurso.Read())
                {
                    cur.ID = (int)drCurso["id_curso"];
                    cur.IDMateria = (int)drCurso["id_materia"];
                    cur.IDComision = (int)drCurso["id_comision"];
                    cur.AñoCalendario = (int)drCurso["anio_calendario"];
                    cur.Cupo = (int)drCurso["cupo"];
                }
                drCurso.Close();
            }
            catch(Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar datos de curso", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return cur;
        }

        public void Delete(int ID)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdDelete = new SqlCommand("DELETE cursos WHERE id_curso = @id", SqlConn);
                cmdDelete.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                cmdDelete.ExecuteNonQuery();
            }
            catch(Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al eliminar cruso", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public void Update(Curso curso)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdSave = new SqlCommand("UPDATE cursos SET id_materia = @id_mat, " +
                    "id_comision = @id_com, anio_calendario = @anio, cupo = @cup " +
                    "WHERE id_curso = @id", SqlConn);
                cmdSave.Parameters.Add("@id_mat", SqlDbType.Int).Value = curso.IDMateria;
                cmdSave.Parameters.Add("@id_com", SqlDbType.Int).Value = curso.IDComision;
                cmdSave.Parameters.Add("@anio", SqlDbType.Int).Value = curso.AñoCalendario;
                cmdSave.Parameters.Add("@cup", SqlDbType.Int).Value = curso.Cupo;
                cmdSave.Parameters.Add("@id", SqlDbType.Int).Value = curso.ID;
                cmdSave.ExecuteNonQuery();
            }
            catch(Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al modificar datos de curso", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public void Insert(Curso curso)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdSave = new SqlCommand("INSERT INTO curso(id_materia, id_comision, " +
                    "anio_calendario, cupo) VALUES (@id_mat, @id_com, @anio, @cup) " +
                    "SELECT @identity", SqlConn);
                cmdSave.Parameters.Add("@id_mat", SqlDbType.Int).Value = curso.IDMateria;
                cmdSave.Parameters.Add("@id_com", SqlDbType.Int).Value = curso.IDComision;
                cmdSave.Parameters.Add("@anio", SqlDbType.Int).Value = curso.AñoCalendario;
                cmdSave.Parameters.Add("@cup", SqlDbType.Int).Value = curso.Cupo;             
                curso.ID = Decimal.ToInt32((decimal)cmdSave.ExecuteScalar());
            }
            catch(Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al crear curso", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public void Save(Curso  curso)
        {
            if (curso.State == BusinessEntity.States.Deleted)
            {
                this.Delete(curso.ID);
            }
            else if (curso.State == BusinessEntity.States.New)
            {
                this.Insert(curso);
            }
            else if (curso.State == BusinessEntity.States.Modified)
            {
                this.Update(curso);
            }
            curso.State = BusinessEntity.States.Unmodified;
        }
    }
}
