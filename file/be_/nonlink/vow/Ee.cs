namespace nilnul.fs.file.be_.nonlink.vow
{
	public class Ee : nilnul.fs.file.vow.ee_.VowDefault<Vow>
	{
		public Ee(FileI val) : base(val)
		{

		}

		public Ee(nilnul.fs.address_.SpearI val) : this(new nilnul.fs.File(val))
		{

		}



		public Ee(string name) : this(
			new nilnul.fs.address_.Spear(name)
		 )
		{

		}



	}
}
