namespace GUI
{
    partial class Form1
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
            this.listJugadores = new System.Windows.Forms.ListBox();
            this.listMazo = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnRobar = new System.Windows.Forms.Button();
            this.listMano = new System.Windows.Forms.ListBox();
            this.listDescarte = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listJugadores
            // 
            this.listJugadores.FormattingEnabled = true;
            this.listJugadores.ItemHeight = 29;
            this.listJugadores.Location = new System.Drawing.Point(12, 276);
            this.listJugadores.Name = "listJugadores";
            this.listJugadores.Size = new System.Drawing.Size(405, 207);
            this.listJugadores.TabIndex = 6;
            // 
            // listMazo
            // 
            this.listMazo.FormattingEnabled = true;
            this.listMazo.ItemHeight = 29;
            this.listMazo.Location = new System.Drawing.Point(445, 276);
            this.listMazo.Name = "listMazo";
            this.listMazo.Size = new System.Drawing.Size(405, 207);
            this.listMazo.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(270, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(339, 119);
            this.button1.TabIndex = 4;
            this.button1.Text = "Iniciar partida";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRobar
            // 
            this.btnRobar.Location = new System.Drawing.Point(1804, 275);
            this.btnRobar.Name = "btnRobar";
            this.btnRobar.Size = new System.Drawing.Size(265, 76);
            this.btnRobar.TabIndex = 7;
            this.btnRobar.Text = "Robar Carta Mazo";
            this.btnRobar.UseVisualStyleBackColor = true;
            // 
            // listMano
            // 
            this.listMano.FormattingEnabled = true;
            this.listMano.ItemHeight = 29;
            this.listMano.Location = new System.Drawing.Point(1352, 276);
            this.listMano.Name = "listMano";
            this.listMano.Size = new System.Drawing.Size(405, 207);
            this.listMano.TabIndex = 8;
            // 
            // listDescarte
            // 
            this.listDescarte.FormattingEnabled = true;
            this.listDescarte.ItemHeight = 29;
            this.listDescarte.Location = new System.Drawing.Point(445, 515);
            this.listDescarte.Name = "listDescarte";
            this.listDescarte.Size = new System.Drawing.Size(405, 207);
            this.listDescarte.TabIndex = 9;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1804, 407);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(265, 76);
            this.button2.TabIndex = 10;
            this.button2.Text = "Robar Carta Descarte";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1485, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(450, 55);
            this.label1.TabIndex = 11;
            this.label1.Text = "JUGADOR ACTIVO";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2147, 945);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listDescarte);
            this.Controls.Add(this.listMano);
            this.Controls.Add(this.btnRobar);
            this.Controls.Add(this.listJugadores);
            this.Controls.Add(this.listMazo);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listJugadores;
        private System.Windows.Forms.ListBox listMazo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnRobar;
        private System.Windows.Forms.ListBox listMano;
        private System.Windows.Forms.ListBox listDescarte;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
    }
}

