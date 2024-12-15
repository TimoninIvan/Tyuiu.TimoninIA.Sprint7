// MainForm.Designer.cs
namespace Tyuiu.TimoninIA.Sprint7.Project.V10
{
    partial class MainForm_TIA
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewOrders_TIA;
        private System.Windows.Forms.Button buttonAddOrder_TIA;
        private System.Windows.Forms.Button buttonSaveOrders_TIA;
        private System.Windows.Forms.Button buttonSearch_TIA;
        private System.Windows.Forms.TextBox textBoxSearch_TIA;
        private System.Windows.Forms.Button buttonSortByDate_TIA;
        private System.Windows.Forms.Button buttonSortByPrice_TIA;
        private System.Windows.Forms.Button buttonFilterByPrice_TIA;
        private System.Windows.Forms.TextBox textBoxMinPrice_TIA;
        private System.Windows.Forms.TextBox textBoxMaxPrice_TIA;
        private System.Windows.Forms.Button buttonStatistics_TIA;
        private System.Windows.Forms.Label labelStatistics_TIA;
        private System.Windows.Forms.Button buttonLoadCSV_TIA;

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm_TIA));
            dataGridViewOrders_TIA = new DataGridView();
            buttonAddOrder_TIA = new Button();
            buttonSaveOrders_TIA = new Button();
            buttonSearch_TIA = new Button();
            textBoxSearch_TIA = new TextBox();
            buttonSortByDate_TIA = new Button();
            buttonSortByPrice_TIA = new Button();
            buttonFilterByPrice_TIA = new Button();
            textBoxMinPrice_TIA = new TextBox();
            textBoxMaxPrice_TIA = new TextBox();
            buttonStatistics_TIA = new Button();
            labelStatistics_TIA = new Label();
            buttonLoadCSV_TIA = new Button();
            chartOrders_TIA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            toolStripTIA = new ToolStrip();
            toolStripButtonAbout = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            toolStripButton1 = new ToolStripButton();
            toolTip1 = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrders_TIA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartOrders_TIA).BeginInit();
            toolStripTIA.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewOrders_TIA
            // 
            dataGridViewOrders_TIA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOrders_TIA.Dock = DockStyle.Fill;
            dataGridViewOrders_TIA.Location = new Point(0, 0);
            dataGridViewOrders_TIA.Name = "dataGridViewOrders_TIA";
            dataGridViewOrders_TIA.Size = new Size(934, 507);
            dataGridViewOrders_TIA.TabIndex = 0;
            // 
            // buttonAddOrder_TIA
            // 
            buttonAddOrder_TIA.Location = new Point(129, 365);
            buttonAddOrder_TIA.Name = "buttonAddOrder_TIA";
            buttonAddOrder_TIA.Size = new Size(75, 23);
            buttonAddOrder_TIA.TabIndex = 1;
            buttonAddOrder_TIA.Text = "Добавить заказ";
            toolTip1.SetToolTip(buttonAddOrder_TIA, "Добавить файл в приложении");
            buttonAddOrder_TIA.UseVisualStyleBackColor = true;
            buttonAddOrder_TIA.Click += buttonAddOrder_TIA_Click;
            // 
            // buttonSaveOrders_TIA
            // 
            buttonSaveOrders_TIA.ForeColor = Color.Green;
            buttonSaveOrders_TIA.Location = new Point(210, 365);
            buttonSaveOrders_TIA.Name = "buttonSaveOrders_TIA";
            buttonSaveOrders_TIA.Size = new Size(89, 23);
            buttonSaveOrders_TIA.TabIndex = 2;
            buttonSaveOrders_TIA.Text = "Сохранить";
            toolTip1.SetToolTip(buttonSaveOrders_TIA, "Сохранить данные");
            buttonSaveOrders_TIA.UseVisualStyleBackColor = true;
            buttonSaveOrders_TIA.Click += buttonSaveOrders_TIA_Click;
            // 
            // buttonSearch_TIA
            // 
            buttonSearch_TIA.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSearch_TIA.Location = new Point(305, 365);
            buttonSearch_TIA.Name = "buttonSearch_TIA";
            buttonSearch_TIA.Size = new Size(75, 23);
            buttonSearch_TIA.TabIndex = 3;
            buttonSearch_TIA.Text = "Найти";
            toolTip1.SetToolTip(buttonSearch_TIA, "Найти заказ по данным");
            buttonSearch_TIA.UseVisualStyleBackColor = true;
            buttonSearch_TIA.Click += buttonSearch_TIA_Click;
            // 
            // textBoxSearch_TIA
            // 
            textBoxSearch_TIA.Location = new Point(386, 365);
            textBoxSearch_TIA.Name = "textBoxSearch_TIA";
            textBoxSearch_TIA.Size = new Size(88, 23);
            textBoxSearch_TIA.TabIndex = 4;
            // 
            // buttonSortByDate_TIA
            // 
            buttonSortByDate_TIA.Location = new Point(480, 368);
            buttonSortByDate_TIA.Name = "buttonSortByDate_TIA";
            buttonSortByDate_TIA.Size = new Size(87, 43);
            buttonSortByDate_TIA.TabIndex = 5;
            buttonSortByDate_TIA.Text = "Сортировать по дате";
            toolTip1.SetToolTip(buttonSortByDate_TIA, "Сортировка по дате ");
            buttonSortByDate_TIA.UseVisualStyleBackColor = true;
            buttonSortByDate_TIA.Click += buttonSortByDate_TIA_Click_1;
            // 
            // buttonSortByPrice_TIA
            // 
            buttonSortByPrice_TIA.Location = new Point(573, 366);
            buttonSortByPrice_TIA.Name = "buttonSortByPrice_TIA";
            buttonSortByPrice_TIA.Size = new Size(96, 43);
            buttonSortByPrice_TIA.TabIndex = 6;
            buttonSortByPrice_TIA.Text = "Сортировать по цене";
            toolTip1.SetToolTip(buttonSortByPrice_TIA, "Сортировка по цене");
            buttonSortByPrice_TIA.UseVisualStyleBackColor = true;
            buttonSortByPrice_TIA.Click += buttonSortByPrice_TIA_Click_1;
            // 
            // buttonFilterByPrice_TIA
            // 
            buttonFilterByPrice_TIA.Location = new Point(675, 365);
            buttonFilterByPrice_TIA.Name = "buttonFilterByPrice_TIA";
            buttonFilterByPrice_TIA.Size = new Size(75, 43);
            buttonFilterByPrice_TIA.TabIndex = 7;
            buttonFilterByPrice_TIA.Text = "Фильтр цены";
            toolTip1.SetToolTip(buttonFilterByPrice_TIA, "Искать от заданной цены");
            buttonFilterByPrice_TIA.UseVisualStyleBackColor = true;
            buttonFilterByPrice_TIA.Click += buttonFilterByPrice_TIA_Click_1;
            // 
            // textBoxMinPrice_TIA
            // 
            textBoxMinPrice_TIA.Location = new Point(756, 369);
            textBoxMinPrice_TIA.Name = "textBoxMinPrice_TIA";
            textBoxMinPrice_TIA.Size = new Size(41, 23);
            textBoxMinPrice_TIA.TabIndex = 8;
            // 
            // textBoxMaxPrice_TIA
            // 
            textBoxMaxPrice_TIA.Location = new Point(803, 369);
            textBoxMaxPrice_TIA.Name = "textBoxMaxPrice_TIA";
            textBoxMaxPrice_TIA.Size = new Size(34, 23);
            textBoxMaxPrice_TIA.TabIndex = 9;
            // 
            // buttonStatistics_TIA
            // 
            buttonStatistics_TIA.Location = new Point(843, 368);
            buttonStatistics_TIA.Name = "buttonStatistics_TIA";
            buttonStatistics_TIA.Size = new Size(91, 23);
            buttonStatistics_TIA.TabIndex = 10;
            buttonStatistics_TIA.Text = "Статистика";
            toolTip1.SetToolTip(buttonStatistics_TIA, "Статистика таблицы");
            buttonStatistics_TIA.UseVisualStyleBackColor = true;
            buttonStatistics_TIA.Click += buttonStatistics_TIA_Click;
            // 
            // labelStatistics_TIA
            // 
            labelStatistics_TIA.Location = new Point(0, 412);
            labelStatistics_TIA.Name = "labelStatistics_TIA";
            labelStatistics_TIA.Size = new Size(776, 33);
            labelStatistics_TIA.TabIndex = 11;
            labelStatistics_TIA.Text = "Статистика расположена тут";
            // 
            // buttonLoadCSV_TIA
            // 
            buttonLoadCSV_TIA.Location = new Point(12, 363);
            buttonLoadCSV_TIA.Name = "buttonLoadCSV_TIA";
            buttonLoadCSV_TIA.Size = new Size(111, 26);
            buttonLoadCSV_TIA.TabIndex = 12;
            buttonLoadCSV_TIA.Text = "Загрузить файл";
            toolTip1.SetToolTip(buttonLoadCSV_TIA, "Выбрать файл и загрузить в приложении");
            buttonLoadCSV_TIA.UseVisualStyleBackColor = true;
            buttonLoadCSV_TIA.Click += buttonLoadCSV_TIA_Click_1;
            // 
            // chartOrders_TIA
            // 
            chartArea1.Name = "ChartArea1";
            chartOrders_TIA.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartOrders_TIA.Legends.Add(legend1);
            chartOrders_TIA.Location = new Point(0, 448);
            chartOrders_TIA.Name = "chartOrders_TIA";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartOrders_TIA.Series.Add(series1);
            chartOrders_TIA.Size = new Size(425, 159);
            chartOrders_TIA.TabIndex = 13;
            chartOrders_TIA.Text = "chart1";
            // 
            // toolStripTIA
            // 
            toolStripTIA.Dock = DockStyle.Bottom;
            toolStripTIA.GripStyle = ToolStripGripStyle.Hidden;
            toolStripTIA.Items.AddRange(new ToolStripItem[] { toolStripButtonAbout, toolStripButton2 });
            toolStripTIA.Location = new Point(0, 482);
            toolStripTIA.Name = "toolStripTIA";
            toolStripTIA.Size = new Size(934, 25);
            toolStripTIA.TabIndex = 0;
            // 
            // toolStripButtonAbout
            // 
            toolStripButtonAbout.Image = (Image)resources.GetObject("toolStripButtonAbout.Image");
            toolStripButtonAbout.ImageTransparentColor = Color.Magenta;
            toolStripButtonAbout.Name = "toolStripButtonAbout";
            toolStripButtonAbout.Size = new Size(157, 22);
            toolStripButtonAbout.Text = "Справка о приложении";
            toolStripButtonAbout.ToolTipText = "О чем приложение";
            toolStripButtonAbout.Click += toolStripButtonAbout_Click;
            // 
            // toolStripButton2
            // 
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(126, 22);
            toolStripButton2.Text = "Рук.Пользователя";
            toolStripButton2.ToolTipText = "Краткое руководство пользователя";
            toolStripButton2.Click += toolStripButton2_Click;
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(23, 22);
            toolStripButton1.Text = "toolStripButton1";
            // 
            // MainForm_TIA
            // 
            ClientSize = new Size(934, 507);
            Controls.Add(toolStripTIA);
            Controls.Add(chartOrders_TIA);
            Controls.Add(buttonLoadCSV_TIA);
            Controls.Add(labelStatistics_TIA);
            Controls.Add(buttonStatistics_TIA);
            Controls.Add(textBoxMaxPrice_TIA);
            Controls.Add(textBoxMinPrice_TIA);
            Controls.Add(buttonFilterByPrice_TIA);
            Controls.Add(buttonSortByPrice_TIA);
            Controls.Add(buttonSortByDate_TIA);
            Controls.Add(textBoxSearch_TIA);
            Controls.Add(buttonSearch_TIA);
            Controls.Add(buttonSaveOrders_TIA);
            Controls.Add(buttonAddOrder_TIA);
            Controls.Add(dataGridViewOrders_TIA);
            Name = "MainForm_TIA";
            Text = "Приложени по заказам.Выполнил студент группы ИИПБ 24-1. Тимонин Иван Александрович";
            WindowState = FormWindowState.Maximized;
            Load += MainForm_TIA_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrders_TIA).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartOrders_TIA).EndInit();
            toolStripTIA.ResumeLayout(false);
            toolStripTIA.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.DataVisualization.Charting.Chart chartOrders_TIA;
        private ToolStrip toolStripTIA;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButtonAbout;
        private ToolTip toolTip1;
        private ToolStripButton toolStripButton2;
    }
}
