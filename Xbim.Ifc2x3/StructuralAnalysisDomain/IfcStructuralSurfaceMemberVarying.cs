// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.RepresentationResource;
using Xbim.Ifc2x3.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.StructuralAnalysisDomain;
//## Custom using statements
//##

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcStructuralSurfaceMemberVarying
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcStructuralSurfaceMemberVarying : IIfcStructuralSurfaceMember
	{
		IEnumerable<IfcPositiveLengthMeasure> @SubsequentThickness { get; }
		IIfcShapeAspect @VaryingThicknessLocation { get; }
		List<IfcPositiveLengthMeasure> @VaryingThickness  { get ; }
	
	}
}

namespace Xbim.Ifc2x3.StructuralAnalysisDomain
{
	[ExpressType("IfcStructuralSurfaceMemberVarying", 421)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcStructuralSurfaceMemberVarying : IfcStructuralSurfaceMember, IInstantiableEntity, IIfcStructuralSurfaceMemberVarying, IEquatable<@IfcStructuralSurfaceMemberVarying>
	{
		#region IIfcStructuralSurfaceMemberVarying explicit implementation
		IEnumerable<IfcPositiveLengthMeasure> IIfcStructuralSurfaceMemberVarying.SubsequentThickness { get { return @SubsequentThickness; } }	
		IIfcShapeAspect IIfcStructuralSurfaceMemberVarying.VaryingThicknessLocation { get { return @VaryingThicknessLocation; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcStructuralSurfaceMemberVarying(IModel model) : base(model) 		{ 
			Model = model; 
			_subsequentThickness = new ItemSet<IfcPositiveLengthMeasure>( this, 0 );
		}

		#region Explicit attribute fields
		private ItemSet<IfcPositiveLengthMeasure> _subsequentThickness;
		private IfcShapeAspect _varyingThicknessLocation;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(10, EntityAttributeState.Mandatory, EntityAttributeType.List, EntityAttributeType.None, 2, -1, 19)]
		public ItemSet<IfcPositiveLengthMeasure> @SubsequentThickness 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _subsequentThickness;
				((IPersistEntity)this).Activate(false);
				return _subsequentThickness;
			} 
		}	
		[EntityAttribute(11, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 20)]
		public IfcShapeAspect @VaryingThicknessLocation 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _varyingThicknessLocation;
				((IPersistEntity)this).Activate(false);
				return _varyingThicknessLocation;
			} 
			set
			{
				SetValue( v =>  _varyingThicknessLocation = v, _varyingThicknessLocation, value,  "VaryingThicknessLocation");
			} 
		}	
		#endregion


		#region Derived attributes
		[EntityAttribute(0, EntityAttributeState.Derived, EntityAttributeType.List, EntityAttributeType.None, 3, -1, 0)]
		public List<IfcPositiveLengthMeasure> @VaryingThickness 
		{
			get 
			{
				//## Getter for VaryingThickness
			    var result = new List<IfcPositiveLengthMeasure> {Thickness ?? 0};
                result.AddRange(SubsequentThickness);
			    return result;
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
				case 1: 
				case 2: 
				case 3: 
				case 4: 
				case 5: 
				case 6: 
				case 7: 
				case 8: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 9: 
					if (_subsequentThickness == null) _subsequentThickness = new ItemSet<IfcPositiveLengthMeasure>( this );
					_subsequentThickness.InternalAdd(value.RealVal);
					return;
				case 10: 
					_varyingThicknessLocation = (IfcShapeAspect)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcStructuralSurfaceMemberVarying other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcStructuralSurfaceMemberVarying
            var root = (@IfcStructuralSurfaceMemberVarying)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcStructuralSurfaceMemberVarying left, @IfcStructuralSurfaceMemberVarying right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcStructuralSurfaceMemberVarying left, @IfcStructuralSurfaceMemberVarying right)
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