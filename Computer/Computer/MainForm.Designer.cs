namespace Computer
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.AuthPanel = new System.Windows.Forms.Panel();
            this.FilterPanel = new System.Windows.Forms.Panel();
            this.InfoPanel = new System.Windows.Forms.Panel();
            this.Auth = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PassTextBox = new System.Windows.Forms.TextBox();
            this.ModelComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TypeComboBox = new System.Windows.Forms.ComboBox();
            this.Filtbutton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.PriceCombobox = new System.Windows.Forms.ComboBox();
            this.FindButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.AuthPanel.SuspendLayout();
            this.FilterPanel.SuspendLayout();
            this.InfoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // AuthPanel
            // 
            this.AuthPanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.AuthPanel.Controls.Add(this.PassTextBox);
            this.AuthPanel.Controls.Add(this.label2);
            this.AuthPanel.Controls.Add(this.LoginTextBox);
            this.AuthPanel.Controls.Add(this.label1);
            this.AuthPanel.Controls.Add(this.Auth);
            this.AuthPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.AuthPanel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AuthPanel.Location = new System.Drawing.Point(0, 0);
            this.AuthPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AuthPanel.Name = "AuthPanel";
            this.AuthPanel.Size = new System.Drawing.Size(1313, 95);
            this.AuthPanel.TabIndex = 0;
            this.AuthPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.AuthPanel_Paint);
            // 
            // FilterPanel
            // 
            this.FilterPanel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.FilterPanel.Controls.Add(this.FindButton);
            this.FilterPanel.Controls.Add(this.PriceCombobox);
            this.FilterPanel.Controls.Add(this.label5);
            this.FilterPanel.Controls.Add(this.Filtbutton);
            this.FilterPanel.Controls.Add(this.TypeComboBox);
            this.FilterPanel.Controls.Add(this.label4);
            this.FilterPanel.Controls.Add(this.label3);
            this.FilterPanel.Controls.Add(this.ModelComboBox);
            this.FilterPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.FilterPanel.Location = new System.Drawing.Point(0, 95);
            this.FilterPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FilterPanel.Name = "FilterPanel";
            this.FilterPanel.Size = new System.Drawing.Size(1313, 103);
            this.FilterPanel.TabIndex = 1;
            // 
            // InfoPanel
            // 
            this.InfoPanel.BackColor = System.Drawing.SystemColors.HotTrack;
            this.InfoPanel.Controls.Add(this.pictureBox3);
            this.InfoPanel.Controls.Add(this.pictureBox2);
            this.InfoPanel.Controls.Add(this.label8);
            this.InfoPanel.Controls.Add(this.label7);
            this.InfoPanel.Controls.Add(this.pictureBox1);
            this.InfoPanel.Controls.Add(this.label6);
            this.InfoPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.InfoPanel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InfoPanel.Location = new System.Drawing.Point(0, 198);
            this.InfoPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.InfoPanel.Name = "InfoPanel";
            this.InfoPanel.Size = new System.Drawing.Size(1313, 512);
            this.InfoPanel.TabIndex = 2;
            this.InfoPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.InfoPanel_Paint);
            // 
            // Auth
            // 
            this.Auth.Location = new System.Drawing.Point(1038, 12);
            this.Auth.Name = "Auth";
            this.Auth.Size = new System.Drawing.Size(242, 56);
            this.Auth.TabIndex = 0;
            this.Auth.Text = " Войти";
            this.Auth.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Логин";
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.Location = new System.Drawing.Point(115, 22);
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(370, 30);
            this.LoginTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(513, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Пароль";
            // 
            // PassTextBox
            // 
            this.PassTextBox.Location = new System.Drawing.Point(606, 22);
            this.PassTextBox.Name = "PassTextBox";
            this.PassTextBox.Size = new System.Drawing.Size(370, 30);
            this.PassTextBox.TabIndex = 4;
            // 
            // ModelComboBox
            // 
            this.ModelComboBox.FormattingEnabled = true;
            this.ModelComboBox.Items.AddRange(new object[] {
            "Gigabyte",
            "Gigabyte(Aorus)"});
            this.ModelComboBox.Location = new System.Drawing.Point(229, 28);
            this.ModelComboBox.Name = "ModelComboBox";
            this.ModelComboBox.Size = new System.Drawing.Size(256, 31);
            this.ModelComboBox.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "модель";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 23);
            this.label4.TabIndex = 2;
            this.label4.Text = "Тип комплектующего";
            // 
            // TypeComboBox
            // 
            this.TypeComboBox.FormattingEnabled = true;
            this.TypeComboBox.Items.AddRange(new object[] {
            "Видеокарта",
            "Процессор ",
            "оперативная паамять",
            "блок питания"});
            this.TypeComboBox.Location = new System.Drawing.Point(229, 68);
            this.TypeComboBox.Name = "TypeComboBox";
            this.TypeComboBox.Size = new System.Drawing.Size(256, 31);
            this.TypeComboBox.TabIndex = 3;
            // 
            // Filtbutton
            // 
            this.Filtbutton.Location = new System.Drawing.Point(3, 0);
            this.Filtbutton.Name = "Filtbutton";
            this.Filtbutton.Size = new System.Drawing.Size(169, 31);
            this.Filtbutton.TabIndex = 4;
            this.Filtbutton.Text = "Фильтр";
            this.Filtbutton.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(614, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 23);
            this.label5.TabIndex = 5;
            this.label5.Text = "Цена";
            // 
            // PriceCombobox
            // 
            this.PriceCombobox.FormattingEnabled = true;
            this.PriceCombobox.Location = new System.Drawing.Point(707, 34);
            this.PriceCombobox.Name = "PriceCombobox";
            this.PriceCombobox.Size = new System.Drawing.Size(121, 31);
            this.PriceCombobox.TabIndex = 6;
            // 
            // FindButton
            // 
            this.FindButton.Location = new System.Drawing.Point(1075, 8);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(138, 68);
            this.FindButton.TabIndex = 7;
            this.FindButton.Text = "Найти";
            this.FindButton.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(371, 23);
            this.label6.TabIndex = 0;
            this.label6.Text = "Процессор \"Amd Ryzen 5  5600G (Box)\"";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(16, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(351, 282);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(452, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(376, 23);
            this.label7.TabIndex = 2;
            this.label7.Text = "Видеокарта \"MSI GeForce GTX 1050 Ti\"\r\n";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(862, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(439, 23);
            this.label8.TabIndex = 3;
            this.label8.Text = "Блок питания \"Seasonic Prime TX-1000 1000W\"\r\n";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(456, 49);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(351, 282);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(876, 49);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(351, 282);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1313, 710);
            this.Controls.Add(this.InfoPanel);
            this.Controls.Add(this.FilterPanel);
            this.Controls.Add(this.AuthPanel);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.AuthPanel.ResumeLayout(false);
            this.AuthPanel.PerformLayout();
            this.FilterPanel.ResumeLayout(false);
            this.FilterPanel.PerformLayout();
            this.InfoPanel.ResumeLayout(false);
            this.InfoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel AuthPanel;
        private System.Windows.Forms.Panel FilterPanel;
        private System.Windows.Forms.Panel InfoPanel;
        private System.Windows.Forms.TextBox PassTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox LoginTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Auth;
        private System.Windows.Forms.Button FindButton;
        private System.Windows.Forms.ComboBox PriceCombobox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Filtbutton;
        private System.Windows.Forms.ComboBox TypeComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ModelComboBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}

