using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Tyuiu.TimoninIA.Sprint7.Project.V10
{
    public class OrderManager_TIA
    {
        private string filePath;

        public OrderManager_TIA(string filePath)
        {
            this.filePath = filePath;
        }

        public List<Order_TIA> LoadOrders()
        {
            return LoadOrdersFromFile(filePath);
        }

        public List<Order_TIA> LoadOrdersFromFile(string filePath)
        {
            var orders = new List<Order_TIA>();
            if (File.Exists(filePath))
            {
                var lines = File.ReadAllLines(filePath);
                foreach (var line in lines.Skip(1))
                {
                    var values = line.Split(',');
                    var order = new Order_TIA
                    {
                        OrderNumber = int.Parse(values[0]),
                        ClientLastName = values[1],
                        ClientFirstName = values[2],
                        ClientMiddleName = values[3],
                        AccountNumber = values[4],
                        Address = values[5],
                        Phone = values[6],
                        ExecutionDate = DateTime.Parse(values[7]),
                        OrderCost = decimal.Parse(values[8]),
                        ProductName = values[9],
                        ProductPrice = decimal.Parse(values[10]),
                        ProductQuantity = int.Parse(values[11])
                    };
                    orders.Add(order);
                }
            }
            return orders;
        }

        public void SaveOrders(List<Order_TIA> orders)
        {
            var lines = new List<string> { "OrderNumber,ClientLastName,ClientFirstName,ClientMiddleName,AccountNumber,Address,Phone,ExecutionDate,OrderCost,ProductName,ProductPrice,ProductQuantity" };
            foreach (var order in orders)
            {
                var line = $"{order.OrderNumber},{order.ClientLastName},{order.ClientFirstName},{order.ClientMiddleName},{order.AccountNumber},{order.Address},{order.Phone},{order.ExecutionDate},{order.OrderCost},{order.ProductName},{order.ProductPrice},{order.ProductQuantity}";
                lines.Add(line);
            }
            File.WriteAllLines(filePath, lines);
        }
    }

    public class Order_TIA
    {
        public int OrderNumber { get; set; }
        public string ClientLastName { get; set; }
        public string ClientFirstName { get; set; }
        public string ClientMiddleName { get; set; }
        public string AccountNumber { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public DateTime ExecutionDate { get; set; }
        public decimal OrderCost { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public int ProductQuantity { get; set; }
    }
}
