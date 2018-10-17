using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conta_poupança
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Poupança poupador1 = new Poupança(2000M);
                Poupança poupador2 = new Poupança(3000M);
                decimal saldoPoupador1 = 0.0M;
                decimal saldoPoupador2 = 0.0M;


                Console.WriteLine("Taxa de Juros = 4%");
                Poupança.AlterarTaxaDeJuros(0.04);


                saldoPoupador1 = poupador1.CalcularJurosMensal();
                saldoPoupador2 = poupador2.CalcularJurosMensal();
                Console.WriteLine("   Poupador 1 = {0:C}", saldoPoupador1);
                Console.WriteLine("   Poupador 2 = {0:C}", saldoPoupador2);


                Console.WriteLine("\nTaxa de Juros = 5%");
                Poupança.AlterarTaxaDeJuros(0.05);

                saldoPoupador1 = poupador1.CalcularJurosMensal();
                saldoPoupador2 = poupador2.CalcularJurosMensal();
                Console.WriteLine("   Poupador 1 = {0:C}", saldoPoupador1);
                Console.WriteLine("   Poupador 2 = {0:C}", saldoPoupador2);


                Console.Write("\n\nPressione qualquer tecla para sair . . .");
                Console.ReadKey(true);

            }
        }
    }
}
