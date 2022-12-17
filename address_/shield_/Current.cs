using System;

namespace nilnul.fs.address_.shield_
{
	/// <summary>
	/// Gets the current working directory of the application.
	/// The current directory is distinct from the original directory, which is the one from which the process was started.
	/// </summary>
	public class _CurrentX
	{

		static public string Address()
		{
			return System.IO.Directory.GetCurrentDirectory();
		}

		/// <summary>
		/// </summary>
		/// <param name="address"></param>
		static public string Address_byEnv
		{
			/*By definition, if this process starts in the root directory of a local or network drive, the value of this property is the drive name followed by a trailing slash (for example, "C:\"). If this process starts in a subdirectory, the value of this property is the drive and subdirectory path, without a trailing slash (for example, "C:\mySubDirectory").*/
			get
			{
				return Environment.CurrentDirectory;

			}
			set
			{
				Environment.CurrentDirectory = value;

			}


		}


	}
}
