using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.address_.shield.eq_
{
	/// <summary>
	/// if they are folders, compare the tgt of the symlink
	/// </summary>
	public class Tgt
		:
		nilnul.obj.eq_.Homo<nilnul.fs.address_.ShieldI>
		,
		nilnul.fs.address_.shield.EqI
	{
		public Tgt(
			) : base(
				nilnul.fs.address_.shield.op_.unary_.Tgt.Singleton.op, nilnul.fs.address_.shield.Eq.Singleton
				)
		{
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
