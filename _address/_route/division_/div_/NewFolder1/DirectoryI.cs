using System;

namespace nilnul.fs._address
{
	[Obsolete()]
	public interface IDirectory
		:IDestination,
		IDiv
	{

	}
	/// <summary>
	/// "a\", "a\b\"
	/// exclude:
	///		"", "a", "a\b"
	/// </summary>
	[Obsolete()]
	public interface DirectoryI : DestinationI, DivI, IDirectory
	{



	}

	[Obsolete()]
	static public class DirectoryIX
	{
		static public nilnul.fs._address.dir.str_.seq.Started Dirs(this DirectoryI directory)
		{
			switch (directory)
			{
				case Directory directory1:
					return directory1;
				default:
					return Directory.Parse(directory.ToString());
#pragma warning disable CS0162 // Unreachable code detected
					break;
#pragma warning restore CS0162 // Unreachable code detected
			}
		}

		static public nilnul.fs._address.DivI ToDiv(this DirectoryI directory)
		{
			switch (directory)
			{
				case Directory directory1:
					return directory1;
				default:
					return Directory.Parse(directory.ToString());
#pragma warning disable CS0162 // Unreachable code detected
					break;
#pragma warning restore CS0162 // Unreachable code detected
			}
		}

		static public DirectoryI Ov(DestinationI destination)
		{
			switch (DestinationA.Document0Directory(destination))
			{
				case DirectoryI directory:
					return directory;
				case DocumentI document:
					return Directory.Ov(document);
				default:
					throw new UnexpectedTypeException();
					break;
			}

		}

	}
}
