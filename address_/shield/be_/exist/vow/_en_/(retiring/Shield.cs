using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.address_.shield.be_.exist.vow._en_
{
	[Obsolete()]
	public class Shield<TShield>
		: 
		nilnul.fs.address_.shield.vow._en_.Shield<
			TShield
			,
			nilnul.fs.address_.shield.be_.exist._vow_.Shield<TShield>
		>
		where TShield : nilnul.fs.address_.ShieldI
	{
		public Shield(TShield val) : base(val)
		{
		}
	}
}
