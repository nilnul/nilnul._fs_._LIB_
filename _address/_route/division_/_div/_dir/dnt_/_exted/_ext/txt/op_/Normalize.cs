namespace nilnul.fs._address._route.division_._div._dir.dnt_._exted._ext.txt.op_.unary_
{
	public class PrependDotIfNeed : nilnul.txt.op_.UnaryI
	{
		public string op(string par)
		{
			if (par == "")
			{
				return par;
			}
			if (par.StartsWith("."))
			{
				return par;
			}
			return $".{par}";
			//throw new NotImplementedException();
		}

		static public PrependDotIfNeed Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<PrependDotIfNeed>.Instance;
			}
		}

	}
}
