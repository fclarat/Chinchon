namespace chinchon
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
            this.button1 = new System.Windows.Forms.Button();
            this.listMazo = new System.Windows.Forms.ListBox();
            this.listJugadores = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(296, 192);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(474, 180);
            this.button1.TabIndex = 0;
            this.button1.Text = "Iniciar partida";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listMazo
            // 
            this.listMazo.FormattingEnabled = true;
            this.listMazo.ItemHeight = 29;
            this.listMazo.Location = new System.Drawing.Point(547, 488);
            this.listMazo.Name = "listMazo";
            this.listMazo.Size = new System.Drawing.Size(405, 207);
            this.listMazo.TabIndex = 2;
            this.listMazo.SelectedIndexChanged += new System.EventHandler(this.listMazo_SelectedIndexChanged);
            // 
            // listJugadores
            // 
            this.listJugadores.FormattingEnabled = true;
            this.listJugadores.ItemHeight = 29;
            this.listJugadores.Location = new System.Drawing.Point(88, 488);
            this.listJugadores.Name = "listJugadores";
            this.listJugadores.Size = new System.Drawing.Size(405, 207);
            this.listJugadores.TabIndex = 3;
            this.listJugadores.SelectedIndexChanged += new System.EventHandler(this.listJugadores_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 858);
            this.Controls.Add(this.listJugadores);
            this.Controls.Add(this.listMazo);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listMazo;
        private System.Windows.Forms.ListBox listJugadores;
    }
}

