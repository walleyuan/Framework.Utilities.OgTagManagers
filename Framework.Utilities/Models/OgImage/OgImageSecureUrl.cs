using Framework.Utilities.OgTagManagers.Interfaces;

namespace Framework.Utilities.OgTagManagers.Models.OgImage
{
    public class OgImageSecureUrl : IOgTag
    {
        public string Property
        {
            get { return "og:image:secure_url"; }
        }
        public string Content { get; set; }
    }
}
