using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PresidentialLiving
{
    public partial class MtVernon : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (User.Identity.IsAuthenticated)
            {
                admincontrols.Visible = true;
            }
            else
            {
                admincontrols.Visible = false;
            }

            DataLayer dl = new DataLayer();
            contents.InnerHtml = dl.Variables.Single(x => x.Name == "mtvernon").Value;
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            Response.Redirect("EditPage.aspx?df=MtVernon", true);
        }
    }
}