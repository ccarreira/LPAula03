using System;
using System.Collections.Generic;

namespace CityManager1
{
    public class Building : IHasValue
    {
        public string tipo;
        public float area;
        public float Value {get; }

        public Building(string tipo, float area, float value)
        {
            this.tipo = tipo;
            this.area = area;
            Value = value;
        }
        public override string ToString()
        {
            return $"{tipo,-18}{"Val="+Value,8:F2}{", Area="+area,8:F2}";
        }

        public bool Equals(IHasValue other)
        {
            return other != null && other.Value == Value;
        }

    }
}