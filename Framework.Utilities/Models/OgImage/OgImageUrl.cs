using Framework.Utilities.OgTagManagers.Interfaces;

namespace Framework.Utilities.OgTagManagers.Models.OgImage
{
    public class OgImageUrl:IOgTag
    {
        public string Property {
            get { return "og:Image"; }
        }
        public string Content { get; set; }
    }
}
