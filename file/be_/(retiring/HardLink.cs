using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.file.be_
{
	/// <summary>

	/// </summary>
	public class HardLink
	{
	}
	/*
	In truth, every filename is a hard link to the file content.Hard links are always linking names to content, symbolic links(which are themselves a form of content) are links to other names, that's the difference. – Ben Voigt Mar 21 '10 at 17:02 
 
 
@akappa: then if you delete FileA.txt what happens to FileB.txt? – v.oddou Jun 3 '14 at 9:53 
 
 
@v.oddou: nothing.Think of it as reference-counting garbage collection: the file is erased only when the number of hard-reference pointing to it is zero.When you delete FileA.txt, you are decrementing the reference count from 2 to 1, so nothing happens. – akappa Jun 3 '14 at 12:03 

@v.oddou: The concept of "deleting" a file is a bit tricky.You're not deleting the file so much as removing one of its names. Once a file has no name, the file itself is removed. – Gabe Jun 3 '14 at 15:29  

	Hard link uses the same MFT entry as the original file. Adding a hard link creates a new name attribute and increases the hard link count (for a newly created file this count equals to one). Deleting a hard link removes the appropriate name and decreases the hard link count. When the count goes to zero, the system deletes the file, freeing up its allocated disk space and releasing its MFT record. All the name attributes are independent, so deleting, moving, or renaming the file don't affect other hard links. 

	Because all the links must refer to the same MFT entry, you cannot create a hard link on a different drive. Another limitation is that only files can be hard-linked, not directories (however soft links to directories are allowed). 


	In order to delete a hard link, call the Windows API function DeleteFile, specifying the link path. The DeleteFile function removes the link and decreases the link count in the file's MFT record. If the link count becomes zero, the system deletes the file, that is frees its MFT entry and disk space. 

Note that there is no difference between the original file name and an additional hard link. Both are just pointers to the file's MFT entry. 

	*/
}
