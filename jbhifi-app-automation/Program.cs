using jbhifi_app_automation.Global;
using jbhifi_app_automation.Pages;
using NUnit.Framework;

namespace jbhifi_app_automation
{
    public static class Program
    {
        [TestFixture]
        class User : Base
        {
            [Test, Order(1)]
            public void AddToCart()
            {
                AddProduct AddProductObj = new AddProduct();
                AddProductObj.AddProductSteps();
            }
        }
    }
}