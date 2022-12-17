namespace nilnul.fs.file_.ext_
{
	public class Doc : nilnul.fs.file.be_.ext_.doc.vow.En

	{
		public Doc(FileI val) : base(val)
		{
		}

		public Doc(string address) : this(new nilnul.fs.File(address))
		{

		}
	}
}
