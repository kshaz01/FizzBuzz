using Sitecore.Data.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace FizzBuzz.Domain.Abstract
{
    public interface IAppItem
    {
        HtmlString Heading { get; set; }
        HtmlString Summary { get; set; }
        Item SitecoreItem { set; }
    }
}
