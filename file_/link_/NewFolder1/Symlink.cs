using nilnul.fs.address_;
using nilnul.fs.address_.spear_;
using System;

namespace nilnul.fs.file_
{
	/// <summary>
	/// 
	/// </summary>
	///
	[Obsolete(nameof(file_.link_._SymX))]
	static public class _SymlinkX
	{
		static public void Ensure(SpearI link, SpearI target)
		{
			if (nilnul.fs.address_.spear.be_.Newable.Singleton.be(link))
			{
				nilnul.fs.location_.link_.sym_.file.create_.ret_.success._ThrowIfFailX.Void(
					link.ToString()
					,
					target.ToString()
				);
			}
		}
		public static void Create(SpearI link, SpearI target)
		{
			//Create(new ShieldDoc1(link), target);
			nilnul.fs.location_.link_.sym_.file.create_.ret_.success._ThrowIfFailX.Void(
				link.ToString()
				,
				target.ToString()
			);

			//throw new NotImplementedException();
		}


		public static void Create(ParentDoc link, SpearI target)
		{
			Create((SpearI)link, target);

			//nilnul.fs.location_.link_.sym_.file.create_.ret_.success._ThrowIfFailX.Void(link.ToString(), target.ToString()
			//);
			//nilnul.fs.location_.link_.sym_.file.create_.ret_.success._ThrowIfFailX.Exe(link.ToString(), target.ToString()
			//);

			//throw new NotImplementedException();
		}

		public static void Create(nilnul.fs.address_.spear_.ParentDocument link, SpearI target)
		{
			nilnul.fs.location_.link_.sym_.file.create_.ret_.success._ThrowIfFailX.Void(link.ToString(), target.ToString()
			);
			//nilnul.fs.location_.link_.sym_.file.create_.ret_.success._ThrowIfFailX.Exe(link.ToString(), target.ToString()
			//);

			//throw new NotImplementedException();
		}





		public static void Create(
			nilnul.fs.address_.ShieldI linkShield
			,
			nilnul.fs._address.DocI linkDoc
			,
			nilnul.fs.address_.SpearI target
		)
		{

			Create(new ParentDoc(linkShield, linkDoc), target);
		}

		public static void OfLinkShieldAsAddress(
			string linkShield
			,
			string linkDoc
			,
			nilnul.fs.address_.SpearI target
		)
		{

			Create(ParentDoc.Create_ofContainerAsAddress(linkShield, linkDoc), target);
		}

		public static void OfLinkShieldAsAddress(
			string linkShield
			,
			string linkDoc
			,
			string target
		)
		{

			OfLinkShieldAsAddress(linkShield, linkDoc, nilnul.fs.address_.Spear.Parse(target));
		}


	}
	/*
In computing, a symbolic link (also symlink or soft link) is the nickname for any file that contains a reference to another file or directory in the form of an absolute or relative path and that affects pathname resolution.[1]

	A symbolic link contains a text string that is automatically interpreted and followed by the operating system as a path to another file or directory. This other file or directory is called the "target". The symbolic link is a second file that exists independently of its target. If a symbolic link is deleted, its target remains unaffected. If a symbolic link points to a target, and sometime later that target is moved, renamed or deleted, the symbolic link is not automatically updated or deleted, but continues to exist and still points to the old target, now a non-existing location or file. Symbolic links pointing to moved or non-existing targets are sometimes called broken, orphaned, dead, or dangling.

	This method was slow and an inefficient use of disk-space on small systems. An improvement, called fast symlinks, allowed storage of the target path within the data structures used for storing file information on disk (inodes). This space normally stores a list of disk block addresses allocated to a file. Thus, symlinks with short target paths are accessed quickly. Systems with fast symlinks often fall back to using the original method if the target path exceeds the available inode space. The original style is retroactively termed a slow symlink. It is also used for disk compatibility with other or older versions of operating systems.
	 */
}
