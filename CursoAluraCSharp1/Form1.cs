using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

            namespace CaixaEletronico
            {
                public partial class Form1 : Form
                {
                    public Form1()
                    {
                        InitializeComponent();
                    }

                    private void button1_Click(object sender, EventArgs e)
                    {
                        Conta contaGuilherme = new Conta();
                        contaGuilherme.numero = 1;
                        contaGuilherme.saldo = 1500.0;

                        Cliente clienteGuilherme = new Cliente();
                        clienteGuilherme.nome = "Guilherme";
                        clienteGuilherme.idade = 18;

                        contaGuilherme.titular = clienteGuilherme;

                        bool sacou = contaGuilherme.Saca(300.0);//testando idade
                        if(sacou)
                        {
                            MessageBox.Show("Saldo Conta do Guilherme apos saque de 300: " + contaGuilherme.saldo);
                        }
                        else
                        {
                            MessageBox.Show("Não foi possível sacar da conta do Guilherme");
                        }
                    }
                }
            }
