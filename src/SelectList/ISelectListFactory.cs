using System.Collections.Generic;

namespace Factory.SelectList
{
    public interface ISelectListFactory
    {
        System.Web.Mvc.SelectList Create<T>(IEnumerable<T> listOftems) where T : ISelectable;
    }
}