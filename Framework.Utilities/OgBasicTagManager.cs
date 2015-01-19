using System.Collections.Generic;
using System.Web.UI.HtmlControls;
using Framework.Utilities.OgTagManagers.Base;
using Framework.Utilities.OgTagManagers.Models.OgBasic;

namespace Framework.Utilities.OgTagManagers
{
    public class OgBasicTagManager : TagManager
    {
        public OgTitle Title { get; set; }
        public OgUrl Url { get; set; }
        public OgDescription Description { get; set; }
        public OgSiteName SiteName { get; set; }

        private readonly OgImageTagManager _ogImageTagManager;

        public OgBasicTagManager
            (OgTitle title,
             OgUrl url,
             OgDescription ogDescription,
             OgSiteName ogSiteName,
             OgImageTagManager ogImageTagManager = null)
        {
            this.Title = title;
            this.Url = url;
            this.Description = ogDescription;
            this.SiteName = ogSiteName;
            this._ogImageTagManager = ogImageTagManager;
        }


        public override IList<HtmlMeta> GetOgTagMeta()
        {
            var tags = base.GetOgTagMeta();

            if (_ogImageTagManager != null)
            {
                var imgTags = _ogImageTagManager.GetOgTagMeta();

                foreach (var imgTag in imgTags)
                {
                    tags.Add(imgTag);
                }
            }

            return tags;
        }
    }
}
