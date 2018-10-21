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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabLogin = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCrearPass = new System.Windows.Forms.TextBox();
            this.txtCrearUser = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCrear = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.tabGame = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabLogin.SuspendLayout();
            this.tabGame.SuspendLayout();
            this.SuspendLayout();
            // 
            // listJugadores
            // 
            this.listJugadores.FormattingEnabled = true;
            this.listJugadores.ItemHeight = 31;
            this.listJugadores.Location = new System.Drawing.Point(113, 404);
            this.listJugadores.Name = "listJugadores";
            this.listJugadores.Size = new System.Drawing.Size(462, 221);
            this.listJugadores.TabIndex = 6;
            // 
            // listMazo
            // 
            this.listMazo.DisplayMember = "Carta";
            this.listMazo.FormattingEnabled = true;
            this.listMazo.ItemHeight = 31;
            this.listMazo.Location = new System.Drawing.Point(676, 264);
            this.listMazo.Name = "listMazo";
            this.listMazo.Size = new System.Drawing.Size(462, 221);
            this.listMazo.TabIndex = 5;
            this.listMazo.ValueMember = "Carta";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(408, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(387, 127);
            this.button1.TabIndex = 4;
            this.button1.Text = "Repartir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRobar
            // 
            this.btnRobar.Location = new System.Drawing.Point(1915, 263);
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
            this.listMano.Location = new System.Drawing.Point(1398, 264);
            this.listMano.Name = "listMano";
            this.listMano.Size = new System.Drawing.Size(462, 376);
            this.listMano.TabIndex = 8;
            // 
            // listDescarte
            // 
            this.listDescarte.FormattingEnabled = true;
            this.listDescarte.ItemHeight = 31;
            this.listDescarte.Location = new System.Drawing.Point(676, 520);
            this.listDescarte.Name = "listDescarte";
            this.listDescarte.Size = new System.Drawing.Size(462, 221);
            this.listDescarte.TabIndex = 9;
            // 
            // btnRobarDes
            // 
            this.btnRobarDes.Location = new System.Drawing.Point(1915, 404);
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
            this.label1.Location = new System.Drawing.Point(1387, 62);
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
            this.labelId.Location = new System.Drawing.Point(1938, 62);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(106, 63);
            this.labelId.TabIndex = 12;
            this.labelId.Text = "{id}";
            // 
            // btnDescartar
            // 
            this.btnDescartar.Location = new System.Drawing.Point(1915, 544);
            this.btnDescartar.Name = "btnDescartar";
            this.btnDescartar.Size = new System.Drawing.Size(303, 81);
            this.btnDescartar.TabIndex = 13;
            this.btnDescartar.Text = "Descartar Carta";
            this.btnDescartar.UseVisualStyleBackColor = true;
            this.btnDescartar.Click += new System.EventHandler(this.btnDescartar_Click);
            // 
            // btnCortar
            // 
            this.btnCortar.Location = new System.Drawing.Point(1473, 726);
            this.btnCortar.Name = "btnCortar";
            this.btnCortar.Size = new System.Drawing.Size(303, 81);
            this.btnCortar.TabIndex = 14;
            this.btnCortar.Text = "Cortar";
            this.btnCortar.UseVisualStyleBackColor = true;
            this.btnCortar.Click += new System.EventHandler(this.btnCortar_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabLogin);
            this.tabControl1.Controls.Add(this.tabGame);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(2475, 1118);
            this.tabControl1.TabIndex = 15;
            // 
            // tabLogin
            // 
            this.tabLogin.Controls.Add(this.label5);
            this.tabLogin.Controls.Add(this.txtCrearPass);
            this.tabLogin.Controls.Add(this.txtCrearUser);
            this.tabLogin.Controls.Add(this.label6);
            this.tabLogin.Controls.Add(this.label7);
            this.tabLogin.Controls.Add(this.btnCrear);
            this.tabLogin.Controls.Add(this.label4);
            this.tabLogin.Controls.Add(this.txtPass);
            this.tabLogin.Controls.Add(this.txtUser);
            this.tabLogin.Controls.Add(this.label3);
            this.tabLogin.Controls.Add(this.label2);
            this.tabLogin.Controls.Add(this.btnIngresar);
            this.tabLogin.Location = new System.Drawing.Point(10, 48);
            this.tabLogin.Name = "tabLogin";
            this.tabLogin.Padding = new System.Windows.Forms.Padding(3);
            this.tabLogin.Size = new System.Drawing.Size(2455, 1060);
            this.tabLogin.TabIndex = 0;
            this.tabLogin.Text = "Login/Register";
            this.tabLogin.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1511, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(360, 46);
            this.label5.TabIndex = 11;
            this.label5.Text = "Crearte una cuenta";
            // 
            // txtCrearPass
            // 
            this.txtCrearPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCrearPass.Location = new System.Drawing.Point(1648, 456);
            this.txtCrearPass.Name = "txtCrearPass";
            this.txtCrearPass.PasswordChar = '*';
            this.txtCrearPass.Size = new System.Drawing.Size(338, 53);
            this.txtCrearPass.TabIndex = 10;
            // 
            // txtCrearUser
            // 
            this.txtCrearUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCrearUser.Location = new System.Drawing.Point(1648, 355);
            this.txtCrearUser.Name = "txtCrearUser";
            this.txtCrearUser.Size = new System.Drawing.Size(338, 53);
            this.txtCrearUser.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1408, 459);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(207, 46);
            this.label6.TabIndex = 8;
            this.label6.Text = "Password:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1408, 361);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(169, 46);
            this.label7.TabIndex = 7;
            this.label7.Text = "Usuario:";
            // 
            // btnCrear
            // 
            this.btnCrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrear.Location = new System.Drawing.Point(1598, 563);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(255, 159);
            this.btnCrear.TabIndex = 6;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(352, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(401, 46);
            this.label4.TabIndex = 5;
            this.label4.Text = "Agregarte a la partida";
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(489, 442);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(338, 53);
            this.txtPass.TabIndex = 4;
            // 
            // txtUser
            // 
            this.txtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(489, 341);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(338, 53);
            this.txtUser.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(249, 445);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 46);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(249, 347);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 46);
            this.label2.TabIndex = 1;
            this.label2.Text = "Usuario:";
            // 
            // btnIngresar
            // 
            this.btnIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.Location = new System.Drawing.Point(413, 541);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(255, 159);
            this.btnIngresar.TabIndex = 0;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // tabGame
            // 
            this.tabGame.Controls.Add(this.btnFinalizar);
            this.tabGame.Controls.Add(this.label8);
            this.tabGame.Controls.Add(this.listMazo);
            this.tabGame.Controls.Add(this.btnCortar);
            this.tabGame.Controls.Add(this.button1);
            this.tabGame.Controls.Add(this.btnDescartar);
            this.tabGame.Controls.Add(this.listJugadores);
            this.tabGame.Controls.Add(this.labelId);
            this.tabGame.Controls.Add(this.listDescarte);
            this.tabGame.Controls.Add(this.label1);
            this.tabGame.Controls.Add(this.listMano);
            this.tabGame.Controls.Add(this.btnRobarDes);
            this.tabGame.Controls.Add(this.btnRobar);
            this.tabGame.Location = new System.Drawing.Point(10, 48);
            this.tabGame.Name = "tabGame";
            this.tabGame.Padding = new System.Windows.Forms.Padding(3);
            this.tabGame.Size = new System.Drawing.Size(2455, 1060);
            this.tabGame.TabIndex = 1;
            this.tabGame.Text = "Mesa de juego";
            this.tabGame.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(113, 319);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(268, 32);
            this.label8.TabIndex = 15;
            this.label8.Text = "Puntos de la partida";
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Location = new System.Drawing.Point(1070, 924);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(303, 81);
            this.btnFinalizar.TabIndex = 16;
            this.btnFinalizar.Text = "Finalizar juego";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2586, 1378);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabLogin.ResumeLayout(false);
            this.tabLogin.PerformLayout();
            this.tabGame.ResumeLayout(false);
            this.tabGame.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.TabPage tabLogin;
        private System.Windows.Forms.TabPage tabGame;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCrearPass;
        private System.Windows.Forms.TextBox txtCrearUser;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnFinalizar;
    }
}

