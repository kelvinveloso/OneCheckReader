using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PaniniNorthAmerica.VisionAPI;
using System.Collections;
using System.IO;
using System.Runtime.InteropServices;
using PaniniNorthAmerica;


namespace OneCheckReader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        public string deviceid;


        private void Form1_Load(object sender, EventArgs e)
        {

            try
            {

                visionAPIDotNetControl1.VxApiStartup();

                int result = visionAPIDotNetControl1.VxApiSetDeviceParameters(deviceParameters1);
            if (result == 1)
            {
                visionAPIDotNetControl1.VxApiOnline();

                deviceid = visionAPIDotNetControl1.VxApiGetDeviceStateString();
                LBL_Status.Text = "Scanner:"+deviceid+" Conectado !!!";
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro: "+ex);
            }


        }

        private void visionAPIDotNetControl1_DeviceConnectedEvent(object sender, PaniniNorthAmerica.VisionAPI.VisionXAPIEventArgs e)
        {
           /*
            int result = visionAPIDotNetControl1.VxApiSetDeviceParameters(deviceParameters1);

            LBL_Status.Text = "Scanner Conectado !!!";

            if (result == 1)
            {
                visionAPIDotNetControl1.VxApiOnline();
            }
           */
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int vIdDevice = int.Parse(deviceid);

            int res = visionAPIDotNetControl1.VxApiStartFeeding();
            if (res == 1)
            {
                LBLLeitura.Text = "Cheque Lido";
            }

            //visionAPIDotNetControl1.VxApiChangeParameters);
            // visionAPIDotNetControl1.VxApiSetFeedingMode( PaniniNorthAmerica.VisionAPI.FeedingMode.HopperFeed);


            /*
    teste:
        MessageBox.Show("Loop !");


        LBLLeitura.Text = deviceid;
        visionAPIDotNetControl1.VxApiStartFeeding();
        LBLLeitura.Text = "Cheque Lido !!!";
        visionAPIDotNetControl1.VxApiSetDeviceParameters(deviceParameters1);
        LBLLeitura.Text = "-";

        goto teste;

        // MessageBox.Show(teste);

        //visionAPIDotNetControl1.VxApiStartFeeding();

        //visionAPIDotNetControl1.VxApiStopFeeding();

        //MessageBox.Show("Cheque Lido");
            */
        }

        private void BTN_Parar_Click(object sender, EventArgs e)
        {
            
            visionAPIDotNetControl1.VxApiStopFeeding();
            MessageBox.Show("Desconectado");
        }

        private void BTN_Inicio_Click(object sender, EventArgs e)
        {

   


        }
    }
}
