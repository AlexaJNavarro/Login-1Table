using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Data.Sql;
using Entity;
using Data;
using Domain;
using Presentation.Models;

namespace Presentation
{
    public partial class _Default : Page
    {
        E_Roles e_roles = new E_Roles();
        Do_Roles do_roles = new Do_Roles();

        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Redirect("~/Default.aspx", true);

        }

        protected void btnsubmit_Click(object sender, EventArgs e)
        {
            
        }

        protected void btnadd_Click(object sender, EventArgs e)
        {
            //e_roles.name = txtname.Text;
            //string message = do_roles.Do_AddRoles(e_roles);
            using (DB_WEBFORMEntities db = new DB_WEBFORMEntities()) {
                db.ADD_ROLES(txtname.Text);
                db.SaveChanges();
            }
        }

        protected void btnupdate_Click(object sender, EventArgs e)
        {
            using (DB_WEBFORMEntities db = new DB_WEBFORMEntities())
            {
                db.UPDATE_ROLES(Convert.ToInt32(txtid.Text),txtname.Text);
                db.SaveChanges();
            }
        }

        protected void btndelete_Click(object sender, EventArgs e)
        {
            using (DB_WEBFORMEntities db = new DB_WEBFORMEntities())
            {
                db.DELETE_ROLES(txtname.Text);
                db.SaveChanges();
            }
        }
    }
}