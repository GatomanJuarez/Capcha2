using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaptchaVersion2
{
    public partial class Form1 : Form
    {
        //Equipo
        //Medina Díaz Eduardo
        //Contreras Acosta Cesar
        //Ortiz Hernández Rocío Guadalupe
        //Juárez Devora Jesús Antonio
        //Rodríguez Vásquez Gerardo
        //Martínez Rodríguez Francisco Alfonso

        //Declaramos una instancia de objeto random
        Random r = new Random();
        //Declaramos un auxiliar para el texto de la caja de texto
        string aux1 = "";
        //Sonidos para si el texto es correcto o incorrecto
        //Declaramos una instancia de objeto tipo SoundPlayer
        SoundPlayer simpleSound = new SoundPlayer(@"Goods.wav");
        SoundPlayer simpleSoundRed = new SoundPlayer(@"Mals.wav");
        //Declaramos un arreglo en el cual tenga las imagenes
        string[] imagenes = new string[5];
        string[] nombres = new string[5];
        //Declaramos una variable para la posicion
        int posicion = 0;

        public Form1()
        {
            InitializeComponent();
            //Para guardar la direccion de la imagen usamos @
            imagenes[0] = @"AllYues arcades.png";
            nombres[0] = "AllYues arcades";
            imagenes[1] = @"kfnh hqck.jpg";
            nombres[1] = "kfnh hqck";
            imagenes[2] = @"Levelers critic.jpg";
            nombres[2] = "Levelers critics";
            imagenes[3] = @"morning ovelooks.jpg";
            nombres[3] = "morning overlooks";
            imagenes[4] = @"nitz haiphong.jpg";
            nombres[4] = "nitz haiphong";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Cuando carga el formulario
            //Llama al metodo 
            final();
         
        }

        private void final()
        {
            txtCaja.Text = "";
            //Pone en color gris el fondo y pone una imagen al azar
            this.BackColor = Color.FromArgb(224, 224, 224);
            //Generea un numero ramdom y lo guarda en la variable
            posicion = r.Next(0, 5);
            //Imprime la imagen en la posicion 0
            pictureBox1.ImageLocation = imagenes[posicion];
        }

        private void done()
        {
            aux1 = "";
            simpleSound.Load();
            simpleSoundRed.Load();
            aux1 = txtCaja.Text;
            if (aux1 == nombres[0] && posicion == 0)
            {
                simpleSound.Play();
                this.BackColor = Color.Green;
                txtCaja.Text = "";
                MessageBox.Show("Felicidades es correcto!!", "Human", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                final();
            }

            else if (aux1 == nombres[1] && posicion == 1)
            {
                simpleSound.Play();
                this.BackColor = Color.Green;
                txtCaja.Text = "";
                MessageBox.Show("Felicidades es correcto!!", "Human", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                final();
            }
            else if (aux1 == nombres[2] && posicion == 2)
            {
                simpleSound.Play();
                this.BackColor = Color.Green;
                txtCaja.Text = "";
                MessageBox.Show("Felicidades es correcto!!", "Human", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                final();
            }
            else if (aux1 == nombres[3] && posicion == 3)
            {
                simpleSound.Play();
                this.BackColor = Color.Green;
                txtCaja.Text = "";
                MessageBox.Show("Felicidades es correcto!!", "Human", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                final();
            }
            else if (aux1 == nombres[4] && posicion == 4)
            {
                simpleSound.Play();
                this.BackColor = Color.Green;
                txtCaja.Text = "";
                MessageBox.Show("Felicidades es correcto!!", "Human", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                final();
            }
            else
            {
                simpleSoundRed.Play();
                this.BackColor = Color.Red;
                MessageBox.Show("You are a machine!!", "MACHINE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                final();
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                done();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            final();
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            done();
        }
    }
}