using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defining_Classes_Part_I
{
    public class GSM
    {
        // Fields
        private string model;
        private string manufacturer;
        private double price;
        private string owner;
        private Battery gsmBattery;
        private Display gsmDisplay;
        private static GSM iPhone4S = new GSM("iPhone4S", "Apple");
        private List<Call> callHistory = new List<Call>();

        // Constructors
        public GSM(string model, string manufacturer)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
        }
        public GSM(string model, string manufacturer, double price, string owner, Battery gsmBattery, Display gsmDisplay)
            : this(model, manufacturer)
        {
            this.Price = price;
            this.Owner = owner;
            this.GSMBattery = gsmBattery;
            this.GSMDisplay = gsmDisplay;
        }

        // Properties
        public string Model 
        {
            get { return this.model; }
            set 
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid model!");
                }
                this.model = value; 
            }
        }
        public string Manufacturer 
        {
            get { return this.manufacturer; }
            set 
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid manufacturer!");
                }
                this.manufacturer = value; 
            } 
        }
        public double Price 
        {
            get { return this.price; } 
            set
            {
                if (value < 0)
			    {
				    throw new ArgumentException("Invalid price! It cannot be negative.");
			    }
                this.price = value;
            }
        }
        public string Owner 
        {
            get { return this.owner; } 
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Owner cannot be empty!");
                }
                this.owner = value;
            } 
        }
        public Battery GSMBattery
        {
            get { return this.gsmBattery; }
            set { this.gsmBattery = value; }
        }
        public Display GSMDisplay
        {
            get { return this.gsmDisplay; }
            set { this.gsmDisplay = value; }
        }
        public static GSM IPhone4S
        {
            get { return iPhone4S; }
        }
        public List<Call> CallHistory
        {
            get { return this.callHistory; }
            set { this.callHistory = value; }
        }

        // Methods
        public override string ToString()
        {
            string result = "----------------------------- \n";
            result += String.Format("Model: {0} \n", this.Model);
            result += String.Format("Manufacturer: {0} \n", this.Manufacturer);
            result += String.Format("Price: {0:C} \n", this.Price);
            result += String.Format("Owner: {0} \n", this.Owner);
            result += String.Format("{0}", this.GSMBattery);
            result += String.Format("{0}", this.GSMDisplay);
            return result;
        }
        public void AddCall(Call call)
        {
            this.CallHistory.Add(call);
        }
        public void DeleteCall(int index)
        {
            if (index > this.CallHistory.Count)
            {
                throw new ArgumentOutOfRangeException("Error! There is no call with index " + index);
            }
            this.CallHistory.RemoveAt(index - 1);
        }
        public void ClearCallHistory()
        {
            this.CallHistory.Clear();
        }
        public decimal TotalCallPrice(decimal pricePerMinute)
        {
            decimal totalCallPrice = 0;
            foreach (var item in CallHistory)
            {
                totalCallPrice += (pricePerMinute / (decimal)60) * (decimal)item.Duration;
            }
            return totalCallPrice;
        }
    }
}
