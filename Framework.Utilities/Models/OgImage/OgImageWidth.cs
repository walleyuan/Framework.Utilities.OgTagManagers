using Framework.Utilities.OgTagManagers.Interfaces;

namespace Framework.Utilities.OgTagManagers.Models.OgImage
{
   public class OgImageWidth : IOgTag
    {
       public string Property
       {
           get { return "og:image:width"; }
       }
       public string Content { get; set; }
    }
}
