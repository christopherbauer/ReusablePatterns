using System;
using System.Collections.Generic;
using System.Linq;
using Factory.SelectList;
using NUnit.Framework;

namespace FactoryTests.SelectList
{
    internal class SelectListFactoryTests
    {
        [TestFixture]
        public class when_creating_a_select_list_factory
        {
            [Test]
            public void then_should_use_text_field_of_selectable_for_text()
            {
                // Arrange
                var factory = new SelectListFactory();

                // Act
                const string text = "Test";
                var selectList = factory.Create(new List<ExampleSelectable> { new ExampleSelectable { PropertyToDeriveText = text} });

                // Assert
                Assert.That(selectList.All(item => item.Text == text), Is.True);
            }

            [Test]
            public void then_should_use_value_field_of_selectable_for_value()
            {
                // Arrange
                var factory = new SelectListFactory();

                // Act
                const string value = "Value";
                var selectList = factory.Create(new List<ExampleSelectable> { new ExampleSelectable {PropertyToDeriveValue = value} });

                // Assert
                Assert.That(selectList.All(item => item.Value == value), Is.True);
            }

            [Test]
            public void then_should_throw_exception_given_null_list_of_items()
            {
                // Arrange
                var factory = new SelectListFactory();

                // Act // Assert
                Assert.Throws<ArgumentNullException>(() => factory.Create((List<ExampleSelectable>)null));
            }
        }
    }
}