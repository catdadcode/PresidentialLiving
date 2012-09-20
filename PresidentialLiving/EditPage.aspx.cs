using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PresidentialLiving
{
    public partial class EditPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CKFinder.FileBrowser fileBrowser = new CKFinder.FileBrowser();
            fileBrowser.BasePath = "/ckfinder/";
            fileBrowser.SetupCKEditor(rteBody);

            DataLayer dl = new DataLayer();

            if (!User.Identity.IsAuthenticated)
            {
                Response.Redirect("Default.aspx", true);
            }

            if (Request.QueryString["df"] == null)
            {
                Response.Redirect("Default.aspx", true);
            }
            else
            {
                if (!this.IsPostBack)
                {
                    string sDataFile = Request.QueryString["df"];
                    rteBody.Text = dl.Variables.Single(x => x.Name == sDataFile).Value;
                }
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            DataLayer dl = new DataLayer();
            string sDataFile = Request.QueryString["df"];
            var pageVariable = dl.Variables.Single(x => x.Name == sDataFile);
            pageVariable.Value = rteBody.Text;
            dl.SaveChanges();
            Response.Redirect(sDataFile + ".aspx", true);
        }
    }
}