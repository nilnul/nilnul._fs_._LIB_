using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs._address._doc
{
	/// <summary>
	/// </summary>
	/// 
	[Obsolete()]
	public class Ext
	{
		static public IEnumerable<char> chars2exclude = System.IO.Path.GetInvalidPathChars().Concat(new[] { '.' });

		/// <summary>
		/// nulable if a doc has no dot.
		/// empty if a doc has dot at the end
		/// 
		/// </summary>
		string _name;

		/// <summary>
		/// 
		/// </summary>
		public string name
		{
			get
			{
				return _name;
			}
		}

		public Ext(

			string name = null

			)
		{
			if (name== null)
			{
				return;
			}

			new nilnul.txt.be_.Exclude.Avow(chars2exclude).avow(
				name
			);

			this._name = name;

		}



		[Obsolete(nameof(asSuffix))]
		public override string ToString()
		{
			return asSuffix();
		}

		public string asSuffix() {
			return _name == null ? "" : $".{_name}";
		}

		[Obsolete()]
		static public implicit operator string(Ext ext)
		{
			return ext.asSuffix();
		}


	}
}
