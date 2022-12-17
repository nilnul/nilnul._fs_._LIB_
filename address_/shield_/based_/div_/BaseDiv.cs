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
	public class BaseDiv:
		ShieldA,
		ShieldI
	{
		private ShieldI _basic;

		public ShieldI basic
		{
			get { return _basic; }
			set { _basic = value; }
		}

		private nilnul.fs._address.DivI1 _descendent;

		public nilnul.fs._address.DivI1 descendent
		{
			get { return _descendent; }
			set { _descendent = value; }
		}

		public override VolI vol => _basic.vol;


		public override StemI1 stem => new nilnul.fs._address.route_.stem_.ParentDiv( 
				_basic.stem.div
				,
				_descendent
			
		);

		public BaseDiv(ShieldI container, nilnul.fs._address.DivI1 div)
		{
			_basic = container;
			_descendent = div;
		}


		public  BaseDiv(VolI vol, IEnumerable<DirI1> enumerable)
			:this(
				 new shield_.Vol(vol), new nilnul.fs._address.Div1(enumerable)
			 )
		{

		}



		public BaseDiv(ShieldI container):this(container, new fs._address.Div1())
		{
		}

		public override string ToString()
		{
			return $"{_basic}{_descendent}";
		}

		

		


	}
}
