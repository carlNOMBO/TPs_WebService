using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP001ClientDotNet
{
    class Program
    {
        static void Main(string[] args)
        {
            WSB.BanqueServiceClient stub = new WSB.BanqueServiceClient();
            Console.WriteLine(stub.ConversionEuroToDH(700));
            WSB.compte compte = stub.getCompte(7);
            Console.WriteLine("Code : " + compte.code);
            Console.WriteLine("Solde : " + compte.solde);
            WSB.compte[] comptes = stub.listCompte();
            foreach(var c in comptes)
            {
                Console.WriteLine("**************************");
                Console.WriteLine("Code : " + c.code);
                Console.WriteLine("Solde : " + c.solde);
            }
            Console.ReadLine();
        }
    }
}
