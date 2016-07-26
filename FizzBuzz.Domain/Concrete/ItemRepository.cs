using FizzBuzz.Domain.Abstract;
using Sitecore.Data;
using Sitecore.Mvc.Presentation;
using FizzBuzz.Domain.Utilities;
namespace FizzBuzz.Domain.Concrete
{
   public class ItemRepository : IItemRepository
    {
        #region region Constants and Fields

        /// <summary>
        /// The Database
        /// </summary>
        private readonly Database db = Sitecore.Context.Database ?? Sitecore.Data.Database.GetDatabase("web");


        #endregion

        /// <summary>
        /// Get the rendering or main page context item depending on scope.
        /// </summary>
        /// <returns>Item</returns>
        protected Sitecore.Data.Items.Item GetContextItem()
        {
            var context = RenderingContext.CurrentOrNull;

            if (context == null)
            {
                return Sitecore.Context.Item;
            }

            return db.GetItem(context.Rendering.DataSource);
        }


       /// <summary>
        /// Get the app items
       /// </summary>
        /// <param name="item">IAppItem</param>
        /// <returns>IAppItem</returns>
        public IAppItem GetAppItem(IAppItem item)
        {
            var contentItem = this.GetContextItem();

            if (contentItem == null || !contentItem.TemplateID.Guid.Equals(AppTemplates.AppTemplateID))
            {
                return item;
            }

            item.SitecoreItem = contentItem;

            return item;
        }
    }
}
