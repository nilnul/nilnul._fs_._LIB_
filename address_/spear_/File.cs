namespace nilnul.fs.address_.spear_
{
	public class File : nilnul.fs.address_.spear.be_.file.vow.En, _location_.BlankI
	{
		public File(SpearI val) : base(val)
		{
		}

		public File(Spear address) : this((SpearI)address)
		{
		}

		public File(string address) : this(new Spear(address))
		{
		}
	}
}
