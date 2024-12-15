using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Tyuiu.TimoninaIA.Sprint7.V10.Lib
{
    // Order.cs
    public class Order
    {
        public string OrderNumber { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string Index { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime OrderDate { get; set; }
        public string OrderName { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string AccountNumber { get; set; }
    }

    // OrderManager.cs
    public class OrderManager
    {
        public List<Order> Orders { get; set; }

        public OrderManager()
        {
            Orders = new List<Order>();
        }

        public void AddOrder(Order order)
        {
            Orders.Add(order);
        }

        public List<Order> FilterByPrice(decimal minPrice, decimal maxPrice)
        {
            return Orders.Where(o => o.Price >= minPrice && o.Price <= maxPrice).ToList();
        }

        public List<Order> SearchByClientName(string clientName)
        {
            return Orders.Where(o => o.LastName.Contains(clientName, StringComparison.OrdinalIgnoreCase) ||
                                     o.FirstName.Contains(clientName, StringComparison.OrdinalIgnoreCase) ||
                                     o.MiddleName.Contains(clientName, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public void SortByOrderDate()
        {
            Orders = Orders.OrderBy(o => o.OrderDate).ToList();
        }

        public void SortByPrice()
        {
            Orders = Orders.OrderBy(o => o.Price).ToList();
        }

        public (decimal TotalCost, decimal AverageCost, decimal MinCost, decimal MaxCost) GetStatistics()
        {
            var totalCost = Orders.Sum(o => o.Price * o.Quantity);
            var averageCost = Orders.Average(o => o.Price * o.Quantity);
            var minCost = Orders.Min(o => o.Price * o.Quantity);
            var maxCost = Orders.Max(o => o.Price * o.Quantity);
            return (totalCost, averageCost, minCost, maxCost);
        }
    }

    // CSVManager.cs

    public class CSVManager
    {
        public void SaveToCSV(List<Order> orders, string filePath)
        {
            using (var writer = new StreamWriter(filePath))
            {
                writer.WriteLine("OrderNumber,LastName,FirstName,MiddleName,Index,City,Address,PhoneNumber,OrderDate,OrderName,Price,Quantity,AccountNumber");
                foreach (var order in orders)
                {
                    writer.WriteLine($"{order.OrderNumber},{order.LastName},{order.FirstName},{order.MiddleName},{order.Index},{order.City},{order.Address},{order.PhoneNumber},{order.OrderDate},{order.OrderName},{order.Price},{order.Quantity},{order.AccountNumber}");
                }
            }
        }

        public List<Order> LoadFromCSV(string filePath)
        {
            var orders = new List<Order>();
            try
            {
                using (var reader = new StreamReader(filePath))
                {
                    reader.ReadLine(); // Skip header
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        if (string.IsNullOrEmpty(line)) continue;
                        var values = line.Split(',');
                        if (values.Length != 13)
                        {
                            throw new Exception("Invalid number of columns in CSV file.");
                        }
                        var order = new Order
                        {
                            OrderNumber = values[0],
                            LastName = values[1],
                            FirstName = values[2],
                            MiddleName = values[3],
                            Index = values[4],
                            City = values[5],
                            Address = values[6],
                            PhoneNumber = values[7],
                            OrderDate = DateTime.Parse(values[8]),
                            OrderName = values[9],
                            Price = decimal.Parse(values[10]),
                            Quantity = int.Parse(values[11]),
                            AccountNumber = values[12]
                        };
                        orders.Add(order);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error loading CSV file: {ex.Message}");
            }
            return orders;
        }
    }
}