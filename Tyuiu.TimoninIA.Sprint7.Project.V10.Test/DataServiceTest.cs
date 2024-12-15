using Tyuiu.TimoninaIA.Sprint7.V10.Lib;
namespace Tyuiu.TimoninIA.Sprint7.Project.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestFilterByPrice()
        {
            var orderManager = new OrderManager();
            orderManager.AddOrder(new Order { OrderNumber = "1", LastName = "Ivanov", FirstName = "Ivan", MiddleName = "Ivanovich", Index = "123456", City = "Moscow", Address = "Lenina 1", PhoneNumber = "1234567890", OrderDate = DateTime.Now, OrderName = "ProductA", Price = 100, Quantity = 2, AccountNumber = "1001" });
            orderManager.AddOrder(new Order { OrderNumber = "2", LastName = "Petrov", FirstName = "Petr", MiddleName = "Petrovich", Index = "654321", City = "St. Petersburg", Address = "Nevsky 2", PhoneNumber = "0987654321", OrderDate = DateTime.Now, OrderName = "ProductB", Price = 200, Quantity = 1, AccountNumber = "1002" });

            var filteredOrders = orderManager.FilterByPrice(150, 300);

            Assert.AreEqual(1, filteredOrders.Count);
            Assert.AreEqual("Petrov", filteredOrders[0].LastName);
        }
    }
}