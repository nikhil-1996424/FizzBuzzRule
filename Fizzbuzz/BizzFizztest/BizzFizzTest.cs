using Fizzbuzz;
using Fizzbuzz.Controllers;
using Moq;
using NUnit.Framework;

namespace BizzFizztest
{
    public class Tests
    {
       
        [SetUp]
        public void Setup()
        {
          
        }

        [Test,Order(1)]
        public void FizzBizzTest1()
        {      
            object[] array = new object[3];
           
            array[0] = "Hello";
            array[1] = 123;
            array[2] = "c";

            CalculationRespository calculation = new CalculationRespository();
            string result = string.Empty;
            var respositoryCal = new Mock<ICalculation>();
            var controller = new BuzzFizzController(respositoryCal.Object);
            result = controller.Calculation(array);
            Assert.IsNotNull(calculation.GetCalculationResults(array));
            Assert.Pass();
        }
        [Test, Order(2)]
        public void FizzBizzTest2()
        {   
            object[] array = new object[3];
           
            array[0] = null;
            array[1] = "";
            array[2] = 1;

            CalculationRespository calculation = new CalculationRespository();            
            Assert.IsNotNull(calculation.GetCalculationResults(array));
            Assert.Pass();
        }

        [Test, Order(3)]
        public void FizzBizzTest3()
        {
            object[] array = new object[3];            
            CalculationRespository calculation = new CalculationRespository();           
            Assert.IsNotNull(calculation.GetCalculationResults(array));
            Assert.Pass();
        }

        [Test, Order(4)]
        public void FizzBizzTest4()
        {
            object[] array = new object[3];           
            CalculationRespository calculation = new CalculationRespository();            
            Assert.IsNotNull(calculation.GetCalculationResults(array));
            Assert.Pass();
        }

        [Test, Order(5)]
      
        public void FizzBizzTest5()
        {
            string Expected = "FizzBuzz";
            object[] array = new object[1];
            array[0] = 15;
            CalculationRespository calculation = new CalculationRespository();
            var result = calculation.GetCalculationResults(array).Replace("\n", "").Replace("==>","").Replace(array[0].ToString(),"").Trim();// Replace("");
            Assert.AreEqual(Expected,result);

        }

        [Test, Order(6)]

        public void FizzBizzTest6()
        {
            string Expected = "Fizz";
            object[] array = new object[1];
            array[0] = 3;
            CalculationRespository calculation = new CalculationRespository();
            var result = calculation.GetCalculationResults(array).Replace("\n", "").Replace("==>", "").Replace(array[0].ToString(), "").Trim();// Replace("");
            Assert.AreEqual(Expected, result);

        }

        [Test, Order(6)]

        public void FizzBizzTest7()
        {
            string Expected = "Buzz";
            object[] array = new object[1];
            array[0] = 5;
            CalculationRespository calculation = new CalculationRespository();
            var result = calculation.GetCalculationResults(array).Replace("\n", "").Replace("==>", "").Replace(array[0].ToString(), "").Trim();// Replace("");
            Assert.AreEqual(Expected, result);
        }

        [Test, Order(7)]

        public void FizzBizzTest8()
        {
            string Expected = "Invalid term";
            object[] array = new object[1];
            array[0] ="A";
            CalculationRespository calculation = new CalculationRespository();
            var result = calculation.GetCalculationResults(array).Replace("\n", "").Replace("==>", "").Replace(array[0].ToString(), "").Trim();// Replace("");
            Assert.AreEqual(Expected, result);
        }
        [Test, Order(8)]
        public void FizzBizzTest9()
        {
            string Expected = "Invalid term";
            object[] array = new object[1];
            array[0] = "";
            CalculationRespository calculation = new CalculationRespository();
            string result = calculation.GetCalculationResults(array).Replace("\n", "").Replace("==>", "").Trim();
            Assert.AreEqual(Expected, result);
        }



        [Test, Order(9)]
        public void FizzBizzTest10()
        {
            string Expected = "Divided 1 by 3 Divided 1 by 5";
            object[] array = new object[1];
            array[0] = 1;
            CalculationRespository calculation = new CalculationRespository();
            string result = calculation.GetCalculationResults(array).Replace("\n", "").Replace("==>", "").Trim();
            Assert.AreEqual(Expected, result);
        }
    }
}