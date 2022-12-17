namespace nilnul.fs.address_.folderable
{
	static public class _EnsureX
	{
		static public void Ensure(string address)
		{
			System.IO.Directory.CreateDirectory(address);
		}
		static public void Ensure(nilnul.fs.AddressI address)
		{
			Ensure(address.ToString());
		}


	}
}
