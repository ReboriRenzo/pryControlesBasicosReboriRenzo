namespace pryControlesBasicosReboriRenzo
{
    partial class frmControlesBasicos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmControlesBasicos));
            this.txtTexto = new System.Windows.Forms.Label();
            this.optRojo = new System.Windows.Forms.RadioButton();
            this.optAzul = new System.Windows.Forms.RadioButton();
            this.lblTexto = new System.Windows.Forms.TextBox();
            this.cmdAsignar = new System.Windows.Forms.Button();
            this.mrcPartido = new System.Windows.Forms.GroupBox();
            this.chkEmpate = new System.Windows.Forms.CheckBox();
            this.chkBelgrano = new System.Windows.Forms.CheckBox();
            this.chkTalleres = new System.Windows.Forms.CheckBox();
            this.cmdElegir = new System.Windows.Forms.Button();
            this.cboAñadir = new System.Windows.Forms.ComboBox();
            this.lblElegir = new System.Windows.Forms.Label();
            this.mrcPartido.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTexto
            // 
            this.txtTexto.AutoSize = true;
            this.txtTexto.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTexto.Location = new System.Drawing.Point(40, 37);
            this.txtTexto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.Size = new System.Drawing.Size(0, 17);
            this.txtTexto.TabIndex = 0;
            this.txtTexto.Click += new System.EventHandler(this.label1_Click);
            // 
            // optRojo
            // 
            this.optRojo.AutoSize = true;
            this.optRojo.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optRojo.ForeColor = System.Drawing.Color.Red;
            this.optRojo.Location = new System.Drawing.Point(32, 97);
            this.optRojo.Margin = new System.Windows.Forms.Padding(4);
            this.optRojo.Name = "optRojo";
            this.optRojo.Size = new System.Drawing.Size(51, 20);
            this.optRojo.TabIndex = 1;
            this.optRojo.TabStop = true;
            this.optRojo.Text = "Rojo";
            this.optRojo.UseVisualStyleBackColor = true;
            // 
            // optAzul
            // 
            this.optAzul.AutoSize = true;
            this.optAzul.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optAzul.ForeColor = System.Drawing.Color.Blue;
            this.optAzul.Location = new System.Drawing.Point(117, 97);
            this.optAzul.Margin = new System.Windows.Forms.Padding(4);
            this.optAzul.Name = "optAzul";
            this.optAzul.Size = new System.Drawing.Size(49, 20);
            this.optAzul.TabIndex = 2;
            this.optAzul.TabStop = true;
            this.optAzul.Text = "Azul";
            this.optAzul.UseVisualStyleBackColor = true;
            // 
            // lblTexto
            // 
            this.lblTexto.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTexto.Location = new System.Drawing.Point(32, 34);
            this.lblTexto.Margin = new System.Windows.Forms.Padding(4);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(225, 28);
            this.lblTexto.TabIndex = 3;
            this.lblTexto.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cmdAsignar
            // 
            this.cmdAsignar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmdAsignar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdAsignar.Location = new System.Drawing.Point(200, 82);
            this.cmdAsignar.Margin = new System.Windows.Forms.Padding(4);
            this.cmdAsignar.Name = "cmdAsignar";
            this.cmdAsignar.Size = new System.Drawing.Size(124, 48);
            this.cmdAsignar.TabIndex = 4;
            this.cmdAsignar.Text = "Asignar";
            this.cmdAsignar.UseVisualStyleBackColor = false;
            this.cmdAsignar.Click += new System.EventHandler(this.cmdAsignar_Click);
            // 
            // mrcPartido
            // 
            this.mrcPartido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.mrcPartido.Controls.Add(this.chkEmpate);
            this.mrcPartido.Controls.Add(this.chkBelgrano);
            this.mrcPartido.Controls.Add(this.chkTalleres);
            this.mrcPartido.Location = new System.Drawing.Point(32, 177);
            this.mrcPartido.Margin = new System.Windows.Forms.Padding(4);
            this.mrcPartido.Name = "mrcPartido";
            this.mrcPartido.Padding = new System.Windows.Forms.Padding(4);
            this.mrcPartido.Size = new System.Drawing.Size(225, 140);
            this.mrcPartido.TabIndex = 5;
            this.mrcPartido.TabStop = false;
            this.mrcPartido.Text = "Partidos";
            // 
            // chkEmpate
            // 
            this.chkEmpate.AutoSize = true;
            this.chkEmpate.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEmpate.ForeColor = System.Drawing.Color.Black;
            this.chkEmpate.Location = new System.Drawing.Point(25, 101);
            this.chkEmpate.Margin = new System.Windows.Forms.Padding(4);
            this.chkEmpate.Name = "chkEmpate";
            this.chkEmpate.Size = new System.Drawing.Size(73, 21);
            this.chkEmpate.TabIndex = 2;
            this.chkEmpate.Text = "Emapte";
            this.chkEmpate.UseVisualStyleBackColor = true;
            // 
            // chkBelgrano
            // 
            this.chkBelgrano.AutoSize = true;
            this.chkBelgrano.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBelgrano.ForeColor = System.Drawing.Color.Cyan;
            this.chkBelgrano.Location = new System.Drawing.Point(25, 73);
            this.chkBelgrano.Margin = new System.Windows.Forms.Padding(4);
            this.chkBelgrano.Name = "chkBelgrano";
            this.chkBelgrano.Size = new System.Drawing.Size(81, 20);
            this.chkBelgrano.TabIndex = 1;
            this.chkBelgrano.Text = "Belgrano";
            this.chkBelgrano.UseVisualStyleBackColor = true;
            // 
            // chkTalleres
            // 
            this.chkTalleres.AutoSize = true;
            this.chkTalleres.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTalleres.ForeColor = System.Drawing.Color.Blue;
            this.chkTalleres.Location = new System.Drawing.Point(25, 44);
            this.chkTalleres.Margin = new System.Windows.Forms.Padding(4);
            this.chkTalleres.Name = "chkTalleres";
            this.chkTalleres.Size = new System.Drawing.Size(73, 21);
            this.chkTalleres.TabIndex = 0;
            this.chkTalleres.Text = "Talleres";
            this.chkTalleres.UseVisualStyleBackColor = true;
            this.chkTalleres.CheckedChanged += new System.EventHandler(this.txtTalleres_CheckedChanged);
            // 
            // cmdElegir
            // 
            this.cmdElegir.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmdElegir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdElegir.Location = new System.Drawing.Point(71, 324);
            this.cmdElegir.Name = "cmdElegir";
            this.cmdElegir.Size = new System.Drawing.Size(133, 46);
            this.cmdElegir.TabIndex = 6;
            this.cmdElegir.Text = "Elegir";
            this.cmdElegir.UseVisualStyleBackColor = false;
            this.cmdElegir.Click += new System.EventHandler(this.cmdElegir_Click);
            // 
            // cboAñadir
            // 
            this.cboAñadir.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cboAñadir.FormattingEnabled = true;
            this.cboAñadir.Location = new System.Drawing.Point(32, 410);
            this.cboAñadir.Name = "cboAñadir";
            this.cboAñadir.Size = new System.Drawing.Size(240, 25);
            this.cboAñadir.TabIndex = 7;
            // 
            // lblElegir
            // 
            this.lblElegir.AutoSize = true;
            this.lblElegir.Location = new System.Drawing.Point(114, 390);
            this.lblElegir.Name = "lblElegir";
            this.lblElegir.Size = new System.Drawing.Size(0, 17);
            this.lblElegir.TabIndex = 8;
            // 
            // frmControlesBasicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 512);
            this.Controls.Add(this.lblElegir);
            this.Controls.Add(this.cboAñadir);
            this.Controls.Add(this.cmdElegir);
            this.Controls.Add(this.mrcPartido);
            this.Controls.Add(this.cmdAsignar);
            this.Controls.Add(this.lblTexto);
            this.Controls.Add(this.optAzul);
            this.Controls.Add(this.optRojo);
            this.Controls.Add(this.txtTexto);
            this.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmControlesBasicos";
            this.Text = "Controles Basicos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mrcPartido.ResumeLayout(false);
            this.mrcPartido.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtTexto;
        private System.Windows.Forms.RadioButton optRojo;
        private System.Windows.Forms.RadioButton optAzul;
        private System.Windows.Forms.TextBox lblTexto;
        private System.Windows.Forms.Button cmdAsignar;
        private System.Windows.Forms.GroupBox mrcPartido;
        private System.Windows.Forms.CheckBox chkEmpate;
        private System.Windows.Forms.CheckBox chkBelgrano;
        private System.Windows.Forms.CheckBox chkTalleres;
        private System.Windows.Forms.Button cmdElegir;
        private System.Windows.Forms.ComboBox cboAñadir;
        private System.Windows.Forms.Label lblElegir;
    }
}

