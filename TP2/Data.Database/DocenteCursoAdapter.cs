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
    class DocenteCursoAdapter:Adapter
    {
        public List<DocenteCurso> GetAll()
        {
            List<DocenteCurso> docentes = new List<DocenteCurso>();
            try
            {
                this.OpenConnection();
                SqlCommand cmdDocentes = new SqlCommand("SELECT * FROM docentes_cursos", SqlConn);
                SqlDataReader drDocentes = cmdDocentes.ExecuteReader();
                while (drDocentes.Read())
                {
                    DocenteCurso dc = new DocenteCurso();

                    dc.IDDocente = (int)drDocentes["id_docente"];
                    dc.IDCurso = (int)drDocentes["id_curso"];
                    dc.ID = (int)drDocentes["id_dictado"];
                    //dc.Cargo =

                    docentes.Add(dc);
                }
                drDocentes.Close();
            }
            catch(Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar lista de dictados", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return docentes;
        }

        public DocenteCurso GetOne(int ID)
        {
            DocenteCurso dc = new DocenteCurso();
            try
            {
                this.OpenConnection();
                SqlCommand cmdDocente = new SqlCommand("SELECT * FROM docentes_cursos WHERE id_dictado = @id", SqlConn);
                cmdDocente.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                SqlDataReader drDocente = cmdDocente.ExecuteReader();
                if (drDocente.Read())
                {
                    dc.IDDocente = (int)drDocente["id_docente"];
                    dc.IDCurso = (int)drDocente["id_curso"];
                    dc.ID = (int)drDocente["id_dictado"];
                    //dc.Cargo =
                }
                drDocente.Close();
            }
            catch(Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar datos de dictado", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return dc;
        }

        public void Delete(int ID)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdDelete = new SqlCommand("DELETE docentes_cursos WHERE id_dictado = @id", SqlConn);
                cmdDelete.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                cmdDelete.ExecuteNonQuery();
            }
            catch(Exception Ex)
            {
                Exception ExceptionManejada = new Exception("Error al eliminar dictado", Ex);
                throw ExceptionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public void Update(DocenteCurso dc)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdSave = new SqlCommand("UPDATE docentes_cursos SET id_curso = @id_c, " +
                    "id_docente = @id_d WHERE id_dictado = @id"); //cargo = @car
                cmdSave.Parameters.Add("@id_c", SqlDbType.Int).Value = dc.IDCurso;
                cmdSave.Parameters.Add("@id_d", SqlDbType.Int).Value = dc.IDDocente;
                //cmdSave.Parameters.Add("@car", SqlDbType.Int).Value = dc.Cargo;
                cmdSave.Parameters.Add("@id", SqlDbType.Int).Value = dc.ID;
                cmdSave.ExecuteNonQuery();
            }
            catch(Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al modificar datos de dictado", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public void Insert(DocenteCurso dc)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdSave = new SqlCommand("INSERT INTO docentes_cursos(id_curso, id_docente) " + //, cargo
                    "VALUES (@id_c, @id_d) SELECT @@identity", SqlConn); // , @car
                cmdSave.Parameters.Add("@id_c", SqlDbType.Int).Value = dc.IDCurso;
                cmdSave.Parameters.Add("@id_d", SqlDbType.Int).Value = dc.IDDocente;
                //cmdSave.Parameters.Add("@car", SqlDbType.Int).Value = dc.Cargo;
                dc.ID = Decimal.ToInt32((decimal)cmdSave.ExecuteScalar());
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al crear dictado", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public void Save(DocenteCurso dc)
        {
            if (dc.State == BusinessEntity.States.Deleted)
            {
                this.Delete(dc.ID);
            }
            else if (dc.State == BusinessEntity.States.New)
            {
                this.Insert(dc);
            }
            else if (dc.State == BusinessEntity.States.Modified)
            {
                this.Update(dc);
            }
            dc.State = BusinessEntity.States.Unmodified;
        }
    }
}
