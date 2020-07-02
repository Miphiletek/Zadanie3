using System;

namespace Zadanie3
{
    class Program
    {
        static void Main(string[] args)
        {
            double t = 0.5;
            Console.WriteLine("Программа для вычисления какие  вероятности  выигранных партий выше из определенного количества попыток ,и двух вариантов");
            Console.WriteLine("Введите количество партий который игрок сыграет в 1 варианте");
            double n = Convert.ToDouble(Console.ReadLine());
            double pervfact = Factorial(n);
            Console.WriteLine("Введите количества партий сколько игрок должен выиграть в 1 варианте");
            double k = Convert.ToDouble(Console.ReadLine());
            double vtorfact = Factorial(k);
            double trifact =Factorial( n-k);
            Console.WriteLine("Введите количество партий который игрок сыграет в 2 варианте");
            double n2 = Convert.ToDouble(Console.ReadLine());
            double perfact2 = Factorial(n2);
            Console.WriteLine("Введите количества партий сколько игрок должен выиграть в 2 варианте");
            double k2 = Convert.ToDouble(Console.ReadLine());
            double vtorfact2 = Factorial(k2);
            double trifact2 = Factorial(n2-k2);
            
            
            double rez = (pervfact / (vtorfact * trifact) *Math.Pow(t,n))*100;
            Console.WriteLine("Вероятность выигрыша {0} партий из {1} 1 варианта ={2} % ",n,k, rez);
            double rez2 = (perfact2 / (vtorfact2*trifact2) * Math.Pow(t, n2))*100;
            Console.WriteLine("Вероятность выигрыша {0}  партий из {1} 2 варианта = {2} %",n2,k2, rez2);
            if(rez>rez2)
            {
                Console.WriteLine("Вероятность выигрыша в первом варианте больше {0} % ,чем у второго {1}%", rez, rez2);


            }
            else if(rez<rez2)
            {
                Console.WriteLine("Вероятность выигрыша во втором варианте больше {0}% ,чем у первого {1}%", rez2, rez);
            }
            else if(rez==rez2)
            {
                Console.WriteLine("Вероятность выигрыша в первом варианте  {0}% , и во втором  {1}% равноценна", rez, rez2);
            }

            

        }
        public static double Factorial(double kak)
        {
          
            int factorial = 1;

            for (int i = 1; i <= kak; i++)
            {
                factorial = factorial * i;
            }
            return factorial;
        }
     
    }
}
