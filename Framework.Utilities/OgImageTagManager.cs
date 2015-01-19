using Framework.Utilities.OgTagManagers.Base;
using Framework.Utilities.OgTagManagers.Models.OgImage;

namespace Framework.Utilities.OgTagManagers
{
    public class OgImageTagManager : TagManager
    {
        //og:image identical to og:imag:url
        public OgImageUrl Image { get; set; }
        public OgImageSecureUrl ImageSecureUrl { get; set; }
        public OgImageType Type { get; set; }
        public OgImageHeight Height { get; set; }
        public OgImageWidth Width { get; set; }

        public OgImageTagManager
            (OgImageUrl image = null, 
             OgImageSecureUrl imageSecureUrl = null, 
             OgImageType type = null, 
             OgImageHeight height = null, 
             OgImageWidth width = null)
        {
            this.Image = image;
            this.ImageSecureUrl = imageSecureUrl;
            this.Type = type;
            this.Height = height;
            this.Width = width;
        }

    }
}
