using Factory.SelectList;

namespace FactoryTests.SelectList
{
    public class ExampleSelectable : ISelectable
    {
        public string PropertyToDeriveValue { get; set; }
        public string PropertyToDeriveText { get; set; }

        public string GetValueField()
        {
            return PropertyToDeriveValue;
        }

        public string GetTextField()
        {
            return PropertyToDeriveText;
        }
    }
}