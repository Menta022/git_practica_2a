namespace git_practica_2
{
    partial class frm_agregar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_color = new System.Windows.Forms.TextBox();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.txt_numero = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_localidad = new System.Windows.Forms.ComboBox();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dtg_mostrar_casas = new System.Windows.Forms.DataGridView();
            this.rd_en_venta = new System.Windows.Forms.RadioButton();
            this.rd_vendido = new System.Windows.Forms.RadioButton();
            this.rd_todas = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_mostrar_casas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Color:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Direccion:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Localidad:";
            // 
            // txt_color
            // 
            this.txt_color.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_color.Location = new System.Drawing.Point(128, 36);
            this.txt_color.Name = "txt_color";
            this.txt_color.Size = new System.Drawing.Size(121, 26);
            this.txt_color.TabIndex = 5;
            this.txt_color.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_color_KeyPress);
            // 
            // txt_direccion
            // 
            this.txt_direccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_direccion.Location = new System.Drawing.Point(128, 85);
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(235, 26);
            this.txt_direccion.TabIndex = 7;
            this.txt_direccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_direccion_KeyPress);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cerrar.BackColor = System.Drawing.Color.Red;
            this.btn_cerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cerrar.ForeColor = System.Drawing.Color.White;
            this.btn_cerrar.Location = new System.Drawing.Point(760, 431);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(127, 57);
            this.btn_cerrar.TabIndex = 10;
            this.btn_cerrar.Text = "Volver";
            this.btn_cerrar.UseVisualStyleBackColor = false;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // txt_numero
            // 
            this.txt_numero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_numero.Location = new System.Drawing.Point(451, 85);
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.Size = new System.Drawing.Size(92, 26);
            this.txt_numero.TabIndex = 11;
            this.txt_numero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_numero_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(369, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Numero:";
            // 
            // cmb_localidad
            // 
            this.cmb_localidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_localidad.FormattingEnabled = true;
            this.cmb_localidad.Location = new System.Drawing.Point(128, 137);
            this.cmb_localidad.Name = "cmb_localidad";
            this.cmb_localidad.Size = new System.Drawing.Size(121, 21);
            this.cmb_localidad.TabIndex = 13;
            // 
            // btn_agregar
            // 
            this.btn_agregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_agregar.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar.ForeColor = System.Drawing.Color.White;
            this.btn_agregar.Location = new System.Drawing.Point(433, 131);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(110, 34);
            this.btn_agregar.TabIndex = 14;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = false;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(358, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Agregar Casa";
            // 
            // dtg_mostrar_casas
            // 
            this.dtg_mostrar_casas.AllowUserToAddRows = false;
            this.dtg_mostrar_casas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtg_mostrar_casas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_mostrar_casas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtg_mostrar_casas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_mostrar_casas.Location = new System.Drawing.Point(39, 223);
            this.dtg_mostrar_casas.Name = "dtg_mostrar_casas";
            this.dtg_mostrar_casas.ReadOnly = true;
            this.dtg_mostrar_casas.RowHeadersVisible = false;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtg_mostrar_casas.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dtg_mostrar_casas.Size = new System.Drawing.Size(504, 202);
            this.dtg_mostrar_casas.TabIndex = 16;
            // 
            // rd_en_venta
            // 
            this.rd_en_venta.AutoSize = true;
            this.rd_en_venta.Checked = true;
            this.rd_en_venta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_en_venta.Location = new System.Drawing.Point(562, 223);
            this.rd_en_venta.Name = "rd_en_venta";
            this.rd_en_venta.Size = new System.Drawing.Size(90, 24);
            this.rd_en_venta.TabIndex = 17;
            this.rd_en_venta.TabStop = true;
            this.rd_en_venta.Text = "En venta";
            this.rd_en_venta.UseVisualStyleBackColor = true;
            this.rd_en_venta.CheckedChanged += new System.EventHandler(this.rd_en_venta_CheckedChanged);
            // 
            // rd_vendido
            // 
            this.rd_vendido.AutoSize = true;
            this.rd_vendido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_vendido.Location = new System.Drawing.Point(562, 246);
            this.rd_vendido.Name = "rd_vendido";
            this.rd_vendido.Size = new System.Drawing.Size(86, 24);
            this.rd_vendido.TabIndex = 19;
            this.rd_vendido.Text = "Vendido";
            this.rd_vendido.UseVisualStyleBackColor = true;
            this.rd_vendido.CheckedChanged += new System.EventHandler(this.rd_vendido_CheckedChanged);
            // 
            // rd_todas
            // 
            this.rd_todas.AutoSize = true;
            this.rd_todas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_todas.Location = new System.Drawing.Point(562, 269);
            this.rd_todas.Name = "rd_todas";
            this.rd_todas.Size = new System.Drawing.Size(71, 24);
            this.rd_todas.TabIndex = 21;
            this.rd_todas.Text = "Todas";
            this.rd_todas.UseVisualStyleBackColor = true;
            this.rd_todas.CheckedChanged += new System.EventHandler(this.rd_todas_CheckedChanged);
            // 
            // frm_agregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 500);
            this.Controls.Add(this.rd_todas);
            this.Controls.Add(this.rd_vendido);
            this.Controls.Add(this.rd_en_venta);
            this.Controls.Add(this.dtg_mostrar_casas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.cmb_localidad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_numero);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.txt_direccion);
            this.Controls.Add(this.txt_color);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_agregar";
            this.Text = "frm_agregar";
            this.Load += new System.EventHandler(this.frm_agregar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_mostrar_casas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_color;
        private System.Windows.Forms.TextBox txt_direccion;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.TextBox txt_numero;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_localidad;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dtg_mostrar_casas;
        private System.Windows.Forms.RadioButton rd_en_venta;
        private System.Windows.Forms.RadioButton rd_vendido;
        private System.Windows.Forms.RadioButton rd_todas;
    }
}