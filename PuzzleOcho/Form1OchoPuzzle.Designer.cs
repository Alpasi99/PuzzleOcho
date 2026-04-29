namespace PuzzleOcho
{
    partial class Form1OchoPuzzle
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
            this.components = new System.ComponentModel.Container();
            this.LBL00 = new System.Windows.Forms.Label();
            this.LBL01 = new System.Windows.Forms.Label();
            this.LBL02 = new System.Windows.Forms.Label();
            this.LBL12 = new System.Windows.Forms.Label();
            this.LBL11 = new System.Windows.Forms.Label();
            this.LBL10 = new System.Windows.Forms.Label();
            this.LBL22 = new System.Windows.Forms.Label();
            this.LBL21 = new System.Windows.Forms.Label();
            this.LBL20 = new System.Windows.Forms.Label();
            this.LBLContador = new System.Windows.Forms.Label();
            this.BTNDesordenar = new System.Windows.Forms.Button();
            this.TMRReloj = new System.Windows.Forms.Timer(this.components);
            this.BTNGenerarHijos = new System.Windows.Forms.Button();
            this.BTNEsFinal = new System.Windows.Forms.Button();
            this.BTNAnchuraPrioritaria = new System.Windows.Forms.Button();
            this.TMRResuelve = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // LBL00
            // 
            this.LBL00.BackColor = System.Drawing.SystemColors.Highlight;
            this.LBL00.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.LBL00.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LBL00.Location = new System.Drawing.Point(87, 48);
            this.LBL00.Name = "LBL00";
            this.LBL00.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LBL00.Size = new System.Drawing.Size(70, 70);
            this.LBL00.TabIndex = 0;
            this.LBL00.Text = "1";
            this.LBL00.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LBL00.Click += new System.EventHandler(this.LBL00_Click);
            // 
            // LBL01
            // 
            this.LBL01.BackColor = System.Drawing.SystemColors.Highlight;
            this.LBL01.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.LBL01.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LBL01.Location = new System.Drawing.Point(163, 48);
            this.LBL01.Name = "LBL01";
            this.LBL01.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LBL01.Size = new System.Drawing.Size(70, 70);
            this.LBL01.TabIndex = 1;
            this.LBL01.Text = "2";
            this.LBL01.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LBL01.Click += new System.EventHandler(this.LBL01_Click);
            // 
            // LBL02
            // 
            this.LBL02.BackColor = System.Drawing.SystemColors.Highlight;
            this.LBL02.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.LBL02.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LBL02.Location = new System.Drawing.Point(239, 48);
            this.LBL02.Name = "LBL02";
            this.LBL02.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LBL02.Size = new System.Drawing.Size(70, 70);
            this.LBL02.TabIndex = 2;
            this.LBL02.Text = "3";
            this.LBL02.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LBL02.Click += new System.EventHandler(this.LBL02_Click);
            // 
            // LBL12
            // 
            this.LBL12.BackColor = System.Drawing.SystemColors.Highlight;
            this.LBL12.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.LBL12.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LBL12.Location = new System.Drawing.Point(239, 124);
            this.LBL12.Name = "LBL12";
            this.LBL12.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LBL12.Size = new System.Drawing.Size(70, 70);
            this.LBL12.TabIndex = 5;
            this.LBL12.Text = "6";
            this.LBL12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LBL12.Click += new System.EventHandler(this.LBL12_Click);
            // 
            // LBL11
            // 
            this.LBL11.BackColor = System.Drawing.SystemColors.Highlight;
            this.LBL11.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.LBL11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LBL11.Location = new System.Drawing.Point(163, 124);
            this.LBL11.Name = "LBL11";
            this.LBL11.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LBL11.Size = new System.Drawing.Size(70, 70);
            this.LBL11.TabIndex = 4;
            this.LBL11.Text = "5";
            this.LBL11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LBL11.Click += new System.EventHandler(this.LBL11_Click);
            // 
            // LBL10
            // 
            this.LBL10.BackColor = System.Drawing.SystemColors.Highlight;
            this.LBL10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.LBL10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LBL10.Location = new System.Drawing.Point(87, 124);
            this.LBL10.Name = "LBL10";
            this.LBL10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LBL10.Size = new System.Drawing.Size(70, 70);
            this.LBL10.TabIndex = 3;
            this.LBL10.Text = "4";
            this.LBL10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LBL10.Click += new System.EventHandler(this.LBL10_Click);
            // 
            // LBL22
            // 
            this.LBL22.BackColor = System.Drawing.SystemColors.Highlight;
            this.LBL22.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.LBL22.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LBL22.Location = new System.Drawing.Point(239, 201);
            this.LBL22.Name = "LBL22";
            this.LBL22.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LBL22.Size = new System.Drawing.Size(70, 70);
            this.LBL22.TabIndex = 8;
            this.LBL22.Text = "0";
            this.LBL22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LBL22.Click += new System.EventHandler(this.LBL22_Click);
            // 
            // LBL21
            // 
            this.LBL21.BackColor = System.Drawing.SystemColors.Highlight;
            this.LBL21.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.LBL21.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LBL21.Location = new System.Drawing.Point(163, 201);
            this.LBL21.Name = "LBL21";
            this.LBL21.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LBL21.Size = new System.Drawing.Size(70, 70);
            this.LBL21.TabIndex = 7;
            this.LBL21.Text = "8";
            this.LBL21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LBL21.Click += new System.EventHandler(this.LBL21_Click);
            // 
            // LBL20
            // 
            this.LBL20.BackColor = System.Drawing.SystemColors.Highlight;
            this.LBL20.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.LBL20.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LBL20.Location = new System.Drawing.Point(87, 201);
            this.LBL20.Name = "LBL20";
            this.LBL20.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LBL20.Size = new System.Drawing.Size(70, 70);
            this.LBL20.TabIndex = 6;
            this.LBL20.Text = "7";
            this.LBL20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LBL20.Click += new System.EventHandler(this.LBL20_Click);
            // 
            // LBLContador
            // 
            this.LBLContador.BackColor = System.Drawing.SystemColors.Highlight;
            this.LBLContador.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.LBLContador.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LBLContador.Location = new System.Drawing.Point(402, 111);
            this.LBLContador.Name = "LBLContador";
            this.LBLContador.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LBLContador.Size = new System.Drawing.Size(88, 83);
            this.LBLContador.TabIndex = 9;
            this.LBLContador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LBLContador.Click += new System.EventHandler(this.TMRReloj_Tick);
            // 
            // BTNDesordenar
            // 
            this.BTNDesordenar.Location = new System.Drawing.Point(396, 67);
            this.BTNDesordenar.Name = "BTNDesordenar";
            this.BTNDesordenar.Size = new System.Drawing.Size(107, 23);
            this.BTNDesordenar.TabIndex = 10;
            this.BTNDesordenar.Text = "Desordenar";
            this.BTNDesordenar.UseVisualStyleBackColor = true;
            this.BTNDesordenar.Click += new System.EventHandler(this.BTNDesordenar_Click);
            // 
            // TMRReloj
            // 
            this.TMRReloj.Tick += new System.EventHandler(this.TMRReloj_Tick);
            // 
            // BTNGenerarHijos
            // 
            this.BTNGenerarHijos.Location = new System.Drawing.Point(396, 211);
            this.BTNGenerarHijos.Name = "BTNGenerarHijos";
            this.BTNGenerarHijos.Size = new System.Drawing.Size(107, 23);
            this.BTNGenerarHijos.TabIndex = 11;
            this.BTNGenerarHijos.Text = "Generar Hijos";
            this.BTNGenerarHijos.UseVisualStyleBackColor = true;
            this.BTNGenerarHijos.Click += new System.EventHandler(this.BTNGenerarHijos_Click);
            // 
            // BTNEsFinal
            // 
            this.BTNEsFinal.Location = new System.Drawing.Point(396, 240);
            this.BTNEsFinal.Name = "BTNEsFinal";
            this.BTNEsFinal.Size = new System.Drawing.Size(107, 23);
            this.BTNEsFinal.TabIndex = 12;
            this.BTNEsFinal.Text = "Es Final";
            this.BTNEsFinal.UseVisualStyleBackColor = true;
            this.BTNEsFinal.Click += new System.EventHandler(this.BTNEsFinal_Click);
            // 
            // BTNAnchuraPrioritaria
            // 
            this.BTNAnchuraPrioritaria.Location = new System.Drawing.Point(396, 269);
            this.BTNAnchuraPrioritaria.Name = "BTNAnchuraPrioritaria";
            this.BTNAnchuraPrioritaria.Size = new System.Drawing.Size(107, 23);
            this.BTNAnchuraPrioritaria.TabIndex = 13;
            this.BTNAnchuraPrioritaria.Text = "Anchura";
            this.BTNAnchuraPrioritaria.UseVisualStyleBackColor = true;
            this.BTNAnchuraPrioritaria.Click += new System.EventHandler(this.BTNAnchuraPrioritaria_Click);
            // 
            // TMRResuelve
            // 
            this.TMRResuelve.Interval = 500;
            this.TMRResuelve.Tick += new System.EventHandler(this.TMRResuelve_Tick);
            // 
            // Form1OchoPuzzle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 450);
            this.Controls.Add(this.BTNAnchuraPrioritaria);
            this.Controls.Add(this.BTNEsFinal);
            this.Controls.Add(this.BTNGenerarHijos);
            this.Controls.Add(this.BTNDesordenar);
            this.Controls.Add(this.LBLContador);
            this.Controls.Add(this.LBL22);
            this.Controls.Add(this.LBL21);
            this.Controls.Add(this.LBL20);
            this.Controls.Add(this.LBL12);
            this.Controls.Add(this.LBL11);
            this.Controls.Add(this.LBL10);
            this.Controls.Add(this.LBL02);
            this.Controls.Add(this.LBL01);
            this.Controls.Add(this.LBL00);
            this.Name = "Form1OchoPuzzle";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LBL00;
        private System.Windows.Forms.Label LBL01;
        private System.Windows.Forms.Label LBL02;
        private System.Windows.Forms.Label LBL12;
        private System.Windows.Forms.Label LBL11;
        private System.Windows.Forms.Label LBL10;
        private System.Windows.Forms.Label LBL22;
        private System.Windows.Forms.Label LBL21;
        private System.Windows.Forms.Label LBL20;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LBLContador;
        private System.Windows.Forms.Button BTNDesordenar;
        private System.Windows.Forms.Timer TMRReloj;
        private System.Windows.Forms.Button BTNGenerarHijos;

        private System.Windows.Forms.Button BTNEsFinal;
        private System.Windows.Forms.Button BTNAnchuraPrioritaria;
        private System.Windows.Forms.Timer TMRResuelve;
    }
}

