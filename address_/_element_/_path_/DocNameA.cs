using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.address_._element_._path_
{
	/// <summary>
	/// example：
	///		.git
	///		abc.  //maybe this should be outlawed?
	///		a
	///		a.b
	///
	/// </summary>
	/// 
	[Obsolete(nameof(_address.DocNameA))]
	public abstract class DocA : DocI
	{

		public const char DOT = '.';
		public abstract string ext { get; }
		public abstract string main { get; }

		static public DocI Parse(string s) {

			var lastDot = s.LastIndexOf(DocA.DOT);

			if (lastDot < 0)
			{
				return doc_.NoDot.Parse(s);
				//throw new ArgumentException();
			}
			else
			{

				return doc_.Dotted.Parse(
					s.Substring(0, lastDot)
					,
					s.Substring(lastDot+1)  ///per doc, 如果 startIndex 等于此实例的长度，则为 Empty。

				);
			}
		}

		
	}
}
