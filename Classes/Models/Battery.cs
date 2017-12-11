using System.Reflection;
using System.Text;

namespace Classes.Models
{
    internal class Battery
    {
        private double hoursIdle;
        private double hoursTalk;

        private string model;

        private BatteryType type;

        public double HoursIdle
        {
            get
            {
                return this.hoursIdle;
            }
            set
            {
                this.hoursIdle = value;
            }
        }

        public double HoursTalk
        {
            get
            {
                return this.hoursTalk;
            }
            set
            {
                this.hoursTalk = value;
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

        public BatteryType Type
        {
            get
            {
                return this.type;
            }
            set
            {
                this.type = Type;
            }
        }

        public Battery(string model, double hoursIdle, double hoursTalk, BatteryType batteryType) 
        {
            this.Model = model;
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;
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