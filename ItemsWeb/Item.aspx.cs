using ItemsWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace ItemsWeb
{
    public partial class Item : System.Web.UI.Page
    {
        Connection cn = new Connection();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddl_cats.DataSource = cn.Select("select id,category_nameEn+' | '+category_nameAr as catname from Categories", "AllCategories");
                ddl_cats.DataTextField = "catname";
                ddl_cats.DataValueField = "id";
                ddl_cats.DataBind();
            }
        }

        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            item_price1.Visible = true;
            item_price2.Visible = false;

            item_size1.Visible = false;
            item_size2.Visible = false;
        }

        protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            item_price1.Visible = true;
            item_price2.Visible = true;

            item_size1.Visible = true;
            item_size2.Visible = true;

        }
    }
}