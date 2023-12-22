using System;

namespace Cookies
{
    public partial class cookies : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Cookies: Increment the counter using cookies
                if (Request.Cookies["CounterCookie"] != null)
                {
                    int counter = Convert.ToInt32(Request.Cookies["CounterCookie"].Value);
                    counter++;
                    Response.Cookies["CounterCookie"].Value = counter.ToString();
                }
                else
                {
                    int counter = 1;
                    Response.Cookies["CounterCookie"].Value = counter.ToString();
                }

                lblCookieCounter.Text = "Cookie Counter: " + Request.Cookies["CounterCookie"].Value;

                // Application State: Maintain a count of the total number of visits
                if (Application["VisitCount"] == null)
                {
                    Application["VisitCount"] = 1;
                }
                else
                {
                    int visitCount = Convert.ToInt32(Application["VisitCount"]);
                    visitCount++;
                    Application["VisitCount"] = visitCount;
                }

                lblApplicationState.Text = "Total Visits (Application State): " + Application["VisitCount"];
            }
        }
    }
}
