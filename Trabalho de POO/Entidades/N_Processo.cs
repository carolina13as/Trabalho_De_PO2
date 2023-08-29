using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class N_Processo
{
    public static string Pro(List<C_Processo> processos)
    {
        int i = 1;
        bool verde= true;
        foreach (var pro in processos)
        {
             if (i != Convert.ToInt32(pro.Numero))
             {

                foreach(var p in processos)
                {
                    if(p.Numero == i.ToString())
                    {
                        verde = false;
                        break;
                    }
                    
                }
                  
             }
            if (verde) break;
            verde = true;
             i++;
        }
        return i.ToString() ;
    }
}
