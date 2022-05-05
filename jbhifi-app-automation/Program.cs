using MarsFramework.Pages;
using NUnit.Framework;
using System;
using Target_Appliaction;

namespace jbhifi_app_automation
{
    public static class Program
    {
        [TestFixture]
        [Category("Sprint1")]
        class User : MarsFramework.Global.Base
        {

            [Test, Order(1)]

            public void SelectingProduct()
            {


                AddingProduct addingProductlObj = new AddingProduct();

                addingProductlObj.SelectProduct();
            }
        }
    }
}