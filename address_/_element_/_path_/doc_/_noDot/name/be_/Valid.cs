using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.address_._element_._path_.doc_._noDot.name.be_
{
	/*extern alias obj;*/
	public class Valid :

		/*obj::*/nilnul.obj.BeI1<string>
	{
		static public IEnumerable<char> chars2exclude = System.IO.Path.GetInvalidPathChars().Concat(new[] { '.' });

		static public nilnul.txt.be_.Exclude Excluded = new txt.be_.Exclude(chars2exclude);

		public bool be(string obj)
		{
			return Excluded.be(obj);


			//throw new NotImplementedException();
		}

		static private Lazy<Valid> _Lazy = new Lazy<Valid>();
		static public Valid Lazy
		{
			get
			{
				return _Lazy.Value;
			}
		}

		public class Aver:nilnul.obj.be.Aver<string,Valid>
		{

			static private Lazy<Aver> _Lazy = new Lazy<Aver>();
			static public Aver Lazy
			{
				get
				{
					return _Lazy.Value;
				}
			}


		}

	}
}
