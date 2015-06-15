using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Factory.SelectList
{
    public class SelectListFactory : ISelectListFactory
    {
        public System.Web.Mvc.SelectList Create<T>(IEnumerable<T> listOfItems) where T : ISelectable
        {
            var itemsAsSelectList = listOfItems.Select(arg => new SelectListItem
            {
                Text = arg.GetTextField(),
                Value = arg.GetValueField()
            });

            return new System.Web.Mvc.SelectList(itemsAsSelectList.ToList(), "Value", "Text");
        }
    }
}