using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestServiceprooveiderMeassurement.Model
{
    public class Meassurement
    {
        public int Id { get; set; }

        public int  Pressure { get; set; }

        public int Humidity { get; set; }

        public int Temperature { get; set; }

        public DateTime Timestamp { get; set; }

        public Meassurement()
        {

        }

        public Meassurement(int id, int pressure, int humidity, int temperature)
        {
            this.Id = id;
            this.Pressure = pressure;
            this.Humidity = humidity;
            this.Temperature = temperature;
        }


        public override string ToString()
        {
            return $"{nameof(Pressure)}: {Pressure}, {nameof(Humidity)}: {Humidity}, {nameof(Temperature)}: {Temperature}";

        }

    }
}
