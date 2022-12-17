using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.address_.containers.be_
{
	/// <summary>
	/// determine whether an array of folders are disjoint (any in/inc relations)
	/// </summary>
	/// 
	[Obsolete()]
	static public class _DisjointX
	{
		static public  bool Be(IEnumerable<nilnul.fs.address_.ContainerI1> folders) {
			if ( nilnul.obj.seq.be_._NoneX.None(folders))
			{
				return true;
			}
			return _Be(folders.First(), nilnul.obj.seq_.headed._TailX._Tail(folders) ); 
		}


		static public bool Be(nilnul.objs_.EnumerableI<nilnul.fs.address_.ContainerI1> folders) {
			return Be((IEnumerable<ContainerI1>)folders);
		}

		static public bool Be(ContainerI1[] folders)
		{
			return Be((IEnumerable<ContainerI1>)folders);
			//throw new NotImplementedException();
		}
		

		static  bool _Be( nilnul.fs.address_.ContainerI1 folder, IEnumerable<nilnul.fs.address_.ContainerI1> _disjointFinite) {
			return _disjointFinite.All(
				element=> nilnul.fs.address_.container.re_._DisjointX.Re(element, folder)
			);
		}

		


	}

	public class Disjoint : nilnul.fs.address_.containers.BeI
	{
		

	
		public bool be(IEnumerable<ContainerI1> obj)
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
