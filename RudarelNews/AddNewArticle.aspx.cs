using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RudarelNews
{
    public partial class AddNewArticle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string selectedValue = ddImage.SelectedValue;
            ShowImages();
            ddImage.SelectedValue = selectedValue;
        }

        private void ShowImages()
        {
            string[] images = System.IO.Directory.GetFiles(Server.MapPath("~/Images/RudarelNews"));
            System.Collections.ArrayList imageList = new System.Collections.ArrayList();

            foreach(string image in images)
            {
                string imageName = image.Substring(image.LastIndexOf(@"\") + 1);
                imageList.Add(imageName);
            }

            ddImage.DataSource = imageList;
            ddImage.DataBind();

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}