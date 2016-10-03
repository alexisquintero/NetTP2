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
    public class ModuloUsuarioAdapter:Adapter
    {
        public List<ModuloUsuario> GetAll()
        {
            List<ModuloUsuario> modulosUsuarios = new List<ModuloUsuario>();
            try
            {
                this.OpenConnection();
                SqlCommand cmdModulosUsuarios = new SqlCommand("SELECT * FROM modulos_usuarios", SqlConn);
                SqlDataReader drModulosUsuarios = cmdModulosUsuarios.ExecuteReader();
                while (drModulosUsuarios.Read())
                {
                    ModuloUsuario mu = new ModuloUsuario();

                    mu.ID = (int)drModulosUsuarios["id_modulo_usuario"];
                    mu.IDModulo = (int)drModulosUsuarios["id_modulo"];
                    mu.IDUsuario = (int)drModulosUsuarios["id_usuario"];
                    mu.permiteAlta = (bool)drModulosUsuarios["alta"];
                    mu.permiteBaja = (bool)drModulosUsuarios["baja"];
                    mu.permiteConsulta = (bool)drModulosUsuarios["consulta"];
                    mu.permiteModificacion = (bool)drModulosUsuarios["modificacion"];

                    modulosUsuarios.Add(mu);
                }
                drModulosUsuarios.Close();
            }
            catch(Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar lista de ModulosUsuarios", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return modulosUsuarios;
        }

        public ModuloUsuario GetOne(int ID)
        {
            ModuloUsuario mu = new ModuloUsuario();
            try
            {
                this.OpenConnection();
                SqlCommand cmdModuloUsuario = new SqlCommand("SELECT * FROM modulos_usuarios WHERE " +
                    "id_modulo_usuario = @id", SqlConn);
                cmdModuloUsuario.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                SqlDataReader drModuloUsuario = cmdModuloUsuario.ExecuteReader();
                if (drModuloUsuario.Read())
                {
                    mu.ID = (int)drModuloUsuario["id_modulo_usuario"];
                    mu.IDModulo = (int)drModuloUsuario["id_modulo"];
                    mu.IDUsuario = (int)drModuloUsuario["id_usuario"];
                    mu.permiteAlta = (bool)drModuloUsuario["alta"];
                    mu.permiteBaja = (bool)drModuloUsuario["baja"];
                    mu.permiteConsulta = (bool)drModuloUsuario["consulta"];
                    mu.permiteModificacion = (bool)drModuloUsuario["modificacion"];
                }
                drModuloUsuario.Close();
            }
            catch(Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar datos de usuario", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return mu;
        }

        public void Delete(int ID)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdDelete = new SqlCommand("DELETE modulos_usuarios WHERE id_modulos_usuarios = @id", SqlConn);
                cmdDelete.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                cmdDelete.ExecuteNonQuery();
            }
            catch(Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al eliminar ModuloUsuario", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public void Update(ModuloUsuario mu)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdSave = new SqlCommand("UPDATE modulos_usuarios SET id_modulo = @id_m, " +
                    "id_usuario = @id_u, alta = @alt, baja = @baj, modificacion = @mod, consulta = @con " +
                    "WHERE id_modulo_usuario = @id", SqlConn);
                cmdSave.Parameters.Add("@id_m", SqlDbType.Int).Value = mu.IDModulo;
                cmdSave.Parameters.Add("@id_u", SqlDbType.Int).Value = mu.IDUsuario;
                cmdSave.Parameters.Add("@alt", SqlDbType.Bit).Value = mu.permiteAlta;
                cmdSave.Parameters.Add("@baj", SqlDbType.Bit).Value = mu.permiteBaja;
                cmdSave.Parameters.Add("@mod", SqlDbType.Bit).Value = mu.permiteModificacion;
                cmdSave.Parameters.Add("@con", SqlDbType.Bit).Value = mu.permiteConsulta;
                cmdSave.Parameters.Add("@id", SqlDbType.Int).Value = mu.ID;
                cmdSave.ExecuteNonQuery();
            }
            catch(Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al modificar datos de ModuloUsuario", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public void Insert(ModuloUsuario mu)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdSave = new SqlCommand("INSERT INTO modulos_usuarios(id_modulo, id_usuario, " +
                    "alta, baja, modificacion, consulta)  VALUES (@id_m, @id_u, @alt, @baj, @mod, @con) " +
                    "SELECT @@identity", SqlConn);
                cmdSave.Parameters.Add("@id_m", SqlDbType.Int).Value = mu.IDModulo;
                cmdSave.Parameters.Add("@id_u", SqlDbType.Int).Value = mu.IDUsuario;
                cmdSave.Parameters.Add("@alt", SqlDbType.Bit).Value = mu.permiteAlta;
                cmdSave.Parameters.Add("@baj", SqlDbType.Bit).Value = mu.permiteBaja;
                cmdSave.Parameters.Add("@mod", SqlDbType.Bit).Value = mu.permiteModificacion;
                cmdSave.Parameters.Add("@con", SqlDbType.Bit).Value = mu.permiteConsulta;
                mu.ID = Decimal.ToInt32((decimal)cmdSave.ExecuteScalar());
            }
            catch(Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al crear ModuloUsuario", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public void Save(ModuloUsuario mu)
        {
            if (mu.State == BusinessEntity.States.Deleted)
            {
                this.Delete(mu.ID);
            }
            else if (mu.State == BusinessEntity.States.New)
            {
                this.Insert(mu);
            }
            else if (mu.State == BusinessEntity.States.Modified)
            {
                this.Update(mu);
            }
            mu.State = BusinessEntity.States.Unmodified;
        }
    }
}
