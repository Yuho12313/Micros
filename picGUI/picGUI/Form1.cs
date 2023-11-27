using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace picGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] listaPuertos = System.IO.Ports.SerialPort.GetPortNames();
            portList.DataSource = listaPuertos;
        }

        private void bntConectar_Click(object sender, EventArgs e)
        {
            try 
            {
                if (!puertoSerie.IsOpen)
                {
                    puertoSerie.PortName = portList.SelectedItem.ToString();
                    puertoSerie.Open();
                }
                else
                {
                    MessageBox.Show($"Ya se encuenra conectado al puerto: {puertoSerie.PortName}");
                }
            }
            catch (Exception ermsg)
            {
                MessageBox.Show(ermsg.ToString());
            }
            
        }

        private void btnDesconectar_Click(object sender, EventArgs e)
        {
            try 
            {
                if (puertoSerie.IsOpen)
                {
                    puertoSerie.Close();
                }
                else
                {
                    MessageBox.Show("No se encuentra conectado a ningun puerto.");
                }
                
            }
            catch (Exception errmsg)
            {
                MessageBox.Show(errmsg.ToString());
            }
        }

        private void puertoSerie_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            
            try
            {
                string recibe = puertoSerie.ReadLine();
                bxTemperatura.Text += recibe + Environment.NewLine;
                bxTemperatura.SelectionStart = bxTemperatura.TextLength;
                bxTemperatura.ScrollToCaret();
            }
            catch (Exception ex) 
            { 
            }
            
        }
        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bxRecibir_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }
        //Configuracion de los checkbox
        //Configuracion de los checkbox masters
        private void bcManualMaster_CheckedChanged(object sender, EventArgs e)
        {
        //Si se activa bcMM los bcM se activan y bcSemi se desactiva 
            if (bcManualMaster.Checked)
            {
                bcManual0.Checked = true;
                bcManual1.Checked = true;
                bcSemi.Checked = false;
            }
            //Si es falso bcSemi se activa
            else
            {
                bcSemi.Checked = true;
               
            }
        }
        private void bcSemi_CheckedChanged(object sender, EventArgs e)
        {
        //Si activa bsSemi se desactiva bcMM y bcAM
            if (bcSemi.Checked)
            {
                bcAutomaticoMaster.Checked = false;
                bcManualMaster.Checked = false;
            }
        }
        private void bcAutomaticoMaster_CheckedChanged(object sender, EventArgs e)
        {
        //Si se activa bcAM los bcA se activan y bcSemi se desactiva 
            if (bcAutomaticoMaster.Checked)
            {
                bcAutomatico0.Checked = true;
                bcAutomatico1.Checked = true;
                bcSemi.Checked = false;
            }
            //Si es falso bcSemi se activa
            else
            {
                bcSemi.Checked = true;
                
            }
        }
        //Configuracion de las bc de cada grupo
        private void bcManual0_CheckedChanged(object sender, EventArgs e)
        {
            //Si se activa bcM0 se desactiva bcA0 
            if (bcManual0.Checked)
            {
                bcAutomatico0.Checked = false;
                btnEnviar0.Enabled = true;
                btnOn0.Enabled = true;
                btnOff0.Enabled = true;
                //Si estan activados bcM0 y bcM1 se activa bcMM
                if (bcManual0.Checked && bcManual1.Checked)
                {
                    bcManualMaster.Checked = true;
                }
                //Si estan activados bcM0 y bcA1 se activa bcSemi
                if (bcManual0.Checked && bcAutomatico1.Checked)
                {
                    bcSemi.Checked = true;
                }
                
            }
            //Si es falso se activa bcA0
            else
            {
                bcAutomatico0.Checked = true;
            }

        }

        private void bcAutomatico0_CheckedChanged(object sender, EventArgs e)
        {
            //Si se activa bcA0 se desactiva bcM0
            if (bcAutomatico0.Checked)
            {
                bcManual0.Checked = false;
                btnEnviar0.Enabled = false;
                btnOn0.Enabled = false;
                btnOff0.Enabled = false;
                //Si estan activados bcA0 y bcA1 se activa bcAM
                if (bcAutomatico0.Checked && bcAutomatico1.Checked)
                {
                    bcAutomaticoMaster.Checked = true;
                }                
                //Si se activa bcM1 y bcA0 se activa bcSemi
                if (bcManual1.Checked && bcAutomatico0.Checked)
                {
                    bcSemi.Checked = true;
                }
            }
            //Si es falso se activa bcM0
            else
            {
                bcManual0.Checked = true;
            }

        }

        private void bcManual1_CheckedChanged(object sender, EventArgs e)
        {
            //Si se activa bcM1 se desactiva bcA1 y se activan los botones de control de riego
            if (bcManual1.Checked)
            {
                bcAutomatico1.Checked = false;
                btnEnviar1.Enabled = true;
                btnOn1.Enabled = true;
                btnOff1.Enabled = true;
                //Si estan activados bcM0 y bcM1 se activa bcMM
                if (bcManual1.Checked && bcManual0.Checked)
                {
                    bcManualMaster.Checked = true;
                }
                //Si estan activados bcM0 y bcM1 se activa bcMM
                if (bcManual1.Checked && bcAutomatico0.Checked)
                {
                    bcSemi.Checked = true;
                }
            }
            //Si es falso se activa bcA1
            else
            {
                bcAutomatico1.Checked = true;
            }


        }

        private void bcAutomatico1_CheckedChanged(object sender, EventArgs e)
        {
            //Si se activa bcA1 se desactiva bcM1
            if (bcAutomatico1.Checked)
            {
                bcManual1.Checked = false;
                btnEnviar1.Enabled = false;
                btnOn1.Enabled = false;
                btnOff1.Enabled = false;
                //Si estan activados bcA0 y bcA1 se activa bcAM
                if (bcAutomatico1.Checked && bcAutomatico0.Checked)
                {
                    bcAutomaticoMaster.Checked = true;
                   
                }
                //Si se activa bcM0 y bcA1 se activa bcSemi
                if (bcManual0.Checked && bcAutomatico1.Checked)
                {
                    bcSemi.Checked = true;
                }
            }
            //Si es falso se activa bcM1
            else
            {
                bcManual1.Checked = true;
            }
        }

        private void btnOn1_Click(object sender, EventArgs e)
        {

        }

        private void btnOff1_Click(object sender, EventArgs e)
        {

        }
        //Temperatura en celsius min −273 °C max 100 °C
        private void btnEnviar0_Click(object sender, EventArgs e)
        {
            try
            {
                if (puertoSerie.IsOpen)
                {
                    float temperatura;
                    if(float.TryParse(bxEnviar0.Text, out temperatura))
                    {
                        if (temperatura >= -273 && temperatura <= 100)
                        {
                            puertoSerie.Write(bxEnviar0.Text);
                            bxEnviar0.Clear();
                        }
                        else
                        {
                            bxEnviar1.Clear();
                            MessageBox.Show("Ingrese un numero entre -273 y 100");
                        }
                    }
                    else
                    {
                        bxEnviar1.Clear();
                        MessageBox.Show("Ingrese solo numeros del -273 al 100");
                    }
                }
                else
                {
                    bxEnviar1.Clear();
                    MessageBox.Show("No se encuentra conectado a ningun puerto");
                }
            }
            catch (Exception Ex)
            {

            }
        }
        //Sensor de humedad se mide en %
        private void btnEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                if (puertoSerie.IsOpen)
                {
                    int humedad;
                    if (int.TryParse(bxEnviar1.Text, out humedad))
                    {
                        if (humedad >= 0 && humedad <= 100)
                        {
                            puertoSerie.Write(bxEnviar1.Text);
                            bxEnviar1.Clear();
                        }
                        else
                        {
                            bxEnviar1.Clear();
                            MessageBox.Show("Ingrese un numero entre 0 y 100");
                        }
                    }
                    else
                    {
                        bxEnviar1.Clear();
                        MessageBox.Show("Ingrese solo numeros del 0 al 100");
                    }
                }
                else
                {
                    bxEnviar1.Clear();
                    MessageBox.Show("No se encuentra conectado a ningun puerto");
                }
            }
            catch (Exception ex)
            {
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
