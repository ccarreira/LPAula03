using System;

namespace GameInterfaces
{
    public class Program
    {
        private static void Main(string[] args)
        {
            IHasValue[] lista = new IHasValue[5];

            lista[0] = new Building(tipo: "Barrack", area: 10f, value: 100f);
            lista[1] = new MilitaryUnit(movement: 2, health: 10, attackPower: 120);
            lista[2] = new Building(tipo: "Barrack", area: 10f, value: 120f);
            lista[3] = new Building(tipo: "Barrack", area: 10f, value: 130f);
            lista[4] = new Building(tipo: "Barrack", area: 10f, value: 150f);

            IHasValue anterior = null;;

            foreach (IHasValue i in lista)
            {
                Console.WriteLine(i.ToString());
                if(anterior != null && anterior.Equals(i))
                {
                    Console.WriteLine("Igual ao anterior");
                }
                anterior = i;
            }
        }



    }
}
