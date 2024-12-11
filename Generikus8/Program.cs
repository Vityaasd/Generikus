using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generikus8
{
    public class TimestampedValue<T>
    {
        public T Value { get; private set; }
        public DateTime Timestamp { get; private set; }

        public TimestampedValue(T initialValue)
        {
            Value = initialValue;
            Timestamp = DateTime.Now;
        }

        public void UpdateValue(T newValue)
        {
            Value = newValue;
            Timestamp = DateTime.Now;
        }

        public double GetAge()
        {
            return (DateTime.Now - Timestamp).TotalSeconds;
        }
    }
}
