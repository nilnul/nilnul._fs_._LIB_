using System;
using System.Collections.Generic;
using System.Linq;

namespace nilnul.fs.address.str_.seq.be_
{
	/// <summary>
	/// determine whether an array of folders are disjoint (any in/inc relations)
	/// </summary>
	static public class _DisjointX
	{
		static bool _Be(nilnul.fs.AddressI folder, IEnumerable<nilnul.fs.AddressI> _disjointFinite)
		{
			return Be(_disjointFinite) && _disjointFinite.All(
				element => nilnul.fs.address.re_._DisjointX.Re(element, folder)
			) ;
		}

		static public bool Be(IEnumerable<nilnul.fs.AddressI > folders)
		{
			if (nilnul.obj.seq.be_._NoneX.None(folders))
			{
				return true;
			}
			return _Be(folders.First(), nilnul.obj.seq_.headed._TailX._Tail(folders));
		}




	}

	public class Disjoint : nilnul.fs.address.str_.seq.BeI
	{



		public bool be(IEnumerable<AddressI> obj)
		{
			return _DisjointX.Be(obj);
		}


		static public Disjoint Singleton
		{
			get
			{
#pragma warning disable CS0612 // 'Singleton<Disjoint1>' is obsolete
				return nilnul.obj_.Singleton<Disjoint>.Instance;
#pragma warning restore CS0612 // 'Singleton<Disjoint1>' is obsolete
			}
		}


	}
}
