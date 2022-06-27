using System;


namespace classTest
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = new DateTime(2022, 06, 30);
            DateTime d2 = new DateTime(2022, 06, 27);

            int result = DateTime.Compare(d1, d2);

                Console.WriteLine(result);

            bool resultb = false;
            
            if(result < 0)
            {
                resultb = true;
                
            }
            Console.WriteLine(resultb);
        }



    }
}
