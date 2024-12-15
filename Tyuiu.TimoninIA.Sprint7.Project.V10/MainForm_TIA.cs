using System;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Tyuiu.TimoninaIA.Sprint7.V10.Lib;
namespace Tyuiu.TimoninIA.Sprint7.Project.V10
{
    public partial class MainForm_TIA : Form
    {
        private OrderManager orderManager;
        private CSVManager csvManager;

        public MainForm_TIA()
        {
            InitializeComponent();
            orderManager = new OrderManager();
            csvManager = new CSVManager();
        }

        private void MainForm_TIA_Load(object sender, EventArgs e)
        {
            // Загрузка данных из CSV при запуске
            var openFileDialog = new OpenFileDialog
            {
                Filter = "CSV Files (*.csv)|*.csv",
                Title = "Select a CSV File"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var orders = csvManager.LoadFromCSV(openFileDialog.FileName);
                    foreach (var order in orders)
                    {
                        orderManager.AddOrder(order);
                    }
                    UpdateDataGridView();
                    UpdateChart();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void buttonAddOrder_TIA_Click(object sender, EventArgs e)
        {
            var addOrderForm = new AddOrderForm_TIA();
            if (addOrderForm.ShowDialog() == DialogResult.OK)
            {
                orderManager.AddOrder(addOrderForm.Order);
                UpdateDataGridView();
                UpdateChart();
            }
        }

        private void buttonSaveOrders_TIA_Click(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog
            {
                Filter = "CSV Files (*.csv)|*.csv",
                Title = "Save CSV File"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    csvManager.SaveToCSV(orderManager.Orders, saveFileDialog.FileName);
                    MessageBox.Show("Заказы успешно изменены.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void UpdateDataGridView()
        {
            dataGridViewOrders_TIA.DataSource = null;
            dataGridViewOrders_TIA.DataSource = orderManager.Orders;
        }

        private void UpdateChart()
        {
            chartOrders_TIA.Series.Clear();
            var series = new Series
            {
                Name = "Цена заказа",
                Color = System.Drawing.Color.Blue,
                IsVisibleInLegend = false,
                IsXValueIndexed = true,
                ChartType = SeriesChartType.Column
            };

            foreach (var order in orderManager.Orders)
            {
                series.Points.AddXY(order.OrderNumber, order.Price);
            }

            chartOrders_TIA.Series.Add(series);
            chartOrders_TIA.ChartAreas[0].AxisX.Title = "Номер заказа";
            chartOrders_TIA.ChartAreas[0].AxisY.Title = "Цена";
        }

        private void buttonSortByPrice_TIA_Click_1(object sender, EventArgs e)
        {
            orderManager.SortByPrice();
            Console.WriteLine("Заказы сортированы по цене.");
            UpdateDataGridView();
            Console.WriteLine("DataGridView updated.");
        }

        private void buttonFilterByPrice_TIA_Click_1(object sender, EventArgs e)
        {
            if (decimal.TryParse(textBoxMinPrice_TIA.Text, out decimal minPrice) &&
                decimal.TryParse(textBoxMaxPrice_TIA.Text, out decimal maxPrice))
            {
                var filteredOrders = orderManager.FilterByPrice(minPrice, maxPrice);
                dataGridViewOrders_TIA.DataSource = filteredOrders;
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите действительные значения цен.");
            }
        }

        private void buttonLoadCSV_TIA_Click_1(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog
            {
                Filter = "CSV Files (*.csv)|*.csv",
                Title = "Select a CSV File"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var orders = csvManager.LoadFromCSV(openFileDialog.FileName);
                    orderManager.Orders.Clear();
                    foreach (var order in orders)
                    {
                        orderManager.AddOrder(order);
                    }
                    UpdateDataGridView();
                    UpdateChart();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void buttonStatistics_TIA_Click(object sender, EventArgs e)
        {
            var statistics = orderManager.GetStatistics();
            labelStatistics_TIA.Text = $"Общая цена: {statistics.TotalCost}, Средняя цена: {statistics.AverageCost}, Мин. цена: {statistics.MinCost}, Макс. цена: {statistics.MaxCost}";
        }

        private void buttonSortByDate_TIA_Click_1(object sender, EventArgs e)
        {
            orderManager.SortByOrderDate();
            UpdateDataGridView();
        }

        private void buttonSearch_TIA_Click(object sender, EventArgs e)
        {
            var searchTerm = textBoxSearch_TIA.Text;
            var filteredOrders = orderManager.SearchByClientName(searchTerm);
            dataGridViewOrders_TIA.DataSource = filteredOrders;
        }

        private void toolStripButtonAbout_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            FormAboutMe formAbout = new FormAboutMe();
            formAbout.ShowDialog();
        }
    }
}





