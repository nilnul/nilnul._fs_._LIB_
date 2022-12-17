namespace nilnul.fs.address_.spear_.exist
{
	/// <summary>
	/// if it's non exist create one with the given content; if it's existant, keep it intact
	/// </summary>
	public class _EnsureX
	{
		public static bool New(nilnul.fs.address_.SpearI element, string content)
		{
			if (!System.IO.File.Exists(element.ToString()))
			{
				_ForceX._Force(element, content);
				return true;
			}
			return false;
		}

		public static bool New(string targetAddress, string content)
		{
			return New(new nilnul.fs.address_.Spear(targetAddress), content);

		}

	}
}