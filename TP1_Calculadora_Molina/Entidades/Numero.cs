using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Numero
    {
        private double numero;
        private string SetNumero
        {
            set { this.numero = ValidarNumero(value); }
        }
        public Numero()
        {
            this.numero = 0;
        }
        public Numero(double numero)
        {
            this.numero = numero;
        }
        public Numero(string strNumero)
        {
            this.SetNumero = strNumero;
        }
        public double ValidarNumero(string strNumero)
        {
            double numero;
            if (!double.TryParse(strNumero, out numero))
            {
                numero = 0;
            }
            else
            {
                numero = double.Parse(strNumero);
            }
            return numero;
        }
        public static double operator +(Numero num1, Numero num2)
        {
            double result;
            result = (double)(num1.numero + num2.numero);
            return result;
        }
        public static double operator -(Numero num1, Numero num2)
        {
            double result;
            result = (double)(num1.numero - num2.numero);
            return result;
        }
        public static double operator *(Numero num1, Numero num2)
        {
            double result;
            result = (double)(num1.numero * num2.numero);
            return result;
        }
        public static double operator /(Numero num1, Numero num2)
        {
            double result;
            if (num2.numero == 0)
            {
                result = double.MinValue;
            }
            else
            {
                result = (double)(num1.numero / num2.numero);
            }
            return result;
        }
        private static bool EsBinario(string binario)
        {
            foreach (var i in binario)
            {
                if(i!= '0' && i!= '1')
                {
                    return false;
                }
            }
            return true;
        }
        public static string BinarioDecimal(string binario)
        {
            int exponente = 0;
            int largoStr = binario.Length;
            string result;
            double num = 0;
            if (EsBinario(binario) == true)
            {
                for (int i = largoStr-1;i>=0;i--)
                {
                    if (binario[i] == '1')
                    {
                        num += Math.Pow(2, exponente);
                    }
                    exponente++;
                }
                result = num.ToString();
                return result;
            }
            else
            {
                return "Valor invalido";
            }
        }
        public static string DecimalBinario(double numero)
        {
            int rest;
            string result="";
            int auxNumero = (int)numero;

            if (auxNumero < 0 )
            {
                auxNumero = auxNumero * -1;
            }

            if (auxNumero == 0)
            {
                result = "0";
            }
            else
            {
                while (auxNumero > 0)
                {
                    rest = auxNumero % 2;
                    auxNumero = auxNumero / 2;
                    result = Convert.ToString(rest) +""+ result;
                }
            }
            return result;
        }
        public static string DecimalBinario(string numero)
        {
            double num;
            if(!(double.TryParse(numero, out num)) || numero.Length > 10)
            {
                return "Valor invalido";
            }
            else
            {
                return DecimalBinario(Convert.ToDouble(numero));
            }
        }
    }
}