using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder.dnt_.cfg_
{
	/// <summary>
	/// where nilnul to store configuration.
	/// the info can be store to <see cref="doc_.nilnulCfg"/> or <see cref="dir_.cfg"/>, or both if we can merge them (doc is the basic; if it is not enough, the dir is created).
	/// </summary>
	/// <remarks>
	/// if we already have a doc named ".nilnul", then creation of dir of same name would fail. To solve this, we can
	///		-) name the dir as ".nilnul0"
	///		-) rename the doc as ".nilnul0", or "nilnul.ini"; and the doc's content is still merged and takes effect.
	/// </remarks>
	/// 
	class INn:ICfg
	{
	}
}
