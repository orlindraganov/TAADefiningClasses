using System.Reflection;
using System.Text;

namespace Classes.Models
{
    internal class GSM
    {
        private static GSM iPhone4S;

        private string model;
        private string manufacturer;
        private string owner;
        private Battery battery;
        private Display display;

        public static GSM IPhone4S
        {
            get
            {
                return iPhone4S;
            }
            set
            {
                iPhone4S = value;
            }
        }

        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                this.model = value;

            }
        }

        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }
            set
            {
                this.manufacturer = value;
            }
        }

        public string Owner
        {
            get
            {
                return this.owner;
            }
            set
            {
                this.owner = value;
            }
        }

        public Battery Battery
        {
            get
            {
                return this.battery;
            }
            set
            {
                this.battery = value;
            }
        }

        public Display Display
        {
            get
            {
                return this.display;
            }
            set
            {
                this.display = value;
            }
        }

        static GSM()
        {
            IPhone4S = new GSM("iPhone 4S", "Apple", "Orlin", new Battery("Chinese", 85, 44, BatteryType.LiIon), new Display(5, 65536));
        }

        public GSM(string model, string manufacturer, string owner, Battery battery, Display display)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Owner = owner;
            this.Battery = battery;
            this.Display = display;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            foreach (PropertyInfo propertyInfo in this.GetType().GetProperties())
            {
                sb.AppendLine(propertyInfo.ToString());
            }

            return sb.ToString();
        }
    }
}
