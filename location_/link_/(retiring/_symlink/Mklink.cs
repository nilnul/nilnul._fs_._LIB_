using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs._symlink
{
	/*
	 Without any extra options, mklink creates a symbolic link to a file. The below command creates a symbolic, or “soft”, link at Link pointing to the file Target :
mklink Link Target

Use /D when you want to create a soft link pointing to a directory. like so:
mklink /D Link Target

Use /H when you want to create a hard link pointing to a file:
mklink /H Link Target

Use /J to create a hard link pointing to a directory, also known as a directory junction:
mklink /J Link Target



So, for example, if you wanted to create a hard link at C:\LinkToFolder that pointed to C:\Users\Name\OriginalFolder, you’d run the following command:
mklink /J C:\LinkToFolder C:\Users\Name\OriginalFolder

You’ll need to put quotation marks around paths with spaces. For example, if the folders are instead named C:\Link To Folder and C:\Users\Name\Original Folder, you’d use the following command instead:
mklink /J "C:\Link To Folder" "C:\Users\Name\Original Folder"



If you see the message “You do not have sufficient privilege to perform this operation.”, you need to launch the Command Prompt as Administrator before running the command.

		 */
	public class Mklink
	{

	}
}
