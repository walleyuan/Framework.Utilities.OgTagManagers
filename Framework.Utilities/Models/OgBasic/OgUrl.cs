using Framework.Utilities.OgTagManagers.Interfaces;

namespace Framework.Utilities.OgTagManagers.Models.OgBasic
{
    public class OgUrl : IOgTag
    {
        public string Property
        {
            get { return "og:url"; }
        }
        public string Content { get; set; }
    }
}
