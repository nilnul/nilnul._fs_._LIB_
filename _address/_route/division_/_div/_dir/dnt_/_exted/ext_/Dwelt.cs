namespace nilnul.fs._address._route.division_._div._dir.dnt_._exted.ext_
{

	/*see OvAftDot*/

	/// <summary>
	/// the ext is dot led.
	/// after the dot, no dot is allowed. so this excludes multiple exts, as we allow dot in main such as "nilnul.fs._git_" and allowing multiple dots in ext would make the dot in main mistaken as the dot leading an ext
	/// "." is a special ext. but generally Os doesnot allow this.
	/// </summary>
	/// <remarks>
	/// alias:
	///		dotLed
	/// </remarks>
	public interface INonempty {

	}

	public interface NonemptyI:INonempty, ExtI { }
}
