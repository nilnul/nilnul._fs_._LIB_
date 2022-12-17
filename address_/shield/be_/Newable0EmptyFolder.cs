namespace nilnul.fs.address_.shield.be_
{
	/// <summary>
	/// the spear is not occumpied by file, nor fold. It can be created
	/// </summary>
	public class Newable0EmptyFolder
		: nilnul.fs.address_.shield.BeI1
	{
		public bool be(ShieldI obj)
		{

			return shield.be_.Newable.Singleton.be(obj) || shield.be_.folder_.Empty.Singleton.be(obj);

		}


		public bool be_ofAddress(string obj)
		{
			return be(nilnul.fs.address_.Shield.FroAddress(obj));
		}



		static public Newable0EmptyFolder Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Newable0EmptyFolder>.Instance;
			}
		}



	}
}
