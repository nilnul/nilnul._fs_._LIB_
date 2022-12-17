namespace nilnul.fs.folder.dst_
{
	class HardLink
	{
	}
	/*
Hard links do not link paths on different volumes or file systems, 

	Every directory is itself a dst, only special because it contains a list of file names maintained by the file system. Since directories themselves are files, multiple hard links to directories are possible which would create loops within the structure of the directories, rather than a branching structure like a tree. For that reason, the creation of hard links to directories is sometimes forbidden, even if possible.

	To prevent loops in the filesystem, and to keep the interpretation of .. (parent directory) consistent, many modern operating systems do not allow hard links to directories. UNIX System V allowed them, but only the superuser had permission to make such links.[6] Mac OS X v10.5 (Leopard) and newer use hard links on directories for the Time Machine backup mechanism only. Symbolic links and NTFS junction points are generally used instead for this purpose.

	Hard links can be created to files only on the same volume. If a link to a file on a different volume is needed, it may be created with a symbolic link.

	Hard links always refer to an existing file, whereas symbolic links may contain an arbitrary path that does not point to anything.
	 */
}
