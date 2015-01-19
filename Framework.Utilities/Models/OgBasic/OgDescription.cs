using Framework.Utilities.OgTagManagers.Interfaces;

namespace Framework.Utilities.OgTagManagers.Models.OgBasic
{
    public class OgDescription : IOgTag
    {
        public string Property
        {
            get { return "og:description"; }
        }
        public string Content { get; set; }
    }
}
