using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LitDev
{
    enum eLeafType { NONE, COMPOUND, VALUE, PREFIX, NUMBER, UNIT, DERIVEDUNIT, POWER }
    enum eParentLevel { SAME, OPPOSITE }

    public class BaseUnit
    {
        public string dimension;
        public string name = "";
        public double mult = 1;
        public double add = 0;

        public BaseUnit(string dimension, string name, double mult, double add)
        {
            this.dimension = dimension;
            this.name = name;
            this.mult = mult;
            this.add = add;
        }

        public double ToBase(double value)
        {
            return (value + add) * mult;
        }

        public double ToUser(double value)
        {
            return (value / mult) - add;
        }
    }

    public class DerivedUnit
    {
        public string name = "";
        public string baseUnits = "";
        public double add = 0;

        public DerivedUnit(string name, string baseUnits, double add = 0)
        {
            this.name = name;
            this.baseUnits = baseUnits;
            this.add = add;
        }
    }

    public class UnitSystem
    {
        public static List<BaseUnit> BaseUnits = new List<BaseUnit>();
        public static List<DerivedUnit> DerivedUnits = new List<DerivedUnit>();
        public static Dictionary<string, double> Prefixes = new Dictionary<string, double>();
        public static Dictionary<string, double> Constants = new Dictionary<string, double>();
        public static List<string> Dimensions = new List<string>();
        public static List<string> Errors = new List<string>();

        public UnitSystem()
        {
            Errors.Clear();
            Initialise();
            SetBaseUnits();
        }

        private void Initialise()
        {
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
            BaseUnits.Add(new BaseUnit("TIME", "s", 1, 0));

            //LENGTH
            BaseUnits.Add(new BaseUnit("LENGTH",  "m", 1, 0));

            //MASS
            BaseUnits.Add(new BaseUnit("MASS", "g", 1, 0));

            //TEMPERATURE
            BaseUnits.Add(new BaseUnit("TEMPERATURE", "K", 1, 0));
            BaseUnits.Add(new BaseUnit("TEMPERATURE", "R", 5.0/9.0, 0));

            //Charge
            BaseUnits.Add(new BaseUnit("CHARGE", "Q", 1, 0));

            //CONSTANTS
            Constants.Add("pi", Math.PI);
            Constants.Add("e", Math.E);

            //Derived Units

            //TIME
            DerivedUnits.Add(new DerivedUnit("min", "(60)s"));
            DerivedUnits.Add(new DerivedUnit("hr", "(60)min"));
            DerivedUnits.Add(new DerivedUnit("day", "(24)hr"));
            DerivedUnits.Add(new DerivedUnit("week", "(7)day"));

            //LENGTH
            DerivedUnits.Add(new DerivedUnit("ft", "(0.3048)m"));
            DerivedUnits.Add(new DerivedUnit("yd", "(3)ft"));
            DerivedUnits.Add(new DerivedUnit("in", "(2.54).cm"));
            DerivedUnits.Add(new DerivedUnit("mile", "(1760)yd"));

            //MASS
            DerivedUnits.Add(new DerivedUnit("lb", "(453.59237)g"));
            DerivedUnits.Add(new DerivedUnit("oz", "(1/16)lb"));
            DerivedUnits.Add(new DerivedUnit("st", "(14)lb"));
            DerivedUnits.Add(new DerivedUnit("ton", "(160)st"));
            DerivedUnits.Add(new DerivedUnit("tonne", "(1000)Kg"));

            //TEMPERATURE
            DerivedUnits.Add(new DerivedUnit("C", "K", 273.15));
            DerivedUnits.Add(new DerivedUnit("F", "R", 459.67));

            //FORCE
            DerivedUnits.Add(new DerivedUnit("N", "Kg.m/s2"));
            DerivedUnits.Add(new DerivedUnit("lbf", "(4.4482216152605)N"));

            //ENERGY
            DerivedUnits.Add(new DerivedUnit("J", "N.m"));
            DerivedUnits.Add(new DerivedUnit("BTU", "(1055.06)J"));
            DerivedUnits.Add(new DerivedUnit("erg", "(1.0e-7)J"));
            DerivedUnits.Add(new DerivedUnit("kcal", "(4.184e3)J"));
            DerivedUnits.Add(new DerivedUnit("cal", "(4.184)J"));

            //POWER
            DerivedUnits.Add(new DerivedUnit("W", "J/s"));
            DerivedUnits.Add(new DerivedUnit("hp", "(745.7)W"));

            //AREA
            DerivedUnits.Add(new DerivedUnit("acre", "(4840)yd2"));
            DerivedUnits.Add(new DerivedUnit("hectare", "(10000)m2"));

            //VOLUME
            DerivedUnits.Add(new DerivedUnit("cc", "(1.0e-6)m3"));
            DerivedUnits.Add(new DerivedUnit("bbl", "(5.615)ft3"));
            DerivedUnits.Add(new DerivedUnit("l", "(1.0e-3)m3"));
            DerivedUnits.Add(new DerivedUnit("pintUK", "(568)l"));
            DerivedUnits.Add(new DerivedUnit("pintUS", "(473)l"));
            DerivedUnits.Add(new DerivedUnit("galUK", "(4.54609)l"));
            DerivedUnits.Add(new DerivedUnit("galUS", "(0.8327)galUK"));

            //PRESSURE
            DerivedUnits.Add(new DerivedUnit("Pa", "N/m2"));
            DerivedUnits.Add(new DerivedUnit("Bar", "(1.0e5)Pa"));
            DerivedUnits.Add(new DerivedUnit("Atm", "(1.013)Bar"));
            DerivedUnits.Add(new DerivedUnit("psi", "(6894.75729)Pa"));
            DerivedUnits.Add(new DerivedUnit("psig", "psi", 14.69));

            //Current
            DerivedUnits.Add(new DerivedUnit( "I", "Q/s"));

            //Voltage
            DerivedUnits.Add(new DerivedUnit( "V", "J/Q"));

            //Resistance
            DerivedUnits.Add(new DerivedUnit("ohm", "V/I"));
        }

        private void SetBaseUnits()
        {
            foreach (BaseUnit unit in BaseUnits)
            {
                if (!Dimensions.Contains(unit.dimension)) Dimensions.Add(unit.dimension);
            }

        }

        public double Convert(double value, string fromUnit, string toUnit)
        {
            Errors.Clear();
            try
            {
                //Parse units
                Leaf fromLeaf = new Leaf(null, eParentLevel.SAME, eLeafType.COMPOUND, fromUnit);
                Leaf toLeaf = new Leaf(null, eParentLevel.SAME, eLeafType.COMPOUND, toUnit);

                //Check dimensionality is correct
                LeafResult resultFrom = fromLeaf.Multiplier();
                LeafResult resultTo = toLeaf.Multiplier();
                if (resultFrom.dimensions.Count != resultTo.dimensions.Count)
                {
                    Errors.Add("Inconsistent Diemsnions");
                    return double.NaN;
                }
                foreach (KeyValuePair<string, double> kvp in resultFrom.dimensions)
                {
                    if (kvp.Value != resultTo.dimensions[kvp.Key])
                    {
                        Errors.Add("Inconsistent Diemsnions");
                        return double.NaN;
                    }
                }

                //Derived units with multipliers and additive for pure units
                double result = (value * resultFrom.prefix + fromLeaf.Additive) * resultFrom.number * resultFrom.unit;
                result = (result / resultTo.number / resultTo.unit - toLeaf.Additive) / resultTo.prefix;
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
                Leaf leaf = new Leaf(null, eParentLevel.SAME, eLeafType.COMPOUND, unit);

                //Check dimensionality is correct
                return leaf.Multiplier().dimensions;
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
                units[unit.name] = unit.dimension.ToString();
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
            }

            return units;
        }

        public Dictionary<string, string> GetConstants()
        {
            Dictionary<string, string> units = new Dictionary<string, string>();

            foreach (KeyValuePair<string, double> kvp in Constants)
            {
                units[kvp.Key] = kvp.Value.ToString();
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

        public void AddBaseUnit(string name, string dimension, double mult, double add)
        {
            BaseUnits.Add(new BaseUnit(dimension, name, mult, add));
            SetBaseUnits();
        }

        public void AddDerivedUnit(string name, string units, double add)
        {
            DerivedUnits.Add(new DerivedUnit(name, units, add));
        }

        public void AddConstant(string name, double value)
        {
            Constants.Add(name, value);
        }
    }

    class LeafResult
    {
        public double prefix = 1;
        public double number = 1;
        public double unit = 1;
        public double power = 1;
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
        eLeafType eLeaf = eLeafType.NONE;
        Leaf parent = null;
        eParentLevel eParent = eParentLevel.SAME;

        string part = "";
        List<Leaf> children = new List<Leaf>();
        BaseUnit baseUnit = null;
        double value = double.NaN;
        double add = 0;

        public double Additive
        {
            get { return add; }
        }

        public Leaf(Leaf parent, eParentLevel eParent, eLeafType eLeaf, string rawPart)
        {
            this.parent = parent;
            this.eParent = eParent;
            this.eLeaf = eLeaf;
            this.rawPart = rawPart;

            Parse();
        }

        private void Parse()
        {
            part = Trim(rawPart);

            bool bNumber = double.TryParse(part, out value);

            if (bNumber)
            {
                if (eLeaf == eLeafType.NUMBER || eLeaf == eLeafType.POWER) return;
                eLeaf = eLeafType.VALUE;
                children.Add(new Leaf(this, eParentLevel.SAME, eLeafType.NUMBER, part));
                return;
            }

            if (eLeaf == eLeafType.NUMBER)
            {
                foreach (KeyValuePair<string, double> kvp in UnitSystem.Prefixes)
                {
                    if (part == kvp.Key)
                    {
                        Leaf topLeaf = parent;
                        if (null != topLeaf) topLeaf = topLeaf.parent;
                        if (null == topLeaf) eLeaf = eLeafType.PREFIX; //Top level prefix for additive conversion
                        value = kvp.Value;
                        return;
                    }
                }
            }

            if (eLeaf == eLeafType.UNIT)
            {
                foreach (BaseUnit unit in UnitSystem.BaseUnits)
                {
                    if (part == unit.name)
                    {
                        baseUnit = unit;
                        return;
                    }
                }
            }

            SplitOperators();
            if (children.Count > 0) return;

            SplitBrackets();
            if (children.Count > 0) return;

            foreach (DerivedUnit unit in UnitSystem.DerivedUnits)
            {
                if (part == unit.name)
                {
                    eLeaf = eLeafType.VALUE;
                    add = unit.add;
                    children.Add(new Leaf(this, eParentLevel.SAME, eLeafType.DERIVEDUNIT, unit.baseUnits));
                    return;
                }
                else
                {
                    int pos = part.LastIndexOf(unit.name);
                    if (pos < 0) continue;

                    string power = part.Substring(pos + unit.name.Length);
                    double number = 0;
                    if (power.Length > 0 && !double.TryParse(Trim(power), out number)) continue;

                    string prefix = part.Substring(0, pos);
                    if (prefix.Length > 0 && !double.TryParse(Trim(prefix), out number) && !UnitSystem.Prefixes.ContainsKey(prefix)) continue;

                    eLeaf = eLeafType.VALUE;
                    add = unit.add;
                    if (prefix.Length > 0) children.Add(new Leaf(this, eParentLevel.SAME, eLeafType.NUMBER, prefix));
                    children.Add(new Leaf(this, eParentLevel.SAME, eLeafType.DERIVEDUNIT, unit.baseUnits));
                    if (power.Length > 0) children.Add(new Leaf(this, eParentLevel.SAME, eLeafType.POWER, power));
                    return;
                }
            }

            foreach (BaseUnit unit in UnitSystem.BaseUnits)
            {
                if (part == unit.name)
                {
                    eLeaf = eLeafType.VALUE;
                    add = unit.add;
                    children.Add(new Leaf(this, eParentLevel.SAME, eLeafType.UNIT, unit.name));
                    return;
                }
                else
                {
                    int pos = part.LastIndexOf(unit.name);
                    if (pos < 0) continue;

                    string power = part.Substring(pos + unit.name.Length);
                    double number = 0;
                    if (power.Length > 0 && !double.TryParse(Trim(power), out number)) continue;

                    string prefix = part.Substring(0, pos);
                    if (prefix.Length > 0 && !double.TryParse(Trim(prefix), out number) && !UnitSystem.Prefixes.ContainsKey(prefix)) continue;

                    eLeaf = eLeafType.VALUE;
                    add = unit.add;
                    if (prefix.Length > 0) children.Add(new Leaf(this, eParentLevel.SAME, eLeafType.NUMBER, prefix));
                    children.Add(new Leaf(this, eParentLevel.SAME, eLeafType.UNIT, unit.name));
                    if (power.Length > 0) children.Add(new Leaf(this, eParentLevel.SAME, eLeafType.POWER, power));
                    return;
                }
            }

            foreach (KeyValuePair<string, double> kvp in UnitSystem.Constants)
            {
                if (part == kvp.Key)
                {
                    eLeaf = eLeafType.VALUE;
                    children.Add(new Leaf(this, eParentLevel.SAME, eLeafType.NUMBER, kvp.Value.ToString()));
                    return;
                }
            }

            UnitSystem.Errors.Add("Unit could not be found : "+ part);

            eLeaf = eLeafType.NONE;
        }

        private void SplitOperators()
        {
            int iBracket = 0;
            string childPart = "";
            eParentLevel childLevel = eParentLevel.SAME;
            for (int i = 0; i < part.Length; i++)
            {
                char c = part[i];
                switch (c)
                {
                    case '(':
                        iBracket++;
                        break;
                    case ')':
                        iBracket--;
                        break;
                    case '.':
                        if (iBracket == 0)
                        {
                            children.Add(new Leaf(this, childLevel, eLeaf, childPart));
                            childLevel = eParentLevel.SAME;
                            childPart = "";
                        }
                        else
                            childPart += c;
                        break;
                    case '/':
                        if (iBracket == 0)
                        {
                            children.Add(new Leaf(this, childLevel, eLeaf, childPart));
                            childLevel = eParentLevel.OPPOSITE;
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
            if (children.Count > 0) children.Add(new Leaf(this, childLevel, eLeaf, childPart));
        }

        private void SplitBrackets()
        {
            int iBracket = 0;
            string childPart = "";
            for (int i = 0; i < part.Length; i++)
            {
                char c = part[i];
                switch (c)
                {
                    case '(':
                        if (iBracket == 0 && childPart.Length > 0)
                        {
                            children.Add(new Leaf(this, eParentLevel.SAME, eLeaf, childPart));
                            childPart = "";
                        }
                        iBracket++;
                        break;
                    case ')':
                        iBracket--;
                        if (iBracket == 0 && childPart.Length > 0)
                        {
                            children.Add(new Leaf(this, eParentLevel.SAME, eLeaf, childPart));
                            childPart = "";
                        }
                        break;
                    case ' ':
                        break;
                    default:
                        childPart += c;
                        break;
                }
            }
            if (children.Count > 0) children.Add(new Leaf(this, eParentLevel.SAME, eLeaf, childPart));
        }

        public LeafResult Multiplier()
        {
            LeafResult leafResult = new LeafResult();
            double prefix = 1.0;
            double number = 1.0;
            double unit = 1.0;
            double power = 1.0;
            LeafResult leaf = new LeafResult();

            foreach (Leaf child in children)
            {
                LeafResult childResult = child.Multiplier();
                switch (child.eLeaf)
                {
                    case eLeafType.COMPOUND:
                    case eLeafType.VALUE:
                        leafResult.prefix *= childResult.prefix;
                        leafResult.number *= childResult.number;
                        leafResult.unit *= childResult.unit;
                        leafResult.power *= childResult.power;
                        foreach (KeyValuePair<string, double> kvp in childResult.dimensions)
                        {
                            leafResult.dimensions[kvp.Key] += kvp.Value;
                        }
                        break;
                    case eLeafType.POWER:
                        power = childResult.power;
                        break;
                    case eLeafType.PREFIX:
                        prefix = childResult.prefix;
                        break;
                    case eLeafType.NUMBER:
                        number = childResult.number;
                        break;
                    case eLeafType.UNIT:
                        unit = childResult.unit;
                        foreach (KeyValuePair<string, double> kvp in childResult.dimensions)
                        {
                            leaf.dimensions[kvp.Key] += kvp.Value;
                        }
                        break;
                    case eLeafType.DERIVEDUNIT:
                        prefix *= childResult.prefix;
                        number *= childResult.number;
                        unit *= childResult.unit;
                        power *= childResult.power;
                        foreach (KeyValuePair<string, double> kvp in childResult.dimensions)
                        {
                            leaf.dimensions[kvp.Key] += kvp.Value;
                        }
                        break;
                    case eLeafType.NONE:
                        break;
                }
            }

            switch (eLeaf)
            {
                case eLeafType.POWER:
                    leafResult.power *= value;
                    break;
                case eLeafType.PREFIX:
                    leafResult.prefix *= value;
                    break;
                case eLeafType.NUMBER:
                    leafResult.number *= value;
                    break;
                case eLeafType.UNIT:
                    leafResult.unit = baseUnit.mult;
                    leafResult.dimensions[baseUnit.dimension] = 1;
                    break;
                case eLeafType.VALUE:
                    bool bSet = false;
                    foreach (Leaf child in children)
                    {
                        if (child.eLeaf == eLeafType.VALUE) bSet = true; //already set
                    }
                    leafResult.prefix = Math.Pow(prefix, power);
                    if (!bSet)
                    {
                        leafResult.number = Math.Pow(number, power);
                        leafResult.unit = Math.Pow(unit, power);
                        foreach (KeyValuePair<string, double> kvp in leaf.dimensions)
                        {
                            leafResult.dimensions[kvp.Key] += leaf.dimensions[kvp.Key] * (eParent == eParentLevel.OPPOSITE ? -power : power);
                        }
                    }
                    break;
                case eLeafType.COMPOUND:
                case eLeafType.DERIVEDUNIT:
                    break;
                case eLeafType.NONE:
                    break;
            }

            if (eParent == eParentLevel.OPPOSITE)
            {
                leafResult.prefix = 1 / leafResult.prefix;
                leafResult.number = 1 / leafResult.number;
                leafResult.unit = 1 / leafResult.unit;
            }
            return leafResult;
        }

        private string Trim(string part)
        {
            part = part.Trim();
            if (part.StartsWith("(") && part.StartsWith(")")) part = part.Trim(new char[] { ' ', '(', ')' });
            return part;
        }
    }
}
