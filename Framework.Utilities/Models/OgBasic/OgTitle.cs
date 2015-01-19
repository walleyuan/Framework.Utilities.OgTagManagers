using Framework.Utilities.OgTagManagers.Interfaces;

namespace Framework.Utilities.OgTagManagers.Models.OgBasic
{
    public class OgTitle : IOgTag
    {
        public string Property
        {
            get { return "og:title"; }
        }
        public string Content { get; set; }
    }
}
