using Framework.Utilities.OgTagManagers.Interfaces;

namespace Framework.Utilities.OgTagManagers.Models.OgBasic
{
    public class OgType: IOgTag
    {
        public string Property {
            get { return "og:type"; }
        }
        public string Content { get; set; }
    }
}
