using nilnul.fs.address_;
using System;

namespace nilnul.fs.address.phrase_
{
	/*Enabling Win32 Long Path Support
Long paths aren't enabled by default*/
	/// <summary>
	/// https://blogs.msdn.microsoft.com/bclteam/2007/02/13/long-paths-in-net-part-1-of-3-kim-hamilton/
	/// </summary>
	static public class _OverlongX
	{
		public const long MAX_LENGTH = 260;

		public const string Prefix = @"\\?\";


		static public string Prepend(string x)
		{

			return Prefix + x;

		}

		static public string PrependIfNeed(string x)
		{/*The Unicode versions of several functions permit a maximum path length of approximately 32,000 characters composed of components up to 255 characters in length. */
			if (x.Length>= MAX_LENGTH)
			{
				return Prepend(x);

			}
			return x;


		}

		public static string PrependIfNeed(ShieldI path)
		{
			return PrependIfNeed(path.ToString());
		}

		public static string PrependIfNeed(nilnul.fs.AddressI path)
		{
			return PrependIfNeed(path.ToString());
		}

		public static string PrependIfNeed(nilnul.fs.IAddress path)
		{
			return PrependIfNeed(path.ToString());
		}



	}
	/*For file I/O, the "\\?\" prefix to a path string tells the Windows APIs to disable all string parsing and to send the string that follows it straight to the file system. For example, if the file system supports large paths and file names, you can exceed the MAX_PATH limits that are otherwise enforced by the Windows APIs. For more information about the normal maximum path limitation, see the previous section Maximum Path Length Limitation.

Because it turns off automatic expansion of the path string, the "\\?\" prefix also allows the use of ".." and "." in the path names, which can be useful if you are attempting to perform operations on a file with these otherwise reserved relative path specifiers as part of the fully qualified path.

Many but not all file I/O APIs support "\\?\"; you should look at the reference topic for each API to be sure.

Win32 Device Namespaces
The "\\.\" prefix will access the Win32 device namespace instead of the Win32 file namespace. This is how access to physical disks and volumes is accomplished directly, without going through the file system, if the API supports this type of access. You can access many devices other than disks this way (using the CreateFile and DefineDosDevice functions, for example).

For example, if you want to open the system's serial communications port 1, you can use "COM1" in the call to the CreateFile function. This works because COM1–COM9 are part of the reserved names in the NT namespace, although using the "\\.\" prefix will also work with these device names. By comparison, if you have a 100 port serial expansion board installed and want to open COM56, you cannot open it using "COM56" because there is no predefined NT namespace for COM56. You will need to open it using "\\.\COM56" because "\\.\" goes directly to the device namespace without attempting to locate a predefined alias.

Another example of using the Win32 device namespace is using the CreateFile function with "\\.\PhysicalDiskX" (where X is a valid integer value) or "\\.\CdRomX". This allows you to access those devices directly, bypassing the file system. This works because these device names are created by the system as these devices are enumerated, and some drivers will also create other aliases in the system. For example, the device driver that implements the name "C:\" has its own namespace that also happens to be the file system.

APIs that go through the CreateFile function generally work with the "\\.\" prefix because CreateFile is the function used to open both files and devices, depending on the parameters you use.

If you're working with Windows API functions, you should use the "\\.\" prefix to access devices only and not files.

Most APIs won't support "\\.\"; only those that are designed to work with the device namespace will recognize it. Always check the reference topic for each API to be sure.

NT Namespaces
There are also APIs that allow the use of the NT namespace convention, but the Windows Object Manager makes that unnecessary in most cases. To illustrate, it is useful to browse the Windows namespaces in the system object browser using the Windows Sysinternals WinObj tool. When you run this tool, what you see is the NT namespace beginning at the root, or "\". The subfolder called "Global??" is where the Win32 namespace resides. Named device objects reside in the NT namespace within the "Device" subdirectory. Here you may also find Serial0 and Serial1, the device objects representing the first two COM ports if present on your system. A device object representing a volume would be something like "HarddiskVolume1", although the numeric suffix may vary. The name "DR0" under subdirectory "Harddisk0" is an example of the device object representing a disk, and so on.

To make these device objects accessible by Windows applications, the device drivers create a symbolic link (symlink) in the Win32 namespace, "Global??", to their respective device objects. For example, COM0 and COM1 under the "Global??" subdirectory are simply symlinks to Serial0 and Serial1, "C:" is a symlink to HarddiskVolume1, "Physicaldrive0" is a symlink to DR0, and so on. Without a symlink, a specified device "Xxx" will not be available to any Windows application using Win32 namespace conventions as described previously. However, a handle could be opened to that device using any APIs that support the NT namespace absolute path of the format "\Device\Xxx".

With the addition of multi-user support via Terminal Services and virtual machines, it has further become necessary to virtualize the system-wide root device within the Win32 namespace. This was accomplished by adding the symlink named "GLOBALROOT" to the Win32 namespace, which you can see in the "Global??" subdirectory of the WinObj browser tool previously discussed, and can access via the path "\\?\GLOBALROOT". This prefix ensures that the path following it looks in the true root path of the system object manager and not a session-dependent path.*/
}
