
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sandbox
{
    class Car
    {
        private String licensePlate;//instance fields
        private String brand;//instance fields
        private String model;//instance fields

        public Car(String plate, String brand, String model)
        {
            this.licensePlate = plate;
            this.brand = brand;
            this.model = model;
        }

        public String GetLicensePlate() 
        {
            return licensePlate;
        }

        public String GetBrand()
        {
            return brand;
        }

        public String GetModel()
        {
            return model;
        }
    }
}
