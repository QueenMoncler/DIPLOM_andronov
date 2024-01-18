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
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxColor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxPower = new System.Windows.Forms.TextBox();
            this.buttonEdit = new System.Windows.Forms.Button();
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
            this.comboBoxTypeKyzov.Location = new System.Drawing.Point(50, 31);
            this.comboBoxTypeKyzov.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxTypeKyzov.Name = "comboBoxTypeKyzov";
            this.comboBoxTypeKyzov.Size = new System.Drawing.Size(303, 37);
            this.comboBoxTypeKyzov.TabIndex = 1;
            this.comboBoxTypeKyzov.Text = "Тип кузова";
            this.comboBoxTypeKyzov.SelectedIndexChanged += new System.EventHandler(this.comboBoxTypeKyzov_SelectedIndexChanged);
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
            this.comboBoxMarka.Location = new System.Drawing.Point(51, 118);
            this.comboBoxMarka.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxMarka.Name = "comboBoxMarka";
            this.comboBoxMarka.Size = new System.Drawing.Size(302, 37);
            this.comboBoxMarka.TabIndex = 2;
            this.comboBoxMarka.Text = "Марка";
            this.comboBoxMarka.SelectedIndexChanged += new System.EventHandler(this.comboBoxMarka_SelectedIndexChanged);
            // 
            // textBoxModel
            // 
            this.textBoxModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxModel.Location = new System.Drawing.Point(50, 226);
            this.textBoxModel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxModel.Name = "textBoxModel";
            this.textBoxModel.Size = new System.Drawing.Size(303, 35);
            this.textBoxModel.TabIndex = 3;
            this.textBoxModel.TextChanged += new System.EventHandler(this.textBoxModel_TextChanged);
            // 
            // textBoxGosNum
            // 
            this.textBoxGosNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxGosNum.Location = new System.Drawing.Point(49, 581);
            this.textBoxGosNum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxGosNum.Name = "textBoxGosNum";
            this.textBoxGosNum.Size = new System.Drawing.Size(303, 35);
            this.textBoxGosNum.TabIndex = 4;
            this.textBoxGosNum.TextChanged += new System.EventHandler(this.textBoxGosNum_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(376, 118);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 281);
            this.button1.TabIndex = 5;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(44, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Модель";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(44, 549);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(346, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "Гос.Номер(пример: Н694СО)";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(44, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 29);
            this.label3.TabIndex = 9;
            this.label3.Text = "Год";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBoxYear
            // 
            this.textBoxYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxYear.Location = new System.Drawing.Point(50, 315);
            this.textBoxYear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(303, 35);
            this.textBoxYear.TabIndex = 8;
            this.textBoxYear.TextChanged += new System.EventHandler(this.textBoxYear_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(45, 374);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 29);
            this.label4.TabIndex = 11;
            this.label4.Text = "Цвет";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBoxColor
            // 
            this.textBoxColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxColor.Location = new System.Drawing.Point(51, 409);
            this.textBoxColor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxColor.Name = "textBoxColor";
            this.textBoxColor.Size = new System.Drawing.Size(303, 35);
            this.textBoxColor.TabIndex = 10;
            this.textBoxColor.TextChanged += new System.EventHandler(this.textBoxColor_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(45, 460);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(321, 29);
            this.label5.TabIndex = 13;
            this.label5.Text = "Мощность двигателя (л.с.)";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // textBoxPower
            // 
            this.textBoxPower.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPower.Location = new System.Drawing.Point(51, 495);
            this.textBoxPower.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxPower.Name = "textBoxPower";
            this.textBoxPower.Size = new System.Drawing.Size(303, 35);
            this.textBoxPower.TabIndex = 12;
            this.textBoxPower.TextChanged += new System.EventHandler(this.textBoxPower_TextChanged);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEdit.Location = new System.Drawing.Point(378, 122);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(148, 281);
            this.buttonEdit.TabIndex = 14;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Visible = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // AddCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 629);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxPower);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxColor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxYear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxGosNum);
            this.Controls.Add(this.textBoxModel);
            this.Controls.Add(this.comboBoxMarka);
            this.Controls.Add(this.comboBoxTypeKyzov);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AddCar";
            this.Text = "addCar";
            this.Load += new System.EventHandler(this.AddCar_Load);
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxColor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxPower;
        private System.Windows.Forms.Button buttonEdit;
    }
}