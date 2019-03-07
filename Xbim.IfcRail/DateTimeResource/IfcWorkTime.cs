// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.IfcRail.DateTimeResource;
//## Custom using statements
//##


namespace Xbim.IfcRail.DateTimeResource
{
	[ExpressType("IfcWorkTime", 1319)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcWorkTime : IfcSchedulingTime, IInstantiableEntity, IContainsEntityReferences, IEquatable<@IfcWorkTime>
	{

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcWorkTime(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcRecurrencePattern _recurrencePattern;
		private IfcDate? _start;
		private IfcDate? _finish;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(4, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, null, null, 4)]
		public IfcRecurrencePattern @RecurrencePattern 
		{ 
			get 
			{
				if(_activated) return _recurrencePattern;
				Activate();
				return _recurrencePattern;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _recurrencePattern = v, _recurrencePattern, value,  "RecurrencePattern", 4);
			} 
		}	
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 5)]
		public IfcDate? @Start 
		{ 
			get 
			{
				if(_activated) return _start;
				Activate();
				return _start;
			} 
			set
			{
				SetValue( v =>  _start = v, _start, value,  "Start", 5);
			} 
		}	
		[EntityAttribute(6, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 6)]
		public IfcDate? @Finish 
		{ 
			get 
			{
				if(_activated) return _finish;
				Activate();
				return _finish;
			} 
			set
			{
				SetValue( v =>  _finish = v, _finish, value,  "Finish", 6);
			} 
		}	
		#endregion




		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
				case 1: 
				case 2: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 3: 
					_recurrencePattern = (IfcRecurrencePattern)(value.EntityVal);
					return;
				case 4: 
					_start = value.StringVal;
					return;
				case 5: 
					_finish = value.StringVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcWorkTime other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@RecurrencePattern != null)
					yield return @RecurrencePattern;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}