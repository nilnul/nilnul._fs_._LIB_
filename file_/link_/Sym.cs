using nilnul.fs.address_;
using nilnul.fs.address_.spear.be_.file.vow;
using nilnul.fs.address_.spear_;

namespace nilnul.fs.file_.link_
{
	/// <summary>
	/// 
	/// </summary>
	public class Sym
	   : nilnul.fs.file.be.En<nilnul.fs.file.be_.link_.Sym>
		,
		FileI

	{
		public Sym(FileI val) : base(val)
		{
		}

		public Sym(SpearI spear) : base(spear)
		{
		}

		public Sym(string spear) : base(spear)
		{
		}

		public En file => this.ee.file;

		public string target {
			get {
				return nilnul.fs.location_.link_._sym_.SymbolicLink.GetTarget(ToString());
			}
		}

		public override string ToString()
		{
			return this.file.ToString();
		}
	}
}
