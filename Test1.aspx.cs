using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace test
{
    public partial class Test1 : System.Web.UI.Page
    {

        public Panel ItemPanel;
        public Label ProductPrice;

        protected void Page_Load(object sender, EventArgs e)
        {
            this.BindGrid();
            this.GenerateList();
            this.GenerateDetail();
        }

        protected void Menu1_MenuItemClick(object sender, MenuEventArgs e)
        {
                int index = Int32.Parse(e.Item.Value);
                Multiview1.ActiveViewIndex = index;
        }

        private void BindGrid()
        {
            using (DataSet ds = new DataSet())
            {
                ds.ReadXml(Server.MapPath("~/XML/List.xml"));
                //GridView1.DataSource = ds;
                //GridView1.DataBind();
            }
        }


        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {

        }

        protected void GenerateList()
        {
            Panel myPanel = new Panel();

            
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(Server.MapPath("~/XML/List.xml"));



            XmlNodeList elemList = xmlDoc.GetElementsByTagName("Product");
            //XmlNodeList detailElemList = detailDoc.GetElementsByTagName("Specs");

            int index = 0;
            foreach (XmlNode node in elemList)
            {
                    ItemPanel = new Panel();
                    MasterPanel.Controls.Add(ItemPanel);
                    ItemPanel.Height = 90;
                    ItemPanel.Width = 600;
                    ItemPanel.BorderStyle = BorderStyle.Inset;

                    Image ProductImage = new Image();
                    ItemPanel.Controls.Add(ProductImage);
                    ProductImage.Height = 64;
                    ProductImage.Width = 64;
                    ProductImage.ImageAlign = ImageAlign.Left;
                    ProductImage.ImageUrl = node["Image"].InnerText;

                    Label ProductTitle = new Label();
                    ItemPanel.Controls.Add(ProductTitle);
                    ProductTitle.Text = node.Attributes[0].InnerText;


                    Label TextPrice = new Label();
                    ItemPanel.Controls.Add(TextPrice);
                    TextPrice.Text = Environment.NewLine + "Price: ";

                    ProductPrice = new Label();
                    ItemPanel.Controls.Add(ProductPrice);
                    ProductPrice.Text = node["Price"].InnerText;

                    Label ProductDescription = new Label();
                    ItemPanel.Controls.Add(ProductDescription);
                    ProductDescription.Text = node["Description"].InnerText;

                    Label ProductAvailability = new Label();
                    ItemPanel.Controls.Add(ProductAvailability);
                
                    Button Btn_MoreDetails = new Button();
                    ItemPanel.Controls.Add(Btn_MoreDetails);
                    Btn_MoreDetails.Text = "More Details";
                    Btn_MoreDetails.ID = "Button" + index.ToString();
                    Btn_MoreDetails.Click += new EventHandler(InfoClick);
                index++;

            }

      
           
        }


        protected void GenerateDetail()
        {

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(Server.MapPath("~/XML/List.xml"));

            XmlDocument detailDoc = new XmlDocument();
            detailDoc.Load(Server.MapPath("~/XML/Detail.xml"));

            //XmlNodeList elemList = xmlDoc.GetElementsByTagName("Product");

        }






        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void InfoClick(object sender, EventArgs e)
        {
            Multiview1.ActiveViewIndex = 1;

           
            XmlDocument detailDoc = new XmlDocument();
            detailDoc.Load(Server.MapPath("~/XML/Detail.xml"));


            XmlNodeList detailElemList = detailDoc.GetElementsByTagName("Product");
            //XmlNode DetailNode = detailDoc;

           
            foreach (XmlNode DetailNode in detailElemList)
            {
                D_ProdTitle.Text = DetailNode.Attributes[0].InnerText;
                D_Prod_Description.GroupingText = DetailNode["Description"].InnerText;
                D_ProdImg1.ImageUrl = DetailNode["Image"].InnerText;
                D_Price.Text = "999";
                D_spec1.Text = "Test";
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click2(object sender, EventArgs e)
        {
            
        }
    }
}