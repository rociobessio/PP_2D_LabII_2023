﻿namespace Carniceria_GUI
{
    partial class FrmHeladera
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHeladera));
            lblVendedorEmail = new Label();
            pictureBoxVendedor = new PictureBox();
            dataGridViewProductos = new DataGridView();
            label2 = new Label();
            groupBoxReponer = new GroupBox();
            label11 = new Label();
            txtPrecioCompraFrigorifico = new TextBox();
            label10 = new Label();
            txtProveedor = new TextBox();
            cbTipoDeCarneReponer = new ComboBox();
            label8 = new Label();
            btnReponer = new Button();
            label7 = new Label();
            dtpFechaVencimiento = new DateTimePicker();
            label6 = new Label();
            txtPrecioVentaClientes = new TextBox();
            label5 = new Label();
            txtPesoCarne = new TextBox();
            cbTexturaCarne = new ComboBox();
            label4 = new Label();
            cbCorteCarne = new ComboBox();
            label3 = new Label();
            btnVender = new Button();
            lblPrintHelp = new Label();
            groupBox1 = new GroupBox();
            label1 = new Label();
            btnHistorial = new Button();
            label9 = new Label();
            lblHoraIngreso = new Label();
            label12 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxVendedor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProductos).BeginInit();
            groupBoxReponer.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblVendedorEmail
            // 
            lblVendedorEmail.Anchor = AnchorStyles.None;
            lblVendedorEmail.AutoSize = true;
            lblVendedorEmail.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblVendedorEmail.ForeColor = Color.White;
            lblVendedorEmail.Location = new Point(285, 35);
            lblVendedorEmail.Name = "lblVendedorEmail";
            lblVendedorEmail.Size = new Size(65, 28);
            lblVendedorEmail.TabIndex = 0;
            lblVendedorEmail.Text = "label1";
            // 
            // pictureBoxVendedor
            // 
            pictureBoxVendedor.Anchor = AnchorStyles.None;
            pictureBoxVendedor.Image = Properties.Resources.call_center_contact_information_service_icon_187270;
            pictureBoxVendedor.Location = new Point(26, 15);
            pictureBoxVendedor.Name = "pictureBoxVendedor";
            pictureBoxVendedor.Size = new Size(82, 72);
            pictureBoxVendedor.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxVendedor.TabIndex = 1;
            pictureBoxVendedor.TabStop = false;
            // 
            // dataGridViewProductos
            // 
            dataGridViewProductos.AllowUserToAddRows = false;
            dataGridViewProductos.AllowUserToDeleteRows = false;
            dataGridViewProductos.AllowUserToResizeColumns = false;
            dataGridViewProductos.AllowUserToResizeRows = false;
            dataGridViewProductos.Anchor = AnchorStyles.Bottom;
            dataGridViewProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewProductos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProductos.GridColor = Color.MediumPurple;
            dataGridViewProductos.Location = new Point(17, 438);
            dataGridViewProductos.Name = "dataGridViewProductos";
            dataGridViewProductos.ReadOnly = true;
            dataGridViewProductos.RowHeadersWidth = 62;
            dataGridViewProductos.RowTemplate.Height = 33;
            dataGridViewProductos.Size = new Size(1147, 275);
            dataGridViewProductos.TabIndex = 12;
            dataGridViewProductos.CellClick += dataGridViewProductos_CellClick;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(32, 403);
            label2.Name = "label2";
            label2.Size = new Size(323, 32);
            label2.TabIndex = 3;
            label2.Text = "PRODUCTOS DISPONIBLES:";
            // 
            // groupBoxReponer
            // 
            groupBoxReponer.Anchor = AnchorStyles.None;
            groupBoxReponer.Controls.Add(label11);
            groupBoxReponer.Controls.Add(txtPrecioCompraFrigorifico);
            groupBoxReponer.Controls.Add(label10);
            groupBoxReponer.Controls.Add(txtProveedor);
            groupBoxReponer.Controls.Add(cbTipoDeCarneReponer);
            groupBoxReponer.Controls.Add(label8);
            groupBoxReponer.Controls.Add(btnReponer);
            groupBoxReponer.Controls.Add(label7);
            groupBoxReponer.Controls.Add(dtpFechaVencimiento);
            groupBoxReponer.Controls.Add(label6);
            groupBoxReponer.Controls.Add(txtPrecioVentaClientes);
            groupBoxReponer.Controls.Add(label5);
            groupBoxReponer.Controls.Add(txtPesoCarne);
            groupBoxReponer.Controls.Add(cbTexturaCarne);
            groupBoxReponer.Controls.Add(label4);
            groupBoxReponer.Controls.Add(cbCorteCarne);
            groupBoxReponer.Controls.Add(label3);
            groupBoxReponer.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            groupBoxReponer.ForeColor = Color.White;
            groupBoxReponer.Location = new Point(285, 93);
            groupBoxReponer.Name = "groupBoxReponer";
            groupBoxReponer.Size = new Size(879, 261);
            groupBoxReponer.TabIndex = 4;
            groupBoxReponer.TabStop = false;
            groupBoxReponer.Text = "Reponer Carne";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(6, 177);
            label11.Name = "label11";
            label11.Size = new Size(156, 50);
            label11.TabIndex = 22;
            label11.Text = "Precio de compra \r\ndel Frigorifico:";
            label11.Click += label11_Click;
            // 
            // txtPrecioCompraFrigorifico
            // 
            txtPrecioCompraFrigorifico.Location = new Point(168, 190);
            txtPrecioCompraFrigorifico.Name = "txtPrecioCompraFrigorifico";
            txtPrecioCompraFrigorifico.Size = new Size(157, 37);
            txtPrecioCompraFrigorifico.TabIndex = 8;
            txtPrecioCompraFrigorifico.TextChanged += txtPrecioCompraFrigorifico_TextChanged;
            txtPrecioCompraFrigorifico.KeyPress += txtPrecioCompra_KeyPress;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(620, 114);
            label10.Name = "label10";
            label10.Size = new Size(98, 25);
            label10.TabIndex = 20;
            label10.Text = "Proveedor:";
            label10.Click += label10_Click;
            // 
            // txtProveedor
            // 
            txtProveedor.Location = new Point(723, 107);
            txtProveedor.Name = "txtProveedor";
            txtProveedor.Size = new Size(151, 37);
            txtProveedor.TabIndex = 7;
            // 
            // cbTipoDeCarneReponer
            // 
            cbTipoDeCarneReponer.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cbTipoDeCarneReponer.FormattingEnabled = true;
            cbTipoDeCarneReponer.Location = new Point(168, 41);
            cbTipoDeCarneReponer.Name = "cbTipoDeCarneReponer";
            cbTipoDeCarneReponer.Size = new Size(157, 36);
            cbTipoDeCarneReponer.TabIndex = 4;
            cbTipoDeCarneReponer.SelectedIndexChanged += cbTipoDeCarneReponer_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(6, 38);
            label8.Name = "label8";
            label8.Size = new Size(126, 25);
            label8.TabIndex = 15;
            label8.Text = "Tipo de Carne:";
            // 
            // btnReponer
            // 
            btnReponer.Cursor = Cursors.Hand;
            btnReponer.FlatStyle = FlatStyle.Popup;
            btnReponer.Image = Properties.Resources.shoppaymentorderbuy_08_icon_icons_com_73885;
            btnReponer.ImageAlign = ContentAlignment.MiddleRight;
            btnReponer.Location = new Point(688, 190);
            btnReponer.Name = "btnReponer";
            btnReponer.Size = new Size(169, 61);
            btnReponer.TabIndex = 3;
            btnReponer.Text = "   Reponer";
            btnReponer.TextAlign = ContentAlignment.MiddleLeft;
            btnReponer.UseVisualStyleBackColor = true;
            btnReponer.Click += btnReponer_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(348, 177);
            label7.Name = "label7";
            label7.Size = new Size(113, 50);
            label7.TabIndex = 14;
            label7.Text = "Fecha de \r\nVencimiento:";
            label7.Click += label7_Click;
            // 
            // dtpFechaVencimiento
            // 
            dtpFechaVencimiento.Location = new Point(458, 188);
            dtpFechaVencimiento.Name = "dtpFechaVencimiento";
            dtpFechaVencimiento.Size = new Size(156, 37);
            dtpFechaVencimiento.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(348, 102);
            label6.Name = "label6";
            label6.Size = new Size(102, 42);
            label6.TabIndex = 12;
            label6.Text = "Precio Venta \r\nPara Clientes:";
            // 
            // txtPrecioVentaClientes
            // 
            txtPrecioVentaClientes.Location = new Point(458, 107);
            txtPrecioVentaClientes.Name = "txtPrecioVentaClientes";
            txtPrecioVentaClientes.Size = new Size(156, 37);
            txtPrecioVentaClientes.TabIndex = 10;
            txtPrecioVentaClientes.KeyPress += txtPrecio_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(348, 44);
            label5.Name = "label5";
            label5.Size = new Size(58, 28);
            label5.TabIndex = 10;
            label5.Text = "Kilos:";
            // 
            // txtPesoCarne
            // 
            txtPesoCarne.Location = new Point(458, 40);
            txtPesoCarne.Name = "txtPesoCarne";
            txtPesoCarne.Size = new Size(156, 37);
            txtPesoCarne.TabIndex = 9;
            txtPesoCarne.KeyPress += txtPesoCarne_KeyPress;
            // 
            // cbTexturaCarne
            // 
            cbTexturaCarne.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cbTexturaCarne.FormattingEnabled = true;
            cbTexturaCarne.Location = new Point(168, 108);
            cbTexturaCarne.Name = "cbTexturaCarne";
            cbTexturaCarne.Size = new Size(157, 36);
            cbTexturaCarne.TabIndex = 6;
            cbTexturaCarne.SelectedIndexChanged += cbTexturaCarne_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(6, 99);
            label4.Name = "label4";
            label4.Size = new Size(93, 50);
            label4.TabIndex = 7;
            label4.Text = "Categoría \r\nBovina:";
            // 
            // cbCorteCarne
            // 
            cbCorteCarne.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cbCorteCarne.FormattingEnabled = true;
            cbCorteCarne.Location = new Point(723, 44);
            cbCorteCarne.Name = "cbCorteCarne";
            cbCorteCarne.Size = new Size(150, 36);
            cbCorteCarne.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(620, 47);
            label3.Name = "label3";
            label3.Size = new Size(59, 25);
            label3.TabIndex = 5;
            label3.Text = "Corte:";
            label3.Click += label3_Click;
            // 
            // btnVender
            // 
            btnVender.Cursor = Cursors.Hand;
            btnVender.FlatStyle = FlatStyle.Popup;
            btnVender.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnVender.ForeColor = Color.White;
            btnVender.ImageAlign = ContentAlignment.MiddleRight;
            btnVender.Location = new Point(32, 173);
            btnVender.Name = "btnVender";
            btnVender.Size = new Size(180, 70);
            btnVender.TabIndex = 1;
            btnVender.Text = "Vender";
            btnVender.UseVisualStyleBackColor = true;
            btnVender.Click += btnVender_Click;
            // 
            // lblPrintHelp
            // 
            lblPrintHelp.Anchor = AnchorStyles.Bottom;
            lblPrintHelp.AutoSize = true;
            lblPrintHelp.Cursor = Cursors.Hand;
            lblPrintHelp.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrintHelp.Image = Properties.Resources.support_call_center_help_information_customer_service_icon_140644;
            lblPrintHelp.Location = new Point(17, 732);
            lblPrintHelp.Name = "lblPrintHelp";
            lblPrintHelp.Size = new Size(37, 60);
            lblPrintHelp.TabIndex = 9;
            lblPrintHelp.Text = " ";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.None;
            groupBox1.Controls.Add(btnVender);
            groupBox1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(26, 93);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(241, 261);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Venderle producto a Cliente";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(127, 31);
            label1.Name = "label1";
            label1.Size = new Size(152, 32);
            label1.TabIndex = 11;
            label1.Text = "VENDEDOR:";
            // 
            // btnHistorial
            // 
            btnHistorial.Anchor = AnchorStyles.Bottom;
            btnHistorial.Cursor = Cursors.Hand;
            btnHistorial.FlatStyle = FlatStyle.Popup;
            btnHistorial.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnHistorial.ForeColor = Color.White;
            btnHistorial.Image = Properties.Resources.receipt_information_icon_1774012;
            btnHistorial.ImageAlign = ContentAlignment.MiddleRight;
            btnHistorial.Location = new Point(943, 732);
            btnHistorial.Name = "btnHistorial";
            btnHistorial.Size = new Size(221, 57);
            btnHistorial.TabIndex = 39;
            btnHistorial.Text = "    Historial Ventas";
            btnHistorial.TextAlign = ContentAlignment.MiddleLeft;
            btnHistorial.UseVisualStyleBackColor = true;
            btnHistorial.Click += btnHistorial_Click;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(957, 9);
            label9.Name = "label9";
            label9.Size = new Size(128, 21);
            label9.TabIndex = 40;
            label9.Text = "Hora de ingreso:";
            // 
            // lblHoraIngreso
            // 
            lblHoraIngreso.Anchor = AnchorStyles.None;
            lblHoraIngreso.AutoSize = true;
            lblHoraIngreso.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblHoraIngreso.ForeColor = Color.White;
            lblHoraIngreso.Location = new Point(1079, 9);
            lblHoraIngreso.Name = "lblHoraIngreso";
            lblHoraIngreso.Size = new Size(30, 21);
            lblHoraIngreso.TabIndex = 41;
            lblHoraIngreso.Text = "hs.";
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.None;
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label12.ForeColor = Color.White;
            label12.Location = new Point(1129, 9);
            label12.Name = "label12";
            label12.Size = new Size(30, 21);
            label12.TabIndex = 42;
            label12.Text = "hs.";
            // 
            // FrmHeladera
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumPurple;
            ClientSize = new Size(1176, 801);
            Controls.Add(label12);
            Controls.Add(lblHoraIngreso);
            Controls.Add(label9);
            Controls.Add(btnHistorial);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Controls.Add(lblPrintHelp);
            Controls.Add(groupBoxReponer);
            Controls.Add(label2);
            Controls.Add(dataGridViewProductos);
            Controls.Add(pictureBoxVendedor);
            Controls.Add(lblVendedorEmail);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(1198, 857);
            Name = "FrmHeladera";
            Text = "FrmHeladera";
            FormClosing += FrmHeladera_FormClosing;
            Load += FrmHeladera_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxVendedor).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProductos).EndInit();
            groupBoxReponer.ResumeLayout(false);
            groupBoxReponer.PerformLayout();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblVendedorEmail;
        private PictureBox pictureBoxVendedor;
        private DataGridView dataGridViewProductos;
        private Label label2;
        private GroupBox groupBoxReponer;
        private Button btnReponer;
        private Label label7;
        private DateTimePicker dtpFechaVencimiento;
        private Label label6;
        private TextBox txtPrecioVentaClientes;
        private Label label5;
        private TextBox txtPesoCarne;
        private ComboBox cbTexturaCarne;
        private Label label4;
        private ComboBox cbCorteCarne;
        private Label label3;
        private ComboBox cbTipoDeCarneReponer;
        private Label label8;
        private Label label10;
        private TextBox txtProveedor;
        private Button btnVender;
        private Label lblPrintHelp;
        private GroupBox groupBox1;
        private Label label11;
        private TextBox txtPrecioCompraFrigorifico;
        private Label label1;
        private Button btnHistorial;
        private Label label9;
        private Label lblHoraIngreso;
        private Label label12;
    }
}