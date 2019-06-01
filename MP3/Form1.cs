using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace MP3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        //Al cargar el formulario ponemos el reproductor como invisible
        private void Form1_Load(object sender, EventArgs e)
        {
            reproductor.uiMode = "invisible";
        }
        
        //Reproducir A través de Windows Player
        private void button1_Click(object sender, EventArgs e)
        {           

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                reproductor.URL = openFileDialog1.FileName;                 
            }
            reproductor.Ctlcontrols.play();
        }
      

        //Detener la reproducción en Windows Player
        private void button2_Click(object sender, EventArgs e)
        {
            reproductor.Ctlcontrols.stop();
        }


        //DLL a utilizar para poder reproducir MP3
       [DllImport("winmm.dll")]

        //Método externo (esta definido en winmm.dll) tipo long que se encargara de enviar comandos al MCI
        private static extern long mciSendString(string strCommand, StringBuilder strReturn, int iReturnLength, IntPtr hwndCallback);


        //Método para reproducir MP3 a través de MCI
        //Recibe: Nombre y ruta del archivo a reproducir
        public void PlayMP3(string rutaArchivo)
        {
            //Comandos multimedia de MCI http://msdn.microsoft.com/en-us/library/ms712587        

            //Abrir el dispositivo MCI
            //miMP3 es el alias con el que manejaremos el archivo MP3 recibido como parametro en rutaArchivo
            string comandoMCI = string.Format("open \"{0}\" type mpegvideo alias miMP3", rutaArchivo);
            //a traves de mciSendString, enviamos el comando anterior, para abrir el dispositivo MCO
            mciSendString(comandoMCI, null, 0, IntPtr.Zero);
            //Ahora en comandoMCI daremos la orden de reproducir el archivo, recordando que lo hacemos
            //a traves del alias que definimos anteriormente miMP3
            comandoMCI = "play miMP3";
            //enviamos a ejecutar el comando play
            mciSendString(comandoMCI, null, 0, IntPtr.Zero);
        }

       //Reproducir a través de MCI, 
        //Envia: el nombre del archivo se envia hacia el método PlayMP3
        private void button3_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                PlayMP3(openFileDialog1.FileName); 
            }
            

        }

        //Detener la reproducción del MP3 en el MCI
        private void button4_Click(object sender, EventArgs e)
        {
            //Comandos multimedia de MCI http://msdn.microsoft.com/en-us/library/ms712587            
            //el comando es stop y se le envia al alias miMP3, que se definio cuando se dio Play
            string comandoMCI = "stop miMP3";
            //Enviar el comando stop al MCI
            mciSendString(comandoMCI, null, 0, IntPtr.Zero);
        }

        private void reproductor_Enter(object sender, EventArgs e)
        {

        }
    }
}
