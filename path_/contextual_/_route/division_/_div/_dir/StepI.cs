
namespace nilnul.fs.path_.division_._div._dir
{
	/// <summary>
	/// subtype is:
	///		up
	///		self
	///		dnt
	/// </summary>
	public interface IStep {

	}
	/// <summary>
	/// containing no DirSep. rather, dirSep is used to delimit steps
	/// </summary>
	static public class StepX
	{
		static public IStep Parse(string s) {
			if (s=="..")
			{
				return  step_.Up.Singleton;
			}
			if (s==".")
			{
				return step_.Self.Singleton;
			}
			return new _address.Dnt(s);
		}

		

	}



}
