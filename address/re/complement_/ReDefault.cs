using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.address.re.complement_
{
	public class ReDefault<TRe> :
		nilnul.obj.re.complement_.ReDefault<nilnul.fs.AddressI, TRe>
		where TRe:
		nilnul.fs.address.ReI,new()
	{

	}
}
