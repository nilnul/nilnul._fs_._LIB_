namespace nilnul.fs.address_.spear.be_
{
	static public class _FileX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="obj"></param>
		/// <returns></returns>
		static public bool _Be(string obj)
		{
			///this throws exception if the path is too long
			/// however, we can remove this constraint by setting registry key
			/// 
			/*Home Edition doesn’t have Group Policy Editor. Is there some other way to the the same?

	JeremyKuhne
	August 8, 2016 at 5:54 pm
	You can set the registry key directly. It’s “\Computer\HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\FileSystem\” with the “LongPathsEnabled” DWORD value set to 1.*/

			return System.IO.File.Exists(obj);
		}


	}

	
}
