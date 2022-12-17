namespace nilnul.fs.address.re_
{
	/// <summary>
	/// one including the other. disregard the ending slash.
	/// </summary>
	public class Sup : 
		re.Converse<Sub>
	{




		static public Sup Singleton
		{
			get
			{
				return nilnul._obj.Singleton<Sup>.Instance;
			}
		}


	}
}
