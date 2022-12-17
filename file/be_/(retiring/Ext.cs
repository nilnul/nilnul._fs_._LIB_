using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs._address._doc;
using nilnul.fs.address_.spear.be_;

namespace nilnul.fs.file.be_
{
	public class Ext : 
		nilnul.Box1<nilnul.fs.address_.spear.be_.Ext>
		,
		nilnul.fs.file.BeI1
	{
		public Ext(address_.spear.be_.Ext val) : base(val)
		{
		}

		public Ext(_address._doc.Ext ext):this(new address_.spear.be_.Ext(ext))
		{
		}

		//public Ext(string extWithDot):this( new address_.spear.be_.Ext(extWithDot) )
		//{

		//}

		public bool be(FileI1 obj)
		{
			return boxed.be(obj.file.en);
		}

	}
}
