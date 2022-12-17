using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs._address;
using nilnul.fs._address.route_;

namespace nilnul.fs.address_.shield_
{
	[Obsolete()]
	public class BaseChild: ShieldI
	{
		private ShieldI _basic;

		public ShieldI basic
		{
			get { return _basic; }
			set { _basic = value; }
		}

		private nilnul.fs._address.DirI1 _child;

		public nilnul.fs._address.DirI1 child
		{
			get { return _child; }
			set { _child = value; }
		}

		public VolI vol => _basic.vol;

		public RouteI route => stem;

		public StemI1 stem => new nilnul.fs._address.route_.stem_.ParentDir1( 
			 
				_basic.stem
				,
				_child
			
		);

		public BaseChild(ShieldI container, nilnul.fs._address.DirI1 div)
		{
			_basic = container;
			_child = div;
		}

		public BaseChild(ShieldI shield, DocI doc):this(
			shield, new nilnul.fs._address.Dir1(doc)
		)
		{

		}

		public override string ToString()
		{
			return $"{_basic}{_child}";
		}

		static public BaseChild OfContainerAddress_DirDst(string containerAddress, string dst) {
			return new BaseChild(
				 nilnul.fs.address_.Shield.FroAddress(containerAddress)
				 ,
				 nilnul.fs._address.dir_._DstX1.CreateFroDst(dst)
			);
		}

		static public   BaseChild _Fro(ShieldI shield) {
			var stem = shield.stem;

			return new BaseChild(
				 new Shield(shield.vol, stem.div.dirs.Take(stem.div.dirs.Count()-1))
				 ,
				 stem.div.dirs.Last()
			);
		}



	}
}
