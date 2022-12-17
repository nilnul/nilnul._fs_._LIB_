using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.file.blob_.txt_.lines
{
	static public class _AsSeqX
	{
		static public IEnumerable<string> AsSeq(string address) {
			using (var reader=new  StreamReader(address) )
			{
				while (!reader.EndOfStream)
				{
					yield return reader.ReadLine();

				}
			}
		}

		static public IEnumerable<string> NoWhite(string address) {
			return AsSeq(address).Where(x => nilnul.txt.be_.white.Anto.Singleton.be(x));
		}

		static public IEnumerable<string> NoWhite_Trim(string address) {
			return NoWhite(address).Select(x=>x.Trim());
		}


	}
}
