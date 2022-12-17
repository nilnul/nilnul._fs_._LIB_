namespace nilnul.fs.address_.shield.be_
{
	/// <summary>
	/// </summary>
	public class Root
		: nilnul.fs.address_.shield.BeI1
	{
		public bool be(ShieldI obj)
		{

			return nilnul.fs._address.route_.stem.be_.Rt.Singleton.be(obj.stem);

			//throw new NotImplementedException();
		}


		public bool be_ofAddress(string obj)
		{
			return be(nilnul.fs.address_.Shield.FroAddress(obj));
		}



		static public Root Singleton
		{
			get
			{
#pragma warning disable CS0612 // 'Singleton<Root>' is obsolete
				return nilnul._obj.Singleton<Root>.Instance;
#pragma warning restore CS0612 // 'Singleton<Root>' is obsolete
			}
		}



	}
}
