namespace HealthMgrTests
{
    public class BmiCalculatorTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CalculateTest()
        {
            HealthMgr.BmiCalculator bmi = new HealthMgr.BmiCalculator();
            bmi.Height = 170;
            bmi.Weight = 70;

            var result = bmi.Calculate();

            Assert.AreEqual("24.22", result.ToString("00.00"));
        }
    }
}