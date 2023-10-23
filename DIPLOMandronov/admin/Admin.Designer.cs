namespace DIPLOMandronov.admin
{
    partial class Admin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddCar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonViewCar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonViewCar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnAddCar);
            this.panel1.Location = new System.Drawing.Point(83, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(432, 132);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(147, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Автомобили";
            // 
            // btnAddCar
            // 
            this.btnAddCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddCar.Location = new System.Drawing.Point(54, 76);
            this.btnAddCar.Name = "btnAddCar";
            this.btnAddCar.Size = new System.Drawing.Size(160, 43);
            this.btnAddCar.TabIndex = 0;
            this.btnAddCar.Text = "Добавить";
            this.btnAddCar.UseVisualStyleBackColor = true;
            this.btnAddCar.Click += new System.EventHandler(this.btnAddCar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1027, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonViewCar
            // 
            this.buttonViewCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonViewCar.Location = new System.Drawing.Point(220, 76);
            this.buttonViewCar.Name = "buttonViewCar";
            this.buttonViewCar.Size = new System.Drawing.Size(160, 43);
            this.buttonViewCar.TabIndex = 2;
            this.buttonViewCar.Text = "Смотреть";
            this.buttonViewCar.UseVisualStyleBackColor = true;
            this.buttonViewCar.Click += new System.EventHandler(this.buttonViewCar_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 759);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Name = "Admin";
            this.Text = "admin";
            this.Load += new System.EventHandler(this.admin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddCar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonViewCar;
    }
}