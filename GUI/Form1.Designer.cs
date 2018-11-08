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
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.imgDescarte = new System.Windows.Forms.PictureBox();
            this.imgMazo = new System.Windows.Forms.PictureBox();
            this.mano8 = new System.Windows.Forms.PictureBox();
            this.mano7 = new System.Windows.Forms.PictureBox();
            this.mano5 = new System.Windows.Forms.PictureBox();
            this.mano4 = new System.Windows.Forms.PictureBox();
            this.mano6 = new System.Windows.Forms.PictureBox();
            this.mano3 = new System.Windows.Forms.PictureBox();
            this.mano2 = new System.Windows.Forms.PictureBox();
            this.mano1 = new System.Windows.Forms.PictureBox();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gridPuntos = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabLogin.SuspendLayout();
            this.tabGame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgDescarte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMazo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mano8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mano7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mano5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mano4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mano6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mano3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mano2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mano1)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPuntos)).BeginInit();
            this.SuspendLayout();
            // 
            // listJugadores
            // 
            this.listJugadores.FormattingEnabled = true;
            this.listJugadores.ItemHeight = 16;
            this.listJugadores.Location = new System.Drawing.Point(11, 205);
            this.listJugadores.Margin = new System.Windows.Forms.Padding(2);
            this.listJugadores.Name = "listJugadores";
            this.listJugadores.Size = new System.Drawing.Size(233, 116);
            this.listJugadores.TabIndex = 6;
            // 
            // listMazo
            // 
            this.listMazo.DisplayMember = "Carta";
            this.listMazo.FormattingEnabled = true;
            this.listMazo.ItemHeight = 16;
            this.listMazo.Location = new System.Drawing.Point(13, 327);
            this.listMazo.Margin = new System.Windows.Forms.Padding(2);
            this.listMazo.Name = "listMazo";
            this.listMazo.Size = new System.Drawing.Size(233, 116);
            this.listMazo.TabIndex = 5;
            this.listMazo.ValueMember = "Carta";
            this.listMazo.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(50, 32);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 66);
            this.button1.TabIndex = 4;
            this.button1.Text = "Repartir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRobar
            // 
            this.btnRobar.Location = new System.Drawing.Point(1067, 81);
            this.btnRobar.Margin = new System.Windows.Forms.Padding(2);
            this.btnRobar.Name = "btnRobar";
            this.btnRobar.Size = new System.Drawing.Size(152, 42);
            this.btnRobar.TabIndex = 7;
            this.btnRobar.Text = "Robar Carta Mazo";
            this.btnRobar.UseVisualStyleBackColor = true;
            this.btnRobar.Click += new System.EventHandler(this.btnRobar_Click);
            // 
            // listMano
            // 
            this.listMano.FormattingEnabled = true;
            this.listMano.ItemHeight = 16;
            this.listMano.Location = new System.Drawing.Point(1067, 186);
            this.listMano.Margin = new System.Windows.Forms.Padding(2);
            this.listMano.Name = "listMano";
            this.listMano.Size = new System.Drawing.Size(152, 180);
            this.listMano.TabIndex = 8;
            // 
            // listDescarte
            // 
            this.listDescarte.FormattingEnabled = true;
            this.listDescarte.ItemHeight = 16;
            this.listDescarte.Location = new System.Drawing.Point(11, 447);
            this.listDescarte.Margin = new System.Windows.Forms.Padding(2);
            this.listDescarte.Name = "listDescarte";
            this.listDescarte.Size = new System.Drawing.Size(233, 116);
            this.listDescarte.TabIndex = 9;
            this.listDescarte.Visible = false;
            // 
            // btnRobarDes
            // 
            this.btnRobarDes.Location = new System.Drawing.Point(1067, 136);
            this.btnRobarDes.Margin = new System.Windows.Forms.Padding(2);
            this.btnRobarDes.Name = "btnRobarDes";
            this.btnRobarDes.Size = new System.Drawing.Size(152, 42);
            this.btnRobarDes.TabIndex = 10;
            this.btnRobarDes.Text = "Robar Carta Descarte";
            this.btnRobarDes.UseVisualStyleBackColor = true;
            this.btnRobarDes.Click += new System.EventHandler(this.btnRobarDes_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(694, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 31);
            this.label1.TabIndex = 11;
            this.label1.Text = "JUGADOR ACTIVO:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelId.Location = new System.Drawing.Point(969, 32);
            this.labelId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(53, 31);
            this.labelId.TabIndex = 12;
            this.labelId.Text = "{id}";
            // 
            // btnDescartar
            // 
            this.btnDescartar.Location = new System.Drawing.Point(1067, 379);
            this.btnDescartar.Margin = new System.Windows.Forms.Padding(2);
            this.btnDescartar.Name = "btnDescartar";
            this.btnDescartar.Size = new System.Drawing.Size(152, 42);
            this.btnDescartar.TabIndex = 13;
            this.btnDescartar.Text = "Descartar Carta";
            this.btnDescartar.UseVisualStyleBackColor = true;
            this.btnDescartar.Click += new System.EventHandler(this.btnDescartar_Click);
            // 
            // btnCortar
            // 
            this.btnCortar.Location = new System.Drawing.Point(1067, 486);
            this.btnCortar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCortar.Name = "btnCortar";
            this.btnCortar.Size = new System.Drawing.Size(152, 42);
            this.btnCortar.TabIndex = 14;
            this.btnCortar.Text = "Cortar";
            this.btnCortar.UseVisualStyleBackColor = true;
            this.btnCortar.Click += new System.EventHandler(this.btnCortar_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabLogin);
            this.tabControl1.Controls.Add(this.tabGame);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(6, 6);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1238, 577);
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
            this.tabLogin.Location = new System.Drawing.Point(4, 25);
            this.tabLogin.Margin = new System.Windows.Forms.Padding(2);
            this.tabLogin.Name = "tabLogin";
            this.tabLogin.Padding = new System.Windows.Forms.Padding(2);
            this.tabLogin.Size = new System.Drawing.Size(1230, 548);
            this.tabLogin.TabIndex = 0;
            this.tabLogin.Text = "Login/Register";
            this.tabLogin.UseVisualStyleBackColor = true;
            this.tabLogin.Click += new System.EventHandler(this.tabLogin_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(826, 131);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Crearte una cuenta";
            // 
            // txtCrearPass
            // 
            this.txtCrearPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCrearPass.Location = new System.Drawing.Point(894, 235);
            this.txtCrearPass.Margin = new System.Windows.Forms.Padding(2);
            this.txtCrearPass.Name = "txtCrearPass";
            this.txtCrearPass.PasswordChar = '*';
            this.txtCrearPass.Size = new System.Drawing.Size(171, 30);
            this.txtCrearPass.TabIndex = 10;
            // 
            // txtCrearUser
            // 
            this.txtCrearUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCrearUser.Location = new System.Drawing.Point(894, 183);
            this.txtCrearUser.Margin = new System.Windows.Forms.Padding(2);
            this.txtCrearUser.Name = "txtCrearUser";
            this.txtCrearUser.Size = new System.Drawing.Size(171, 30);
            this.txtCrearUser.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(774, 237);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "Password:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(774, 186);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 25);
            this.label7.TabIndex = 7;
            this.label7.Text = "Usuario:";
            // 
            // btnCrear
            // 
            this.btnCrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrear.Location = new System.Drawing.Point(869, 291);
            this.btnCrear.Margin = new System.Windows.Forms.Padding(2);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(128, 82);
            this.btnCrear.TabIndex = 6;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(230, 131);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Agregarte a la partida";
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(298, 235);
            this.txtPass.Margin = new System.Windows.Forms.Padding(2);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(171, 30);
            this.txtPass.TabIndex = 4;
            // 
            // txtUser
            // 
            this.txtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(298, 183);
            this.txtUser.Margin = new System.Windows.Forms.Padding(2);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(171, 30);
            this.txtUser.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(178, 237);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(178, 186);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Usuario:";
            // 
            // btnIngresar
            // 
            this.btnIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.Location = new System.Drawing.Point(260, 286);
            this.btnIngresar.Margin = new System.Windows.Forms.Padding(2);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(128, 82);
            this.btnIngresar.TabIndex = 0;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // tabGame
            // 
            this.tabGame.Controls.Add(this.label10);
            this.tabGame.Controls.Add(this.label9);
            this.tabGame.Controls.Add(this.imgDescarte);
            this.tabGame.Controls.Add(this.imgMazo);
            this.tabGame.Controls.Add(this.mano8);
            this.tabGame.Controls.Add(this.mano7);
            this.tabGame.Controls.Add(this.mano5);
            this.tabGame.Controls.Add(this.mano4);
            this.tabGame.Controls.Add(this.mano6);
            this.tabGame.Controls.Add(this.mano3);
            this.tabGame.Controls.Add(this.mano2);
            this.tabGame.Controls.Add(this.mano1);
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
            this.tabGame.Location = new System.Drawing.Point(4, 25);
            this.tabGame.Margin = new System.Windows.Forms.Padding(2);
            this.tabGame.Name = "tabGame";
            this.tabGame.Padding = new System.Windows.Forms.Padding(2);
            this.tabGame.Size = new System.Drawing.Size(1230, 548);
            this.tabGame.TabIndex = 1;
            this.tabGame.Text = "Mesa de juego";
            this.tabGame.UseVisualStyleBackColor = true;
            this.tabGame.Click += new System.EventHandler(this.tabGame_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(478, 262);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 17);
            this.label10.TabIndex = 28;
            this.label10.Text = "Descarte:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(478, 69);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 17);
            this.label9.TabIndex = 27;
            this.label9.Text = "Mazo:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // imgDescarte
            // 
            this.imgDescarte.Location = new System.Drawing.Point(481, 282);
            this.imgDescarte.Name = "imgDescarte";
            this.imgDescarte.Size = new System.Drawing.Size(117, 161);
            this.imgDescarte.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgDescarte.TabIndex = 26;
            this.imgDescarte.TabStop = false;
            this.imgDescarte.Click += new System.EventHandler(this.imgDescarte_Click);
            // 
            // imgMazo
            // 
            this.imgMazo.Location = new System.Drawing.Point(481, 89);
            this.imgMazo.Name = "imgMazo";
            this.imgMazo.Size = new System.Drawing.Size(117, 161);
            this.imgMazo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgMazo.TabIndex = 25;
            this.imgMazo.TabStop = false;
            this.imgMazo.Click += new System.EventHandler(this.imgMazo_Click);
            // 
            // mano8
            // 
            this.mano8.Location = new System.Drawing.Point(808, 394);
            this.mano8.Name = "mano8";
            this.mano8.Size = new System.Drawing.Size(100, 120);
            this.mano8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mano8.TabIndex = 24;
            this.mano8.TabStop = false;
            // 
            // mano7
            // 
            this.mano7.Location = new System.Drawing.Point(692, 394);
            this.mano7.Name = "mano7";
            this.mano7.Size = new System.Drawing.Size(100, 120);
            this.mano7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mano7.TabIndex = 23;
            this.mano7.TabStop = false;
            // 
            // mano5
            // 
            this.mano5.Location = new System.Drawing.Point(808, 242);
            this.mano5.Name = "mano5";
            this.mano5.Size = new System.Drawing.Size(100, 120);
            this.mano5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mano5.TabIndex = 22;
            this.mano5.TabStop = false;
            // 
            // mano4
            // 
            this.mano4.Location = new System.Drawing.Point(692, 242);
            this.mano4.Name = "mano4";
            this.mano4.Size = new System.Drawing.Size(100, 120);
            this.mano4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mano4.TabIndex = 21;
            this.mano4.TabStop = false;
            // 
            // mano6
            // 
            this.mano6.Location = new System.Drawing.Point(922, 246);
            this.mano6.Name = "mano6";
            this.mano6.Size = new System.Drawing.Size(100, 120);
            this.mano6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mano6.TabIndex = 20;
            this.mano6.TabStop = false;
            // 
            // mano3
            // 
            this.mano3.Location = new System.Drawing.Point(921, 95);
            this.mano3.Name = "mano3";
            this.mano3.Size = new System.Drawing.Size(100, 120);
            this.mano3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mano3.TabIndex = 19;
            this.mano3.TabStop = false;
            // 
            // mano2
            // 
            this.mano2.Location = new System.Drawing.Point(808, 95);
            this.mano2.Name = "mano2";
            this.mano2.Size = new System.Drawing.Size(100, 120);
            this.mano2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mano2.TabIndex = 18;
            this.mano2.TabStop = false;
            // 
            // mano1
            // 
            this.mano1.Location = new System.Drawing.Point(692, 95);
            this.mano1.Name = "mano1";
            this.mano1.Size = new System.Drawing.Size(100, 120);
            this.mano1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mano1.TabIndex = 17;
            this.mano1.TabStop = false;
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Location = new System.Drawing.Point(283, 56);
            this.btnFinalizar.Margin = new System.Windows.Forms.Padding(2);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(152, 42);
            this.btnFinalizar.TabIndex = 16;
            this.btnFinalizar.Text = "Finalizar juego";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 161);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "Puntos de la partida";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gridPuntos);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1230, 548);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Puntos historicos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // gridPuntos
            // 
            this.gridPuntos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPuntos.Location = new System.Drawing.Point(280, 66);
            this.gridPuntos.Name = "gridPuntos";
            this.gridPuntos.RowTemplate.Height = 24;
            this.gridPuntos.Size = new System.Drawing.Size(636, 428);
            this.gridPuntos.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1326, 682);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Chinhon!!";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabLogin.ResumeLayout(false);
            this.tabLogin.PerformLayout();
            this.tabGame.ResumeLayout(false);
            this.tabGame.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgDescarte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMazo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mano8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mano7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mano5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mano4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mano6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mano3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mano2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mano1)).EndInit();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridPuntos)).EndInit();
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
        private System.Windows.Forms.PictureBox mano1;
        private System.Windows.Forms.PictureBox mano8;
        private System.Windows.Forms.PictureBox mano7;
        private System.Windows.Forms.PictureBox mano5;
        private System.Windows.Forms.PictureBox mano4;
        private System.Windows.Forms.PictureBox mano6;
        private System.Windows.Forms.PictureBox mano3;
        private System.Windows.Forms.PictureBox mano2;
        private System.Windows.Forms.PictureBox imgDescarte;
        private System.Windows.Forms.PictureBox imgMazo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView gridPuntos;
    }
}

