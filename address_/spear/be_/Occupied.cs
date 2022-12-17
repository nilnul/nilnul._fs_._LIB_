using System;

namespace nilnul.fs.address_.spear.be_
{
	/// <summary>
	/// 
	/// </summary>
	static public class _OccupiedX
	{
		static public bool _Be(string spear)
		{
			return System.IO.Directory.Exists(spear) || System.IO.File.Exists(spear);

		}
	}

	/// <summary>
	/// occupied by file or folder
	/// </summary>
	public class Occupied
		: nilnul.fs.address_.spear.BeI
		,
		BeI1
	{
		public bool be(SpearI obj)
		{
			return _OccupiedX._Be(obj.ToString());
		}

		public bool be(SpearI1 obj)
		{
			return _OccupiedX._Be(obj.ToString());
		}

		[Obsolete(nameof(_OccupiedX._Be))]
		public bool be(string address)
		{
			return _OccupiedX._Be(address)
				;
		}



		static public Occupied Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Occupied>.Instance;
			}
		}




	}
}
