using System;

namespace nilnul.fs.address.be_
{
	/// <summary>
	///  it referes to a file.
	/// </summary>
	///
	public class Location1 : Location<nilnul.fs.AddressI1>
		,
		nilnul.fs.address.BeAI1
	{


		public bool be(string obj)
		{
			return be(nilnul.fs.AddressA1.Parse(obj));
		}


		static public Location1 Lazy
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<Location1>.Instance;
			}
		}
		static public Location1 Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Location1>.Instance;
			}
		}


	}
}
