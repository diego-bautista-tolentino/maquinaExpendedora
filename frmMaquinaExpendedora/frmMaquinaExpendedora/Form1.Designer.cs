namespace frmMaquinaExpendedora
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.pnlAgua = new System.Windows.Forms.Panel();
            this.lblStockAgua = new System.Windows.Forms.Label();
            this.lblPrecioAgua = new System.Windows.Forms.Label();
            this.lblAgua = new System.Windows.Forms.Label();
            this.picAgua = new System.Windows.Forms.PictureBox();
            this.pnlPapas = new System.Windows.Forms.Panel();
            this.lblStockSabritas = new System.Windows.Forms.Label();
            this.lblPrecioPapas = new System.Windows.Forms.Label();
            this.lblPapas = new System.Windows.Forms.Label();
            this.picPapas = new System.Windows.Forms.PictureBox();
            this.pnlChocolate = new System.Windows.Forms.Panel();
            this.lblPrecioChocolate = new System.Windows.Forms.Label();
            this.lblStockSnickers = new System.Windows.Forms.Label();
            this.lblChocolate = new System.Windows.Forms.Label();
            this.picChocolate = new System.Windows.Forms.PictureBox();
            this.pnlGalletas = new System.Windows.Forms.Panel();
            this.lblStockChokis = new System.Windows.Forms.Label();
            this.lblPrecioGalletas = new System.Windows.Forms.Label();
            this.lblGalletas = new System.Windows.Forms.Label();
            this.picGalletas = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.btnComprar = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbProducto = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.pnlAgua.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAgua)).BeginInit();
            this.pnlPapas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPapas)).BeginInit();
            this.pnlChocolate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picChocolate)).BeginInit();
            this.pnlGalletas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGalletas)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(301, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(489, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "MAQUINA EXPENDEDORA";
            // 
            // pnlAgua
            // 
            this.pnlAgua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnlAgua.Controls.Add(this.lblStockAgua);
            this.pnlAgua.Controls.Add(this.lblPrecioAgua);
            this.pnlAgua.Controls.Add(this.lblAgua);
            this.pnlAgua.Controls.Add(this.picAgua);
            this.pnlAgua.Location = new System.Drawing.Point(12, 80);
            this.pnlAgua.Name = "pnlAgua";
            this.pnlAgua.Size = new System.Drawing.Size(200, 327);
            this.pnlAgua.TabIndex = 1;
            // 
            // lblStockAgua
            // 
            this.lblStockAgua.AutoSize = true;
            this.lblStockAgua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockAgua.Location = new System.Drawing.Point(39, 293);
            this.lblStockAgua.Name = "lblStockAgua";
            this.lblStockAgua.Size = new System.Drawing.Size(104, 25);
            this.lblStockAgua.TabIndex = 3;
            this.lblStockAgua.Text = "Stock: 20";
            // 
            // lblPrecioAgua
            // 
            this.lblPrecioAgua.AutoSize = true;
            this.lblPrecioAgua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioAgua.Location = new System.Drawing.Point(71, 253);
            this.lblPrecioAgua.Name = "lblPrecioAgua";
            this.lblPrecioAgua.Size = new System.Drawing.Size(48, 25);
            this.lblPrecioAgua.TabIndex = 2;
            this.lblPrecioAgua.Text = "$15";
            // 
            // lblAgua
            // 
            this.lblAgua.AutoSize = true;
            this.lblAgua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgua.Location = new System.Drawing.Point(27, 208);
            this.lblAgua.Name = "lblAgua";
            this.lblAgua.Size = new System.Drawing.Size(138, 25);
            this.lblAgua.TabIndex = 1;
            this.lblAgua.Text = "Agua Natural";
            // 
            // picAgua
            // 
            this.picAgua.Image = ((System.Drawing.Image)(resources.GetObject("picAgua.Image")));
            this.picAgua.Location = new System.Drawing.Point(19, 20);
            this.picAgua.Name = "picAgua";
            this.picAgua.Size = new System.Drawing.Size(159, 176);
            this.picAgua.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAgua.TabIndex = 0;
            this.picAgua.TabStop = false;
            // 
            // pnlPapas
            // 
            this.pnlPapas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnlPapas.Controls.Add(this.lblStockSabritas);
            this.pnlPapas.Controls.Add(this.lblPrecioPapas);
            this.pnlPapas.Controls.Add(this.lblPapas);
            this.pnlPapas.Controls.Add(this.picPapas);
            this.pnlPapas.Location = new System.Drawing.Point(228, 80);
            this.pnlPapas.Name = "pnlPapas";
            this.pnlPapas.Size = new System.Drawing.Size(200, 327);
            this.pnlPapas.TabIndex = 2;
            // 
            // lblStockSabritas
            // 
            this.lblStockSabritas.AutoSize = true;
            this.lblStockSabritas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockSabritas.Location = new System.Drawing.Point(43, 293);
            this.lblStockSabritas.Name = "lblStockSabritas";
            this.lblStockSabritas.Size = new System.Drawing.Size(104, 25);
            this.lblStockSabritas.TabIndex = 6;
            this.lblStockSabritas.Text = "Stock: 15";
            // 
            // lblPrecioPapas
            // 
            this.lblPrecioPapas.AutoSize = true;
            this.lblPrecioPapas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioPapas.Location = new System.Drawing.Point(75, 253);
            this.lblPrecioPapas.Name = "lblPrecioPapas";
            this.lblPrecioPapas.Size = new System.Drawing.Size(48, 25);
            this.lblPrecioPapas.TabIndex = 5;
            this.lblPrecioPapas.Text = "$18";
            // 
            // lblPapas
            // 
            this.lblPapas.AutoSize = true;
            this.lblPapas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPapas.Location = new System.Drawing.Point(59, 208);
            this.lblPapas.Name = "lblPapas";
            this.lblPapas.Size = new System.Drawing.Size(92, 25);
            this.lblPapas.TabIndex = 4;
            this.lblPapas.Text = "Sabritas";
            // 
            // picPapas
            // 
            this.picPapas.Image = ((System.Drawing.Image)(resources.GetObject("picPapas.Image")));
            this.picPapas.Location = new System.Drawing.Point(22, 20);
            this.picPapas.Name = "picPapas";
            this.picPapas.Size = new System.Drawing.Size(159, 176);
            this.picPapas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPapas.TabIndex = 1;
            this.picPapas.TabStop = false;
            // 
            // pnlChocolate
            // 
            this.pnlChocolate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pnlChocolate.Controls.Add(this.lblPrecioChocolate);
            this.pnlChocolate.Controls.Add(this.lblStockSnickers);
            this.pnlChocolate.Controls.Add(this.lblChocolate);
            this.pnlChocolate.Controls.Add(this.picChocolate);
            this.pnlChocolate.Location = new System.Drawing.Point(447, 80);
            this.pnlChocolate.Name = "pnlChocolate";
            this.pnlChocolate.Size = new System.Drawing.Size(200, 327);
            this.pnlChocolate.TabIndex = 3;
            // 
            // lblPrecioChocolate
            // 
            this.lblPrecioChocolate.AutoSize = true;
            this.lblPrecioChocolate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioChocolate.Location = new System.Drawing.Point(81, 253);
            this.lblPrecioChocolate.Name = "lblPrecioChocolate";
            this.lblPrecioChocolate.Size = new System.Drawing.Size(48, 25);
            this.lblPrecioChocolate.TabIndex = 8;
            this.lblPrecioChocolate.Text = "$20";
            // 
            // lblStockSnickers
            // 
            this.lblStockSnickers.AutoSize = true;
            this.lblStockSnickers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockSnickers.Location = new System.Drawing.Point(47, 293);
            this.lblStockSnickers.Name = "lblStockSnickers";
            this.lblStockSnickers.Size = new System.Drawing.Size(104, 25);
            this.lblStockSnickers.TabIndex = 9;
            this.lblStockSnickers.Text = "Stock: 10";
            // 
            // lblChocolate
            // 
            this.lblChocolate.AutoSize = true;
            this.lblChocolate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChocolate.Location = new System.Drawing.Point(47, 208);
            this.lblChocolate.Name = "lblChocolate";
            this.lblChocolate.Size = new System.Drawing.Size(85, 25);
            this.lblChocolate.TabIndex = 7;
            this.lblChocolate.Text = "Snikers\r\n";
            // 
            // picChocolate
            // 
            this.picChocolate.Image = ((System.Drawing.Image)(resources.GetObject("picChocolate.Image")));
            this.picChocolate.Location = new System.Drawing.Point(22, 20);
            this.picChocolate.Name = "picChocolate";
            this.picChocolate.Size = new System.Drawing.Size(159, 176);
            this.picChocolate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picChocolate.TabIndex = 2;
            this.picChocolate.TabStop = false;
            // 
            // pnlGalletas
            // 
            this.pnlGalletas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pnlGalletas.Controls.Add(this.lblStockChokis);
            this.pnlGalletas.Controls.Add(this.lblPrecioGalletas);
            this.pnlGalletas.Controls.Add(this.lblGalletas);
            this.pnlGalletas.Controls.Add(this.picGalletas);
            this.pnlGalletas.Location = new System.Drawing.Point(667, 80);
            this.pnlGalletas.Name = "pnlGalletas";
            this.pnlGalletas.Size = new System.Drawing.Size(200, 327);
            this.pnlGalletas.TabIndex = 4;
            // 
            // lblStockChokis
            // 
            this.lblStockChokis.AutoSize = true;
            this.lblStockChokis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockChokis.Location = new System.Drawing.Point(40, 293);
            this.lblStockChokis.Name = "lblStockChokis";
            this.lblStockChokis.Size = new System.Drawing.Size(104, 25);
            this.lblStockChokis.TabIndex = 12;
            this.lblStockChokis.Text = "Stock: 25";
            // 
            // lblPrecioGalletas
            // 
            this.lblPrecioGalletas.AutoSize = true;
            this.lblPrecioGalletas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioGalletas.Location = new System.Drawing.Point(75, 253);
            this.lblPrecioGalletas.Name = "lblPrecioGalletas";
            this.lblPrecioGalletas.Size = new System.Drawing.Size(48, 25);
            this.lblPrecioGalletas.TabIndex = 11;
            this.lblPrecioGalletas.Text = "$12";
            // 
            // lblGalletas
            // 
            this.lblGalletas.AutoSize = true;
            this.lblGalletas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGalletas.Location = new System.Drawing.Point(53, 208);
            this.lblGalletas.Name = "lblGalletas";
            this.lblGalletas.Size = new System.Drawing.Size(79, 25);
            this.lblGalletas.TabIndex = 10;
            this.lblGalletas.Text = "Chokis";
            // 
            // picGalletas
            // 
            this.picGalletas.Image = ((System.Drawing.Image)(resources.GetObject("picGalletas.Image")));
            this.picGalletas.Location = new System.Drawing.Point(22, 20);
            this.picGalletas.Name = "picGalletas";
            this.picGalletas.Size = new System.Drawing.Size(159, 176);
            this.picGalletas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picGalletas.TabIndex = 3;
            this.picGalletas.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel5.Controls.Add(this.nudCantidad);
            this.panel5.Controls.Add(this.btnComprar);
            this.panel5.Controls.Add(this.lblTotal);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.cmbProducto);
            this.panel5.Controls.Add(this.label15);
            this.panel5.Controls.Add(this.label14);
            this.panel5.Location = new System.Drawing.Point(887, 80);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 327);
            this.panel5.TabIndex = 5;
            // 
            // nudCantidad
            // 
            this.nudCantidad.Location = new System.Drawing.Point(23, 125);
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(152, 26);
            this.nudCantidad.TabIndex = 6;
            this.nudCantidad.ValueChanged += new System.EventHandler(this.nudCantidad_ValueChanged);
            // 
            // btnComprar
            // 
            this.btnComprar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnComprar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComprar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnComprar.Location = new System.Drawing.Point(38, 269);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(129, 40);
            this.btnComprar.TabIndex = 20;
            this.btnComprar.Text = "Comprar";
            this.btnComprar.UseVisualStyleBackColor = false;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(62, 235);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(66, 25);
            this.lblTotal.TabIndex = 19;
            this.lblTotal.Text = "$0.00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 25);
            this.label2.TabIndex = 18;
            this.label2.Text = "Total a pagar:";
            // 
            // cmbProducto
            // 
            this.cmbProducto.FormattingEnabled = true;
            this.cmbProducto.Items.AddRange(new object[] {
            "Agua Natural",
            "Sabritas",
            "Snikers",
            "Chokis"});
            this.cmbProducto.Location = new System.Drawing.Point(23, 43);
            this.cmbProducto.Name = "cmbProducto";
            this.cmbProducto.Size = new System.Drawing.Size(152, 28);
            this.cmbProducto.TabIndex = 16;
            this.cmbProducto.SelectedIndexChanged += new System.EventHandler(this.cmbProducto_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(50, 97);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(99, 25);
            this.label15.TabIndex = 14;
            this.label15.Text = "Cantidad";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(51, 20);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(98, 25);
            this.label14.TabIndex = 13;
            this.label14.Text = "Producto";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 450);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.pnlGalletas);
            this.Controls.Add(this.pnlChocolate);
            this.Controls.Add(this.pnlPapas);
            this.Controls.Add(this.pnlAgua);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlAgua.ResumeLayout(false);
            this.pnlAgua.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAgua)).EndInit();
            this.pnlPapas.ResumeLayout(false);
            this.pnlPapas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPapas)).EndInit();
            this.pnlChocolate.ResumeLayout(false);
            this.pnlChocolate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picChocolate)).EndInit();
            this.pnlGalletas.ResumeLayout(false);
            this.pnlGalletas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGalletas)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlAgua;
        private System.Windows.Forms.Panel pnlPapas;
        private System.Windows.Forms.Panel pnlChocolate;
        private System.Windows.Forms.Panel pnlGalletas;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblStockAgua;
        private System.Windows.Forms.Label lblPrecioAgua;
        private System.Windows.Forms.Label lblAgua;
        private System.Windows.Forms.PictureBox picAgua;
        private System.Windows.Forms.Label lblStockSabritas;
        private System.Windows.Forms.Label lblPrecioPapas;
        private System.Windows.Forms.Label lblPapas;
        private System.Windows.Forms.PictureBox picPapas;
        private System.Windows.Forms.Label lblStockSnickers;
        private System.Windows.Forms.Label lblPrecioChocolate;
        private System.Windows.Forms.Label lblChocolate;
        private System.Windows.Forms.PictureBox picChocolate;
        private System.Windows.Forms.Label lblStockChokis;
        private System.Windows.Forms.Label lblPrecioGalletas;
        private System.Windows.Forms.Label lblGalletas;
        private System.Windows.Forms.PictureBox picGalletas;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cmbProducto;
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudCantidad;
    }
}

