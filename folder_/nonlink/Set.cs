using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;

namespace nilnul.fs.folder_.nonlink
{
	public class Set : nilnul.obj.Set<nilnul.fs.folder_.Normal, nilnul.fs.folder_.nonlink.Eq>
	{
		public Set()
		{
		}

		public Set(params Normal[] vars) : base(vars)
		{
		}

		public Set(IEnumerable<Normal> elements) : base(elements)
		{
		}

		static public Set FroAddresses(IEnumerable<string> addresses)
		{
			return new Set(
				addresses.Select(x => Normal.FroAddress(x))
			);
		}

		static public Set FroAddresses(StringCollection addresses)
		{
			return FroAddresses(
				nilnul.txt.seq_._StringCollectionX.Seq(addresses)
			);
		}



	}
}
