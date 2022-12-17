namespace nilnul.fs.address.be_
{
	/// <summary>
	///  it referes to a file.
	/// </summary>
	public class File :
		BeA,
		BeI
		,
		BeI1
	{
		public override bool be(AddressI obj)
		{
			return be_.shield.Anto.Singleton.be(obj) &&
				System.IO.File.Exists(obj.ToString())
			;
		}

		public bool be(AddressI1 obj)
		{
			return be_.shield.Anto1.Singleton.be(obj) &&
				System.IO.File.Exists(obj.ToString())
			;

		}

		static public File Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<File>.Instance;
			}
		}
	}
	
}
