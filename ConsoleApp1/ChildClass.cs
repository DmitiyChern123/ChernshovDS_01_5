using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1
{
    public class ChildClass : BaseClass
    {
        private bool p; //есть ли плата
        
      public  ChildClass (string Name, double Cost, double Plosh,bool P)
        {
            
                name = Name;
                cost = Cost;
                plosh = Plosh;
                p = P;
                
        }
        public double Qp() //qp
        {
            double q = Q();
            if (p == true)
            {
              double  qp = 0.7 * q;
                return qp;
            }
            else
            {
               double qp = 1.5 * q;
                return qp;
            }
            return 0;

        }
        public void TarifInfo( ) //вывод
        {
            Console.WriteLine( "назваие оператора " +  name);
            Console.WriteLine( "цена/мин " + cost );
            Console.WriteLine( "площадь покрытия " +  plosh);
            Console.WriteLine("наличие платы за соеднение" +  p);
           // Console.WriteLine("q " + Q);
            
        }
        public string OperatorInfo() //вывод в строку
        {
            return name + " " + cost;
        }
       
        public double GetPlosh() //площадь
        {
            return plosh;
        }


    }
}
