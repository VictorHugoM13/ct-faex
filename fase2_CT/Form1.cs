using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace fase2_CT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtResultado.Text += 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtResultado.Text += 2;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtResultado.Text += 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtResultado.Text += 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtResultado.Text += 5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtResultado.Text += 6;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtResultado.Text += 7;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtResultado.Text += 8;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtResultado.Text += 9;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtResultado.Text += 0;
        }

        

        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
        

            if (comboBox1.Text != "Selecione")
            {
                try
                {
                    PORTA_SERIAL.PortName = comboBox1.Text;
                    PORTA_SERIAL.BaudRate = 9600;
                    PORTA_SERIAL.Parity = Parity.None;
                    PORTA_SERIAL.DataBits = 8;
                    PORTA_SERIAL.StopBits = StopBits.One;                                      
                    MessageBox.Show("Código Enviado!", "Horas Complementares", MessageBoxButtons.OK);
                    PORTA_SERIAL.Open();
                    PORTA_SERIAL.Write(txtResultado.Text + ";" + textBox1.Text + "\n");
                      
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Horas Complementares", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Nenhuma PORTA seleciona!", "Horas Complementares", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            
        }

        SerialPort PORTA_SERIAL = new SerialPort();

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Selecione");
            string[] LISTA_COM;
            LISTA_COM = SerialPort.GetPortNames();
            for (int i = 0; i < LISTA_COM.Length; i++)
            {
                comboBox1.Items.Add(LISTA_COM[i]);

            }
            comboBox1.SelectedIndex = 0;
            

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            Random numAleatorio = new Random();
            int valorInteiro = numAleatorio.Next(10000, 99999);
            textBox1.Text = valorInteiro.ToString();
            button11.Enabled = false;
        }

        private void txtResultado_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
