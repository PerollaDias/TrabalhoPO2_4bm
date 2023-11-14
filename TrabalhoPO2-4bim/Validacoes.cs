using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoPO2_4bim
{
    internal class Validacoes
    {
        public static bool ValidarCPF (string Cpf)
        {
            Cpf = Cpf.Replace(".", "");
            Cpf = Cpf.Replace("-", "");
            if (Cpf.Length != 11)
            {
                return false;
            }
            else
            {
                int soma = 0;
                int soma2 = 0;
                for (int i = 0; i < Cpf.Length - 1; i++)
                {
                    if (i < 9)
                    {
                        soma += Convert.ToInt32(Cpf[i].ToString()) * (10 - i);
                    }
                    soma2 += Convert.ToInt32(Cpf[i].ToString()) * (11 - i);
                }

                int resto = soma % 11;
                if (resto < 2 && Convert.ToInt32(Cpf[9].ToString()) != 0)
                {
                    
                    return false;
                }
                else
                {
                    if (Convert.ToInt32(Cpf[9].ToString()) != (11 - resto))
                    {
                       
                        return false;
                    }
                }
                int resto2 = soma2 % 11;
                if (resto2 < 2 && Convert.ToInt32(Cpf[10].ToString()) != 0)
                {
                    
                    return false;
                }
                else
                {
                    if (Convert.ToInt32(Cpf[10].ToString()) != (11 - resto2))
                    {
                      
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
