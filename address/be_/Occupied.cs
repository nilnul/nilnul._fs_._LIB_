namespace nilnul.fs.address.be_
{
	/// <summary>
	///  occupied by a file or folder. it is used.
	/// </summary>
	public class Occupied
		:
		
		nilnul.fs.address.BeA
	{

		static public Occupied Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Occupied>.Instance;
			}
		}

		public override bool be(AddressI obj)
		{
			var shrunk = nilnul.fs.address.op_.unary_.Shrink.Op(obj);

			return nilnul.fs.address.be_.Location.Singleton.be(shrunk);


		}
	}
}
