namespace git_practica_2
{
    partial class frm_venta_hogar
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
            this.pnl_menu_superior = new System.Windows.Forms.Panel();
            this.pnl_menu_lateral = new System.Windows.Forms.Panel();
            this.btn_datos = new System.Windows.Forms.Button();
            this.btn_vender = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnl_contenedor = new System.Windows.Forms.Panel();
            this.pnl_menu_lateral.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_menu_superior
            // 
            this.pnl_menu_superior.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnl_menu_superior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_menu_superior.Location = new System.Drawing.Point(0, 0);
            this.pnl_menu_superior.Name = "pnl_menu_superior";
            this.pnl_menu_superior.Size = new System.Drawing.Size(1065, 54);
            this.pnl_menu_superior.TabIndex = 0;
            // 
            // pnl_menu_lateral
            // 
            this.pnl_menu_lateral.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnl_menu_lateral.Controls.Add(this.btn_datos);
            this.pnl_menu_lateral.Controls.Add(this.btn_vender);
            this.pnl_menu_lateral.Controls.Add(this.btn_modificar);
            this.pnl_menu_lateral.Controls.Add(this.btn_agregar);
            this.pnl_menu_lateral.Controls.Add(this.panel1);
            this.pnl_menu_lateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_menu_lateral.Location = new System.Drawing.Point(0, 54);
            this.pnl_menu_lateral.Name = "pnl_menu_lateral";
            this.pnl_menu_lateral.Size = new System.Drawing.Size(155, 500);
            this.pnl_menu_lateral.TabIndex = 1;
            // 
            // btn_datos
            // 
            this.btn_datos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_datos.Location = new System.Drawing.Point(0, 208);
            this.btn_datos.Name = "btn_datos";
            this.btn_datos.Size = new System.Drawing.Size(155, 49);
            this.btn_datos.TabIndex = 3;
            this.btn_datos.Text = "Datos";
            this.btn_datos.UseVisualStyleBackColor = true;
            // 
            // btn_vender
            // 
            this.btn_vender.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_vender.Location = new System.Drawing.Point(0, 159);
            this.btn_vender.Name = "btn_vender";
            this.btn_vender.Size = new System.Drawing.Size(155, 49);
            this.btn_vender.TabIndex = 2;
            this.btn_vender.Text = "Vender";
            this.btn_vender.UseVisualStyleBackColor = true;
            this.btn_vender.Click += new System.EventHandler(this.btn_vender_Click);
            // 
            // btn_modificar
            // 
            this.btn_modificar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_modificar.Location = new System.Drawing.Point(0, 110);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(155, 49);
            this.btn_modificar.TabIndex = 1;
            this.btn_modificar.Text = "Modificar Casa";
            this.btn_modificar.UseVisualStyleBackColor = true;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // btn_agregar
            // 
            this.btn_agregar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_agregar.Location = new System.Drawing.Point(0, 61);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(155, 49);
            this.btn_agregar.TabIndex = 0;
            this.btn_agregar.Text = "Agregar Casa";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(155, 61);
            this.panel1.TabIndex = 0;
            // 
            // pnl_contenedor
            // 
            this.pnl_contenedor.BackColor = System.Drawing.Color.Silver;
            this.pnl_contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_contenedor.Location = new System.Drawing.Point(155, 54);
            this.pnl_contenedor.Name = "pnl_contenedor";
            this.pnl_contenedor.Size = new System.Drawing.Size(910, 500);
            this.pnl_contenedor.TabIndex = 2;
            // 
            // frm_venta_hogar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 554);
            this.Controls.Add(this.pnl_contenedor);
            this.Controls.Add(this.pnl_menu_lateral);
            this.Controls.Add(this.pnl_menu_superior);
            this.Name = "frm_venta_hogar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Venta Hogar";
            this.Load += new System.EventHandler(this.frm_venta_hogar_Load);
            this.pnl_menu_lateral.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_menu_superior;
        private System.Windows.Forms.Panel pnl_menu_lateral;
        private System.Windows.Forms.Panel pnl_contenedor;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_vender;
        private System.Windows.Forms.Button btn_datos;
    }
}

