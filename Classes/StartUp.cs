using System;

namespace Classes
{
    using Classes.Models;

    internal class StartUp
    {
        private static void Main()
        {
            var phone = new GSM("iPhone 4S", "Apple", "Orlin", new Battery("Chinese", 73, 44, BatteryType.LiIon), new Display(5, 65536));
            Console.WriteLine(phone);
        }
    }
}
