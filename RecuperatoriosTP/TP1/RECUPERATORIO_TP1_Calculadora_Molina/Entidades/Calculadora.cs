using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Calculadora
    {
        private static string validarOperador(string operador)
        {
            if ((operador != "+") && (operador != "-") && (operador != "*") && (operador != "/"))
            {
                operador = "+";
            }
            return operador;
        }
        public static double operar(Numero num1, Numero num2, string op)
        {
            double result = 0;
            switch (validarOperador(op))
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "/":
                    result = num1 / num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                default:
                    break;
            }
            return result;
        }
    }
}
