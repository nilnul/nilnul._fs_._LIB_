using System.Linq;

namespace nilnul.fs._address.div
{
	/// <summary>
	/// used for the tip name of FsInfo
	/// </summary>
	static public class _LocalNameX
	{
		/// <summary>
		/// empty if no tip
		/// </summary>
		/// <param name="div"></param>
		/// <returns></returns>
		static public string Name(this DivI div) => div.dirs.Any() ? div.dirs.Last().ToString() : "";

	}
}
