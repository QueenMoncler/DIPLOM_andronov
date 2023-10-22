namespace DIPLOMandronov.admin
{
    partial class AddCar
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
            this.comboBoxTypeKyzov = new System.Windows.Forms.ComboBox();
            this.comboBoxMarka = new System.Windows.Forms.ComboBox();
            this.textBoxModel = new System.Windows.Forms.TextBox();
            this.textBoxGosNum = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // comboBoxTypeKyzov
            // 
            this.comboBoxTypeKyzov.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxTypeKyzov.FormattingEnabled = true;
            this.comboBoxTypeKyzov.Items.AddRange(new object[] {
            "Купе",
            "Универсал",
            "Седан",
            "Хетчбек",
            "Кнедорожник",
            "Пикап",
            "Кабриолет",
            "Лимузин"});
            this.comboBoxTypeKyzov.Location = new System.Drawing.Point(44, 25);
            this.comboBoxTypeKyzov.Name = "comboBoxTypeKyzov";
            this.comboBoxTypeKyzov.Size = new System.Drawing.Size(270, 33);
            this.comboBoxTypeKyzov.TabIndex = 1;
            this.comboBoxTypeKyzov.Text = "Тип кузова";
            // 
            // comboBoxMarka
            // 
            this.comboBoxMarka.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxMarka.FormattingEnabled = true;
            this.comboBoxMarka.Items.AddRange(new object[] {
            "LADA",
            "TOYOTA",
            "NISSAN",
            "HYUNDAI",
            "KIA",
            "RENAULT",
            "CHEVROLET",
            "VOLKSWAGEN",
            "FORD",
            "MITSUBISHI"});
            this.comboBoxMarka.Location = new System.Drawing.Point(45, 94);
            this.comboBoxMarka.Name = "comboBoxMarka";
            this.comboBoxMarka.Size = new System.Drawing.Size(269, 33);
            this.comboBoxMarka.TabIndex = 2;
            this.comboBoxMarka.Text = "Марка";
            // 
            // textBoxModel
            // 
            this.textBoxModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxModel.Location = new System.Drawing.Point(44, 181);
            this.textBoxModel.Name = "textBoxModel";
            this.textBoxModel.Size = new System.Drawing.Size(270, 30);
            this.textBoxModel.TabIndex = 3;
            // 
            // textBoxGosNum
            // 
            this.textBoxGosNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxGosNum.Location = new System.Drawing.Point(44, 337);
            this.textBoxGosNum.Name = "textBoxGosNum";
            this.textBoxGosNum.Size = new System.Drawing.Size(270, 30);
            this.textBoxGosNum.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(334, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 225);
            this.button1.TabIndex = 5;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(39, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Модель";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(40, 311);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(284, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Гос.Номер(пример: Н694СО)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(39, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "год";
            // 
            // textBoxYear
            // 
            this.textBoxYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxYear.Location = new System.Drawing.Point(44, 260);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(270, 30);
            this.textBoxYear.TabIndex = 8;
            // 
            // AddCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 399);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxYear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxGosNum);
            this.Controls.Add(this.textBoxModel);
            this.Controls.Add(this.comboBoxMarka);
            this.Controls.Add(this.comboBoxTypeKyzov);
            this.Name = "AddCar";
            this.Text = "addCar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxTypeKyzov;
        private System.Windows.Forms.ComboBox comboBoxMarka;
        private System.Windows.Forms.TextBox textBoxModel;
        private System.Windows.Forms.TextBox textBoxGosNum;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxYear;
    }
}