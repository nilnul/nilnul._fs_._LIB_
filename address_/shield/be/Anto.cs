namespace nilnul.fs.address_.shield.be
{
	public class Anto<T> : nilnul.obj.be.Anto<ShieldI, T>
		, nilnul.fs.address_.shield.BeI1
		where T : nilnul.fs.address_.shield.BeI1, new()
	{


		static public Anto<T> Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Anto<T>>.Instance;
			}
		}


	}
}
