using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYAZ203.Week_6
{
    public class Progam
    {
        public static void Main()
        {
            Knight knight = new Knight("Sir Knight");
            Enemy enemy = new Enemy();

            var kHealth=knight.Health;
            var eHealth=enemy.Health;

            while(kHealth > 0 && eHealth > 0)
            {
                knight.Attack(ref eHealth);
                enemy.Attack(ref kHealth);
                Console.WriteLine($"Enemy Health: {eHealth}\n" +
                    $"{knight.Name}:{kHealth}");

             }
        }

    }
}
