// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.Interfaces;
using System.Collections.Generic;
using System.Linq;

// ReSharper disable once CheckNamespace
namespace Xbim.Ifc2x3.PresentationOrganizationResource
{
	public partial class @IfcPresentationLayerAssignment : IIfcPresentationLayerAssignment
	{
		Xbim.Ifc4.MeasureResource.IfcLabel IIfcPresentationLayerAssignment.Name 
		{ 
			get
			{
				return new Xbim.Ifc4.MeasureResource.IfcLabel((string)Name);
			} 
		}
		Xbim.Ifc4.MeasureResource.IfcText? IIfcPresentationLayerAssignment.Description 
		{ 
			get
			{
				if (Description == null) return null;
				return new Xbim.Ifc4.MeasureResource.IfcText((string)Description);
			} 
		}
		IEnumerable<Xbim.Ifc4.PresentationOrganizationResource.IfcLayeredItem> IIfcPresentationLayerAssignment.AssignedItems 
		{ 
			get
			{
			foreach (var member in AssignedItems)
			{
				var ifcrepresentationitem = member as Xbim.Ifc2x3.GeometryResource.IfcRepresentationItem;
				if (ifcrepresentationitem != null) 
					yield return ifcrepresentationitem;
				var ifcrepresentation = member as Xbim.Ifc2x3.RepresentationResource.IfcRepresentation;
				if (ifcrepresentation != null) 
					yield return ifcrepresentation;
			}
			} 
		}
		Xbim.Ifc4.MeasureResource.IfcIdentifier? IIfcPresentationLayerAssignment.Identifier 
		{ 
			get
			{
				if (Identifier == null) return null;
				return new Xbim.Ifc4.MeasureResource.IfcIdentifier((string)Identifier);
			} 
		}
	}
}