namespace nilnul.txt.op_.unary_.fs_
{
	public class Backslashed : nilnul.txt.op_.UnaryI
	{


		public string op(string par)
		{
			return par.Replace('/','\\');

		}


		static public Backslashed Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Backslashed>.Instance;
			}
		}


	}
}
