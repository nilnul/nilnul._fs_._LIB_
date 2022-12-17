namespace nilnul.fs.location_.link_
{
	/*Junctions
A junction (also called a soft link) differs from a hard link in that the storage objects it references are separate directories, and a junction can link directories located on different local volumes on the same computer. Otherwise, junctions operate identically to hard links. Junctions are implemented through reparse points.

Assuming the same conditions in the Hard Links section, the following references are permitted as junctions:

C:\dira linked to C:\dirb\dirc
C:\dirx linked to D:\diry
The following are not:

C:\dira\one.txt linked to C:\dirb\two.txt
C:\dir1 linked to Z:\dir2*/

	class _JunctionX
	{
	}


}
