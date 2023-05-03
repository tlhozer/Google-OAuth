using Google.Apis.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static WebApplication1.Deneme;

namespace WebApplication2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)

                    if (Request.QueryString["code"] != null)
                    {
                        var code = Request.QueryString["code"].ToString();

                        var credential = GoogleHelper.GetUserCredential(code);
                        var service = new Google.Apis.Oauth2.v2.Oauth2Service(new BaseClientService.Initializer
                        {
                            HttpClientInitializer = credential,
                            ApplicationName = "Google Authentication"
                        });

                        var userInfo = service.Userinfo.Get().Execute();

                        string email = userInfo.Email;
                        string name = userInfo.Name;

                        TextBox1.Text = email;
                        TextBox2.Text = name;


                    }
            }



            catch
            {
                Response.Write(string.Empty);
                TextBox1.Text = string.Empty;
                TextBox2.Text = string.Empty;
                Response.Redirect("https://localhost:44353/WebForm1.aspx");

            }


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string loginUrl2 = GoogleHelper.GetGoogleLoginUrl();
            Response.Redirect(loginUrl2);
        }
    }
}
