using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InterviewHolocron.Tests
{
    [TestClass]
    public class HolocronTests
    {
        [TestMethod]
        public void PositiveFizz()
        {
            var sithHolocron = new Holocron();
            var FizzNum = "3";

            var retVal = sithHolocron.FizzBuzz(FizzNum);

            Assert.IsTrue(retVal.ToUpper()=="FIZZ");
        }

        [TestMethod]
        public void PositiveBuzz()
        {
            var sithHolocron = new Holocron();
            var FizzNum = "5";

            var retVal = sithHolocron.FizzBuzz(FizzNum);

            Assert.IsTrue(retVal.ToUpper() == "BUZZ");
        }

        [TestMethod]
        public void PositiveFizzBuzz()
        {
            var sithHolocron = new Holocron();
            var FizzNum = "15";

            var retVal = sithHolocron.FizzBuzz(FizzNum);

            Assert.IsTrue(retVal.ToUpper() == "FIZZBUZZ");
        }
    }
}
