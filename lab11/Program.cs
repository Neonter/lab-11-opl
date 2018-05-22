using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab11
{
    class Program
    {
        static void Main(string[] args)
        {
            var microArr = new Microcontroller[6];
            microArr[0] = new Microcontroller("MC9S08LL64CLK", 64, 4, "10-ch", 1, 2);
            microArr[1] = new Microcontroller("MC9S08LL64CLH", 64, 4, "8-ch", 1, 2);
            microArr[2] = new Microcontroller("MC9S08LL36CLK", 36, 4, "10-ch", 1, 2);
            microArr[3] = new Microcontroller("MC9S08LL36CLH", 36, 4, "8-ch", 1, 2);
            microArr[4] = new Microcontroller("MC9S08LL16CLH", 16, 2, "8-ch");
            microArr[5] = new Microcontroller("MC9S08LL8CLF", 8, 2, "8-ch");

            List<Microcontroller> microList = new List<Microcontroller>(microArr);
            foreach(var item in microList)
            {
                item.Show();
            }
            var maxFlash = microList.Max(m => m.getFlashMemory());
            var maxFlashObjects = microList.Where(m => m.getFlashMemory() == maxFlash).ToList();

            var minFlash = microList.Min(m => m.getFlashMemory());
            var minFlashObjects = microList.Where(m => m.getFlashMemory() == minFlash).ToList();

            Console.WriteLine("Maximum flash memory have these mc:");
            foreach(var entry in maxFlashObjects)
            {
                Console.WriteLine("Name: {0}, flash: {1}kB", entry.getName(), entry.getFlashMemory());
            }
            Console.WriteLine("Minimum flash memory have these mc:");
            foreach (var entry in minFlashObjects)
            {
                Console.WriteLine("Name: {0}, flash: {1}kB", entry.getName(), entry.getFlashMemory());
            }
            Console.ReadKey();
        }
    }
}
