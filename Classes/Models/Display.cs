using System.Reflection;
using System.Text;

namespace Classes.Models
{
    internal class Display
    {
        private int size;
        private int numberOfColours;

        private int Size
        {
            get
            {
                return this.size;
            }
            set
            {
                this.size = value;
            }
        }

        private int NumberOfColours
        {
            get
            {
                return this.numberOfColours;
            }
            set
            {
                this.numberOfColours = value;
            }
        }

        public Display(int size, int numberOfColours)
        {
            this.Size = size;
            this.NumberOfColours = numberOfColours;
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