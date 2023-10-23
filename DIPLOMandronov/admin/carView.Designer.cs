namespace DIPLOMandronov.admin
{
    partial class carView
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttoтDeleteCar = new System.Windows.Forms.Button();
            this.buttonRemont = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(34, 149);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(734, 276);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // buttoтDeleteCar
            // 
            this.buttoтDeleteCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttoтDeleteCar.Location = new System.Drawing.Point(92, 68);
            this.buttoтDeleteCar.Name = "buttoтDeleteCar";
            this.buttoтDeleteCar.Size = new System.Drawing.Size(165, 61);
            this.buttoтDeleteCar.TabIndex = 1;
            this.buttoтDeleteCar.Text = "Удалить авто";
            this.buttoтDeleteCar.UseVisualStyleBackColor = true;
            // 
            // buttonRemont
            // 
            this.buttonRemont.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRemont.Location = new System.Drawing.Point(537, 68);
            this.buttonRemont.Name = "buttonRemont";
            this.buttonRemont.Size = new System.Drawing.Size(161, 61);
            this.buttonRemont.TabIndex = 2;
            this.buttonRemont.Text = "Отправить на ремонт";
            this.buttonRemont.UseVisualStyleBackColor = true;
            // 
            // carView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonRemont);
            this.Controls.Add(this.buttoтDeleteCar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "carView";
            this.Text = "carView";
            this.Load += new System.EventHandler(this.carView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttoтDeleteCar;
        private System.Windows.Forms.Button buttonRemont;
    }
}