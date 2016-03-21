// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc2x3.DateTimeResource
{
	[ExpressType("IfcMonthInYearNumber", 193)]
	[DefinedType(typeof(long))]
    // ReSharper disable once PartialTypeWithSinglePart
	public partial struct IfcMonthInYearNumber : IExpressValueType, System.IEquatable<long>
	{ 
		private long _value;
        
		public object Value
        {
            get { return _value; }
        }

		public override string ToString()
        {
			return _value.ToString();
        }
        public IfcMonthInYearNumber(long val)
        {
            _value = val;
        }

		public IfcMonthInYearNumber(string val)
        {
			_value = System.Convert.ToInt64(val);
        }

        public static implicit operator IfcMonthInYearNumber(long value)
        {
            return new IfcMonthInYearNumber(value);
        }

        public static implicit operator long(IfcMonthInYearNumber obj)
        {
            return obj._value;

        }


        public override bool Equals(object obj)
        {
			if (obj == null && Value == null)
                return true;

            if (obj == null)
                return false;

            if (GetType() != obj.GetType())
                return false;

            return ((IfcMonthInYearNumber) obj)._value == _value;
        }

		public bool Equals(long other)
	    {
	        return this == other;
	    }

        public static bool operator ==(IfcMonthInYearNumber obj1, IfcMonthInYearNumber obj2)
        {
            return Equals(obj1, obj2);
        }

        public static bool operator !=(IfcMonthInYearNumber obj1, IfcMonthInYearNumber obj2)
        {
            return !Equals(obj1, obj2);
        }

        public override int GetHashCode()
        {
            return Value != null ? _value.GetHashCode() : base.GetHashCode();
        }

		#region IPersist implementation
		void IPersist.Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			if (propIndex != 0)
				throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
            _value = value.IntegerVal;
            
		}
		#endregion

		#region IExpressValueType implementation
        System.Type IExpressValueType.UnderlyingSystemType { 
			get 
			{
				return typeof(long);
			}
		}
		#endregion


	}
}
