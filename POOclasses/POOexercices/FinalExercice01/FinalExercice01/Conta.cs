using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExercice01
{
    class Conta
    {
        private int _numero;
        public double Saldo { get; private set; }
        public string Nome { get; private set; }

        public Conta(int numero, string nome)
        {
            _numero = numero;
            Nome = nome;
            Saldo = 0;
        }

        public Conta(double valor, int numero, string nome) : this(numero, nome)
        {
            Saldo = valor;
        }

        public int Numero
        {
            get { return _numero; }
            set
            {
                if (_numero == 0)
                {
                    _numero = value;
                }
            }
        }

        public void Deposito(double valor)
        {
            Saldo = Saldo + valor;
        }

        public void Saque(double valor)
        {
            Saldo = Saldo - (valor + 5.00);
        }

        public override string ToString()
        {
            return $"Nome: {Nome}, Numero: {_numero}, Saldo: {Saldo}";
        }
    }
}
