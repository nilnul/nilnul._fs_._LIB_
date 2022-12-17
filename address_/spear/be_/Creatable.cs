namespace nilnul.fs.address_.spear.be_
{
	/// <summary>
	/// not occupied. niether file nor folder
	/// </summary>
	public class Newable
		: nilnul.fs.address_.spear.BeI
		,
		BeI1
	{
		public bool be(SpearI obj)
		{
			return !Occupied.Singleton.be(obj);
			//throw new NotImplementedException();
		}

		public bool be(SpearI1 obj)
		{
			return !Occupied.Singleton.be(obj);
		}



		static public Newable Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Newable>.Instance;
			}
		}





	}
}
