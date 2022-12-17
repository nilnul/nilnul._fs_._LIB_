namespace nilnul.fs.folder.be_.normal.vow
{
	public class En : nilnul.fs.folder.vow.En2<Vow>
	{
		public En(FolderI val) : base(val)
		{

		}

		public En(nilnul.fs.address_.ShieldI val) : this(new nilnul.fs.Folder(val))
		{

		}


		static public En FroShield(string name)
		{
			return new En(
				nilnul.fs.Folder.FroShield(name)
			);
		}
		static public En FroAddress(string name)
		{
			return new En(
				nilnul.fs.address_.shield_._AddressX1.Create(name)
			);
		}



	}
}
