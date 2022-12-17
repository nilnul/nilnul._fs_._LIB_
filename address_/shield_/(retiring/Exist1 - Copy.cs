using System;

namespace nilnul.fs.address_.shield_
{
	/// <summary>
	/// due to the ending "seperator / or \", the existed must be folder
	/// </summary>
	///
	[Obsolete()]
	public class Exist : _exist_.Shield<ShieldI>, _location_.BlankI
	{
		public Exist(ShieldI val) : base(val)
		{
		}

		public Exist(Exist exist) : this(exist.en)
		{
		}
	}
}
