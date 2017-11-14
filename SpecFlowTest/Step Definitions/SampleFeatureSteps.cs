using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using SpecFlowTest.Step_Definitions;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SpecFlowTest
{
    [Binding]
    class SampleFeatureSteps
    {
        public readonly EmployeeDetails employeeDetail;
        public SampleFeatureSteps(EmployeeDetails emp)
        {
            employeeDetail = emp;
        }
  
        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int numbers)
        {
            Console.WriteLine(numbers);
        }

        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            Console.WriteLine("Pressed Add button");
        }

        [When(@"I fill form (.*) (.*) (.*)")]
        public void WhenIFillForm(string p0, string p1, string p2, Table table)
        {
            //Single element
            /*
              EmployeeDetails EmpList = table.CreateInstance<EmployeeDetails>();

              Console.WriteLine(EmpList.Name);
              Console.WriteLine(EmpList.Age);
              Console.WriteLine(EmpList.Email);
              Console.WriteLine(EmpList.Phone);
            */
           var EmpList = table.CreateSet<EmployeeDetails>();
            foreach (var unit in EmpList)
            {
                Console.WriteLine(unit.Name);
                Console.WriteLine(unit.Age);
                Console.WriteLine(unit.Email);
                Console.WriteLine(unit.Phone);
            }
            foreach (var unit in EmpList)
            {
                employeeDetail.Name =(unit.Name);
                employeeDetail.Age = (unit.Age);
                employeeDetail.Email = (unit.Email);
                employeeDetail.Phone = (unit.Phone);
            }
        }
   


        //8.table data from outline through example
        [When(@"I add data like (.*), (.*), (.*), (.*)")]
        public void WhenIAddDataLike(string Name, int Age, string Phone, string Email)
        {
                Console.WriteLine(Name);
                Console.WriteLine(Age);
                Console.WriteLine(Phone);
                Console.WriteLine(Email);
        }

        //9. data in context
        [When(@"I add data like next")]
        public void WhenIAddDataLikeNext()
        {
            ScenarioContext.Current["keyInfo"] = "ScenarioName";
            Console.WriteLine(ScenarioContext.Current["keyInfo"]);
            List<EmployeeDetails> empDetails = new List<EmployeeDetails>()
            {
                new EmployeeDetails()
                {
                    Age = Faker.RandomNumber.Next(1, 70),
                    Email = Faker.Internet.Email(),
                    Name = Faker.Name.Last(),
                    Phone = Faker.Phone.Number()
                },
                new EmployeeDetails()
                {
                    Age = Faker.RandomNumber.Next(1, 70),
              //      Email = Faker.Internet.Email(),
                    Name = Faker.Name.Last(),
                    Phone = Faker.Phone.Number()
                },
                new EmployeeDetails()
                {
                    Age = Faker.RandomNumber.Next(1, 70),
                    Email = Faker.Internet.Email(),
                    Name = Faker.Name.Last(),
                    Phone = Faker.Phone.Number()
                }
                
            };

            //save value in ScenarioContext
            ScenarioContext.Current.Add("keyInfo2", empDetails);
            //Get the value  out from ScenarioContext
            var empList = ScenarioContext.Current.Get<IEnumerable<EmployeeDetails>>("keyInfo2");

            foreach (var item in empList)
            {
                Console.WriteLine("Age: " + item.Age);
                Console.WriteLine("Email: " + item.Email);
                Console.WriteLine("Name: " + item.Name);
                Console.WriteLine("Phone: " + item.Phone);
            }
        }
        
        [When(@"I add data through Assist")]
        public void WhenIAddDataThroughAssist(Table table)
        {
            var details = table.CreateDynamicSet();
            foreach (var item in details)
            {
                Console.WriteLine("Name: " + item.Name);
                Console.WriteLine("Age: " + item.Age);
                Console.WriteLine("Phone: " + item.Phone);
                Console.WriteLine("Email: " + item.Email);
            }
        }





    }
}
