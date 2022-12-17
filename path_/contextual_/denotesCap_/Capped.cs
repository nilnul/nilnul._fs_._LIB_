using nilnul.fs._address._dst.denote.str_.seq;
using System.Collections.Generic;
using System.Linq;

namespace nilnul.fs._address._dst.denote.str.join
{
	/// <summary>
	/// appending a "/" (or "\" according to OS dir separator) to denote.str.JoinI
	/// eg:
	///		/
	///		a/
	///		a/b/
	///		a/b/c/
	///		
	/// </summary>
	/// <remarks>
	/// <see cref="nameof(_address.Division0RouteX)"/>
	/// </remarks>
	public class Capped
		: nilnul.obj.Box<
			nilnul.fs._address._dst.denote.str_.seq.Join
		>
	{
		public Capped(Join val) : base(val)
		{
		}

		public Capped(IEnumerable<Denote> join) : this(new Join(join))
		{
		}

		public Capped(DivisionI x):this( new Join(x))
		{

		}

		public override string ToString()
		{
			return $"{boxed.ToString()}{System.IO.Path.DirectorySeparatorChar}";
		}
		static public Capped Parse(string s)
		{
			nilnul.character_.cha.vow_.fs_.DirSep.Singleton.vow(s.Last());
			var join = Join.Parse2Str(
			s.Substring(s.Length - 1));

			return new Capped(join);
		}
	}
}
