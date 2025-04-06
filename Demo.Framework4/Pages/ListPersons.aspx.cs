using Demo.Framework4.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Demo.Framework4.Pages
{
    public partial class ListPersons : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Bind the data only on the initial page load, not on postbacks
            if (!IsPostBack)
            {
                BindPersonList();
            }
        }

        private void BindPersonList()
        {
            PersonService personService = new PersonService();

            List<Person> personList = personService.GenerateListOfPersons();
            gvPersons.DataSource = personList;
            gvPersons.DataBind(); // This method triggers the display of data
            ViewState["Persons"] = personList;
        }

        protected void gvPersons_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "edit")
            {
                int rowidx = -1;
                int.TryParse(e.CommandArgument as string, out rowidx);
                var list = ViewState["Persons"] as List<Person>;
                var personne = list[rowidx];
                Session["to_edit"] = personne;
                Response.Redirect("~/pages/createperson.aspx");
            }
        }
    }
} 