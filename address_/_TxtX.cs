namespace nilnul.fs.address_
{
	public class _TxtX
	{
		static public nilnul.fs.AddressI By(string address)
		{
#pragma warning disable CS0618 // 'Address' is obsolete: 'this shall be abstract'
			return nilnul.fs.Address.Parse(address);
#pragma warning restore CS0618 // 'Address' is obsolete: 'this shall be abstract'
		}
	}
}
