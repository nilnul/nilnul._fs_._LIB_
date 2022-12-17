using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs._address
{
	/// <summary>
	/// </summary>
	/// 

		[Obsolete("doc_.Dir")]
	public class DirName
		:
		_dir.name.be_.Valid.En
		,
		DirNameI
	{
		static public char[] chars2exclude = System.IO.Path.GetInvalidPathChars();

		

	//	private string _name;

		public string name
		{
			get { return avowed; }
			//set { _name = value; }
		}

		

		public DirName(
			
			nilnul.txt.op_.trim.ed.be_.started.en_.WhiteTrimmedStarted name
			
			):this(name.avowed.processed)
		{
			


		}
		public DirName(

			string name

			):base(name)
		{
			/////cannot contain illegal chars.
			/////
			//new nilnul.txt.be_.Exclude.Avow(chars2exclude).avow(
			//	name
			//);
			////cannot be ".", "..",...

			//nilnul.obj.aver_.False.Aver(
			//	name.All(x => x == '.')
			//	,
			//	$"作为目录名，{name}不能全是\".\""
			//);

			//this._name = name;


		}

		public override string ToString()
		{
			return this.name;
		}


		public string toTxt_endWithBackslash() {
			return $"{this.name}{System.IO.Path.DirectorySeparatorChar}";
		}

		static public string ToTxt(nilnul.fs._address.DstI dst)
		{
			return $"{dst}{System.IO.Path.DirectorySeparatorChar}";
		}




	}
}
