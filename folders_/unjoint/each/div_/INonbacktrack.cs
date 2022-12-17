using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folders_.unjoint.divs.traverse_
{
	/// <summary>
	/// We keep a state/memory of each link that is not side any forest.
	/// if we encounter a link, we check its norm: if its norm is inside one tree, we ignore it; otherwise, we memorize it as a new tree.
	/// Note: a norm can be linked by two different divs; two traverse might reach it thru different paths, this may, as <see cref="nilnul.dev.Bak"/> name repo according to reaching path, give different cognoms.
	/// </summary>
	/// <see cref="nilnul.fs.folders_.isolated.Prjs"/> from <see cref="nilnul.dev._src_._LIB_"/>
	/// and
	/// <see cref="nilnul.dev.Bak"/>, where we ignore links where its norm has been processed.
	class INonbacktrack
	{
	}
}
