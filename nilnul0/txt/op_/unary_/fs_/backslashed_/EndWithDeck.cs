namespace nilnul.txt.op_.unary_.fs_.backslashed_
{
	public class EndWithDeck : nilnul.txt.op_.UnaryI
	{


		public string op(string par)
		{
			if (nilnul.txt.be_.fs_.endWithDeck.Anto.Singleton.be(par))
			{
				return $"{par}\\";
			}
			return par;
		}


		static public EndWithDeck Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<EndWithDeck>.Instance;
			}
		}


	}
}
