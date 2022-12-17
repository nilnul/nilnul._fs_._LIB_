using nilnul.fs._address._dst_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs._address._route.division_._div._dir
{


	/// <summary>
	/// the name of a doc, or a dir without the ending dec(k).
	/// Here we avoid the use of the term "doc", as denote here can also be used to refer to dir (nondoc)
	/// </summary>
	/// <remarks>
	/// from Deck "/", we first grow a denote, say "a", which can be a doc, or, if capped with a "/" at the end, be a dir "a/".
	/// The difference between denote and doc is that in address, we use denote which is ambiguous denoation to either doc or dir whileas in location, denote is, being materialized, a doc or dir , or to be created doc or dir. So denote is not yet created doc0dir.
	/// </remarks>
	public interface IDnt : IDst
		//, _address.division.co._duct._pass.IStep
		,
		path_.division_._div._dir.IStep
	{
	}

	/// <summary>
	/// intend to be used as the doc, not dir, in a folder not recursively; But it can also convert to a dir by simply appending a slash sign.
	/// </summary>
	///the tier is too deep. maybe we can leave <see cref="IDnt"/> here at the deep tier, but move this to a shallow tier, for example, to <see cref="_address.DntI"/>

	public interface DntI : DstI, IDnt
	//,
	//_doc_.MainI
	//,_doc_.ExtI
	{


	}


}
