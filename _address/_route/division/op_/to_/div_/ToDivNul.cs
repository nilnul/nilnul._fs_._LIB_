using System;

namespace nilnul.fs._address.division
{
	[Obsolete()]
	public class ToDivNul 
	{
		

		public nilnul.fs._address.Div _to_assumeDivOrDocument(DivisionI division)
		{
			if (division is _address.Div d) { return d; }

			return null;
			


		

		}


		public nilnul.fs._address.Div to(DivisionI division)
		{
			if (division is _address.Div d) { return d; }
			if (division is _address.Document)
			{
				return null;
			}


			return _to_assumeDivOrDocument(
					DivisionA.Parse(division.ToString())
			);

		}



	




		static public ToDivNul Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<ToDivNul>.Instance;
			}
		}

	}
}
