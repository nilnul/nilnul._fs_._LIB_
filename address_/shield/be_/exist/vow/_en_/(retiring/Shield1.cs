using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.address_.shield.be_.exist.vow._en_
{
	[Obsolete()]
	public class Shield1<TShield>
		: 
		nilnul.fs.address_.shield.vow._en_.Shield1<
			TShield
			,
			nilnul.fs.address_.shield.be_.exist._vow_.Shield1<TShield>
		>
		where TShield : nilnul.fs.address_.ShieldI1
	{
		public Shield1(TShield val) : base(val)
		{
		}
	}
}
