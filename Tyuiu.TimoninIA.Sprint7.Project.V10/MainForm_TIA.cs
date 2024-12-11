using System;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Tyuiu.TimoninIA.Sprint7.Project.V10
{
    public partial class MainForm_TIA : Form
    {
        private OrderManager_TIA orderManager;
        private List<Order_TIA> orders;
        public MainForm_TIA()
        {
            InitializeComponent();
            orderManager = new OrderManager_TIA("orders.csv");
            orders = orderManager.LoadOrders();

        }


        private void ButtonAddOrder_TIA_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
            DataGridView dataGridViewOrders = new DataGridView();
            dataGridViewOrders_TIA.RowCount = 10;
            dataGridViewOrders_TIA.ColumnCount = 13;
            for (int i = 0; i < dataGridViewOrders_TIA.ColumnCount; i++)
            {
                dataGridViewOrders_TIA.Columns[i].Width = 35;
            }


        }

        private void ButtonEditOrder_TIA_Click(object sender, EventArgs e)
        {
            EditOrderForm_TIA edit = new EditOrderForm_TIA();
            edit.ShowDialog();
        }

        private void ButtonSave_TIA_Click(object sender, EventArgs e)
        {
            // Ñîõðàíèòü äàííûå â CSV ôàéë
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void êðàòêîåÐóêÏîëüçîâàòåëÿToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FormAboutMe formAbout = new FormAboutMe();
            formAbout.ShowDialog();
        }

        private void îÏðîãðàììåToolStripMenuItem_Click(object sender, EventArgs e)
        {
             FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}
