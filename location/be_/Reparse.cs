namespace nilnul.fs.file.be_
{
	/// <summary>
	/// </summary>
	public class Reparse
	{


	}
	/*
	Symbolic Links, Junction Points, and Mount Points, collectively known as Reparse Points, were introduced into NTFS at version 5 (or version 3, depending on what you read), and are thus present in Windows operating systems from 2000 onwards. However, they did not really impinge on the public consciousness until Vista arrived, when Microsoft, in their wisdom, decided to move or rename all the 'special' folders, such as My Documents (which no one really understood the need for anyway), and then, just to maximise confusion, to provide "shortcuts" to these directories under the original names. Upon closer inspection, however, these "shortcuts" are not shortcuts, but Reparse Points (I will look at the difference between the two later).

	Reparse Points are basically redirections, very similar in function to the shortcuts we are familiar with. However, while shortcuts are, in fact, quite normal files (with a .LNK extension) and are handled by the operating system, Reparse Points are implemented at a lower level by the file system (NTFS) itself.

	There is another big difference as well, shortcuts are quite "intelligent" in that if the target of a shortcut moves (for example, where it is on a remote drive which changes its drive letter), Windows can often track the change and update the shortcut file "on the fly". Nothing like this happens with Reparse Points - they specify a target path, but have no knowledge of whether that path exits, or even whether it is a well-formed Windows path.

	There are four flavours of Reparse Points that I know of - Symbolic Links, Junction Points, Mount Points, and Remote Storage Servers. I am going to concentrate on Symbolic Links and Junction Points, with a glance at Mount Points. About Remote Storage Servers, I'm afraid I know nothing.

	Now, according to various web articles, Symbolic Links store relative paths, while Junctions use absolute paths. This is not true. 
	Symbolic Links basically store whatever string you put into them; it is up to whoever decodes them to decide if the target is relative, absolute, or just garbage. Junction Points are slightly different in that they always return an absolute path, which, as far as I can tell, is worked out when the Junction Point is created. Nevertheless

	Reparse points provide another way of creating links. If a file or a directory has a reparse point attached, the system calls a file system filter, indicated by the reparse point tag. The filter may implement any method of accessing the actual data, including quite complicated ones. HSM (Hierarchical Storage Management) is a good example how useful reparse points can be. 

Unfortunately, although we can link to directories using the reparse points mechanism (such links are called junctions), there is no way of linking to files short of writing a custom file system filter driver. Even if using reparse points is a natural way of implementing soft links, the gain is hardly worth the pain. 

However reparse points are not all that useless for our purpose: junctions can supplement NTFS file-only hard links. Just keep in mind that they are, in fact, soft links, and if you move or delete the referred directory, the junction will point to nowhere. On the other hand, being a soft link, a junction is not limited to objects residing on the same drive; it can point to a directory on a different drive, or even to the drive itself (although a junction is not allowed to point to a mapped network object). 

	A file or directory can contain a reparse point, which is a collection of user-defined data. The format of this data is understood by the application which stores the data, and a file system filter, which you install to interpret the data and process the file. When an application sets a reparse point, it stores this data, plus a reparse tag, which uniquely identifies the data it is storing. When the file system opens a file with a reparse point, it attempts to find the file system filter associated with the data format identified by the reparse tag. If a file system filter is found, the filter processes the file as directed by the reparse data. If a file system filter is not found, the file open operation fails.

For example, reparse points are used to implement NTFS file system links and the Microsoft Remote Storage Server (RSS). RSS uses an administrator-defined set of rules to move infrequently used files to long term storage, such as tape or optical media. It uses reparse points to store information about the file in the file system. This information is stored in a stub file that contains a reparse point whose data points to the device where the actual file is now located. The file system filter can use this information to retrieve the file.

	•Reparse points can be established for a directory, but the directory must be empty. Otherwise, the NTFS file system fails to establish the reparse point. In addition, you cannot create directories or files in a directory that contains a reparse point.
•Reparse points and extended attributes are mutually exclusive. The NTFS file system cannot create a reparse point when the file contains extended attributes, and it cannot create extended attributes on a file that contains a reparse point.
•Reparse point data, including the tag and optional GUID, cannot exceed 16 kilobytes. Setting a reparse point fails if the amount of data to be placed in the reparse point exceeds this limit.
•There is a limit of 63 reparse points on any given path. 
Windows Server 2003 and Windows XP:  There is a limit of 31 reparse points on any given path.




	*/
}
