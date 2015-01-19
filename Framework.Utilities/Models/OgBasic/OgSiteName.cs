using Framework.Utilities.OgTagManagers.Interfaces;

namespace Framework.Utilities.OgTagManagers.Models.OgBasic
{
    public class OgSiteName : IOgTag
    {
        public string Property
        {
            get { return "og:site_name"; }
        }
        public string Content { get; set; }
    }
}
