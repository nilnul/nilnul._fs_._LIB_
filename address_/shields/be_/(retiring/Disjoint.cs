using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.address_.shields.be_
{
	/// <summary>
	/// determine whether an array of folders are disjoint (any in/inc relations)
	/// </summary>
	/// 
	[Obsolete()]
	static public class _DisjointX
	{
		static public  bool Be(IEnumerable<nilnul.fs.address_.ShieldI> folders) {
			if ( nilnul.obj.seq.be_._NoneX.None(folders))
			{
				return true;
			}
			return _Be(folders.First(), nilnul.obj.seq_.headed._TailX._Tail(folders) ); 
		}


		static public bool Be(nilnul.objs_.EnumerableI<nilnul.fs.address_.ShieldI> folders) {
			return Be((IEnumerable<ShieldI>)folders);
		}

		static public bool Be(ShieldI[] folders)
		{
			return Be((IEnumerable<ShieldI>)folders);
			//throw new NotImplementedException();
		}
		

		static  bool _Be( nilnul.fs.address_.ShieldI folder, IEnumerable<nilnul.fs.address_.ShieldI> _disjointFinite) {
			return _disjointFinite.All(
				element=> nilnul.fs.address_.shield.re_._DisjointX.Re(element, folder)
			);
		}

		


	}
	[Obsolete()]
	public class Disjoint : nilnul.fs.address_.shields.BeI
	{
		

	
		public bool be(IEnumerable<ShieldI> obj)
		{
			return _DisjointX.Be( obj);
			throw new NotImplementedException();
		}


		static public Disjoint Singleton
		{
			get
			{
				return nilnul._obj.Singleton<Disjoint>.Instance;
			}
		}


	}
}
