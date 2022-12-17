namespace nilnul.fs.address_.shield_.notOverlong.be_
{
	public class Folder
		: nilnul.fs.address_.shield.BeI1
	{
		public bool be(ShieldI obj)
		{
			return System.IO.Directory.Exists(obj.ToString());

			//throw new NotImplementedException();
		}
		public bool be(nilnul.fs.AddressI obj)
		{
			return be(nilnul.fs.address_.Shield.FroAddress(obj));
		}

		public bool be(string obj)
		{
			return be(nilnul.fs.address_.Shield.FroAddress(obj));
		}


		public bool be_ofAddress(string obj)
		{
			return be(nilnul.fs.address_.Shield.Parse(obj));
		}




		static public Folder Singleton
		{
			get
			{
#pragma warning disable CS0612 // 'Singleton<Folder>' is obsolete
				return nilnul._obj.Singleton<Folder>.Instance;
#pragma warning restore CS0612 // 'Singleton<Folder>' is obsolete
			}
		}



	}
}
