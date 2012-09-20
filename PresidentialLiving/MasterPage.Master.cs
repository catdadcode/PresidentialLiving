using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PresidentialLiving
{
    public partial class MasterPage : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.Page.Title += " | PresidentialLiving.com";
            this.Page.MaintainScrollPositionOnPostBack = true;

            if (!this.IsPostBack)
            {
                if (Request.Cookies["visited"] == null)
                {
                    DrawFlashIntro();
                    Response.Cookies["visited"].Value = "visited";
                    Response.Cookies["visited"].Expires = DateTime.Now.AddYears(1);
                    lbtnVideoReplay.Visible = false;
                }
                else
                {
                    DrawFlashNav();
                    lbtnVideoReplay.Visible = true;
                }

                if (Page.User.Identity.IsAuthenticated)
                {
                    loggedincontrols.Visible = true;
                    logincontrols.Visible = false;
                    loginviewer.Visible = true;
                }
                else
                {
                    loggedincontrols.Visible = false;
                    logincontrols.Visible = true;
                    loginviewer.Visible = false;
                }
            }
        }

        protected void btnShowLogin_Click(object sender, ImageClickEventArgs e)
        {
            if (loginviewer.Visible == false)
            {
                loginviewer.Visible = true;
            }
            else
            {
                loginviewer.Visible = false;
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            DataLayer dl = new DataLayer();

            if (tbxUsername.Text.ToUpper() == "ADMIN")
            {
                string sPassword = dl.Variables.Single(x => x.Name == "password").Value;
                if (tbxPassword.Text == sPassword)
                {
                    FormsAuthentication.SetAuthCookie("Admin", false);
                    Response.Redirect(Request.RawUrl);
                }
            }
        }

        protected void lbtnVideoReplay_Click(object sender, EventArgs e)
        {
            Response.Cookies["visited"].Expires = DateTime.Now.AddDays(-1);
            Response.Redirect(Request.RawUrl, true);
        }

        protected void DrawFlashIntro()
        {
            flashbox.InnerHtml = "<object width=\"900\" height=\"200\"><param name=\"movie\" value=\"flash/homepage.swf\"><param name=\"wmode\" value=\"transparent\" /><embed src=\"flash/homepage.swf\" wmode=\"transparent\" width=\"900\" height=\"200\"></embed></object>";
        }

        protected void DrawFlashNav()
        {
            flashbox.InnerHtml = "<object width=\"900\" height=\"200\"><param name=\"movie\" value=\"flash/homepage2.swf\"><param name=\"wmode\" value=\"transparent\" /><embed src=\"flash/homepage2.swf\" wmode=\"transparent\" width=\"900\" height=\"200\"></embed></object>";
        }
    }
}