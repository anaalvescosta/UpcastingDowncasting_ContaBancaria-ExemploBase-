using ex01T07M10.Entities;
using System;

namespace ex01T07M10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Herança, polimorfismo, metodos vituais e override, " +
                "upcasting e downcasting");

            //upcasting
            Account acc = new Account(1001, "Rodrigo", 1000.0);
            BusinessAccount bacc = new BusinessAccount(1002, "Lucas", 2000, 1000);

            Console.WriteLine("\n\n-----Polimorfismo-------");
            Console.WriteLine(acc.AccountData());
            Console.WriteLine(bacc.AccountData());

            //UPCASTING  (sem problemas)
            Account acc1 = (Account)acc;
            Console.WriteLine(acc1.AccountData());

            Account acc2 = (Account)bacc;
            Console.WriteLine(acc2.AccountData());


            //DOWNCASTING  - não é seguro!! É necessário fazer testes

            /*
            BusinessAccount bacc1 = (BusinessAccount)acc;
            SavingsAccount sacc1 = (SavingsAccount)acc;

            Console.WriteLine(bacc1.AccountData());
            Console.WriteLine(sacc1.AccountData());
            */

            if (acc is BusinessAccount)
            {
                BusinessAccount bacc1 = (BusinessAccount)acc;
                Console.WriteLine(bacc1.AccountData());
            }
            else
                Console.WriteLine("Não foi possivel fazer o DOWCASTING");

            if (bacc is BusinessAccount)
            {
                BusinessAccount bacc1 = (BusinessAccount)bacc;
                Console.WriteLine("Downcasting com sucesso!!:\n " + bacc1.AccountData());
            }

            BusinessAccount baccE = new BusinessAccount(acc.Number, acc.Holder, acc.Balance, 5000);
            Console.WriteLine(baccE.AccountData());
        }
    }
}
