//The following Copyright applies to the LitDev Extension for Small Basic and files in the namespace LitDev.
//Copyright (C) <2011 - 2015> litdev@hotmail.co.uk
//This file is part of the LitDev Extension for Small Basic.

//LitDev Extension is free software: you can redistribute it and/or modify
//it under the terms of the GNU General Public License as published by
//the Free Software Foundation, either version 3 of the License, or
//(at your option) any later version.

//LitDev Extension is distributed in the hope that it will be useful,
//but WITHOUT ANY WARRANTY; without even the implied warranty of
//MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//GNU General Public License for more details.

//You should have received a copy of the GNU General Public License
//along with LitDev Extension.  If not, see <http://www.gnu.org/licenses/>.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Dynamic;
using System.Linq.Expressions;
using System.Net;
using System.Text;

namespace LitDev.Engines
{
    enum eLeafType { COMPOUND, VALUE, PREFIX, UNIT, DERIVEDUNIT, POWER }
    enum eOperatorType { NONE, MULTIPLY, DIVIDE, ADD, SUBTRACT }

    public class BaseUnit
    {
        public string dimension;
        public string name = "";

        public BaseUnit(string dimension, string name)
        {
            this.dimension = dimension;
            this.name = name;
        }
    }

    public class DerivedUnit
    {
        public string description = "";
        public string name = "";
        public string baseUnits = "";
        public double add = 0;

        public DerivedUnit(string description, string name, string baseUnits, double add = 0)
        {
            this.description = description;
            this.name = name;
            this.baseUnits = baseUnits;
            this.add = add;
        }
    }

    public class Constant
    {
        public string description = "";
        public string name = "";
        public double value = 0;

        public Constant(string description, string name, double value)
        {
            this.description = description;
            this.name = name;
            this.value = value;
        }
    }

    public class UnitSystem
    {
        public static List<BaseUnit> BaseUnits = new List<BaseUnit>();
        public static List<DerivedUnit> DerivedUnits = new List<DerivedUnit>();
        public static List<Constant> Constants = new List<Constant>();
        public static Dictionary<string, double> Prefixes = new Dictionary<string, double>();
        public static List<string> Dimensions = new List<string>();
        public static List<string> Errors = new List<string>();
        private static bool bInitialised = false;

        public UnitSystem()
        {
            if (!bInitialised) Initialise();
            Validate();
        }

        private void Initialise()
        {
            BaseUnits.Clear();
            DerivedUnits.Clear();
            Prefixes.Clear();
            Constants.Clear();
            Dimensions.Clear();

            //PREFIXES
            Prefixes["Y"] = 1.0e24;
            Prefixes["Yotta"] = 1.0e24;
            Prefixes["Z"] = 1.0e21;
            Prefixes["Zetta"] = 1.0e21;
            Prefixes["E"] = 1.0e18;
            Prefixes["Exa"] = 1.0e18;
            Prefixes["P"] = 1.0e15;
            Prefixes["Peta"] = 1.0e15;
            Prefixes["T"] = 1.0e12;
            Prefixes["Tera"] = 1.0e12;
            Prefixes["G"] = 1.0e9;
            Prefixes["Giga"] = 1.0e9;
            Prefixes["M"] = 1.0e6;
            Prefixes["Mega"] = 1.0e6;
            Prefixes["K"] = 1000;
            Prefixes["Kilo"] = 1000;
            Prefixes["H"] = 100;
            Prefixes["Hecto"] = 100;
            Prefixes["D"] = 10;
            Prefixes["Deka"] = 10;
            Prefixes["d"] = 0.1;
            Prefixes["deci"] = 0.1;
            Prefixes["c"] = 0.01;
            Prefixes["centi"] = 0.01;
            Prefixes["m"] = 0.001;
            Prefixes["milli"] = 0.001;
            Prefixes["µ"] = 1.0e-6;
            Prefixes["micro"] = 1.0e-6;
            Prefixes["n"] = 1.0e-9;
            Prefixes["nano"] = 1.0e-9;
            Prefixes["p"] = 1.0e-12;
            Prefixes["pico"] = 1.0e-12;
            Prefixes["f"] = 1.0e-15;
            Prefixes["femto"] = 1.0e-15;
            Prefixes["a"] = 1.0e-18;
            Prefixes["atto"] = 1.0e-18;
            Prefixes["z"] = 1.0e-21;
            Prefixes["zepto"] = 1.0e-21;
            Prefixes["y"] = 1.0e-24;
            Prefixes["yocto"] = 1.0e-24;

            //TIME
            BaseUnits.Add(new BaseUnit("TIME", "s"));

            //LENGTH
            BaseUnits.Add(new BaseUnit("LENGTH",  "m"));

            //MASS
            BaseUnits.Add(new BaseUnit("MASS", "g"));

            //TEMPERATURE
            BaseUnits.Add(new BaseUnit("TEMPERATURE", "K"));

            //Charge
            BaseUnits.Add(new BaseUnit("CHARGE", "Q"));

            //Charge
            BaseUnits.Add(new BaseUnit("SUBSTANCE", "mol"));

            //Luminance
            BaseUnits.Add(new BaseUnit("LUMINANCE", "candella"));

            //CONSTANTS
            Constants.Add(new Constant("Ratio of Circumference to Diameter", "pi", Math.PI));
            Constants.Add(new Constant("Natural Logarithm Base", "e", Math.E));

            //Derived Units

            //TIME
            DerivedUnits.Add(new DerivedUnit("Minute", "min", "(60)s"));
            DerivedUnits.Add(new DerivedUnit("Hour", "hr", "(60)min"));
            DerivedUnits.Add(new DerivedUnit("Day", "day", "(24)hr"));
            DerivedUnits.Add(new DerivedUnit("Week", "week", "(7)day"));
            DerivedUnits.Add(new DerivedUnit("Year", "year", "(365.25)day"));

            //LENGTH
            DerivedUnits.Add(new DerivedUnit("Foot", "ft", "(0.3048)m"));
            DerivedUnits.Add(new DerivedUnit("Yard", "yd", "(3)ft"));
            DerivedUnits.Add(new DerivedUnit("Inch", "in", "(2.54)cm"));
            DerivedUnits.Add(new DerivedUnit("Mile", "mile", "(1760)yd"));
            DerivedUnits.Add(new DerivedUnit("Parsec", "pc", "(3.0856776e16)m"));
            DerivedUnits.Add(new DerivedUnit("Astronomical Unit", "au", "(1.4960e11)m"));
            DerivedUnits.Add(new DerivedUnit("Light Year", "ly", "(9.4607e15)m"));

            //MASS
            DerivedUnits.Add(new DerivedUnit("Pound", "lb", "(453.59237)g"));
            DerivedUnits.Add(new DerivedUnit("Ounce", "oz", "(1/16)lb"));
            DerivedUnits.Add(new DerivedUnit("Stone", "st", "(14)lb"));
            DerivedUnits.Add(new DerivedUnit("Imperial Ton", "ton", "(160)st"));
            DerivedUnits.Add(new DerivedUnit("Metric Tonne", "tonne", "(1000)Kg"));

            //TEMPERATURE
            DerivedUnits.Add(new DerivedUnit("Rankine", "R", "(5/9)K", 0));
            DerivedUnits.Add(new DerivedUnit("Centigrade", "C", "K", 273.15));
            DerivedUnits.Add(new DerivedUnit("Farenheight", "F", "R", 459.67));

            //FORCE
            DerivedUnits.Add(new DerivedUnit("Newton", "N", "Kg.m/s2"));
            DerivedUnits.Add(new DerivedUnit("Pound Force", "lbf", "(4.4482216152605)N"));

            //ENERGY
            DerivedUnits.Add(new DerivedUnit("Joule", "J", "N.m"));
            DerivedUnits.Add(new DerivedUnit("British Thermal Unit", "BTU", "(1055.06)J"));
            DerivedUnits.Add(new DerivedUnit("Erg", "erg", "(1.0e-7)J"));
            DerivedUnits.Add(new DerivedUnit("Kilo Calorie", "kcal", "(4.184e3)J"));
            DerivedUnits.Add(new DerivedUnit("Calorie", "cal", "(4.184)J"));

            //POWER
            DerivedUnits.Add(new DerivedUnit("Watt", "W", "J/s"));
            DerivedUnits.Add(new DerivedUnit("Horsepower", "hp", "(745.7)W"));

            //AREA
            DerivedUnits.Add(new DerivedUnit("Acre", "acre", "(4840).yd2"));
            DerivedUnits.Add(new DerivedUnit("Hectare", "hectare", "(10000).m2"));
            DerivedUnits.Add(new DerivedUnit("Darcy", "D", "(9.869233e-13).m2"));
            DerivedUnits.Add(new DerivedUnit("Barn", "b", "(1e-28).m2"));

            //VOLUME
            DerivedUnits.Add(new DerivedUnit("Cubic Centimeter", "cc", "(1.0e-6).m3"));
            DerivedUnits.Add(new DerivedUnit("Barrel", "bbl", "(5.615).ft3"));
            DerivedUnits.Add(new DerivedUnit("Litre", "litre", "(1.0e-3).m3"));
            DerivedUnits.Add(new DerivedUnit("Litre", "l", "litre"));
            DerivedUnits.Add(new DerivedUnit("UK Pint", "pintUK", "(568)l"));
            DerivedUnits.Add(new DerivedUnit("US Pint", "pintUS", "(473)l"));
            DerivedUnits.Add(new DerivedUnit("UK Gallon", "galUK", "(4.54609)l"));
            DerivedUnits.Add(new DerivedUnit("US Gallon", "galUS", "(0.8327)galUK"));

            //PRESSURE
            DerivedUnits.Add(new DerivedUnit("Pascal", "Pa", "N/m2"));
            DerivedUnits.Add(new DerivedUnit("Bar", "Bar", "(1.0e5)Pa"));
            DerivedUnits.Add(new DerivedUnit("Atmosphere", "Atm", "(1.013)Bar"));
            DerivedUnits.Add(new DerivedUnit("Pound Per Square Inch", "psi", "(6894.75729)Pa"));
            DerivedUnits.Add(new DerivedUnit("Gauge Pound Per Square Inch", "psig", "psi", 14.69));

            //Current
            DerivedUnits.Add(new DerivedUnit("Ampere", "Amp", "Q/s"));

            //Voltage
            DerivedUnits.Add(new DerivedUnit("Voltage", "Volt", "J/Q"));
            DerivedUnits.Add(new DerivedUnit("Voltage", "V", "Volt"));

            //Resistance
            DerivedUnits.Add(new DerivedUnit("Electrical Resistance", "Ohm", "V/Amp"));
            DerivedUnits.Add(new DerivedUnit("Electrical Capacitance", "Farad", "Q/V"));
            DerivedUnits.Add(new DerivedUnit("Electrical Inductance", "Henry", "J/Amp2"));
            DerivedUnits.Add(new DerivedUnit("Magnetic Field Strength", "Tesla", "V.s/m2"));

            //Viscosity
            DerivedUnits.Add(new DerivedUnit("Viscosity Poise", "P", "(0.1).Pa.s"));

            //Substance
            DerivedUnits.Add(new DerivedUnit("Molarity", "M", "mol/l"));
            DerivedUnits.Add(new DerivedUnit("Molality", "molal", "mol/Kg"));
            DerivedUnits.Add(new DerivedUnit("Parts Per Million", "ppm", "(1.0e-6).g/g"));

            //Frequency
            DerivedUnits.Add(new DerivedUnit("Frequency", "Hz", "1/s"));

            //Luminance
            DerivedUnits.Add(new DerivedUnit("Luminance", "cd", "candella"));

            //Constants with units
            DerivedUnits.Add(new DerivedUnit("Avagadro Constant", "Avagadro", "(6.0221408578e23)/mol"));
            DerivedUnits.Add(new DerivedUnit("Plank Constant", "h", "(6.626070041e-34).J.s"));
            DerivedUnits.Add(new DerivedUnit("Speed of Light", "c", "(299792458).m/s"));
            DerivedUnits.Add(new DerivedUnit("Electron Charge", "eQ", "(1.6021766209e-19)Q"));
            DerivedUnits.Add(new DerivedUnit("Electron Mass", "Me", "(9.10938356e-31).Kg"));
            DerivedUnits.Add(new DerivedUnit("Proton Mass", "Mp", "(1.672621898e-27).Kg"));
            DerivedUnits.Add(new DerivedUnit("Neutron Mass", "Mn", "(1.674927471e-27).Kg"));
            DerivedUnits.Add(new DerivedUnit("Atomic Mass Unit", "amu", "(1.6605402e-27).Kg"));
            DerivedUnits.Add(new DerivedUnit("Boltzman Constant", "k", "(1.38064853e-23).J/K"));
            DerivedUnits.Add(new DerivedUnit("Gas Constant", "RC", "k.Avagadro"));
            DerivedUnits.Add(new DerivedUnit("Gravitation Constant", "G", "(6.674e-11).N.m2/Kg2"));
            DerivedUnits.Add(new DerivedUnit("Vacuum Permitivity", "e0", "(8.854187817e-12).Farad/m")); //Q2/J/m
            DerivedUnits.Add(new DerivedUnit("Vacuum Permeability", "mu0", "(4e-7*pi).N/Amp2")); //J/m/Q2.s2

            SetCurrency();

            bInitialised = true;
        }

        private void SetCurrency()
        {
            try
            {
                WebRequest webRequest = WebRequest.Create("http://api.fixer.io/latest");
                WebResponse webResponse = webRequest.GetResponse();
                StreamReader stream = new StreamReader(webResponse.GetResponseStream());
                string[] data = stream.ReadLine().Split(new char[] { '"', ',', ':', '{', '}' }, StringSplitOptions.RemoveEmptyEntries);

                bool bRates = false;
                string baseCurrency = "";
                for (int i = 0; i < data.Length; i++)
                {
                    if (data[i] == "base")
                    {
                        baseCurrency = data[++i];
                        BaseUnits.Add(new BaseUnit("CURRENCY", baseCurrency));
                    }
                    else if (data[i] == "rates")
                    {
                        bRates = true;
                    }
                    else if (bRates)
                    {
                        DerivedUnits.Add(new DerivedUnit("Currency", data[i], "(" + (1 / double.Parse(data[++i])) + ")" + baseCurrency));
                    }
                }
            }
            catch (Exception ex)
            {
                Errors.Add(ex.Message);
            }
        }

        private void Validate()
        {
            Errors.Clear();

            for (int i = 0; i < BaseUnits.Count; i++)
            {
                for (int j = i + 1; j < BaseUnits.Count; j++)
                {
                    if (BaseUnits[i].name == BaseUnits[j].name)
                    {
                        Errors.Add("Repeated base unit " + BaseUnits[i].name);
                    }
                }
                for (int j = 0; j < DerivedUnits.Count; j++)
                {
                    if (BaseUnits[i].name == DerivedUnits[j].name)
                    {
                        Errors.Add("Base and derived unit conflict " + BaseUnits[i].name);
                    }
                }
                if (BaseUnits[i].name.ToLower() == "e")
                {
                    Errors.Add("Base unit cannot be 'e' or 'E'");
                }
            }

            for (int i = 0; i < DerivedUnits.Count; i++)
            {
                for (int j = i + 1; j < DerivedUnits.Count; j++)
                {
                    if (DerivedUnits[i].name == DerivedUnits[j].name)
                    {
                        Errors.Add("Repeated derived unit " + DerivedUnits[i].name);
                    }
                }
                if (DerivedUnits[i].name.ToLower() == "e")
                {
                    Errors.Add("Derived unit cannot be 'e' or 'E'");
                }
            }

            for (int i = 0; i < Prefixes.Count; i++)
            {
                for (int j = i + 1; j < Prefixes.Count; j++)
                {
                    if (Prefixes.ElementAt(i).Key == Prefixes.ElementAt(j).Key)
                    {
                        Errors.Add("Repeated prefix " + Prefixes.ElementAt(i).Key);
                    }
                }
                for (int j = 0; j < Constants.Count; j++)
                {
                    if (Prefixes.ElementAt(i).Key == Constants[j].name)
                    {
                        Errors.Add("Prefix and constant conflict " + Prefixes.ElementAt(i).Key);
                    }
                }
            }

            for (int i = 0; i < Constants.Count; i++)
            {
                for (int j = i + 1; j < Constants.Count; j++)
                {
                    if (Constants[i].name == Constants[j].name)
                    {
                        Errors.Add("Repeated constant " + Constants[i].name);
                    }
                }
            }

            foreach (KeyValuePair<string, double>kvp in Prefixes)
            {
                if (kvp.Key.Length > 1)
                {
                    foreach (BaseUnit check in BaseUnits)
                    {
                        if (check.name.Contains(kvp.Key))
                        {
                            Errors.Add("Prefix and base unit conflict " + kvp.Key + " " + check.name);
                        }
                    }
                    foreach (DerivedUnit check in DerivedUnits)
                    {
                        if (check.name.Contains(kvp.Key))
                        {
                            Errors.Add("Prefix and base unit conflict " + kvp.Key + " " + check.name);
                        }
                    }
                    foreach (Constant check in Constants)
                    {
                        if (check.name.Contains(kvp.Key))
                        {
                            Errors.Add("Prefix and constant conflict " + kvp.Key + " " + check.name);
                        }
                    }
                }
            }

            if (Errors.Count > 0)
            {
                foreach (string error in Errors)
                {
                    Microsoft.SmallBasic.Library.TextWindow.WriteLine(error);
                }
            }

            SetDimensions();

            foreach (DerivedUnit unit in DerivedUnits)
            {
                Errors.Clear();
                Leaf fromLeaf = new Leaf(eOperatorType.MULTIPLY, eLeafType.COMPOUND, unit.name);
                foreach (string error in Errors)
                {
                    Microsoft.SmallBasic.Library.TextWindow.WriteLine(error);
                }
            }

        }

        private void SetDimensions()
        {
            foreach (BaseUnit unit in BaseUnits)
            {
                if (!Dimensions.Contains(unit.dimension)) Dimensions.Add(unit.dimension);
            }
        }

        public double Convert(double value, string fromUnit, string toUnit)
        {
            try
            {
                //Parse units
                Errors.Clear();
                Leaf fromLeaf = new Leaf(eOperatorType.MULTIPLY, eLeafType.COMPOUND, fromUnit);
                if (Errors.Count > 0) return double.NaN;
                Errors.Clear();
                Leaf toLeaf = new Leaf(eOperatorType.MULTIPLY, eLeafType.COMPOUND, toUnit);
                if (Errors.Count > 0) return double.NaN;

                //Check dimensionality is correct
                LeafResult resultFrom = fromLeaf.leafResult;
                LeafResult resultTo = toLeaf.leafResult;
                foreach (KeyValuePair<string, double> kvp in resultFrom.dimensions)
                {
                    if (kvp.Value != resultTo.dimensions[kvp.Key])
                    {
                        Errors.Add("Inconsistent Dimensions");
                        return double.NaN;
                    }
                }

                //Derived units with multipliers and additive for pure units
                double result = (value * fromLeaf.Prefix + fromLeaf.Additive) * fromLeaf.Multiplier;
                result = (result / toLeaf.Multiplier - toLeaf.Additive) / toLeaf.Prefix;
                return result;
            }
            catch (Exception ex)
            {
                Errors.Add(ex.Message);
                return double.NaN;
            }
        }

        public Dictionary<string, double> GetDimensions(string unit)
        {
            Errors.Clear();
            try
            {
                //Parse units
                Leaf leaf = new Leaf(eOperatorType.MULTIPLY, eLeafType.COMPOUND, unit);

                //Check dimensionality is correct
                return leaf.leafResult.dimensions;
            }
            catch (Exception ex)
            {
                Errors.Add(ex.Message);
                return null;
            }
        }

        public List<string> GetErrors()
        {
            return Errors;
        }

        public Dictionary<string, string> GetBaseUnits()
        {
            Dictionary<string, string> units = new Dictionary<string, string>();

            foreach (BaseUnit unit in BaseUnits)
            {
                units[unit.dimension.ToString()] = unit.name;
            }

            return units;
        }

        public Dictionary<string, string> GetDerivedUnits()
        {
            Dictionary<string, string> units = new Dictionary<string, string>();

            foreach (DerivedUnit unit in DerivedUnits)
            {
                units[unit.name] = unit.baseUnits;
                if (unit.add > 0) units[unit.name] += " + " + unit.add;
                else if (unit.add < 0) units[unit.name] += " - " + unit.add;
                units[unit.name] += " (" + unit.description + ")";
            }

            return units;
        }

        public Dictionary<string, string> GetConstants()
        {
            Dictionary<string, string> units = new Dictionary<string, string>();

            foreach (Constant constant in Constants)
            {
                units[constant.name + " (" + constant.description + ")"] = constant.value.ToString();
            }

            return units;
        }

        public Dictionary<string, double> GetPrefixes()
        {
            Dictionary<string, double> units = new Dictionary<string, double>();

            foreach (KeyValuePair<string, double> kvp in Prefixes)
            {
                units[kvp.Key] = kvp.Value;
            }

            return units;
        }

        public void AddBaseUnit(string dimension, string name)
        {
            Errors.Clear();
            try
            {
                BaseUnits.Add(new BaseUnit(dimension, name));
                Validate();
            }
            catch (Exception ex)
            {
                Errors.Add(ex.Message);
            }
        }

        public void AddDerivedUnit(string description, string name, string units, double add)
        {
            Errors.Clear();
            try
            {
                DerivedUnits.Add(new DerivedUnit(description, name, units, add));
                Validate();
            }
            catch (Exception ex)
            {
                Errors.Add(ex.Message);
            }
        }

        public void AddConstant(string description, string name, double value)
        {
            Errors.Clear();
            try
            {
                Constants.Add(new Constant(description, name, value));
                Validate();
            }
            catch (Exception ex)
            {
                Errors.Add(ex.Message);
            }
        }

        public void Serialise(string fileName, bool write)
        {
            Errors.Clear();
            try
            {
                if (write)
                {
                    using (StreamWriter sw = new StreamWriter(fileName, false, Encoding.UTF8))
                    {
                        foreach (BaseUnit unit in BaseUnits)
                        {
                            sw.WriteLine("BaseUnit#" + unit.dimension + "#" + unit.name);
                        }
                        foreach (DerivedUnit unit in DerivedUnits)
                        {
                            if (unit.add == 0) sw.WriteLine("DerivedUnit#" + unit.description + "#" + unit.name + "#" + unit.baseUnits);
                            else sw.WriteLine("DerivedUnit#" + unit.description + "#" + unit.name + "#" + unit.baseUnits + "#" + unit.add);
                        }
                        foreach (Constant constant in Constants)
                        {
                            sw.WriteLine("Constant#" + constant.description + "#" + constant.name + "#" + constant.value);
                        }
                        //foreach (KeyValuePair<string, double> kvp in Prefixes)
                        //{
                        //    sw.WriteLine("Prefix#" + kvp.Key + "#" + kvp.Value);
                        //}
                    }
                }
                else
                {
                    BaseUnits.Clear();
                    DerivedUnits.Clear();
                    Constants.Clear();
                    //Prefixes.Clear();
                    using (StreamReader sr = new StreamReader(fileName, Encoding.UTF8))
                    {
                        while (!sr.EndOfStream)
                        {
                            string line = sr.ReadLine();
                            string[] parts = line.Split(new char[] { '#' }, StringSplitOptions.RemoveEmptyEntries);
                            for (int i = 0; i < parts.Length; i++) parts[i] = parts[i].Trim();

                            switch (parts[0])
                            {
                                case "BaseUnit":
                                    if (parts.Length == 3) BaseUnits.Add(new BaseUnit(parts[1], parts[2]));
                                    break;
                                case "DerivedUnit":
                                    if (parts.Length == 4) DerivedUnits.Add(new DerivedUnit(parts[1], parts[2], parts[3]));
                                    if (parts.Length == 5) DerivedUnits.Add(new DerivedUnit(parts[1], parts[2], parts[3], double.Parse(parts[4])));
                                    break;
                                case "Constant":
                                    if (parts.Length == 4) Constants.Add(new Constant(parts[1], parts[2], double.Parse(parts[3])));
                                    break;
                                case "Prefix":
                                    if (parts.Length == 3) Prefixes[parts[1]] = double.Parse(parts[2]);
                                    break;
                            }
                        }
                    }
                    Validate();
                }
            }
            catch (Exception ex)
            {
                Errors.Add(ex.Message);
            }

        }
    }

    class LeafResult
    {
        public double prefix = 1;
        public double number = 1;
        public double unit = 1;
        public double power = 1;
        public double add = 0;
        public Dictionary<string, double> dimensions = new Dictionary<string, double>();

        public LeafResult()
        {
            foreach (string dimension in UnitSystem.Dimensions)
            {
                dimensions[dimension] = 0;
            }
        }
    }

    class Leaf
    {
        string rawPart = "";
        eLeafType eLeaf = eLeafType.COMPOUND;
        eOperatorType eOperator = eOperatorType.NONE;

        string part = "";
        List<Leaf> children = new List<Leaf>();
        BaseUnit baseUnit = null;
        DerivedUnit derivedUnit = null;
        double value = 0;
        public LeafResult leafResult = new LeafResult();

        public double Additive
        {
            get
            {
                return leafResult.add;
            }
        }

        public double Multiplier
        {
            get
            {
                if (eLeaf == eLeafType.VALUE)
                {
                    return children[2].value;
                }
                return value;
            }
        }

        public double Prefix
        {
            get
            {
                if (eLeaf == eLeafType.VALUE)
                {
                    return value / children[2].value;
                }
                return 1;
            }
        }

        public Leaf(eOperatorType eOperator, eLeafType eLeaf, string rawPart)
        {
            this.eOperator = eOperator;
            this.eLeaf = eLeaf;
            this.rawPart = rawPart;

            Parse();
        }

        private void Parse()
        {
            //Trim any start and end bits
            part = rawPart;
            if (eLeaf != eLeafType.COMPOUND) part = Trim(rawPart);

            //Empty part is default values
            if (part == "")
            {
                if (eLeaf == eLeafType.UNIT) value = 1; //A null unit for a pure number value
                return;
            }

            switch (eLeaf)
            {
                case eLeafType.PREFIX:
                    ParsePrefix(part);
                    break;
                case eLeafType.POWER:
                    if (double.TryParse(part, out leafResult.power))
                    {
                        break;
                    }
                    UnitSystem.Errors.Add("Power could not be found : " + part);
                    break;
                case eLeafType.UNIT:
                    foreach (BaseUnit unit in UnitSystem.BaseUnits)
                    {
                        if (part == unit.name)
                        {
                            leafResult.dimensions[unit.dimension] = 1;
                            baseUnit = unit;
                            value = 1;
                            return;
                        }
                    }
                    UnitSystem.Errors.Add("Base unit could not be found : " + part);
                    break;
                case eLeafType.DERIVEDUNIT:
                    foreach (DerivedUnit unit in UnitSystem.DerivedUnits)
                    {
                        if (part == unit.name)
                        {
                            children.Add(new Leaf(eOperatorType.MULTIPLY, eLeafType.COMPOUND, unit.baseUnits));
                            if (ErrorCheck(false, 1)) continue;
                            derivedUnit = unit;
                            UpdateCompound();
                            return;
                        }
                    }
                    UnitSystem.Errors.Add("Derived unit could not be found : " + part);
                    break;
                case eLeafType.COMPOUND:
                    //Split operators
                    SplitOperators();
                    if (children.Count > 0)
                    {
                        UpdateCompound();
                        break;
                    }

                    //Parse a possible derived unit
                    ParseUnit(UnitSystem.DerivedUnits, eLeafType.DERIVEDUNIT);
                    if (children.Count == 3)
                    {
                        UpdateValue();
                        break;
                    }

                    //Parse a possible base unit
                    ParseUnit(UnitSystem.BaseUnits, eLeafType.UNIT);
                    if (children.Count == 3)
                    {
                        UpdateValue();
                        break;
                    }

                    //Parse a pure number
                    children.Add(new Leaf(eOperatorType.NONE, eLeafType.PREFIX, part));
                    children.Add(new Leaf(eOperatorType.NONE, eLeafType.POWER, ""));
                    children.Add(new Leaf(eOperatorType.MULTIPLY, eLeafType.UNIT, ""));
                    UpdateValue();

                    if (UnitSystem.Errors.Count > 0)
                    {
                        UnitSystem.Errors.Add("Unit could not be found : " + part);
                    }
                    break;
            }
        }

        private void ParsePrefix(string prefix)
        {
            double number = 0;

            //A prefix must be at the end - check long first
            foreach (KeyValuePair<string, double> kvp in UnitSystem.Prefixes)
            {
                if (kvp.Key.Length > 1 && prefix.EndsWith(kvp.Key))
                {
                    leafResult.prefix *= kvp.Value;
                    prefix = prefix.Substring(0, prefix.Length - kvp.Key.Length);
                    break;
                }
            }
            foreach (KeyValuePair<string, double> kvp in UnitSystem.Prefixes)
            {
                if (prefix.EndsWith(kvp.Key))
                {
                    leafResult.prefix *= kvp.Value;
                    prefix = prefix.Substring(0, prefix.Length - kvp.Key.Length);
                    break;
                }
            }

            if (prefix == "") return;

            //Replace constants if not a number before (to handle e)
            Dictionary<string, string> replaced = new Dictionary<string, string>();
            foreach (Constant constant in UnitSystem.Constants)
            {
                int pos = prefix.IndexOf(constant.name);
                while (pos >= 0)
                {
                    string before = prefix.Substring(0, pos);
                    string after = prefix.Substring(pos + constant.name.Length);
                    if (before.Length > 0)
                    {
                        string charBefore = before.Substring(before.Length - 1);
                        if (double.TryParse(charBefore, out number))
                        {
                            replaced["XXX" + pos] = constant.name;
                            prefix = before + "XXX" + pos + after;
                        }
                        else
                        {
                            prefix = before + constant.value.ToString() + after;
                        }
                    }
                    else
                    {
                        prefix = before + constant.value.ToString() + after;
                    }
                    pos = prefix.IndexOf(constant.name);
                }
            }
            foreach (KeyValuePair<string, string> kvp in replaced)
            {
                prefix = prefix.Replace(kvp.Key, kvp.Value);
            }

            try
            {
                ParameterExpression pe = Expression.Parameter(typeof(string), "IntegerAsReal");
                ExpressionParser parser = new ExpressionParser(new ParameterExpression[] { pe }, prefix, null);
                LambdaExpression expr = Expression.Lambda(parser.Parse(typeof(double)), null);
                var del = (Func<double>)expr.Compile();
                number = del();
                leafResult.prefix *= number;
            }
            catch
            {
                UnitSystem.Errors.Add("Prefix could not be found : " + part);
            }

            return;

            string[] vals = prefix.Split(new char[] { '(', ')', '*' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string val in vals)
            {
                //handle +-./
                string[] bits = val.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < bits.Length; i++)
                {
                    string bit = bits[i];
                    if (double.TryParse(bit, out number))
                    {
                        if (i == 0) leafResult.prefix *= number;
                        else leafResult.prefix /= number;
                        goto nextBit;
                    }
                    foreach (KeyValuePair<string, double> kvp in UnitSystem.Prefixes)
                    {
                        if (bit == kvp.Key)
                        {
                            if (i == 0) leafResult.prefix *= kvp.Value;
                            else leafResult.prefix /= kvp.Value;
                            goto nextBit;
                        }
                    }
                    foreach (Constant constant in UnitSystem.Constants)
                    {
                        if (bit == constant.name)
                        {
                            if (i == 0) leafResult.prefix *= constant.value;
                            else leafResult.prefix /= constant.value;
                            goto nextBit;
                        }
                    }
                    UnitSystem.Errors.Add("Prefix could not be found : " + part);
                    nextBit:;
                }
            }
        }

        private void ParseUnit<T>(List<T> units, eLeafType eChildLeaf)
        {
            string name = "";

            foreach (T unit in units)
            {
                if (eChildLeaf == eLeafType.UNIT)
                {
                    BaseUnit baseUnit = (BaseUnit)Convert.ChangeType(unit, typeof(BaseUnit));
                    name = baseUnit.name;
                }
                else
                {
                    DerivedUnit derivedUnit = (DerivedUnit)Convert.ChangeType(unit, typeof(DerivedUnit));
                    name = derivedUnit.name;
                }

                int pos = part.LastIndexOf(name);
                if (pos < 0) continue;

                children.Add(new Leaf(eOperatorType.NONE, eLeafType.PREFIX, part.Substring(0, pos)));
                if (ErrorCheck(true, 1)) continue;
                children.Add(new Leaf(eOperatorType.NONE, eLeafType.POWER, part.Substring(pos + name.Length)));
                if (ErrorCheck(true, 2)) continue;
                children.Add(new Leaf(eOperatorType.MULTIPLY, eChildLeaf, name));
                if (ErrorCheck(true, 3)) continue;

                if (children.Count == 6)
                {
                    if (pos == 0)
                    {
                        for (int i = 0; i < 3; i++) children.RemoveAt(0);
                        break;
                    }
                    else
                    {
                        for (int i = 0; i < 3; i++) children.RemoveAt(children.Count - 1);
                    }
                }
                else if (pos == 0) break;
            }
        }

        private bool ErrorCheck(bool bClearErrors, int numRemove)
        {
            if (UnitSystem.Errors.Count > 0)
            {
                for (int i = 0; i < numRemove; i++) children.RemoveAt(children.Count - 1);
                if (bClearErrors) UnitSystem.Errors.Clear();
                return true;
            }
            return false;
        }

        private void UpdateValue()
        {
            eLeaf = eLeafType.VALUE;

            leafResult.number *= children[0].leafResult.number;
            leafResult.prefix *= children[0].leafResult.prefix;
            leafResult.power *= children[1].leafResult.power;
            if (null != children[2].derivedUnit) leafResult.add = children[2].derivedUnit.add;

            value = Math.Pow(leafResult.number * leafResult.prefix * children[2].value, leafResult.power);
            //value = leafResult.number * leafResult.prefix * Math.Pow(children[2].value, leafResult.power);
            foreach (KeyValuePair<string, double> kvp in children[2].leafResult.dimensions)
            {
                leafResult.dimensions[kvp.Key] = kvp.Value * leafResult.power;
            }
        }

        private void UpdateCompound()
        {
            foreach (Leaf child in children)
            {
                switch (child.eOperator)
                {
                    case eOperatorType.NONE:
                        break;
                    case eOperatorType.MULTIPLY:
                        if (value == 0) value = child.value;
                        else value *= child.value;
                        foreach (KeyValuePair<string, double> kvp in child.leafResult.dimensions)
                        {
                            leafResult.dimensions[kvp.Key] += kvp.Value;
                        }
                        break;
                    case eOperatorType.DIVIDE:
                        if (value == 0) value = 1 / child.value;
                        else value /= child.value;
                        foreach (KeyValuePair<string, double> kvp in child.leafResult.dimensions)
                        {
                            leafResult.dimensions[kvp.Key] -= kvp.Value;
                        }
                        break;
                    case eOperatorType.ADD:
                        if (child.leafResult.dimensions.Values.Sum() == 0) //A dimensionless number
                        {
                            if (leafResult.dimensions.Values.Sum() == 0) value += child.value;
                            else value *= 1 + child.value; //Add a number in the parent units
                        }
                        else
                        {
                            value += child.value;
                            foreach (KeyValuePair<string, double> kvp in child.leafResult.dimensions)
                            {
                                if (leafResult.dimensions[kvp.Key] == 0) leafResult.dimensions[kvp.Key] = kvp.Value;
                                if (leafResult.dimensions[kvp.Key] != kvp.Value)
                                {
                                    UnitSystem.Errors.Add("Cannot add incompatible dimensions : " + part);
                                }
                            }
                        }
                        break;
                    case eOperatorType.SUBTRACT:
                        if (child.leafResult.dimensions.Values.Sum() == 0) //A dimensionless number
                        {
                            if (leafResult.dimensions.Values.Sum() == 0) value -= child.value;
                            else value *= 1 - child.value; //Subtract a number in the parent units
                        }
                        else
                        {
                            value -= child.value;
                            foreach (KeyValuePair<string, double> kvp in child.leafResult.dimensions)
                            {
                                if (leafResult.dimensions[kvp.Key] == 0) leafResult.dimensions[kvp.Key] = kvp.Value;
                                if (leafResult.dimensions[kvp.Key] != kvp.Value)
                                {
                                    UnitSystem.Errors.Add("Cannot subtract incompatible dimensions : " + part);
                                }
                            }
                        }
                        break;
                }
            }
        }

        private void SplitOperators()
        {
            double number = 0;
            if (double.TryParse(part, out number)) return;

            int iBracket = 0;
            string childPart = "";
            eOperatorType childOperator = eOperatorType.MULTIPLY;
            for (int i = 0; i < part.Length; i++)
            {
                char c = part[i];
                switch (c)
                {
                    case '(':
                        iBracket++;
                        childPart += c;
                        break;
                    case ')':
                        iBracket--;
                        childPart += c;
                        break;
                    case '.':
                    case '*':
                        if (iBracket == 0)
                        {
                            children.Add(new Leaf(childOperator, eLeaf, childPart));
                            if (ErrorCheck(false, 1)) return;
                            childOperator = eOperatorType.MULTIPLY;
                            childPart = "";
                        }
                        else
                            childPart += c;
                        break;
                    case '/':
                        if (iBracket == 0)
                        {
                            children.Add(new Leaf(childOperator, eLeaf, childPart));
                            if (ErrorCheck(false, 1)) return;
                            childOperator = eOperatorType.DIVIDE;
                            childPart = "";
                        }
                        else
                            childPart += c;
                        break;
                    case '+':
                        if (iBracket == 0)
                        {
                            children.Add(new Leaf(childOperator, eLeaf, childPart));
                            if (ErrorCheck(false, 1)) return;
                            childOperator = eOperatorType.ADD;
                            childPart = "";
                        }
                        else
                            childPart += c;
                        break;
                    case '-':
                        if (iBracket == 0)
                        {
                            children.Add(new Leaf(childOperator, eLeaf, childPart));
                            if (ErrorCheck(false, 1)) return;
                            childOperator = eOperatorType.SUBTRACT;
                            childPart = "";
                        }
                        else
                            childPart += c;
                        break;
                    case ' ':
                        break;
                    default:
                        childPart += c;
                        break;
                }
            }
            if (children.Count > 0)
            {
                children.Add(new Leaf(childOperator, eLeaf, childPart));
                if (ErrorCheck(false, 1)) return;
            }
        }

        private string Trim(string part)
        {
            part = part.Trim();
            //if (part.StartsWith("(") && part.EndsWith(")")) part = part.Substring(1, part.Length - 2);
            //Remove unnecessary end brackets only
            if (part.StartsWith("(") && part.EndsWith(")"))
            {
                int iBracket = 0;
                bool bRemove = true;
                for (int i = 0; i < part.Length; i++)
                {
                    char c = part[i];
                    if (c == '(') iBracket++;
                    else if (c == ')') iBracket--;
                    if (iBracket == 0 && i < part.Length - 1) bRemove = false;
                }
                if (bRemove) part = part.Substring(1, part.Length - 2);
            }
            part = part.Trim();
            return part;
        }
    }
}
