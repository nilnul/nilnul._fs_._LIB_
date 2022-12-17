using System;

namespace nilnul.fs.address.be_
{
	/// <summary>
	///  it referes to a file.
	/// </summary>
	///
	[Obsolete()]
	public class Location : _location_.Address<nilnul.fs.AddressI>
		,
		nilnul.fs.address.BeAI
	{

#pragma warning disable CS0108 // 'Location.Singleton' hides inherited member 'Address<AddressI>.Singleton'. Use the new keyword if hiding was intended.
		static public Location Singleton
#pragma warning restore CS0108 // 'Location.Singleton' hides inherited member 'Address<AddressI>.Singleton'. Use the new keyword if hiding was intended.
		{
			get
			{
				return nilnul.obj_.Singleton<Location>.Instance;
			}
		}

		public bool be(string obj)
		{
			return be(nilnul.fs.AddressA.Parse(obj));
		}
	}
}
