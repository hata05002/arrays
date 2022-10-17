using System;

class program{
    static void Main()
{
	double[] temperatur={4.5, 3.2, 6.7, 6.1, 2.1, 1.6, 2.9};
    
            double s=0;
       foreach (double i in temperatur)
            s+= i ;
            Console.WriteLine(s);
            Console.WriteLine(s/temperatur.Length);

    }

    }