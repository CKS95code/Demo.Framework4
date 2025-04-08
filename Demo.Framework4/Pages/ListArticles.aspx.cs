using Demo.Framework4.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Demo.Framework4.Pages
{
    public partial class ListArticles : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindList();
            }
        }

        private void BindList()
        {
            ArticleService articleService = new ArticleService();

            List<Article> data = articleService.GetListOfArticles();
            gvPersons.DataSource = data;
            gvPersons.DataBind(); 
            ViewState["articles"] = data;
        }

        protected void gvPersons_RowCommand(object sender, GridViewCommandEventArgs e)
        {

        }
    }
}