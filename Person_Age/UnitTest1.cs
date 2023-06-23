using Exception_Problem;

namespace Person_Age
{
    [TestClass]
    public class UnitTest1
    {
        FindCategory findCategory = new FindCategory();
        [TestMethod]
        public void TestMethod1()
        {
            int age = 8;
            string result=findCategory.CategoryCheck(age);
            Assert.AreEqual("Children",result);
        }
        [TestMethod]
        public void TestMethod2()
        {
            int age =18;
            string result = findCategory.CategoryCheck(age);
            Assert.AreEqual("Youth", result);
        }
        [TestMethod]
        public void TestMethod3()
        {
            int age = 28;
            string result = findCategory.CategoryCheck(age);
            Assert.AreEqual("Adults", result);
        }
        [TestMethod]
        public void TestMethod4()
        {
            int age = 78;
            string result = findCategory.CategoryCheck(age);
            Assert.AreEqual("Seniors", result);
        }
        [TestMethod]
        public void TestMethod5()
        {
            try
            {
                int age = default;
                string result = findCategory.CategoryCheck(age);
                
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "Age is Null");
            }
          
        }
        int age;
        [TestMethod]
        public void TestMethod6()
        {
           
            try
            {
                string result = findCategory.CategoryCheck(age);

            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "Age is Empty");
            }

        }


    }
}