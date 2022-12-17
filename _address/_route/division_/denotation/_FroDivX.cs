using System.Linq;

namespace nilnul.fs._address.document_
{
	static public class _DivX
	{
		public static DenotesCappedDoc Cooerce(DivI div)
		{
			return new DenotesCappedDoc(
				div.dirs.Take(div.dirs.Count() - 1).Select(x => (x.denote))
				,
				new nilnul.fs._address.Doc(div.dirs.Last().denote)
			);
		}
	}
}
