using System;

namespace nilnul.fs._address.doc_._exted._ext.txt.op_
{
	[Obsolete()]
	public class Normalize : nilnul.txt.op_.UnaryI
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

		static public Normalize Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Normalize>.Instance;
			}
		}

	}
}
