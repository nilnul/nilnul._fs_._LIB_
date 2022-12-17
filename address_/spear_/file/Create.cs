namespace nilnul.fs.address_.spear_.exist
{
	/// <summary>
	/// if it's non exist create one with the given content; if it's existant, keep it intact
	/// </summary>
	public class _CreateX
	{




		public static void Create(string targetAddress, string content)
		{
			nilnul.obj.vow_.False.Vow(System.IO.File.Exists(targetAddress), $"{targetAddress} already exists");
			_ForceX._Force(targetAddress, content);
		}






	}
}