using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace nilnul.fs.location_.file0Folder.str_._binding
{
	[Serializable()]
	public class Sortable<T> : BindingList<T>, ITypedList
	{
		[NonSerialized()]
		private PropertyDescriptorCollection properties;

		public Sortable() : base()
		{
			// Get the 'shape' of the list. 
			// Only get the public properties marked with Browsable = true.
			PropertyDescriptorCollection pdc = TypeDescriptor.GetProperties(
				typeof(T),
				new Attribute[] { new BrowsableAttribute(true) });

			// Sort the properties.
			properties = pdc.Sort();
		}

		#region ITypedList Implementation

		public PropertyDescriptorCollection GetItemProperties(PropertyDescriptor[] listAccessors)
		{
			PropertyDescriptorCollection pdc;

			if (listAccessors != null && listAccessors.Length > 0)
			{
				// Return child list shape.
				pdc = ListBindingHelper.GetListItemProperties(listAccessors[0].PropertyType);
			}
			else
			{
				// Return properties in sort order.
				pdc = properties;
			}

			return pdc;
		}

		// This method is only used in the design-time framework 
		// and by the obsolete DataGrid control.
		public string GetListName(PropertyDescriptor[] listAccessors)
		{
			return typeof(T).Name;
		}

		#endregion
	}
}