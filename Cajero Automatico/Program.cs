using System;

namespace Carpeta_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //CAJERO AUTOMATICO

            int monto, cincuenta, cien, dosciento, quiniento, mil, dosmil;

            Console.WriteLine("Ingrese monto");
            monto = int.Parse(Console.ReadLine());

            if (monto%50==0)
            {
                dosmil = monto/2000;
                monto = monto%2000;
                mil = monto/1000;
                monto = monto%1000;
                quiniento = monto/500;
                monto = monto%500;
                dosciento = monto/200;
                monto = monto%200;
                cien = monto/100;
                monto = monto%100;
                cincuenta = monto/50;

                if (dosmil>0)
            {
                Console.WriteLine("retira {0} billetes de 2000",dosmil);
            }
            if (mil>0)
            {
                Console.WriteLine("retira {0} billetes de 1000",mil);
            }
            if (quiniento>0)
            {
                Console.WriteLine("retira {0} billetes de 500",quiniento);
            }
            if (dosciento>0)
            {
                Console.WriteLine("retira {0} billetes de 200",dosciento);
            }
            if (cien>0)
            {
                Console.WriteLine("retira {0} billetes de 100",cien);
            }
            if (cincuenta>0)
            {
                Console.WriteLine("retira {0} billetes de 50",cincuenta);
            }
            }  
            else
            {
                Console.WriteLine("Número inválido");
            }
            Console.ReadKey();
        }
    }
}
