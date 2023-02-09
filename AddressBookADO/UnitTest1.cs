using AddressBookSystem;

namespace AddressBookTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Address ar = new Address();
            AddressModel ad = new AddressModel();

            int expected = 4;
            int totalRecordInDB = ar.GetAllEmployee();

            Assert.AreEqual(expected, totalRecordInDB);

        }
    }
}