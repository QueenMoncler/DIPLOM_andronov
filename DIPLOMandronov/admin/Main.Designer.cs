namespace DIPLOMandronov.admin
{
    partial class Main
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
            this.buttonAddAdmin = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonDataGridDBView = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.addNewCar = new DIPLOMandronov.admin.AddNewCar();
            this.dataGridDBView = new DIPLOMandronov.admin.DataGridDBView();
            this.addRabotnik = new DIPLOMandronov.admin.AddRabotnik();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.buttonAddAdmin);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.buttonDataGridDBView);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(226, 620);
            this.panel1.TabIndex = 0;
            // 
            // buttonAddAdmin
            // 
            this.buttonAddAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddAdmin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonAddAdmin.Location = new System.Drawing.Point(3, 251);
            this.buttonAddAdmin.Name = "buttonAddAdmin";
            this.buttonAddAdmin.Size = new System.Drawing.Size(217, 70);
            this.buttonAddAdmin.TabIndex = 2;
            this.buttonAddAdmin.Text = "Добавить Администратора";
            this.buttonAddAdmin.UseVisualStyleBackColor = true;
            this.buttonAddAdmin.Click += new System.EventHandler(this.buttonAddAdmin_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(3, 166);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(217, 70);
            this.button2.TabIndex = 1;
            this.button2.Text = "Добавить авто";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonDataGridDBView
            // 
            this.buttonDataGridDBView.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDataGridDBView.ForeColor = System.Drawing.SystemColors.Desktop;
            this.buttonDataGridDBView.Location = new System.Drawing.Point(3, 87);
            this.buttonDataGridDBView.Name = "buttonDataGridDBView";
            this.buttonDataGridDBView.Size = new System.Drawing.Size(217, 70);
            this.buttonDataGridDBView.TabIndex = 0;
            this.buttonDataGridDBView.Text = "Автомобили";
            this.buttonDataGridDBView.UseVisualStyleBackColor = true;
            this.buttonDataGridDBView.Click += new System.EventHandler(this.buttonDataGridDBView_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SandyBrown;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(226, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(798, 50);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(257, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Аренда Автомобилей";
            // 
            // addNewCar
            // 
            this.addNewCar.ForeColor = System.Drawing.Color.Black;
            this.addNewCar.Location = new System.Drawing.Point(226, 88);
            this.addNewCar.Name = "addNewCar";
            this.addNewCar.Size = new System.Drawing.Size(780, 520);
            this.addNewCar.TabIndex = 3;
            this.addNewCar.Visible = false;
            // 
            // dataGridDBView
            // 
            this.dataGridDBView.ForeColor = System.Drawing.Color.Black;
            this.dataGridDBView.Location = new System.Drawing.Point(232, 88);
            this.dataGridDBView.Name = "dataGridDBView";
            this.dataGridDBView.Size = new System.Drawing.Size(780, 520);
            this.dataGridDBView.TabIndex = 2;
            // 
            // addRabotnik
            // 
            this.addRabotnik.BackColor = System.Drawing.Color.Transparent;
            this.addRabotnik.ForeColor = System.Drawing.Color.Black;
            this.addRabotnik.Location = new System.Drawing.Point(232, 100);
            this.addRabotnik.Name = "addRabotnik";
            this.addRabotnik.Size = new System.Drawing.Size(780, 520);
            this.addRabotnik.TabIndex = 3;
            this.addRabotnik.Visible = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1024, 620);
            this.Controls.Add(this.addRabotnik);
            this.Controls.Add(this.addNewCar);
            this.Controls.Add(this.dataGridDBView);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Name = "Main";
            this.Text = "Main";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAddAdmin;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonDataGridDBView;
        private DataGridDBView dataGridDBView;
        private AddNewCar addNewCar;
        private AddRabotnik addRabotnik;
    }
}