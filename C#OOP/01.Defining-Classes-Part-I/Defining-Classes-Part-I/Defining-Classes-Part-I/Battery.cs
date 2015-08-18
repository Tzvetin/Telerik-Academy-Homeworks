using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defining_Classes_Part_I
{
    public enum BatteryType
    {
        LiIon, NiMH, NiCd
    }
    public class Battery
    {
        // Fields
        private string batteryModel;
        private int hoursIdle;
        private int hoursTalk;
        private BatteryType type;

        // Constructors
        public Battery(string batteryModel)
        {
            this.BatteryModel = batteryModel;
        }
        public Battery(string batteryModel, int hoursIdle, int hoursTalk, BatteryType type) 
            : this(batteryModel)
        {
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;
            this.Type = type;
        }

        // Properties
        public string BatteryModel 
        {
            get { return this.batteryModel; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid battery model!");
                }
                this.batteryModel = value;
            }
        }
        public int HoursIdle 
        {
            get { return this.hoursIdle; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid hours idle! It cannot be negative.");
                }
                this.hoursIdle = value;
            }
        }
        public int HoursTalk 
        {
            get { return this.hoursTalk; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid hours talk! It cannot be negative.");
                }
                this.hoursTalk = value;
            }
        }
        public BatteryType Type
        {
            get { return this.type; }
            set 
            {
                if ((int)value < 0 || (int)value > 3)
                {
                    throw new ArgumentOutOfRangeException("Error! Not a valid Battery type");
                }
                this.type = value;
            }
        }

        public override string ToString()
        {
            StringBuilder batteryFullInformation = new StringBuilder();
            batteryFullInformation.AppendLine("Battery model: " + this.BatteryModel);
            batteryFullInformation.AppendLine("Battery hours idle: " + this.HoursIdle);
            batteryFullInformation.AppendLine("Battery hours talk: " + this.HoursTalk);
            batteryFullInformation.AppendLine("Battery type: " + this.Type);

            return batteryFullInformation.ToString();
        }
    }
}
