using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.address_.shield.vow._en_
{
	[Obsolete()]
	public class Shield1<TShield, TVow>
		: 
		nilnul.obj.vow.En<TShield, TVow>
		where TShield:ShieldI1
		where TVow: nilnul.fs.address_.shield._vow_.ShieldI<TShield>,new()
	{
		public Shield1(TShield val) : base(val)
		{
		}
	}
}
