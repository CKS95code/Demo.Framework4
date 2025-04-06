using Demo.Framework4.Core;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Demo.Framework4.Pages
{
    public partial class CreatePerson : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var perso = Session["to_edit"] as Person;
                txtFirstName.Text = perso.FirstName;
                txtLastName.Text = perso.LastName;
                txtEmail.Text = perso.Email;

                lblMessage.Text = string.Empty;
            }
        }

        protected void btnCreate_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                try
                {
                    var perso = Session["to_edit"] as Person;
                    if (perso == null)
                        perso = new Person();

                    perso.FirstName = txtFirstName.Text.Trim();
                    perso.LastName = txtLastName.Text.Trim();
                    perso.Email = txtEmail.Text.Trim();

                    Session["to_edit"] = null;

                    var listcontacts = Session["mycontacts"] as List<Person>;
                    if (listcontacts == null)
                        listcontacts = new List<Person>();

                    listcontacts.Add(perso);
                    Session["mycontacts"] = listcontacts;

                    lblMessage.Text = $"Successfully created person: {perso.FirstName} {perso.LastName}";
                    lblMessage.CssClass = "message success"; // Use CSS classes for styling

                    // Optional: Clear the form after successful submission
                    ClearForm();

                }
                catch (Exception ex)
                {
                    // Handle potential errors during processing
                    lblMessage.Text = "An error occurred while creating the person. Details: " + ex.Message;
                    lblMessage.CssClass = "message error";
                    lblMessage.ForeColor = Color.Red;


                }
            }
            else
            {
                // Validation failed, provide general feedback (validators show specific errors)
                lblMessage.Text = "Please correct the errors highlighted below.";
                lblMessage.CssClass = "message error";
                // lblMessage.ForeColor = Color.Red;
            }
        }

        private void ClearForm()
        {
            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtEmail.Text = string.Empty;
        }

    }
}