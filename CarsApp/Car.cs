//
// Programmer: Craig Gunhouse
//
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsApp
{
    class Car
    {
        private long mileage;
        public long Mileage
        {
            get
            {
                return mileage;
            }
            set
            {
                mileage = value;
            }
        }

        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        private string model;
        public string Model
        {
            get
            {
                return model;
            }
            set
            {
                model = value;
            }
        }

        private string engine;
        public string Engine
        {
            get
            {
                return engine;
            }
            set
            {
                engine = value;
            }
        }

        private string color;
        public string Color
        {
            get
            {
                return color;
            }
            set
            {
                color = value;
            }
        }

        //
        // Constructor 
        //
        public Car()
        {
            mileage = 0;
            name = null;
            model = null;
            engine = null;
            color = null;
        }

    }

}
