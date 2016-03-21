// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.ExternalReferenceResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.ActorResource;
//## Custom using statements
//##

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcOrganizationRelationship
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcOrganizationRelationship : IIfcResourceLevelRelationship
	{
		IIfcOrganization @RelatingOrganization { get; }
		IEnumerable<IIfcOrganization> @RelatedOrganizations { get; }
	
	}
}

namespace Xbim.Ifc4.ActorResource
{
	[ExpressType("IfcOrganizationRelationship", 486)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcOrganizationRelationship : IfcResourceLevelRelationship, IInstantiableEntity, IIfcOrganizationRelationship, IEquatable<@IfcOrganizationRelationship>
	{
		#region IIfcOrganizationRelationship explicit implementation
		IIfcOrganization IIfcOrganizationRelationship.RelatingOrganization { get { return @RelatingOrganization; } }	
		IEnumerable<IIfcOrganization> IIfcOrganizationRelationship.RelatedOrganizations { get { return @RelatedOrganizations; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcOrganizationRelationship(IModel model) : base(model) 		{ 
			Model = model; 
			_relatedOrganizations = new ItemSet<IfcOrganization>( this, 0 );
		}

		#region Explicit attribute fields
		private IfcOrganization _relatingOrganization;
		private ItemSet<IfcOrganization> _relatedOrganizations;
		#endregion
	
		#region Explicit attribute properties
		[IndexedProperty]
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 3)]
		public IfcOrganization @RelatingOrganization 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _relatingOrganization;
				((IPersistEntity)this).Activate(false);
				return _relatingOrganization;
			} 
			set
			{
				SetValue( v =>  _relatingOrganization = v, _relatingOrganization, value,  "RelatingOrganization");
			} 
		}	
		[IndexedProperty]
		[EntityAttribute(4, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 1, -1, 4)]
		public ItemSet<IfcOrganization> @RelatedOrganizations 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _relatedOrganizations;
				((IPersistEntity)this).Activate(false);
				return _relatedOrganizations;
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
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 2: 
					_relatingOrganization = (IfcOrganization)(value.EntityVal);
					return;
				case 3: 
					if (_relatedOrganizations == null) _relatedOrganizations = new ItemSet<IfcOrganization>( this );
					_relatedOrganizations.InternalAdd((IfcOrganization)value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcOrganizationRelationship other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcOrganizationRelationship
            var root = (@IfcOrganizationRelationship)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcOrganizationRelationship left, @IfcOrganizationRelationship right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcOrganizationRelationship left, @IfcOrganizationRelationship right)
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