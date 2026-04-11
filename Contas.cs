using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaCalcClasse
{
    public class Contas
    {
        // Propiedades
        private double num1;

        public double Num1
        {
            get { return num1; }
            set { num1 = value; }
        }

        private double num2;

        public double Num2
        {
            get { return num2; }
            set { num2 = value; }
        }

        //Construtor

        /// <summary>
        /// construtor padrão
        /// </summary>
        public Contas()
        {
            num1 = 0;
            num2 = 0;
        }

        /// <summary>
        /// construtor Elaborado
        /// </summary>
        public Contas(double num1, double num2)
        {
            Num1 = num1;
            Num2 = num2;
        }

        //Métodos
        public string Somar()
        {
            return "A soma entre " + num1 + " e " + num2 + " é " + (num1 + num2);
        }
        public string Subtrair()
        {
            return "A Subtração entre " + num1 + " e " + num2 + " é " + (num1 - num2);
        }
        public string Dividir()
        {
            if (num2 == 0)
            {
                return "Não é possível dividir por zero!";
            }
            return "A divisão entre " + num1 + " e " + num2 + " é " + (num1 / num2);
        }
        public string Multiplicar()
        {
            return "A multiplicação entre " + num1 + " e " + num2 + " é " + (num1 * num2);
        }
    }
}
