using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs._address.doc_
{
	/// <summary>
	/// </summary>
	/// 
	[Obsolete()]
	public class NoDot
		:
		DocNameA,
		DocNameI,DocI
	{
		static public IEnumerable<char> chars2exclude = System.IO.Path.GetInvalidPathChars().Concat(new[] { '.' });

 



		

		private string _name1;

		public string name1
		{
			get { return _name1; }
			set {
				_noDot.name.be_.Valid.Aver.Lazy.aver(value);

				_name1 = value; }
		}


		public override string main
		{
			get
			{
				return _name1;
				//throw new NotImplementedException();
			}
		}

		public override string ext
		{
			get
			{
				return "";
				//throw new NotImplementedException();
			}
		}

		 
		public NoDot(string s)
		{
			_noDot.name.be_.Valid.Aver.Lazy.aver(s);
			this._name1 = s;
		}

		public override string ToString()
		{
			return _name1;
		}

		static public NoDot Parse(string txt) {
			return new NoDot(txt);
		}

	}
}
