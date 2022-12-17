using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs._pac_
{
	/// <summary>
	/// key is not converted to directory; in fact, the key shall not be directory when the val is a file.
	/// but when comparing the equality, the key is converted to directory by ensuring an ending deck.
	/// By doing so, we can guarantine that the entry in pac is nonconflicting when expanded into a fs directory system.
	/// </summary>
	public interface IKeyEqByDnts
	{
	}
}
