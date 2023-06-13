using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class BaseClass
    {
        
        public string name; //имя оператора
        public double cost; //цена
        public double plosh; //площадь
        
       
        public double Q() //q
        {
            return 100 * plosh / cost;
        }
    }
    
}
