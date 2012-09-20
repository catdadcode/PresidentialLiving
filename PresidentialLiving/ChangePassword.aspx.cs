using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PresidentialLiving
{
    public partial class ChangePassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!User.Identity.IsAuthenticated)
            {
                Response.Redirect("Default.aspx", true);
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            DataLayer dl = new DataLayer();
            var passwordVariable = dl.Variables.Single(x => x.Name == "password");
            string sOldPassword = passwordVariable.Value;
            if (tbxOldPassword.Text == sOldPassword)
            {
                passwordVariable.Value = tbxPassword.Text;
                dl.SaveChanges();
            }
            else
            {
                CustomValidator1.IsValid = false;
            }
        }
    }
}