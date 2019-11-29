//
// Programmer: Craig Gunhouse
//
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CarsApp
{

    class CarList
    {
        public delegate bool Cmp(long lValue);

        // Constant Members
        private const char cStartChar = '[';
        private const char cStartRecord = '{';
        private const char cStartAttr = '"';
        private const char cMidAttr = ':';
        private const char cTxtAttr = '"';
        private const char cAttrSep = ',';
        private const char cEndAttr = '"';
        private const char cEndRecord = '}';
        private const char cEndChar = ']';

        public const string cNone = "none";
        public const string cMileage = "mileage";
        public const string cName = "name";
        public const string cModel = "model";
        public const string cEngine = "engine";
        public const string cColor = "color";

        // Members
        private List<Car> lCars;
        private string _sortAttr = cNone;
        private bool _descending = false;
        private string _filterAttr = cNone;
        private int _MileageCmp = 0; // 0 Exact, 1 <, 2 <=, 3 =, 4 >, and 5 =>
        private long _MileAmt;
        private Cmp _cmp;
        private List<string> _FilterValues;

        // Properties        
        public List<Car> Cars
        {
            get
            {
                return lCars;
            }
            set
            {
                lCars = value;
            }
        }

        public string sortAttr
        {
            get
            {
                return _sortAttr;
            }
            set
            {
                _sortAttr = value;
            }
        }

        public bool descending
        {
            get
            {
                return _descending;
            }
            set
            {
                _descending = value;
            }
        }

        public string filterAttr
        {
            get
            {
                return _filterAttr;
            }
            set
            {
                _filterAttr = value;
            }
        }

        public int MileageCmp
        {
            get
            {
                return _MileageCmp;
            }
            set
            {
                _MileageCmp = value;
            }
        }

        public long MileAmt
        {
            get
            {
                return _MileAmt;
            }
            set
            {
                _MileAmt = value;
            }
        }

        public Cmp cmp
        {
            get
            {
                return _cmp;
            }
            set
            {
                _cmp = value;
            }
        }

        public List<string> FilterValues
        {
            get
            {
                return _FilterValues;
            }
            set
            {
                _FilterValues = value;
            }
        }

        // Methods
        public bool Equal(long lValue)
        {
            return lValue == _MileAmt;
        }

        public bool LessThan(long lValue)
        {
            return lValue < _MileAmt;
        }

        public bool LessThanEqual(long lValue)
        {
            return lValue <= _MileAmt;
        }

        public bool GreaterThan(long lValue)
        {
            return lValue > _MileAmt;
        }

        public bool GreaterThanEqual(long lValue)
        {
            return lValue >= _MileAmt;
        }


        // Constructors
        public CarList()
        {
            lCars = new List<Car>();
            _FilterValues = new List<string>();
        }


        // Methods
        public List<string> getUniqueModels()
        {
            List<string> lModels = new List<string>();

            foreach (Car cCar in lCars)
            {
                string sModel = cCar.Model;

                if (!lModels.Contains(sModel))
                {
                    lModels.Add(sModel);
                }
            }

            return lModels;
        }

        public List<string> getUniqueNames()
        {
            List<string> lNames = new List<string>();

            foreach(Car cCar in lCars)
            {
                string sName = cCar.Name;

                if (!lNames.Contains(sName))
                {
                    lNames.Add(sName);
                }
            }

            return lNames;
        }

        public List<string> getUniqueEngines()
        {
            List<string> lEngines = new List<string>();

            foreach (Car cCar in lCars)
            {
                string sEngine = cCar.Engine;

                if (!lEngines.Contains(sEngine))
                {
                    lEngines.Add(sEngine);
                }
            }

            return lEngines;
        }

        public List<string> getUniqueColors()
        {
            List<string> lColors = new List<string>();

            foreach (Car cCar in lCars)
            {
                string sColor = cCar.Color;

                if (!lColors.Contains(sColor))
                {
                    lColors.Add(sColor);
                }
            }

            return lColors;
        }

        public List<Car> getList()
        {
            List<Car> lfCars = new List<Car>();


            // 
            // Is there a filter 
            //
            if (_filterAttr == cNone)
            {   
                // 
                // Copy all the Cars 
                //
                foreach(Car car in lCars)
                {
                    lfCars.Add(car);
                }

            }
            else
            {

                //
                //  Determine what attribute is being used as the filter.
                //
                switch (_filterAttr)
                {
                    case cMileage:

                        foreach (Car car in lCars)
                        {

                            if (cmp(car.Mileage))
                            {
                                lfCars.Add(car);
                            }

                        }

                        break;

                    case cName:

                        foreach(Car car in lCars)
                        {

                            if (_FilterValues.Contains(car.Name))
                            {
                                lfCars.Add(car);
                            }

                        }

                        break;

                    case cModel:

                        foreach (Car car in lCars)
                        {

                            if (_FilterValues.Contains(car.Model))
                            {
                                lfCars.Add(car);
                            }

                        }

                        break;

                    case cEngine:

                        foreach (Car car in lCars)
                        {

                            if (_FilterValues.Contains(car.Engine))
                            {
                                lfCars.Add(car);
                            }

                        }

                        break;

                    case cColor:

                        foreach (Car car in lCars)
                        {

                            if (_FilterValues.Contains(car.Color))
                            {
                                lfCars.Add(car);
                            }

                        }

                        break;

                }
            }

            //
            //  Determine the attribute to sort on.
            //
            switch (_sortAttr)
            {

                case cMileage:
                    lfCars.Sort((x, y) => (!_descending) ? x.Mileage.CompareTo(y.Mileage) : y.Mileage.CompareTo(x.Mileage));
                    break;

                case cName:
                    lfCars.Sort((x, y) => (!_descending) ? string.Compare(x.Name, y.Name) : string.Compare(y.Name, x.Name));
                    break;

                case cModel:
                    lfCars.Sort((x, y) => (!_descending) ? string.Compare(x.Model, y.Model) : string.Compare(y.Model, x.Model));
                    break;

                case cEngine:
                    lfCars.Sort((x, y) => (!_descending) ? string.Compare(x.Engine, y.Engine) : string.Compare(y.Engine, x.Engine));
                    break;

                case cColor:
                    lfCars.Sort((x, y) => (!_descending) ? string.Compare(x.Color, y.Color) : string.Compare(y.Color, x.Color));
                    break;
            }

            // Return the filter and sort car list
            return lfCars;
        }
        
        //
        //  Parse attribute in source stream.
        //
        //  Note: This parser assumes the source is valid.
        //
        public (string, string, long) ParseAttr(ref string rStr)
        {
            string attrName = null;
            string attrsValue = null;
            long attrlvalue = 0;

            if (rStr[0] == cStartAttr)
            {
                rStr = rStr.Substring(1);

                int iPos = rStr.IndexOf(cEndAttr);

                attrName = rStr.Substring(0, iPos);
                rStr = rStr.Substring(iPos + 1);

                if (rStr[0] == cMidAttr)
                {
                    rStr = rStr.Substring(1);

                    if (rStr[0] == cTxtAttr)
                    {
                        rStr = rStr.Substring(1);
                        iPos = rStr.IndexOf(cEndAttr);
                        attrsValue = rStr.Substring(0, iPos);
                        rStr = rStr.Substring(iPos + 1);
                    }
                    else
                    {
                        char[] caTerm = { cAttrSep, cEndRecord };
                        iPos = rStr.IndexOfAny(caTerm);
                        string sTemp = rStr.Substring(0, iPos);
                        attrlvalue = Convert.ToInt64(rStr.Substring(0, iPos));
                        rStr = rStr.Substring(iPos);
                    }


                }

            }

            return (attrName, attrsValue, attrlvalue);
        }

        //
        //  Parse node in source stream.
        //
        //  Note: This parser assumes the source is valid.
        //        
        public Car ParseNode(ref string rStr)
        {
            Car Car = new Car();

            if (rStr[0] == cStartRecord)
            {
                string attrName = null;
                string attrsValue = null;
                long attrlvalue = 0;


                do
                {
                    rStr = rStr.Substring(1);
                    (attrName, attrsValue, attrlvalue) = ParseAttr(ref rStr);

                    switch (attrName)
                    {
                        case cMileage:
                            Car.Mileage = attrlvalue;
                            break;

                        case cName:
                            Car.Name = attrsValue;
                            break;

                        case cModel:
                            Car.Model = attrsValue;
                            break;

                        case cEngine:
                            Car.Engine = attrsValue;
                            break;

                        case cColor:
                            Car.Color = attrsValue;
                            break;
                    }

                } while (rStr[0] == cAttrSep);

                rStr = rStr.Substring(1);   // Remove end of node character
            }

            if (rStr[0] != cEndChar)
            {
                rStr = rStr.Substring(1);
            }

            return Car;
        }

        //
        //  Load Cars from JSON 
        //
        public int Loader(string vStr)
        {
            String sCur = vStr;
            char cCurr;


            cCurr = vStr[0];

            if (vStr[0] == cStartChar)
            {
                vStr = vStr.Substring(1);

                cCurr = vStr[0];
                while (vStr[0] != cEndChar)
                {
                    Car CarNode = ParseNode(ref vStr);
                    cCurr = vStr[0];
                    lCars.Add(CarNode);
                }
            }

            return 1;
        }

        //
        //  Unused in this version.
        // 
        public bool xmlLoader(XmlTextReader xmlRdr)
        {
            string sName;

            while (xmlRdr.Read())
            {

                switch (xmlRdr.NodeType)
                {
                    case XmlNodeType.Element:

                        if (xmlRdr.Name == "Car")
                        {
                            Car car = new Car();

                            while(xmlRdr.Read())
                            {

                                if (xmlRdr.NodeType == XmlNodeType.EndElement && xmlRdr.Name == "Car") break;

                                if (xmlRdr.NodeType == XmlNodeType.Element)
                                {
                                    sName = xmlRdr.Name;
                                    xmlRdr.Read();

                                    switch (sName)
                                    {
                                        case cMileage:
                                            car.Mileage = Convert.ToInt64(xmlRdr.Value);
                                            break;

                                        case cName:
                                            car.Name = xmlRdr.Value;
                                            break;

                                        case cModel:
                                            car.Model = xmlRdr.Value;
                                            break;

                                        case cEngine:
                                            car.Engine = xmlRdr.Value;
                                            break;

                                        case cColor:
                                            car.Color = xmlRdr.Value;
                                            break;
                                    }

                                }

                            }

                            lCars.Add(car);
                        }

                        break;

                    case XmlNodeType.Text:
                        sName = "text:" + xmlRdr.Value;
                        break;

                }

            }

            return true;
        }
    }
}
