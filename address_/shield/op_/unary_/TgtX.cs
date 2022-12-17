using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.address_.shield.op_.unary_
{
	/// <summary>
	/// 
	/// </summary>
	public class Tgt: shield.op_.UnaryI
	{


		public ShieldI op(ShieldI shield)
		{
			if (
				nilnul.fs.address_.shield.be_.Folder.Singleton.be(shield)
			)
			{
				return nilnul.fs.folder_.nonlink.coerce_._TgtX.Normal(shield).en.address.en;
			}
			return shield;
		}


		static public Tgt Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Tgt>.Instance;
			}
		}

	}


}
