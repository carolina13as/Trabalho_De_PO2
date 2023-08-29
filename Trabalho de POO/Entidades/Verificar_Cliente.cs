using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class Verificar_Cliente
{

    public static bool Cliente_Valido (string CPF, List<C_Pessoa> lista)
    {
        foreach (var pessoa in lista)
        {
            if (pessoa.CPF == CPF)
            {
                return true;
                break;
            }

        }
        return false;
    }

}
