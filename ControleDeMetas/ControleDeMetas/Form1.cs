using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleDeMetas
{
    public partial class Form1 : Form
    {
        Stopwatch cronom1 = new Stopwatch();
        Stopwatch cronom2 = new Stopwatch();
        Stopwatch cronom3 = new Stopwatch();
        Stopwatch cronom4 = new Stopwatch();
        Stopwatch cronom5 = new Stopwatch();
        Stopwatch cronom6 = new Stopwatch();
        int cont1, cont2, cont3, cont4, cont5, cont6 = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void iniciar1(object sender, EventArgs e)
        {
            cont1++;
            iniciar(cronom1, btnIniciar1, btnZerar1, cont1);
        }

        private void iniciar2(object sender, EventArgs e)
        {
            cont2++;
            iniciar(cronom2, btnIniciar2, btnZerar2, cont2);
        }

        private void iniciar3(object sender, EventArgs e)
        {
            cont3++;
            iniciar(cronom3, btnIniciar3, btnZerar3, cont3);
        }

        private void iniciar4(object sender, EventArgs e)
        {
            cont4++;
            iniciar(cronom4, btnIniciar4, btnZerar4, cont4);
        }

        private void iniciar5(object sender, EventArgs e)
        {
            cont5++;
            iniciar(cronom5, btnIniciar5, btnZerar5, cont5);
        }

        private void iniciar6(object sender, EventArgs e)
        {
            cont6++;
            iniciar(cronom6, btnIniciar6, btnZerar6, cont6);
        }

        private void zerar1(object sender, EventArgs e)
        {
            zerar(cronom1, lblCronometro1, btnIniciar1, btnZerar1);
            cont1 = 0;
        }

        private void zerar2(object sender, EventArgs e)
        {
            zerar(cronom2, lblCronometro2, btnIniciar2, btnZerar2);
            cont2 = 0;
        }

        private void zerar3(object sender, EventArgs e)
        {
            zerar(cronom3, lblCronometro3, btnIniciar3, btnZerar3);
            cont3 = 0;
        }

        private void zerar4(object sender, EventArgs e)
        {
            zerar(cronom4, lblCronometro4, btnIniciar4, btnZerar4);
            cont4 = 0;
        }

        private void zerar5(object sender, EventArgs e)
        {
            zerar(cronom5, lblCronometro5, btnIniciar5, btnZerar5);
            cont5 = 0;
        }

        private void zerar6(object sender, EventArgs e)
        {
            zerar(cronom6, lblCronometro6, btnIniciar6, btnZerar6);
            cont6 = 0;
        }

        private void cronometro1(object sender, EventArgs e)
        {
            cronometro(cronom1, lblCronometro1);
        }

        private void cronometro2(object sender, EventArgs e)
        {
            cronometro(cronom2, lblCronometro2);
        }

        private void cronometro3(object sender, EventArgs e)
        {
            cronometro(cronom3, lblCronometro3);
        }

        private void cronometro4(object sender, EventArgs e)
        {
            cronometro(cronom4, lblCronometro4);
        }

        private void cronometro5(object sender, EventArgs e)
        {
            cronometro(cronom5, lblCronometro5);
        }

        private void cronometro6(object sender, EventArgs e)
        {
            cronometro(cronom6, lblCronometro6);
        }

        void iniciar(Stopwatch cronom, Button iniciar, Button zerar, int cont) {
            if (cont % 2 == 1)
            {
                cronom.Start();
                iniciar.Text = "Pausar";
                zerar.Enabled = true;
            }
            else
            {
                cronom.Stop();
                iniciar.Text = "Continuar";
                zerar.Enabled = true;
            }
        }

        void zerar(Stopwatch cronom, Label cronomtext, Button iniciar, Button zerar) {
            cronom.Reset();
            cronomtext.Text = String.Format("00:00:00");
            iniciar.Text = "Iniciar";
            iniciar.Enabled = true;
            zerar.Enabled = false;
        }

        void cronometro(Stopwatch cronon, Label cronomtext) {
            cronomtext.Text = String.Format("{0:00}:{1:00}:{2:00}", cronon.Elapsed.Hours, cronon.Elapsed.Minutes, cronon.Elapsed.Seconds);
        }
        /*####################################################################################################################################################################################################*/
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (tbEntrada.MaskCompleted) {
                countdown.Enabled = true;
                DateTime a = DateTime.Parse(tbEntrada.Text);
                a = a.AddHours(9);
                a = a.AddMinutes(11);
                lblSaida2.Text = String.Format("{0:00}:{1:00}", a.Hour, a.Minute);
            }
            else
            {
                MessageBox.Show("Valor Incorreto!", "Horário de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void contagemRegressiva(object sender, EventArgs e)
        {  
            DateTime minhaHora = DateTime.ParseExact(lblSaida2.Text, "HH:mm", System.Globalization.CultureInfo.InvariantCulture);
            //Se alcançou a hora selecionada
            if (minhaHora <= DateTime.Now)  
            {
                countdown.Enabled = false;
                MessageBox.Show("PONTO SAÍDA", "Pronto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //Se não alcançou, atualiza os labels
            else
            {
                TimeSpan tsTempoRestante = minhaHora.Subtract(DateTime.Now);
                String hh = tsTempoRestante.ToString("hh");
                String mm = tsTempoRestante.ToString("mm");
                String ss = tsTempoRestante.ToString("ss");
                label2.Text = hh + ":" + mm + ":" + ss;
            }
        }
    }
}