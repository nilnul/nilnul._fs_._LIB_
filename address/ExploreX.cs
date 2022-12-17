namespace nilnul.fs.address
{
	static public class _ExploreX
	{
		static public void Sel(nilnul.fs.AddressI address)
		{
			var parsed = nilnul.fs.location_.File0FolderA.Parse(address);
			if (parsed==null)
			{
				return;
			};
			nilnul.fs.location_.file0Folder._ExploreX.Sel(parsed);
		}
		static public void Sel(string address)
		{
			Sel(nilnul.fs.AddressA.Parse(address));
		}

	}
}
