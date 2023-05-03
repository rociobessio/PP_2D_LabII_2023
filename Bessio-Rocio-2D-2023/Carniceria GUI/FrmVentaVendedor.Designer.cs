﻿namespace Carniceria_GUI
{
    partial class FrmVentaVendedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVentaVendedor));
            groupBox1 = new GroupBox();
            label7 = new Label();
            txtApellido = new TextBox();
            label6 = new Label();
            txtNombre = new TextBox();
            label5 = new Label();
            txtDNI = new TextBox();
            label4 = new Label();
            txtTelefono = new TextBox();
            label1 = new Label();
            txtDomicilio = new TextBox();
            label3 = new Label();
            cbClientes = new ComboBox();
            groupBox2 = new GroupBox();
            txtPesoTotalStock = new TextBox();
            label13 = new Label();
            label11 = new Label();
            txtPrecioPorUnidad = new TextBox();
            dataGridViewProductos = new DataGridView();
            btnVender = new Button();
            ckbTarjeta = new CheckBox();
            ckbEfectivo = new CheckBox();
            groupBox3 = new GroupBox();
            btnCalcularCosto = new Button();
            label10 = new Label();
            txtTotalAPagar = new TextBox();
            label2 = new Label();
            lblPrintHelp = new Label();
            pictureBox1 = new PictureBox();
            txtPesoEspecificado = new TextBox();
            label9 = new Label();
            groupBox4 = new GroupBox();
            lblVendedorEmail = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProductos).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.None;
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtApellido);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtDNI);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtTelefono);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtDomicilio);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(cbClientes);
            groupBox1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(12, 70);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(506, 298);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Perfil Cliente";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(342, 212);
            label7.Name = "label7";
            label7.Size = new Size(90, 28);
            label7.TabIndex = 19;
            label7.Text = "Apellido:";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(293, 243);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(193, 37);
            txtApellido.TabIndex = 18;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(64, 212);
            label6.Name = "label6";
            label6.Size = new Size(89, 28);
            label6.TabIndex = 17;
            label6.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(15, 243);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(193, 37);
            txtNombre.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(84, 133);
            label5.Name = "label5";
            label5.Size = new Size(50, 28);
            label5.TabIndex = 15;
            label5.Text = "DNI:";
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(16, 164);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(193, 37);
            txtDNI.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(342, 133);
            label4.Name = "label4";
            label4.Size = new Size(90, 28);
            label4.TabIndex = 13;
            label4.Text = "Teléfono:";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(293, 164);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(193, 37);
            txtTelefono.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(342, 61);
            label1.Name = "label1";
            label1.Size = new Size(100, 28);
            label1.TabIndex = 11;
            label1.Text = "Domicilio:";
            // 
            // txtDomicilio
            // 
            txtDomicilio.Location = new Point(293, 92);
            txtDomicilio.Name = "txtDomicilio";
            txtDomicilio.Size = new Size(193, 37);
            txtDomicilio.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(15, 61);
            label3.Name = "label3";
            label3.Size = new Size(84, 28);
            label3.TabIndex = 9;
            label3.Text = "Clientes:";
            // 
            // cbClientes
            // 
            cbClientes.FormattingEnabled = true;
            cbClientes.Location = new Point(15, 92);
            cbClientes.Name = "cbClientes";
            cbClientes.Size = new Size(194, 38);
            cbClientes.TabIndex = 8;
            cbClientes.SelectedIndexChanged += cbClientes_SelectedIndexChanged;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.None;
            groupBox2.Controls.Add(txtPesoTotalStock);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(txtPrecioPorUnidad);
            groupBox2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(577, 70);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(412, 298);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Producto ";
            // 
            // txtPesoTotalStock
            // 
            txtPesoTotalStock.Location = new Point(232, 173);
            txtPesoTotalStock.Name = "txtPesoTotalStock";
            txtPesoTotalStock.Size = new Size(150, 37);
            txtPesoTotalStock.TabIndex = 28;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(81, 164);
            label13.Name = "label13";
            label13.Size = new Size(101, 56);
            label13.TabIndex = 27;
            label13.Text = "Peso total\r\n del Stock:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(80, 67);
            label11.Name = "label11";
            label11.Size = new Size(102, 56);
            label11.TabIndex = 24;
            label11.Text = "Precio por\r\nUnidad:";
            // 
            // txtPrecioPorUnidad
            // 
            txtPrecioPorUnidad.Location = new Point(231, 77);
            txtPrecioPorUnidad.Name = "txtPrecioPorUnidad";
            txtPrecioPorUnidad.Size = new Size(150, 37);
            txtPrecioPorUnidad.TabIndex = 23;
            // 
            // dataGridViewProductos
            // 
            dataGridViewProductos.AllowUserToAddRows = false;
            dataGridViewProductos.AllowUserToDeleteRows = false;
            dataGridViewProductos.AllowUserToResizeColumns = false;
            dataGridViewProductos.AllowUserToResizeRows = false;
            dataGridViewProductos.Anchor = AnchorStyles.None;
            dataGridViewProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewProductos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProductos.Location = new Point(12, 607);
            dataGridViewProductos.Name = "dataGridViewProductos";
            dataGridViewProductos.ReadOnly = true;
            dataGridViewProductos.RowHeadersWidth = 62;
            dataGridViewProductos.RowTemplate.Height = 33;
            dataGridViewProductos.Size = new Size(977, 189);
            dataGridViewProductos.TabIndex = 2;
            dataGridViewProductos.CellClick += dataGridViewProductos_CellClick;
            // 
            // btnVender
            // 
            btnVender.Anchor = AnchorStyles.Bottom;
            btnVender.Cursor = Cursors.Hand;
            btnVender.FlatStyle = FlatStyle.Popup;
            btnVender.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnVender.ForeColor = Color.White;
            btnVender.Image = Properties.Resources.pay_cash_payment_money_dollar_bill_icon_143267;
            btnVender.ImageAlign = ContentAlignment.MiddleRight;
            btnVender.Location = new Point(832, 802);
            btnVender.Name = "btnVender";
            btnVender.Size = new Size(157, 57);
            btnVender.TabIndex = 7;
            btnVender.Text = "      Vender";
            btnVender.TextAlign = ContentAlignment.MiddleLeft;
            btnVender.UseVisualStyleBackColor = true;
            btnVender.Click += btnVender_Click;
            // 
            // ckbTarjeta
            // 
            ckbTarjeta.AutoSize = true;
            ckbTarjeta.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ckbTarjeta.Location = new Point(57, 46);
            ckbTarjeta.Name = "ckbTarjeta";
            ckbTarjeta.Size = new Size(93, 29);
            ckbTarjeta.TabIndex = 10;
            ckbTarjeta.Text = "Tarjeta ";
            ckbTarjeta.UseVisualStyleBackColor = true;
            // 
            // ckbEfectivo
            // 
            ckbEfectivo.AutoSize = true;
            ckbEfectivo.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ckbEfectivo.Location = new Point(223, 46);
            ckbEfectivo.Name = "ckbEfectivo";
            ckbEfectivo.Size = new Size(100, 29);
            ckbEfectivo.TabIndex = 11;
            ckbEfectivo.Text = "Efectivo";
            ckbEfectivo.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.None;
            groupBox3.Controls.Add(btnCalcularCosto);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(ckbEfectivo);
            groupBox3.Controls.Add(txtTotalAPagar);
            groupBox3.Controls.Add(ckbTarjeta);
            groupBox3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox3.ForeColor = Color.White;
            groupBox3.Location = new Point(12, 394);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(506, 141);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            groupBox3.Text = "Método de Pago";
            // 
            // btnCalcularCosto
            // 
            btnCalcularCosto.Anchor = AnchorStyles.Bottom;
            btnCalcularCosto.Cursor = Cursors.Hand;
            btnCalcularCosto.FlatStyle = FlatStyle.Popup;
            btnCalcularCosto.ForeColor = Color.White;
            btnCalcularCosto.Location = new Point(356, 88);
            btnCalcularCosto.Name = "btnCalcularCosto";
            btnCalcularCosto.Size = new Size(130, 42);
            btnCalcularCosto.TabIndex = 22;
            btnCalcularCosto.Text = "Calcular";
            btnCalcularCosto.UseVisualStyleBackColor = true;
            btnCalcularCosto.Click += btnCalcularCosto_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(26, 97);
            label10.Name = "label10";
            label10.Size = new Size(127, 28);
            label10.TabIndex = 21;
            label10.Text = "Total a Pagar:";
            // 
            // txtTotalAPagar
            // 
            txtTotalAPagar.Location = new Point(173, 93);
            txtTotalAPagar.Name = "txtTotalAPagar";
            txtTotalAPagar.Size = new Size(150, 37);
            txtTotalAPagar.TabIndex = 0;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 572);
            label2.Name = "label2";
            label2.Size = new Size(323, 32);
            label2.TabIndex = 9;
            label2.Text = "PRODUCTOS DISPONIBLES:";
            // 
            // lblPrintHelp
            // 
            lblPrintHelp.Anchor = AnchorStyles.Bottom;
            lblPrintHelp.AutoSize = true;
            lblPrintHelp.Cursor = Cursors.Hand;
            lblPrintHelp.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrintHelp.Image = Properties.Resources.support_call_center_help_information_customer_service_icon_140644;
            lblPrintHelp.Location = new Point(12, 802);
            lblPrintHelp.Name = "lblPrintHelp";
            lblPrintHelp.Size = new Size(37, 60);
            lblPrintHelp.TabIndex = 11;
            lblPrintHelp.Text = " ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.pngwing_com__2_;
            pictureBox1.Location = new Point(12, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(86, 55);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // txtPesoEspecificado
            // 
            txtPesoEspecificado.Location = new Point(238, 55);
            txtPesoEspecificado.Name = "txtPesoEspecificado";
            txtPesoEspecificado.Size = new Size(150, 37);
            txtPesoEspecificado.TabIndex = 25;
            txtPesoEspecificado.TextChanged += txtPesoEspecificado_TextChanged;
            txtPesoEspecificado.KeyPress += txtPesoEspecificado_KeyPress;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(87, 64);
            label9.Name = "label9";
            label9.Size = new Size(97, 28);
            label9.TabIndex = 24;
            label9.Text = "Peso (Kg):";
            // 
            // groupBox4
            // 
            groupBox4.Anchor = AnchorStyles.None;
            groupBox4.Controls.Add(txtPesoEspecificado);
            groupBox4.Controls.Add(label9);
            groupBox4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox4.ForeColor = Color.White;
            groupBox4.Location = new Point(570, 394);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(419, 141);
            groupBox4.TabIndex = 22;
            groupBox4.TabStop = false;
            groupBox4.Text = "Vender";
            // 
            // lblVendedorEmail
            // 
            lblVendedorEmail.Anchor = AnchorStyles.None;
            lblVendedorEmail.AutoSize = true;
            lblVendedorEmail.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblVendedorEmail.ForeColor = Color.White;
            lblVendedorEmail.Location = new Point(116, 22);
            lblVendedorEmail.Name = "lblVendedorEmail";
            lblVendedorEmail.Size = new Size(65, 28);
            lblVendedorEmail.TabIndex = 23;
            lblVendedorEmail.Text = "label1";
            // 
            // FrmVentaVendedor
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkRed;
            ClientSize = new Size(1001, 871);
            Controls.Add(lblVendedorEmail);
            Controls.Add(groupBox4);
            Controls.Add(pictureBox1);
            Controls.Add(lblPrintHelp);
            Controls.Add(label2);
            Controls.Add(groupBox3);
            Controls.Add(btnVender);
            Controls.Add(dataGridViewProductos);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmVentaVendedor";
            Text = "FrmVentaVendedor";
            Load += FrmVentaVendedor_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProductos).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DataGridView dataGridViewProductos;
        private ComboBox cbClientes;
        private Button btnVender;
        private Label label3;
        private TextBox txtTotalAPagar;
        private CheckBox ckbTarjeta;
        private CheckBox ckbEfectivo;
        private GroupBox groupBox3;
        private Label label10;
        private Label label2;
        private Label label1;
        private TextBox txtDomicilio;
        private Label label4;
        private TextBox txtTelefono;
        private Label label5;
        private TextBox txtDNI;
        private Label label7;
        private TextBox txtApellido;
        private Label label6;
        private TextBox txtNombre;
        private Label lblPrintHelp;
        private PictureBox pictureBox1;
        private Label label11;
        private TextBox txtPrecioPorUnidad;
        private TextBox txtPesoTotalStock;
        private Label label13;
        private TextBox txtPesoEspecificado;
        private Label label9;
        private GroupBox groupBox4;
        private Button btnCalcularCosto;
        private Label lblVendedorEmail;
    }
}