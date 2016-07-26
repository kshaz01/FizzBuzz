using FizzBuzz.Domain.Abstract;
using Sitecore.Web.UI.WebControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
namespace FizzBuzz.Domain.Entities
{
    public class AppItem : IAppItem
    {
        #region Methods

        protected void ProcessSitecoreItem(Sitecore.Data.Items.Item item)
        {
            this.Heading = new HtmlString(FieldRenderer.Render(item, "Heading"));
            this.Summary = new HtmlString(FieldRenderer.Render(item, "Summary"));
           
        }

        #endregion

        #region Properties

        public HtmlString Heading { get; set; }

        public HtmlString Summary { get; set; }

        public Sitecore.Data.Items.Item SitecoreItem
        {
            set { this.ProcessSitecoreItem(value); }
        }

        #endregion
    }
}
