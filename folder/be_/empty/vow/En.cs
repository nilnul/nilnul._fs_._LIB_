namespace nilnul.fs.folder.be_.empty.vow
{
	public class Ee : nilnul.fs.folder.vow.ee_.VowDefault<Vow>
	{
		public Ee(FolderI val) : base(val)
		{

		}

		public Ee(nilnul.fs.address_.ShieldI val) : this(new nilnul.fs.Folder(val))
		{

		}


		static public Ee FroShield(string name)
		{
			return new Ee(
				nilnul.fs.Folder.FroShield(name)
			);
		}
		static public Ee FroAddress(string name)
		{
			return new Ee(
				nilnul.fs.address_.shield_._AddressX1.Create(name)
			);
		}



	}
}
