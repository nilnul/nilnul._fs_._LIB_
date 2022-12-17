using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.address_._element_._path_.doc_._dotted
{
	/// <summary>
	/// trimmed
	/// </summary>
	public class Ext
	{
		static public IEnumerable<char> chars2exclude = System.IO.Path.GetInvalidPathChars().Concat(new[] { '.' });

		string _name;

		public string  name {
			get {
				return _name;
			}
		}

		public Ext(

			string name

			)
		{
			///cannot contain illegal chars, or '.'
			///
			new nilnul.txt.be_.Exclude.Avow(chars2exclude).avow(
				name
			);
			

			this._name = name;


		}
		public override string ToString()
		{
			return _name;
		}


	}
}
