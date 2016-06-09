using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronico
{
    class Conta
    {
        public int numero;
        public Cliente titular;
        public double saldo;

        //atributos agencias e cpf omitidos

        public void Deposita(double valorASerDepositado)
        {
            if (valorASerDepositado >= 0)
            {
                this.saldo += valorASerDepositado;
            }
        }

        public bool Saca(double valorASerSacado)
        {
            if (valorASerSacado > this.saldo || valorASerSacado < 0)
            {
                return false;
            }
            else
            {
                if (this.titular.EhMaiorDeIdade())
                {
                    this.saldo -= valorASerSacado;
                    return true;
                }
                else
                {
                    if (valorASerSacado <= 200)
                    {
                        this.saldo -= valorASerSacado;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }

        public void Transfere(double valor, Conta destino)
        {
            this.Saca(valor);
            destino.Deposita(valor);
        }

        public double CalculaRendimentoAnual()
        {
            double saldoNaqueleMes = this.saldo;

            for (int i = 0; i < 12; i++)
            {
                saldoNaqueleMes = saldoNaqueleMes * 1.007;
            }

            double rendimento = saldoNaqueleMes - this.saldo;

            return rendimento;
        }
    }
}
