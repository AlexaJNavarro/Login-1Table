using System;
using System.Collections.Generic;
using System.Text;


using System.Data;
using Data;
using Entity;

namespace Domain
{
    public class Do_Roles
    {
        D_Roles d_roles = new D_Roles();

        private static void Validate(E_Roles e_roles)
        {
            if (String.IsNullOrEmpty(e_roles.name))
            {
                throw new ArgumentException("Nombre del rol vacio.");
            }
        }

        public String Do_AddRoles(E_Roles e_roles) 
        {
            try
            {
                Validate(e_roles);
                return d_roles.D_AddRoles(e_roles);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public String Do_UpdateRoles(E_Roles e_roles)
        {
            try
            {
                Validate(e_roles);
                return d_roles.D_UpdateRoles(e_roles);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public String Do_DeleteRoles(E_Roles e_roles)
        {
            try
            {
                Validate(e_roles);
                return d_roles.D_DeleteRoles(e_roles);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
