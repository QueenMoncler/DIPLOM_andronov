namespace DIPLOMandronov.admin
{
    partial class DataGridDBView
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonHatchback = new System.Windows.Forms.Button();
            this.buttonUni = new System.Windows.Forms.Button();
            this.buttonSedan = new System.Windows.Forms.Button();
            this.buttonAllauto = new System.Windows.Forms.Button();
            this.dataGridViewDB = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDB)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonHatchback
            // 
            this.buttonHatchback.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonHatchback.Location = new System.Drawing.Point(598, 35);
            this.buttonHatchback.Name = "buttonHatchback";
            this.buttonHatchback.Size = new System.Drawing.Size(172, 42);
            this.buttonHatchback.TabIndex = 9;
            this.buttonHatchback.Text = "Хэтчбеки";
            this.buttonHatchback.UseVisualStyleBackColor = true;
            this.buttonHatchback.Click += new System.EventHandler(this.buttonHatchback_Click);
            // 
            // buttonUni
            // 
            this.buttonUni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonUni.Location = new System.Drawing.Point(402, 35);
            this.buttonUni.Name = "buttonUni";
            this.buttonUni.Size = new System.Drawing.Size(178, 42);
            this.buttonUni.TabIndex = 8;
            this.buttonUni.Text = "Универсалы";
            this.buttonUni.UseVisualStyleBackColor = true;
            this.buttonUni.Click += new System.EventHandler(this.buttonUni_Click);
            // 
            // buttonSedan
            // 
            this.buttonSedan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSedan.Location = new System.Drawing.Point(195, 35);
            this.buttonSedan.Name = "buttonSedan";
            this.buttonSedan.Size = new System.Drawing.Size(177, 42);
            this.buttonSedan.TabIndex = 7;
            this.buttonSedan.Text = "Седаны";
            this.buttonSedan.UseVisualStyleBackColor = true;
            this.buttonSedan.Click += new System.EventHandler(this.buttonSedan_Click);
            // 
            // buttonAllauto
            // 
            this.buttonAllauto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAllauto.Location = new System.Drawing.Point(3, 35);
            this.buttonAllauto.Name = "buttonAllauto";
            this.buttonAllauto.Size = new System.Drawing.Size(175, 42);
            this.buttonAllauto.TabIndex = 6;
            this.buttonAllauto.Text = "Все авто";
            this.buttonAllauto.UseVisualStyleBackColor = true;
            this.buttonAllauto.Click += new System.EventHandler(this.buttonAllauto_Click);
            // 
            // dataGridViewDB
            // 
            this.dataGridViewDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDB.Location = new System.Drawing.Point(3, 105);
            this.dataGridViewDB.Name = "dataGridViewDB";
            this.dataGridViewDB.RowHeadersWidth = 62;
            this.dataGridViewDB.RowTemplate.Height = 28;
            this.dataGridViewDB.Size = new System.Drawing.Size(767, 383);
            this.dataGridViewDB.TabIndex = 5;
            // 
            // DataGridDBView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonHatchback);
            this.Controls.Add(this.buttonUni);
            this.Controls.Add(this.buttonSedan);
            this.Controls.Add(this.buttonAllauto);
            this.Controls.Add(this.dataGridViewDB);
            this.Name = "DataGridDBView";
            this.Size = new System.Drawing.Size(780, 520);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonHatchback;
        private System.Windows.Forms.Button buttonUni;
        private System.Windows.Forms.Button buttonSedan;
        private System.Windows.Forms.Button buttonAllauto;
        private System.Windows.Forms.DataGridView dataGridViewDB;
    }
}
