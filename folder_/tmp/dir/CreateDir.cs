namespace nilnul.fs.folder_.tmp.dir
{
	static public class _CreateX
	{

		static public string Address(string prefix)
		{
			var address = nilnul.fs.folder.denote_.Vered.OvAddress(System.IO.Path.GetTempPath()).getNextAddress(prefix);

			System.IO.Directory.CreateDirectory(
					address
			);

			return address;

		}


	}
}
