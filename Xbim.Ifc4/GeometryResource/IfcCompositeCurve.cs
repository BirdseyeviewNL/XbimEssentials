// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.GeometryResource;
//## Custom using statements
//##

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcCompositeCurve
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcCompositeCurve : IIfcBoundedCurve
	{
		IEnumerable<IIfcCompositeCurveSegment> @Segments { get; }
		IfcLogical @SelfIntersect { get; }
		IfcInteger @NSegments  { get ; }
		IfcLogical @ClosedCurve  { get ; }
	
	}
}

namespace Xbim.Ifc4.GeometryResource
{
	[ExpressType("IfcCompositeCurve", 279)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcCompositeCurve : IfcBoundedCurve, IInstantiableEntity, IIfcCompositeCurve, IEquatable<@IfcCompositeCurve>
	{
		#region IIfcCompositeCurve explicit implementation
		IEnumerable<IIfcCompositeCurveSegment> IIfcCompositeCurve.Segments { get { return @Segments; } }	
		IfcLogical IIfcCompositeCurve.SelfIntersect { get { return @SelfIntersect; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcCompositeCurve(IModel model) : base(model) 		{ 
			Model = model; 
			_segments = new ItemSet<IfcCompositeCurveSegment>( this, 0 );
		}

		#region Explicit attribute fields
		private ItemSet<IfcCompositeCurveSegment> _segments;
		private IfcLogical _selfIntersect;
		#endregion
	
		#region Explicit attribute properties
		[IndexedProperty]
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.List, EntityAttributeType.Class, 1, -1, 3)]
		public ItemSet<IfcCompositeCurveSegment> @Segments 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _segments;
				((IPersistEntity)this).Activate(false);
				return _segments;
			} 
		}	
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 4)]
		public IfcLogical @SelfIntersect 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _selfIntersect;
				((IPersistEntity)this).Activate(false);
				return _selfIntersect;
			} 
			set
			{
				SetValue( v =>  _selfIntersect = v, _selfIntersect, value,  "SelfIntersect");
			} 
		}	
		#endregion


		#region Derived attributes
		[EntityAttribute(0, EntityAttributeState.Derived, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 0)]
		public IfcInteger @NSegments 
		{
			get 
			{
				//## Getter for NSegments
			    return Segments.Count;
			    //##
			}
		}

		[EntityAttribute(0, EntityAttributeState.Derived, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 0)]
		public IfcLogical @ClosedCurve 
		{
			get 
			{
				//## Getter for ClosedCurve
			    if (Segments.Count == 0) return null;
			    return Segments.Last().Transition != IfcTransitionCode.DISCONTINUOUS;
			    //##
			}
		}

		#endregion



		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					if (_segments == null) _segments = new ItemSet<IfcCompositeCurveSegment>( this );
					_segments.InternalAdd((IfcCompositeCurveSegment)value.EntityVal);
					return;
				case 1: 
					_selfIntersect = value.BooleanVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcCompositeCurve other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcCompositeCurve
            var root = (@IfcCompositeCurve)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcCompositeCurve left, @IfcCompositeCurve right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcCompositeCurve left, @IfcCompositeCurve right)
        {
            return !(left == right);
        }

        #endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}