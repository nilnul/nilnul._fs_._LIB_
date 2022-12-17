using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.address_._driveEntry
{
	/// <summary>
	/// "a\", "a\b\"
	/// exclude:
	///		"", "a", "a\b"
	/// </summary>
	public class Directory
	{

		private nilnul.fs._address.dsts_.Started _dsts;

		public nilnul.fs._address.dsts_.Started dsts
		{
			get { return _dsts; }
			set { _dsts = value; }
		}

		public Directory(nilnul.fs._address.dsts_.Started dsts)
		{
			_dsts = dsts;

		}

		static public Directory CreateFroDsts(string x) {
			return CreateFroDsts(
				nilnul.fs._address.dsts_.Started.Parse(x)
				
			);
		}

		static public Directory CreateFroDsts(IEnumerable< nilnul.fs._address.DstI> x) {
			return new Directory(
				 _address.dsts_.Started.CreateFroDsts(x)
			);
		}



		public override string ToString()
		{
			return nilnul.txts.accumulate_.Join.Singleton.accumulate(
				_dsts.Select(x=>x.ToString()+ System.IO.Path.PathSeparator)
			);
		}

		public static Directory Parse(string sTEM_since_Base)
		{
			var split = sTEM_since_Base.Split(nilnul.characters_.DirSeperator.Chars);
			nilnul.obj.vow_.True.Vow(split.Last()=="");

			return new Directory(
				 _address.dsts_.Started.CreateFroDsts(
					split.Take(split.Count()-1) 
				)
			);


			throw new NotImplementedException();
		}
	}
}
