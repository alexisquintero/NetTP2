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
    class PersonasAdapter:Adapter
    {
        public List<Personas> GetAll()
        {
            List<Personas> personas = new List<Personas>();
            try
            {
                this.OpenConnection();
                SqlCommand cmdPersonas = new SqlCommand("SELECT * FROM personas", SqlConn);
                SqlDataReader drPersonas = cmdPersonas.ExecuteReader();
                while (drPersonas.Read())
                {
                    Personas p = new Personas();

                    p.ID = (int)drPersonas["id_persona"];
                    p.Nombre = (string)drPersonas["nombre"];
                    p.Apellido = (string)drPersonas["apellido"];
                    p.Direccion = (string)drPersonas["direccion"];
                    p.Email = (string)drPersonas["email"];
                    p.Telefono = (string)drPersonas["telefono"];
                    p.FechaNacimiento = (DateTime)drPersonas["fecha_nac"];
                    p.Legajo = (int)drPersonas["legajo"];
                    p.TipoPersona = (Personas.TiposPersonas)drPersonas["tipo_persona"];
                    p.IDPlan = (int)drPersonas["id_plan"];

                    personas.Add(p);
                }
                drPersonas.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar lista de personas", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return personas;
        }

        public Personas GetOne(int ID)
        {
            Personas p = new Personas();
            try
            {
                this.OpenConnection();
                SqlCommand cmdPersona = new SqlCommand("SELECT * FROM personas WHERE id_persona = @id", SqlConn);
                cmdPersona.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                SqlDataReader drPersona = cmdPersona.ExecuteReader();
                if (drPersona.Read())
                {
                    p.ID = (int)drPersona["id_persona"];
                    p.Nombre = (string)drPersona["nombre"];
                    p.Apellido = (string)drPersona["apellido"];
                    p.Direccion = (string)drPersona["direccion"];
                    p.Email = (string)drPersona["email"];
                    p.Telefono = (string)drPersona["telefono"];
                    p.FechaNacimiento = (DateTime)drPersona["fecha_nac"];
                    p.Legajo = (int)drPersona["legajo"];
                    p.TipoPersona = (Personas.TiposPersonas)drPersona["tipo_persona"];
                    p.IDPlan = (int)drPersona["id_plan"];
                }
                drPersona.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar datos de persona", Ex);
                throw ExcepcionManejada;

            }
            finally
            {
                this.CloseConnection();
            }
            return p;
        }

        public void Delete(int ID)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdDelete = new SqlCommand("DELETE personas WHERE id_persona=@id", SqlConn);
                cmdDelete.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                cmdDelete.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al eliminar persona", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public void Update(Personas p)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdSave = new SqlCommand("UPDATE personas SET nombre = @nom, apellido = @ape, " +
                    "direccion = @dir, email = @em, telefono = @tel, fecha_nac = @fec, legajo = @leg, " +
                    "tipo_persona = @tip, id_plan = @id_p WHERE id_persona = @id", SqlConn);
                cmdSave.Parameters.Add("@nom", SqlDbType.VarChar, 50).Value = p.Nombre;
                cmdSave.Parameters.Add("@ape", SqlDbType.VarChar, 50).Value = p.Apellido;
                cmdSave.Parameters.Add("@dir", SqlDbType.VarChar, 50).Value = p.Direccion;
                cmdSave.Parameters.Add("@em", SqlDbType.VarChar, 50).Value = p.Email;
                cmdSave.Parameters.Add("@tel", SqlDbType.VarChar, 50).Value = p.Telefono;
                cmdSave.Parameters.Add("@fec", SqlDbType.DateTime).Value = p.FechaNacimiento;
                cmdSave.Parameters.Add("@leg", SqlDbType.Int).Value = p.Legajo;
                cmdSave.Parameters.Add("@tip", SqlDbType.Int).Value = p.TipoPersona;
                cmdSave.Parameters.Add("@id_p", SqlDbType.Int).Value = p.IDPlan;
                cmdSave.Parameters.Add("@id", SqlDbType.Int).Value = p.ID;
                cmdSave.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al modificar datos de persona", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public void Insert(Personas p)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdSave = new SqlCommand("INSERT INTO personas(nombre, apellido, direccion, " +
                    "email, telefono, fecha_nac, legajo, tipo_persona, id_plan) VALUES (@nom, @ape, @dir, " +
                    "@em, @tel, @fec, @leg, @tip, @id_p) SELECT @@identity", SqlConn);
                cmdSave.Parameters.Add("@nom", SqlDbType.VarChar, 50).Value = p.Nombre;
                cmdSave.Parameters.Add("@ape", SqlDbType.VarChar, 50).Value = p.Apellido;
                cmdSave.Parameters.Add("@dir", SqlDbType.VarChar, 50).Value = p.Direccion;
                cmdSave.Parameters.Add("@em", SqlDbType.VarChar, 50).Value = p.Email;
                cmdSave.Parameters.Add("@tel", SqlDbType.VarChar, 50).Value = p.Telefono;
                cmdSave.Parameters.Add("@fec", SqlDbType.DateTime).Value = p.FechaNacimiento;
                cmdSave.Parameters.Add("@leg", SqlDbType.Int).Value = p.Legajo;
                cmdSave.Parameters.Add("@tip", SqlDbType.Int).Value = p.TipoPersona;
                cmdSave.Parameters.Add("@id_p", SqlDbType.Int).Value = p.IDPlan;
                p.ID = Decimal.ToInt32((decimal)cmdSave.ExecuteScalar());
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al crear persona", Ex);
                throw ExcepcionManejada;

            }
            finally
            {
                this.CloseConnection();
            }
        }

        public void Save(Personas p)
        {
            if (p.State == BusinessEntity.States.Deleted)
            {
                this.Delete(p.ID);
            }
            else if (p.State == BusinessEntity.States.New)
            {
                this.Insert(p);
            }
            else if (p.State == BusinessEntity.States.Modified)
            {
                this.Update(p);
            }
            p.State = BusinessEntity.States.Unmodified;
        }
    }
}
