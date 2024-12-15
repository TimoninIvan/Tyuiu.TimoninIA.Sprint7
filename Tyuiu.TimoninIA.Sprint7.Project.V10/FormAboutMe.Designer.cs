namespace Tyuiu.TimoninIA.Sprint7.Project.V10
{
    partial class FormAboutMe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAboutMe));
            textBoxAboutMe = new TextBox();
            buttonOK_TIA = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBoxAboutMe
            // 
            textBoxAboutMe.Dock = DockStyle.Fill;
            textBoxAboutMe.Font = new Font("Segoe UI", 12F);
            textBoxAboutMe.Location = new Point(0, 0);
            textBoxAboutMe.Multiline = true;
            textBoxAboutMe.Name = "textBoxAboutMe";
            textBoxAboutMe.ReadOnly = true;
            textBoxAboutMe.Size = new Size(554, 522);
            textBoxAboutMe.TabIndex = 1;
            textBoxAboutMe.Text = "Проект выполнил студент группы ИИПБ 24-1. Тимонин Иван Александрович по предметной области: Заказы";
            // 
            // buttonOK_TIA
            // 
            buttonOK_TIA.Location = new Point(458, 497);
            buttonOK_TIA.Name = "buttonOK_TIA";
            buttonOK_TIA.Size = new Size(75, 23);
            buttonOK_TIA.TabIndex = 2;
            buttonOK_TIA.Text = "Ok";
            buttonOK_TIA.UseVisualStyleBackColor = true;
            buttonOK_TIA.Click += buttonOK_TIA_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1, 76);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(557, 415);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // FormAboutMe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(554, 522);
            Controls.Add(pictureBox1);
            Controls.Add(buttonOK_TIA);
            Controls.Add(textBoxAboutMe);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAboutMe";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormAboutMe";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBoxAboutMe;
        private Button buttonOK_TIA;
        private PictureBox pictureBox1;
    }
}