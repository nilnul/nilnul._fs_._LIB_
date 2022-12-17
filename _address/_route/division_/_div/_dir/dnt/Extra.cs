namespace nilnul.fs._address._dst.denote
{
	class Extra
	{
		/*Alternate Data Streams (ADS) on Windows 2000/XP with NTFS file systems. ADS is a way of storing meta-information for files without actually storing the information in the file it belongs to, carried over from early MacOS compatibility from Windows NT4. Recently browser hijackers began using this technique to store hidden information on the system, and even store trojan executable files in ADS streams of random files on the system. Use with caution. */
		/*As one of the other answers mentioned, the colon is used to designate an alternate data stream. Somehow, the encryptable ADS got saved as it's own file rather than an ADS attached to Thumbs.db    :
		 * 
		  Thumbs.db:encryptable 

The colon isn't a legal character in a file name, but using the \\?\ prefix tells the file sytem, "No, really. I mean a file with a colon in the name." It works on extra long file names, and trailing spaces, and other weird file names.
 and use the \\?\ prefix on the file name.
For example:
del "\\?\D:\My Documents\My Pictures\My Photos Christmas\Thumbs.db:encryptable"
 */
		/*I just ran CHKDSK and it removed them as the filename is invalid...*/
	}
}
