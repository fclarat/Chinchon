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
            this.btnRobarDes = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.btnDescartar = new System.Windows.Forms.Button();
            this.btnCortar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listJugadores
            // 
            this.listJugadores.FormattingEnabled = true;
            this.listJugadores.ItemHeight = 31;
            this.listJugadores.Location = new System.Drawing.Point(14, 295);
            this.listJugadores.Name = "listJugadores";
            this.listJugadores.Size = new System.Drawing.Size(462, 221);
            this.listJugadores.TabIndex = 6;
            // 
            // listMazo
            // 
            this.listMazo.DisplayMember = "Carta";
            this.listMazo.FormattingEnabled = true;
            this.listMazo.ItemHeight = 31;
            this.listMazo.Location = new System.Drawing.Point(509, 295);
            this.listMazo.Name = "listMazo";
            this.listMazo.Size = new System.Drawing.Size(462, 221);
            this.listMazo.TabIndex = 5;
            this.listMazo.ValueMember = "Carta";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(309, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(387, 127);
            this.button1.TabIndex = 4;
            this.button1.Text = "Iniciar partida";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRobar
            // 
            this.btnRobar.Location = new System.Drawing.Point(2062, 294);
            this.btnRobar.Name = "btnRobar";
            this.btnRobar.Size = new System.Drawing.Size(303, 81);
            this.btnRobar.TabIndex = 7;
            this.btnRobar.Text = "Robar Carta Mazo";
            this.btnRobar.UseVisualStyleBackColor = true;
            this.btnRobar.Click += new System.EventHandler(this.btnRobar_Click);
            // 
            // listMano
            // 
            this.listMano.FormattingEnabled = true;
            this.listMano.ItemHeight = 31;
            this.listMano.Location = new System.Drawing.Point(1545, 295);
            this.listMano.Name = "listMano";
            this.listMano.Size = new System.Drawing.Size(462, 376);
            this.listMano.TabIndex = 8;
            // 
            // listDescarte
            // 
            this.listDescarte.FormattingEnabled = true;
            this.listDescarte.ItemHeight = 31;
            this.listDescarte.Location = new System.Drawing.Point(509, 551);
            this.listDescarte.Name = "listDescarte";
            this.listDescarte.Size = new System.Drawing.Size(462, 221);
            this.listDescarte.TabIndex = 9;
            // 
            // btnRobarDes
            // 
            this.btnRobarDes.Location = new System.Drawing.Point(2062, 435);
            this.btnRobarDes.Name = "btnRobarDes";
            this.btnRobarDes.Size = new System.Drawing.Size(303, 81);
            this.btnRobarDes.TabIndex = 10;
            this.btnRobarDes.Text = "Robar Carta Descarte";
            this.btnRobarDes.UseVisualStyleBackColor = true;
            this.btnRobarDes.Click += new System.EventHandler(this.btnRobarDes_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1534, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(521, 63);
            this.label1.TabIndex = 11;
            this.label1.Text = "JUGADOR ACTIVO:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelId.Location = new System.Drawing.Point(2061, 93);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(106, 63);
            this.labelId.TabIndex = 12;
            this.labelId.Text = "{id}";
            // 
            // btnDescartar
            // 
            this.btnDescartar.Location = new System.Drawing.Point(2062, 575);
            this.btnDescartar.Name = "btnDescartar";
            this.btnDescartar.Size = new System.Drawing.Size(303, 81);
            this.btnDescartar.TabIndex = 13;
            this.btnDescartar.Text = "Descartar Carta";
            this.btnDescartar.UseVisualStyleBackColor = true;
            this.btnDescartar.Click += new System.EventHandler(this.btnDescartar_Click);
            // 
            // btnCortar
            // 
            this.btnCortar.Location = new System.Drawing.Point(1620, 757);
            this.btnCortar.Name = "btnCortar";
            this.btnCortar.Size = new System.Drawing.Size(303, 81);
            this.btnCortar.TabIndex = 14;
            this.btnCortar.Text = "Cortar";
            this.btnCortar.UseVisualStyleBackColor = true;
            this.btnCortar.Click += new System.EventHandler(this.btnCortar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2454, 1010);
            this.Controls.Add(this.btnCortar);
            this.Controls.Add(this.btnDescartar);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRobarDes);
            this.Controls.Add(this.listDescarte);
            this.Controls.Add(this.listMano);
            this.Controls.Add(this.btnRobar);
            this.Controls.Add(this.listJugadores);
            this.Controls.Add(this.listMazo);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.Button btnRobarDes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Button btnDescartar;
        private System.Windows.Forms.Button btnCortar;
    }
}

