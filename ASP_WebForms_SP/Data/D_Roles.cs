using System;
using System.Collections.Generic;
using System.Text;

using System.Data;
using System.Data.SqlClient;
using Entity;
namespace Data
{
    public class D_Roles
    {
        D_Connection cn = new D_Connection();

        public string D_AddRoles(E_Roles e_roles) {
            cn.Connection.Open();
            String message = "";

            using (SqlTransaction tr = cn.Connection.BeginTransaction(IsolationLevel.Serializable)){
                SqlCommand cmd = new SqlCommand("ADD_ROLES", cn.Connection, tr);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@NAME", e_roles.name);

                try
                {
                    int num = cmd.ExecuteNonQuery();
                    tr.Commit();
                    message = num.ToString() + "Rol Registrado";
                }
                catch (SqlException ex)
                {
                    tr.Rollback();
                    message = ex.Message;
                }
                finally 
                {
                    cn.Connection.Close();
                }
            }

            return message;
        }

        public string D_UpdateRoles(E_Roles e_roles)
        {
            cn.Connection.Open();
            String message = "";

            using (SqlTransaction tr = cn.Connection.BeginTransaction(IsolationLevel.Serializable))
            {
                SqlCommand cmd = new SqlCommand("UPDATE_ROLES", cn.Connection, tr);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ID_R", e_roles.id);
                cmd.Parameters.AddWithValue("@NAME", e_roles.name);

                try
                {
                    int num = cmd.ExecuteNonQuery();
                    tr.Commit();
                    message = num.ToString() + "Rol Actualizado";
                }
                catch (SqlException ex)
                {
                    tr.Rollback();
                    message = ex.Message;
                }
                finally
                {
                    cn.Connection.Close();
                }
            }

            return message;
        }

        public string D_DeleteRoles(E_Roles e_roles)
        {
            cn.Connection.Open();
            String message = "";

            using (SqlTransaction tr = cn.Connection.BeginTransaction(IsolationLevel.Serializable))
            {
                SqlCommand cmd = new SqlCommand("DELETE_ROLES", cn.Connection, tr);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ID_R", e_roles.id);

                try
                {
                    int num = cmd.ExecuteNonQuery();
                    tr.Commit();
                    message = num.ToString() + "Rol Eliminado";
                }
                catch (SqlException ex)
                {
                    tr.Rollback();
                    message = ex.Message;
                }
                finally
                {
                    cn.Connection.Close();
                }
            }

            return message;
        }
    }
}
