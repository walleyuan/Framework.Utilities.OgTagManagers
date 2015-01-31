using System;
using Framework.Utilities.OgTagManagers;
using Framework.Utilities.OgTagManagers.Models.OgBasic;
using Framework.Utilities.OgTagManagers.Models.OgImage;

namespace Framework.Website
{
    public partial class Demo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            var imageTagManager = new OgImageTagManager
                    (
                        new OgImageUrl { Content = "Image Url goes here" },
                        new OgImageSecureUrl { Content = "Image Secure Url goes here" }
                    );


            var basicTagManager = new OgBasicTagManager
                    (
                        new OgTitle { Content = "Title goes here" },
                        new OgUrl { Content = "Url goes here" },
                        new OgDescription { Content = "Description goes here" },
                        new OgSiteName { Content = "Site name goes here" },
                        new OgType { Content = "website" },
                        imageTagManager
                    );

            var ogTags = basicTagManager.GetOgTagMeta();

            foreach (var ogTag in ogTags)
            {
                Header.Controls.Add(ogTag);

                //phOgTag.Controls.Add(ogTag);
            }
        }
    }
}