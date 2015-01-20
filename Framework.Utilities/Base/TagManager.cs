using System.Collections.Generic;
using System.Reflection;
using System.Web.UI.HtmlControls;
using Framework.Utilities.OgTagManagers.Interfaces;

namespace Framework.Utilities.OgTagManagers.Base
{
      public abstract class TagManager
      {
            public virtual IList<HtmlMeta> GetOgTagMeta()
            {
                  var htmlMetas = new List<HtmlMeta>();

                  foreach (PropertyInfo prop in GetType().GetProperties())
                  {
                        if ((prop.GetValue(this)) != null)
                        {
                              var htmlMeta = new HtmlMeta();

                              var content = ((IOgTag)prop.GetValue(this)).Content;

                              if (!string.IsNullOrEmpty(content))
                              {
                                    htmlMeta.Attributes.Add("property", ((IOgTag)prop.GetValue(this)).Property);
                                    htmlMeta.Content = content;
                              }

                              htmlMetas.Add(htmlMeta);
                        }
                  }

                  return htmlMetas;
            }
      }
}
