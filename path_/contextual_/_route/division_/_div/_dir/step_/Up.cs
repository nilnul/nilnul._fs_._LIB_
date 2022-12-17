using nilnul.fs._address.div.co._relPath._ret_;

namespace nilnul.fs.path_.division_._div._dir.step_
{
	/// <summary>
	/// </summary>
	public class Up : IStep
	{
		public override string ToString()
		{
			return $"..";
			//return $".{_address._route_._SeparatorX.AsChar}";
		}


		static public Up Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Up>.Instance;
			}
		}

	}



}
