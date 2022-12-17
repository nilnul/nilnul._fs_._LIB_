using System;

namespace nilnul.fs.folder.nulable
{
	static public class _ParseX
	{
		static public nilnul.fs.FolderI Parse(string x)
		{
			try
			{
				return nilnul.fs.Folder.FroAddress(x);
			}
			catch (Exception)
			{
				return null;
			}
		}

		static public nilnul.fs.FolderI Ov(nilnul.fs.address_.ShieldI x)
		{
			if (nilnul.fs.address_.shield.be_.Folder.Singleton.be(x))
			{
				return new nilnul.fs.Folder(x);
			}
			else
			{
				return null;
			}
		}

	}
}
