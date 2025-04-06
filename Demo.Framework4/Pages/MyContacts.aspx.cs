using Demo.Framework4.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Demo.Framework4.Pages
{
    public partial class MyContacts : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BindData();
        }

        private void BindData()
        {
            var data = Session["mycontacts"] as List<Person>;

            gvPersons.DataSource = data;
            gvPersons.DataBind();
        }

        protected void gvPersons_RowCommand(object sender, GridViewCommandEventArgs e)
        {

        }
    }
}