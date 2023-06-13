using ConsoleApp1;

namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup ()
        {
        }

        [Test]
        public void Has_Current_Q () //проверка q
        {
            ChildClass c = new ChildClass("mts", 2, 2, true);
            double q = c.Q();
            Assert.AreEqual(100,q);
        }
        [Test]
        public void Has_Current_QP () //проверка qp
        {
            ChildClass c = new ChildClass("mts", 2, 2, true);
            double qp = c.Qp();
            Assert.AreEqual(70, qp);
        }
        [Test]
        public void Has_Current_p () //проверка работает ли p
        {
            ChildClass c_true = new ChildClass("mts", 2, 2, true);
            ChildClass c_false = new ChildClass("mts", 2, 2, false);
            double t = c_true.Qp();
            double f = c_false.Qp();
            bool final = false;
            if ( f<t)
            {
                final = false;
            }
            Assert.AreEqual(final,false);
        }
        [Test]
        public void Has_Current_plosh () //проверка площади
        {
            ChildClass c_true = new ChildClass("mts", 2, 2, true);
            
            Assert.AreEqual(c_true.plosh,2);
        }
        [Test]
        public void Has_Current_Info () //проверка вывода 
        {
            ChildClass c_true = new ChildClass("mts", 2, 2, true);
            string str = c_true.OperatorInfo();
            Assert.AreEqual(str,"mts 2");
        }
    }
}