namespace ProyectoSistemaCaja
{
    partial class Inicio
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
            this.button3 = new System.Windows.Forms.Button();
            this.calendario = new System.Windows.Forms.MonthCalendar();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btnAgregaProducto = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblHora = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Location = new System.Drawing.Point(532, 216);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(240, 122);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // calendario
            // 
            this.calendario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.calendario.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.calendario.FirstDayOfWeek = System.Windows.Forms.Day.Monday;
            this.calendario.Location = new System.Drawing.Point(778, 372);
            this.calendario.Name = "calendario";
            this.calendario.TabIndex = 7;
            this.calendario.UseWaitCursor = true;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button7.BackgroundImage = global::ProyectoSistemaCaja.Properties.Resources.Search;
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.Location = new System.Drawing.Point(612, 344);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(160, 190);
            this.button7.TabIndex = 6;
            this.button7.Text = "Buscar Producto";
            this.button7.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackgroundImage = global::ProyectoSistemaCaja.Properties.Resources.Delete_shopping_car;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.Location = new System.Drawing.Point(449, 344);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(157, 190);
            this.button6.TabIndex = 5;
            this.button6.Text = "Eliminar Producto";
            this.button6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // btnAgregaProducto
            // 
            this.btnAgregaProducto.BackgroundImage = global::ProyectoSistemaCaja.Properties.Resources.AgregarProducto;
            this.btnAgregaProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAgregaProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregaProducto.Location = new System.Drawing.Point(226, 344);
            this.btnAgregaProducto.Name = "btnAgregaProducto";
            this.btnAgregaProducto.Size = new System.Drawing.Size(217, 190);
            this.btnAgregaProducto.TabIndex = 4;
            this.btnAgregaProducto.Text = "Agregar Producto";
            this.btnAgregaProducto.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAgregaProducto.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::ProyectoSistemaCaja.Properties.Resources.Mercado;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button4.FlatAppearance.BorderSize = 10;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.button4.Location = new System.Drawing.Point(778, 97);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(254, 241);
            this.button4.TabIndex = 3;
            this.button4.Text = "Ventas";
            this.button4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::ProyectoSistemaCaja.Properties.Resources.InicioSesion;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.Location = new System.Drawing.Point(532, 97);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(240, 113);
            this.button2.TabIndex = 1;
            this.button2.Text = "Inicio de sesion";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button2.UseMnemonic = false;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackgroundImage = global::ProyectoSistemaCaja.Properties.Resources.goal_achieve_achievement_step_reach_1281;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 10;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(226, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(300, 241);
            this.button1.TabIndex = 0;
            this.button1.Text = "Reporte de finanzas ";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(1100, 18);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(0, 20);
            this.lblHora.TabIndex = 8;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1333, 692);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.calendario);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.btnAgregaProducto);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnAgregaProducto;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.MonthCalendar calendario;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblHora;
    }
}

