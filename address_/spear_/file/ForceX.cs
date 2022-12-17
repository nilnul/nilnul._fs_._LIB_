namespace nilnul.fs.address_.spear_.exist
{
	/// <summary>
	/// if it's non exist create one with the given content; if it's existant, keep it intact
	/// </summary>
	public class _ForceX
	{

		public static void _Force(nilnul.fs.address_.SpearI targetAddress, string content)
		{
			System.IO.Directory.CreateDirectory(nilnul.fs.address_.spear._ContainerX.Shield(targetAddress).ToString());
			System.IO.File.WriteAllText(targetAddress.ToString(), content);
		}

		public static void _Force(string targetAddress, string content)
		{
			_Force(new nilnul.fs.address_.Spear(targetAddress), content);
		}




	}
}