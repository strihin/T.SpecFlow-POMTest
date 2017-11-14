
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SpecFlow2
{
    [Binding]
    public sealed class MenuStep
    {
        [When(@"Menu list consist of")]
        public void WhenMenuListConsistOf(IEnumerable<dynamic> table)
        {
          //  IEnumerable<dynamic> menuList = table.CreateDynamicInstance();
          // dynamic menuList = table.CreateDynamicInstance();
            var menuList = table.First();
            string menu1 = menuList.Menu1; 
            string menu2 = menuList.Menu2;


            Console.WriteLine(menu1 +"  " + menu2);
        }

        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int p0)
        {
           
        }

    
    }
}
