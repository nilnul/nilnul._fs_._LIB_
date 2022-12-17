using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.address_._element_._path_.doc_._dotted
{
	/// <summary>
	/// </summary>
	public class Main
	{
		static public char[] chars2exclude = System.IO.Path.GetInvalidPathChars();

		string  _name;

		public string name {
			get {
				return _name;
			}
		}

		

		public Main(string name)
		{

			new nilnul.txt.be_.Exclude.Avow(chars2exclude).avow(
				name
			);
			//cannot be ".", "..",...



			nilnul.obj.aver_.False.Aver(
				IsStartedAllDots(name)
			);

			this._name = name;


		}

		static public bool IsStartedAllDots(string name)
		{
			return name.Length > 0 && name.All(x => x == '.');
		}

		public override string ToString()
		{
			return this.name;
		}


	}
}
