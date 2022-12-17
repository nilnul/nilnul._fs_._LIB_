using nilnul.fs._address.div.co._relPath._ret_;

namespace nilnul.fs.path_.division_._div._dir.step_
{
	/// <summary>
	/// alias:
	///		self
	/// </summary>
	public class Self : IStep
	{
		public override string ToString()
		{
			return $".";
			//return $".{_address._route_._SeparatorX.AsChar}";
		}


		//public  string ToTxtUsingSlash()
		//{
		//	return $".";
		//}


		static public Self Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Self>.Instance;
			}
		}

	}



}
