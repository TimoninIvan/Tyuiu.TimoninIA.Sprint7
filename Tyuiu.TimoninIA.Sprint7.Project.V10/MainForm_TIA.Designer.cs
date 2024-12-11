using System.Windows.Forms;

namespace Tyuiu.TimoninIA.Sprint7.Project.V10
{
    partial class MainForm_TIA
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MenuStrip menuStripMain_TIA;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStripMain_TIA;
        private System.Windows.Forms.ToolStripButton buttonEditOrder_TIA;
        private System.Windows.Forms.ToolStripButton buttonSave_TIA;
        private System.Windows.Forms.DataGridView dataGridViewOrders_TIA;
        private System.Windows.Forms.ToolTip toolTipMain_TIA;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm_TIA));
            menuStripMain_TIA = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            оПрограммеToolStripMenuItem = new ToolStripMenuItem();
            краткоеРукПользователяToolStripMenuItem = new ToolStripMenuItem();
            toolStripMain_TIA = new ToolStrip();
            buttonAddOrder_TIA = new ToolStripButton();
            buttonEditOrder_TIA = new ToolStripButton();
            buttonSave_TIA = new ToolStripButton();
            dataGridViewOrders_TIA = new DataGridView();
            openFileDialogTask_TIA = new OpenFileDialog();
            menuStripMain_TIA.SuspendLayout();
            toolStripMain_TIA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrders_TIA).BeginInit();
            SuspendLayout();
            // 
            // menuStripMain_TIA
            // 
            menuStripMain_TIA.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, helpToolStripMenuItem });
            menuStripMain_TIA.Location = new Point(0, 0);
            menuStripMain_TIA.Name = "menuStripMain_TIA";
            menuStripMain_TIA.Padding = new Padding(7, 2, 0, 2);
            menuStripMain_TIA.Size = new Size(933, 24);
            menuStripMain_TIA.TabIndex = 0;
            menuStripMain_TIA.Text = "menuStripMain_TIA";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(48, 20);
            fileToolStripMenuItem.Text = "Файл";
            fileToolStripMenuItem.Click += fileToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(99, 20);
            editToolStripMenuItem.Text = "Редактировать";
            editToolStripMenuItem.Click += editToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { оПрограммеToolStripMenuItem, краткоеРукПользователяToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(65, 20);
            helpToolStripMenuItem.Text = "Справка";
            // 
            // оПрограммеToolStripMenuItem
            // 
            оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            оПрограммеToolStripMenuItem.Size = new Size(221, 22);
            оПрограммеToolStripMenuItem.Text = "О программе";
            оПрограммеToolStripMenuItem.Click += оПрограммеToolStripMenuItem_Click;
            // 
            // краткоеРукПользователяToolStripMenuItem
            // 
            краткоеРукПользователяToolStripMenuItem.Name = "краткоеРукПользователяToolStripMenuItem";
            краткоеРукПользователяToolStripMenuItem.Size = new Size(221, 22);
            краткоеРукПользователяToolStripMenuItem.Text = "Краткое рук. пользователя";
            краткоеРукПользователяToolStripMenuItem.Click += краткоеРукПользователяToolStripMenuItem_Click_1;
            // 
            // toolStripMain_TIA
            // 
            toolStripMain_TIA.Items.AddRange(new ToolStripItem[] { buttonAddOrder_TIA, buttonEditOrder_TIA, buttonSave_TIA });
            toolStripMain_TIA.Location = new Point(0, 24);
            toolStripMain_TIA.Name = "toolStripMain_TIA";
            toolStripMain_TIA.Size = new Size(933, 25);
            toolStripMain_TIA.TabIndex = 1;
            toolStripMain_TIA.Text = "toolStripMain_TIA";
            // 
            // buttonAddOrder_TIA
            // 
            buttonAddOrder_TIA.Image = (Image)resources.GetObject("buttonAddOrder_TIA.Image");
            buttonAddOrder_TIA.Name = "buttonAddOrder_TIA";
            buttonAddOrder_TIA.Size = new Size(110, 22);
            buttonAddOrder_TIA.Text = "Добавить заказ";
            buttonAddOrder_TIA.Click += ButtonAddOrder_TIA_Click;
            // 
            // buttonEditOrder_TIA
            // 
            buttonEditOrder_TIA.Image = (Image)resources.GetObject("buttonEditOrder_TIA.Image");
            buttonEditOrder_TIA.Name = "buttonEditOrder_TIA";
            buttonEditOrder_TIA.Size = new Size(138, 22);
            buttonEditOrder_TIA.Text = "Редактировать заказ";
            buttonEditOrder_TIA.Click += ButtonEditOrder_TIA_Click;
            // 
            // buttonSave_TIA
            // 
            buttonSave_TIA.Image = (Image)resources.GetObject("buttonSave_TIA.Image");
            buttonSave_TIA.Name = "buttonSave_TIA";
            buttonSave_TIA.Size = new Size(86, 22);
            buttonSave_TIA.Text = "Сохранить";
            buttonSave_TIA.Click += ButtonSave_TIA_Click;
            // 
            // dataGridViewOrders_TIA
            // 
            dataGridViewOrders_TIA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOrders_TIA.Dock = DockStyle.Fill;
            dataGridViewOrders_TIA.Location = new Point(0, 49);
            dataGridViewOrders_TIA.Margin = new Padding(4, 3, 4, 3);
            dataGridViewOrders_TIA.Name = "dataGridViewOrders_TIA";
            dataGridViewOrders_TIA.Size = new Size(933, 470);
            dataGridViewOrders_TIA.TabIndex = 2;
            // 
            // openFileDialogTask_TIA
            // 
            openFileDialogTask_TIA.FileName = "openFileDialog1";
            // 
            // MainForm_TIA
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 519);
            Controls.Add(dataGridViewOrders_TIA);
            Controls.Add(toolStripMain_TIA);
            Controls.Add(menuStripMain_TIA);
            MainMenuStrip = menuStripMain_TIA;
            Margin = new Padding(4, 3, 4, 3);
            MinimizeBox = false;
            MinimumSize = new Size(949, 558);
            Name = "MainForm_TIA";
            Text = "Главное меню";
            menuStripMain_TIA.ResumeLayout(false);
            menuStripMain_TIA.PerformLayout();
            toolStripMain_TIA.ResumeLayout(false);
            toolStripMain_TIA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrders_TIA).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private ToolTip toolTipMain;
        private OpenFileDialog openFileDialogTask_TIA;
        private ToolStripButton buttonAddOrder_TIA;
        private ToolStripMenuItem оПрограммеToolStripMenuItem;
        private ToolStripMenuItem краткоеРукПользователяToolStripMenuItem;
    }
}