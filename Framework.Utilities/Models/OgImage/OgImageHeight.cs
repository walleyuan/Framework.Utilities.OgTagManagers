using Framework.Utilities.OgTagManagers.Interfaces;

namespace Framework.Utilities.OgTagManagers.Models.OgImage
{
    public class OgImageHeight: IOgTag
    {
        public string Property
        {
            get { return "og:image:height"; }
        }
        public string Content { get; set; }
    }
}
