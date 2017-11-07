using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorEx.Test
{
    [TestClass]
    
    public class CalculatorExTest
    {
        [TestMethod]
        public void Hello_World_Test()
        {
            int tmp_result = 0;
            int expected_result = 20;
            int numerateur = 5;
            int denominateur = 100;
            tmp_result = denominateur / numerateur;
            Assert.AreEqual(expected_result, tmp_result); 
        }
    }
}
