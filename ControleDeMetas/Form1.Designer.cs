namespace ControleDeMetas
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
            this.components = new System.ComponentModel.Container();
            this.btnIniciar1 = new System.Windows.Forms.Button();
            this.btnZerar1 = new System.Windows.Forms.Button();
            this.lblCronometro1 = new System.Windows.Forms.Label();
            this.stopwatch1 = new System.Windows.Forms.Timer(this.components);
            this.tbAtividade1 = new System.Windows.Forms.TextBox();
            this.gbPonto = new System.Windows.Forms.GroupBox();
            this.lblCountdown = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblSaida2 = new System.Windows.Forms.Label();
            this.lblSaida = new System.Windows.Forms.Label();
            this.lblEntrada = new System.Windows.Forms.Label();
            this.tbEntrada = new System.Windows.Forms.MaskedTextBox();
            this.countdown = new System.Windows.Forms.Timer(this.components);
            this.tbAtividade2 = new System.Windows.Forms.TextBox();
            this.lblCronometro2 = new System.Windows.Forms.Label();
            this.btnZerar2 = new System.Windows.Forms.Button();
            this.btnIniciar2 = new System.Windows.Forms.Button();
            this.lblCronometro3 = new System.Windows.Forms.Label();
            this.btnZerar3 = new System.Windows.Forms.Button();
            this.btnIniciar3 = new System.Windows.Forms.Button();
            this.tbAtividade3 = new System.Windows.Forms.TextBox();
            this.lblCronometro4 = new System.Windows.Forms.Label();
            this.btnZerar4 = new System.Windows.Forms.Button();
            this.btnIniciar4 = new System.Windows.Forms.Button();
            this.tbAtividade4 = new System.Windows.Forms.TextBox();
            this.lblCronometro5 = new System.Windows.Forms.Label();
            this.btnZerar5 = new System.Windows.Forms.Button();
            this.btnIniciar5 = new System.Windows.Forms.Button();
            this.tbAtividade5 = new System.Windows.Forms.TextBox();
            this.lblCronometro6 = new System.Windows.Forms.Label();
            this.btnZerar6 = new System.Windows.Forms.Button();
            this.btnIniciar6 = new System.Windows.Forms.Button();
            this.tbAtividade6 = new System.Windows.Forms.TextBox();
            this.stopwatch3 = new System.Windows.Forms.Timer(this.components);
            this.stopwatch4 = new System.Windows.Forms.Timer(this.components);
            this.stopwatch2 = new System.Windows.Forms.Timer(this.components);
            this.stopwatch5 = new System.Windows.Forms.Timer(this.components);
            this.stopwatch6 = new System.Windows.Forms.Timer(this.components);
            this.gbPonto.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnIniciar1
            // 
            this.btnIniciar1.Location = new System.Drawing.Point(274, 10);
            this.btnIniciar1.Name = "btnIniciar1";
            this.btnIniciar1.Size = new System.Drawing.Size(75, 23);
            this.btnIniciar1.TabIndex = 0;
            this.btnIniciar1.Text = "Iniciar";
            this.btnIniciar1.UseVisualStyleBackColor = true;
            this.btnIniciar1.Click += new System.EventHandler(this.iniciar1);
            // 
            // btnZerar1
            // 
            this.btnZerar1.Enabled = false;
            this.btnZerar1.Location = new System.Drawing.Point(355, 10);
            this.btnZerar1.Name = "btnZerar1";
            this.btnZerar1.Size = new System.Drawing.Size(75, 23);
            this.btnZerar1.TabIndex = 1;
            this.btnZerar1.Text = "Zerar";
            this.btnZerar1.UseVisualStyleBackColor = true;
            this.btnZerar1.Click += new System.EventHandler(this.zerar1);
            // 
            // lblCronometro1
            // 
            this.lblCronometro1.AutoSize = true;
            this.lblCronometro1.Location = new System.Drawing.Point(219, 15);
            this.lblCronometro1.Name = "lblCronometro1";
            this.lblCronometro1.Size = new System.Drawing.Size(49, 13);
            this.lblCronometro1.TabIndex = 2;
            this.lblCronometro1.Text = "00:00:00";
            // 
            // stopwatch1
            // 
            this.stopwatch1.Enabled = true;
            this.stopwatch1.Interval = 1;
            this.stopwatch1.Tick += new System.EventHandler(this.cronometro1);
            // 
            // tbAtividade1
            // 
            this.tbAtividade1.Location = new System.Drawing.Point(12, 12);
            this.tbAtividade1.Name = "tbAtividade1";
            this.tbAtividade1.Size = new System.Drawing.Size(201, 20);
            this.tbAtividade1.TabIndex = 3;
            // 
            // gbPonto
            // 
            this.gbPonto.BackColor = System.Drawing.SystemColors.Control;
            this.gbPonto.Controls.Add(this.lblCountdown);
            this.gbPonto.Controls.Add(this.label2);
            this.gbPonto.Controls.Add(this.btnCalcular);
            this.gbPonto.Controls.Add(this.lblSaida2);
            this.gbPonto.Controls.Add(this.lblSaida);
            this.gbPonto.Controls.Add(this.lblEntrada);
            this.gbPonto.Controls.Add(this.tbEntrada);
            this.gbPonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPonto.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gbPonto.Location = new System.Drawing.Point(448, 10);
            this.gbPonto.Margin = new System.Windows.Forms.Padding(4);
            this.gbPonto.Name = "gbPonto";
            this.gbPonto.Size = new System.Drawing.Size(107, 161);
            this.gbPonto.TabIndex = 4;
            this.gbPonto.TabStop = false;
            this.gbPonto.Text = "PONTO";
            // 
            // lblCountdown
            // 
            this.lblCountdown.AutoSize = true;
            this.lblCountdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountdown.Location = new System.Drawing.Point(26, 107);
            this.lblCountdown.Name = "lblCountdown";
            this.lblCountdown.Size = new System.Drawing.Size(56, 15);
            this.lblCountdown.TabIndex = 7;
            this.lblCountdown.Text = "Restante";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 22);
            this.label2.TabIndex = 6;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(26, 76);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(60, 24);
            this.btnCalcular.TabIndex = 5;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblSaida2
            // 
            this.lblSaida2.AutoSize = true;
            this.lblSaida2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaida2.Location = new System.Drawing.Point(59, 54);
            this.lblSaida2.Name = "lblSaida2";
            this.lblSaida2.Size = new System.Drawing.Size(0, 15);
            this.lblSaida2.TabIndex = 4;
            // 
            // lblSaida
            // 
            this.lblSaida.AutoSize = true;
            this.lblSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaida.Location = new System.Drawing.Point(6, 52);
            this.lblSaida.Name = "lblSaida";
            this.lblSaida.Size = new System.Drawing.Size(39, 15);
            this.lblSaida.TabIndex = 3;
            this.lblSaida.Text = "Saída";
            // 
            // lblEntrada
            // 
            this.lblEntrada.AutoSize = true;
            this.lblEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntrada.Location = new System.Drawing.Point(6, 26);
            this.lblEntrada.Name = "lblEntrada";
            this.lblEntrada.Size = new System.Drawing.Size(50, 15);
            this.lblEntrada.TabIndex = 1;
            this.lblEntrada.Text = "Entrada";
            // 
            // tbEntrada
            // 
            this.tbEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEntrada.Location = new System.Drawing.Point(62, 25);
            this.tbEntrada.Mask = "00:00";
            this.tbEntrada.Name = "tbEntrada";
            this.tbEntrada.Size = new System.Drawing.Size(38, 21);
            this.tbEntrada.TabIndex = 0;
            this.tbEntrada.ValidatingType = typeof(System.DateTime);
            // 
            // countdown
            // 
            this.countdown.Tick += new System.EventHandler(this.contagemRegressiva);
            // 
            // tbAtividade2
            // 
            this.tbAtividade2.Location = new System.Drawing.Point(12, 38);
            this.tbAtividade2.Name = "tbAtividade2";
            this.tbAtividade2.Size = new System.Drawing.Size(201, 20);
            this.tbAtividade2.TabIndex = 5;
            // 
            // lblCronometro2
            // 
            this.lblCronometro2.AutoSize = true;
            this.lblCronometro2.Location = new System.Drawing.Point(219, 43);
            this.lblCronometro2.Name = "lblCronometro2";
            this.lblCronometro2.Size = new System.Drawing.Size(49, 13);
            this.lblCronometro2.TabIndex = 8;
            this.lblCronometro2.Text = "00:00:00";
            // 
            // btnZerar2
            // 
            this.btnZerar2.Enabled = false;
            this.btnZerar2.Location = new System.Drawing.Point(355, 38);
            this.btnZerar2.Name = "btnZerar2";
            this.btnZerar2.Size = new System.Drawing.Size(75, 23);
            this.btnZerar2.TabIndex = 7;
            this.btnZerar2.Text = "Zerar";
            this.btnZerar2.UseVisualStyleBackColor = true;
            this.btnZerar2.Click += new System.EventHandler(this.zerar2);
            // 
            // btnIniciar2
            // 
            this.btnIniciar2.Location = new System.Drawing.Point(274, 38);
            this.btnIniciar2.Name = "btnIniciar2";
            this.btnIniciar2.Size = new System.Drawing.Size(75, 23);
            this.btnIniciar2.TabIndex = 6;
            this.btnIniciar2.Text = "Iniciar";
            this.btnIniciar2.UseVisualStyleBackColor = true;
            this.btnIniciar2.Click += new System.EventHandler(this.iniciar2);
            // 
            // lblCronometro3
            // 
            this.lblCronometro3.AutoSize = true;
            this.lblCronometro3.Location = new System.Drawing.Point(219, 72);
            this.lblCronometro3.Name = "lblCronometro3";
            this.lblCronometro3.Size = new System.Drawing.Size(49, 13);
            this.lblCronometro3.TabIndex = 12;
            this.lblCronometro3.Text = "00:00:00";
            // 
            // btnZerar3
            // 
            this.btnZerar3.Enabled = false;
            this.btnZerar3.Location = new System.Drawing.Point(355, 67);
            this.btnZerar3.Name = "btnZerar3";
            this.btnZerar3.Size = new System.Drawing.Size(75, 23);
            this.btnZerar3.TabIndex = 11;
            this.btnZerar3.Text = "Zerar";
            this.btnZerar3.UseVisualStyleBackColor = true;
            this.btnZerar3.Click += new System.EventHandler(this.zerar3);
            // 
            // btnIniciar3
            // 
            this.btnIniciar3.Location = new System.Drawing.Point(274, 67);
            this.btnIniciar3.Name = "btnIniciar3";
            this.btnIniciar3.Size = new System.Drawing.Size(75, 23);
            this.btnIniciar3.TabIndex = 10;
            this.btnIniciar3.Text = "Iniciar";
            this.btnIniciar3.UseVisualStyleBackColor = true;
            this.btnIniciar3.Click += new System.EventHandler(this.iniciar3);
            // 
            // tbAtividade3
            // 
            this.tbAtividade3.Location = new System.Drawing.Point(12, 67);
            this.tbAtividade3.Name = "tbAtividade3";
            this.tbAtividade3.Size = new System.Drawing.Size(201, 20);
            this.tbAtividade3.TabIndex = 9;
            // 
            // lblCronometro4
            // 
            this.lblCronometro4.AutoSize = true;
            this.lblCronometro4.Location = new System.Drawing.Point(219, 101);
            this.lblCronometro4.Name = "lblCronometro4";
            this.lblCronometro4.Size = new System.Drawing.Size(49, 13);
            this.lblCronometro4.TabIndex = 16;
            this.lblCronometro4.Text = "00:00:00";
            // 
            // btnZerar4
            // 
            this.btnZerar4.Enabled = false;
            this.btnZerar4.Location = new System.Drawing.Point(355, 96);
            this.btnZerar4.Name = "btnZerar4";
            this.btnZerar4.Size = new System.Drawing.Size(75, 23);
            this.btnZerar4.TabIndex = 15;
            this.btnZerar4.Text = "Zerar";
            this.btnZerar4.UseVisualStyleBackColor = true;
            this.btnZerar4.Click += new System.EventHandler(this.zerar4);
            // 
            // btnIniciar4
            // 
            this.btnIniciar4.Location = new System.Drawing.Point(274, 96);
            this.btnIniciar4.Name = "btnIniciar4";
            this.btnIniciar4.Size = new System.Drawing.Size(75, 23);
            this.btnIniciar4.TabIndex = 14;
            this.btnIniciar4.Text = "Iniciar";
            this.btnIniciar4.UseVisualStyleBackColor = true;
            this.btnIniciar4.Click += new System.EventHandler(this.iniciar4);
            // 
            // tbAtividade4
            // 
            this.tbAtividade4.Location = new System.Drawing.Point(12, 96);
            this.tbAtividade4.Name = "tbAtividade4";
            this.tbAtividade4.Size = new System.Drawing.Size(201, 20);
            this.tbAtividade4.TabIndex = 13;
            // 
            // lblCronometro5
            // 
            this.lblCronometro5.AutoSize = true;
            this.lblCronometro5.Location = new System.Drawing.Point(219, 130);
            this.lblCronometro5.Name = "lblCronometro5";
            this.lblCronometro5.Size = new System.Drawing.Size(49, 13);
            this.lblCronometro5.TabIndex = 20;
            this.lblCronometro5.Text = "00:00:00";
            // 
            // btnZerar5
            // 
            this.btnZerar5.Enabled = false;
            this.btnZerar5.Location = new System.Drawing.Point(355, 125);
            this.btnZerar5.Name = "btnZerar5";
            this.btnZerar5.Size = new System.Drawing.Size(75, 23);
            this.btnZerar5.TabIndex = 19;
            this.btnZerar5.Text = "Zerar";
            this.btnZerar5.UseVisualStyleBackColor = true;
            this.btnZerar5.Click += new System.EventHandler(this.zerar5);
            // 
            // btnIniciar5
            // 
            this.btnIniciar5.Location = new System.Drawing.Point(274, 125);
            this.btnIniciar5.Name = "btnIniciar5";
            this.btnIniciar5.Size = new System.Drawing.Size(75, 23);
            this.btnIniciar5.TabIndex = 18;
            this.btnIniciar5.Text = "Iniciar";
            this.btnIniciar5.UseVisualStyleBackColor = true;
            this.btnIniciar5.Click += new System.EventHandler(this.iniciar5);
            // 
            // tbAtividade5
            // 
            this.tbAtividade5.Location = new System.Drawing.Point(12, 125);
            this.tbAtividade5.Name = "tbAtividade5";
            this.tbAtividade5.Size = new System.Drawing.Size(201, 20);
            this.tbAtividade5.TabIndex = 17;
            // 
            // lblCronometro6
            // 
            this.lblCronometro6.AutoSize = true;
            this.lblCronometro6.Location = new System.Drawing.Point(219, 159);
            this.lblCronometro6.Name = "lblCronometro6";
            this.lblCronometro6.Size = new System.Drawing.Size(49, 13);
            this.lblCronometro6.TabIndex = 24;
            this.lblCronometro6.Text = "00:00:00";
            // 
            // btnZerar6
            // 
            this.btnZerar6.Enabled = false;
            this.btnZerar6.Location = new System.Drawing.Point(355, 154);
            this.btnZerar6.Name = "btnZerar6";
            this.btnZerar6.Size = new System.Drawing.Size(75, 23);
            this.btnZerar6.TabIndex = 23;
            this.btnZerar6.Text = "Zerar";
            this.btnZerar6.UseVisualStyleBackColor = true;
            this.btnZerar6.Click += new System.EventHandler(this.zerar6);
            // 
            // btnIniciar6
            // 
            this.btnIniciar6.Location = new System.Drawing.Point(274, 154);
            this.btnIniciar6.Name = "btnIniciar6";
            this.btnIniciar6.Size = new System.Drawing.Size(75, 23);
            this.btnIniciar6.TabIndex = 22;
            this.btnIniciar6.Text = "Iniciar";
            this.btnIniciar6.UseVisualStyleBackColor = true;
            this.btnIniciar6.Click += new System.EventHandler(this.iniciar6);
            // 
            // tbAtividade6
            // 
            this.tbAtividade6.Location = new System.Drawing.Point(12, 154);
            this.tbAtividade6.Name = "tbAtividade6";
            this.tbAtividade6.Size = new System.Drawing.Size(201, 20);
            this.tbAtividade6.TabIndex = 21;
            // 
            // stopwatch3
            // 
            this.stopwatch3.Enabled = true;
            this.stopwatch3.Interval = 1;
            this.stopwatch3.Tick += new System.EventHandler(this.cronometro3);
            // 
            // stopwatch4
            // 
            this.stopwatch4.Enabled = true;
            this.stopwatch4.Interval = 1;
            this.stopwatch4.Tick += new System.EventHandler(this.cronometro4);
            // 
            // stopwatch2
            // 
            this.stopwatch2.Enabled = true;
            this.stopwatch2.Interval = 1;
            this.stopwatch2.Tick += new System.EventHandler(this.cronometro2);
            // 
            // stopwatch5
            // 
            this.stopwatch5.Enabled = true;
            this.stopwatch5.Interval = 1;
            this.stopwatch5.Tick += new System.EventHandler(this.cronometro5);
            // 
            // stopwatch6
            // 
            this.stopwatch6.Enabled = true;
            this.stopwatch6.Interval = 1;
            this.stopwatch6.Tick += new System.EventHandler(this.cronometro6);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 185);
            this.Controls.Add(this.lblCronometro6);
            this.Controls.Add(this.btnZerar6);
            this.Controls.Add(this.btnIniciar6);
            this.Controls.Add(this.tbAtividade6);
            this.Controls.Add(this.lblCronometro5);
            this.Controls.Add(this.btnZerar5);
            this.Controls.Add(this.btnIniciar5);
            this.Controls.Add(this.tbAtividade5);
            this.Controls.Add(this.lblCronometro4);
            this.Controls.Add(this.btnZerar4);
            this.Controls.Add(this.btnIniciar4);
            this.Controls.Add(this.tbAtividade4);
            this.Controls.Add(this.lblCronometro3);
            this.Controls.Add(this.btnZerar3);
            this.Controls.Add(this.btnIniciar3);
            this.Controls.Add(this.tbAtividade3);
            this.Controls.Add(this.lblCronometro2);
            this.Controls.Add(this.btnZerar2);
            this.Controls.Add(this.btnIniciar2);
            this.Controls.Add(this.tbAtividade2);
            this.Controls.Add(this.gbPonto);
            this.Controls.Add(this.tbAtividade1);
            this.Controls.Add(this.lblCronometro1);
            this.Controls.Add(this.btnZerar1);
            this.Controls.Add(this.btnIniciar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de Metas 2017";
            this.gbPonto.ResumeLayout(false);
            this.gbPonto.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIniciar1;
        private System.Windows.Forms.Button btnZerar1;
        private System.Windows.Forms.Label lblCronometro1;
        private System.Windows.Forms.Timer stopwatch1;
        private System.Windows.Forms.TextBox tbAtividade1;
        private System.Windows.Forms.Label lblEntrada;
        private System.Windows.Forms.MaskedTextBox tbEntrada;
        private System.Windows.Forms.Label lblSaida;
        private System.Windows.Forms.Label lblSaida2;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Timer countdown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbPonto;
        private System.Windows.Forms.Label lblCountdown;
        private System.Windows.Forms.TextBox tbAtividade2;
        private System.Windows.Forms.Label lblCronometro2;
        private System.Windows.Forms.Button btnZerar2;
        private System.Windows.Forms.Button btnIniciar2;
        private System.Windows.Forms.Label lblCronometro3;
        private System.Windows.Forms.Button btnZerar3;
        private System.Windows.Forms.Button btnIniciar3;
        private System.Windows.Forms.TextBox tbAtividade3;
        private System.Windows.Forms.Label lblCronometro4;
        private System.Windows.Forms.Button btnZerar4;
        private System.Windows.Forms.Button btnIniciar4;
        private System.Windows.Forms.TextBox tbAtividade4;
        private System.Windows.Forms.Label lblCronometro5;
        private System.Windows.Forms.Button btnZerar5;
        private System.Windows.Forms.Button btnIniciar5;
        private System.Windows.Forms.TextBox tbAtividade5;
        private System.Windows.Forms.Label lblCronometro6;
        private System.Windows.Forms.Button btnZerar6;
        private System.Windows.Forms.Button btnIniciar6;
        private System.Windows.Forms.TextBox tbAtividade6;
        private System.Windows.Forms.Timer stopwatch3;
        private System.Windows.Forms.Timer stopwatch4;
        private System.Windows.Forms.Timer stopwatch2;
        private System.Windows.Forms.Timer stopwatch5;
        private System.Windows.Forms.Timer stopwatch6;
    }
}

