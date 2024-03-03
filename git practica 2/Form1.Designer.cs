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
            this.pnl_contenedor = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnl_menu_superior
            // 
            this.pnl_menu_superior.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnl_menu_superior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_menu_superior.Location = new System.Drawing.Point(0, 0);
            this.pnl_menu_superior.Name = "pnl_menu_superior";
            this.pnl_menu_superior.Size = new System.Drawing.Size(940, 54);
            this.pnl_menu_superior.TabIndex = 0;
            // 
            // pnl_menu_lateral
            // 
            this.pnl_menu_lateral.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnl_menu_lateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_menu_lateral.Location = new System.Drawing.Point(0, 54);
            this.pnl_menu_lateral.Name = "pnl_menu_lateral";
            this.pnl_menu_lateral.Size = new System.Drawing.Size(97, 423);
            this.pnl_menu_lateral.TabIndex = 1;
            // 
            // pnl_contenedor
            // 
            this.pnl_contenedor.BackColor = System.Drawing.Color.Silver;
            this.pnl_contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_contenedor.Location = new System.Drawing.Point(97, 54);
            this.pnl_contenedor.Name = "pnl_contenedor";
            this.pnl_contenedor.Size = new System.Drawing.Size(843, 423);
            this.pnl_contenedor.TabIndex = 2;
            // 
            // frm_venta_hogar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 477);
            this.Controls.Add(this.pnl_contenedor);
            this.Controls.Add(this.pnl_menu_lateral);
            this.Controls.Add(this.pnl_menu_superior);
            this.Name = "frm_venta_hogar";
            this.Text = "Venta Hogar";
            this.Load += new System.EventHandler(this.frm_venta_hogar_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_menu_superior;
        private System.Windows.Forms.Panel pnl_menu_lateral;
        private System.Windows.Forms.Panel pnl_contenedor;
    }
}

