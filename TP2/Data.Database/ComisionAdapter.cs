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
    public class ComisionAdapter:Adapter
    {
        public List<Comision> GetAll()
        {
            List<Comision> comisiones = new List<Comision>();
            try
            {
                this.OpenConnection();
                SqlCommand cmdComisiones = new SqlCommand("SELECT * FROM comisiones", SqlConn);
                SqlDataReader drComisiones = cmdComisiones.ExecuteReader();
                while (drComisiones.Read())
                {
                    Comision com = new Comision();
                    com.ID = (int)drComisiones["id_comision"];
                    com.AnioEspecialidad = (int)drComisiones["anio_especialidad"];
                    com.Descripcion = (string)drComisiones["desc_comision"];
                    com.IDPlan = (int)drComisiones["id_plan"];

                    comisiones.Add(com);
                }
                drComisiones.Close();
            }
            catch(Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error ak recuperar lista de comisiones", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return comisiones;
        }

        public Comision GetOne(int ID)
        {
            Comision com = new Comision();
            try
            {
                this.OpenConnection();
                SqlCommand cmdComision = new SqlCommand("SELECT * FROM comisiones WHERE id_comision = @id", SqlConn);
                cmdComision.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                SqlDataReader drComision = cmdComision.ExecuteReader();
                if (drComision.Read())
                {
                    com.ID = (int)drComision["id_comision"];
                    com.IDPlan = (int)drComision["id_plan"];
                    com.AnioEspecialidad = (int)drComision["anio_especialidad"];
                    com.Descripcion = (string)drComision["desc_comision"];
                }
                drComision.Close();
            }
            catch(Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar datos de la comision", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return com;
        }

        public void Delete(int ID)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdDelete = new SqlCommand("DELETE comisiones WHERE id_comision = @id", SqlConn);
                cmdDelete.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                cmdDelete.ExecuteNonQuery();
            }
            catch(Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al eliminar la comision", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public void Update(Comision comision)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdSave = new SqlCommand("UPDATE comisiones SET anio_especialidad = @anio, " +
                    "desc_comision = @desc, id_plan = @id_pln WHERE id_comision = @id", SqlConn);
                cmdSave.Parameters.Add("@anio", SqlDbType.Int).Value = comision.AnioEspecialidad;
                cmdSave.Parameters.Add("@desc", SqlDbType.VarChar, 50).Value = comision.Descripcion;
                cmdSave.Parameters.Add("@id_pln", SqlDbType.Int).Value = comision.IDPlan;
                cmdSave.Parameters.Add("@id", SqlDbType.Int).Value = comision.ID;
                cmdSave.ExecuteNonQuery();
            }
            catch(Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al modificar datos de la comisión", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public void Insert(Comision comision)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdSave = new SqlCommand("INSERT INTO comisiones(anio_especialidad, " +
                    "desc_comision, id_plan) VALUES (@anio, @desc, @id_pln) " +
                    "SELECT @@identity", SqlConn);
                cmdSave.Parameters.Add("@anio", SqlDbType.Int).Value = comision.AnioEspecialidad;
                cmdSave.Parameters.Add("@desc", SqlDbType.VarChar, 50).Value = comision.Descripcion;
                cmdSave.Parameters.Add("@id_pln", SqlDbType.Int).Value = comision.IDPlan;
                comision.ID = Decimal.ToInt32((decimal)cmdSave.ExecuteScalar());
            }
            catch(Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al agregar comision", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }
        public void Save(Comision comision)
        {
            if (comision.State == BusinessEntity.States.Deleted)
            {
                this.Delete(comision.ID);
            }
            else if (comision.State == BusinessEntity.States.New)
            {
                this.Insert(comision);
            }
            else if (comision.State == BusinessEntity.States.Modified)
            {
                this.Update(comision);
            }
            comision.State = BusinessEntity.States.Unmodified;
        }
    }
}
