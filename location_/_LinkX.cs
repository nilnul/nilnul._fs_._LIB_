using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.location_
{
	/*There are three types of file links supported in the NTFS file system: hard links, junctions, and symbolic links. */
	/// <summary>
	/// 
	/// </summary>
	class _LinkX
	{
	}
}


/*
 Background
Symbolic Links, Junction Points, and Mount Points, collectively known as Reparse Points, were introduced into NTFS at version 5 (or version 3, depending on what you read), and are thus present in Windows operating systems from 2000 onwards. However, they did not really impinge on the public consciousness until Vista arrived, when Microsoft, in their wisdom, decided to move or rename all the 'special' folders, such as My Documents (which no one really understood the need for anyway), and then, just to maximise confusion, to provide "shortcuts" to these directories under the original names. Upon closer inspection, however, these "shortcuts" are not shortcuts, but Reparse Points (I will look at the difference between the two later).

Introduction
During the upgrade of an application to run under Vista (not an exercise for the faint-hearted!), it became necessary for me to take account of these peculiar entities, and I discovered that in order to implement the application properly, I needed a way to find the target of a Reparse Point. There is a certain amount of information on the web about Reparse Points, but a lot of it is confusing and contradictory. Nevertheless, I persevered and, in the process, discovered quite a few interesting facts about these elusive creatures. This article is the result of my explorations. I may have got a few things wrong, and, as we will see, there are certainly questions left unanswered. On either of these, I am happy to receive feedback.

The final result is a test program written in C# using .NET 2.0, which displays the directory hierarchy of the system, and shows the properties of all the reparse points.

Reparse Points - what are they?
Reparse Points are basically redirections, very similar in function to the shortcuts we are familiar with. However, while shortcuts are, in fact, quite normal files (with a .LNK extension) and are handled by the operating system, Reparse Points are implemented at a lower level by the file system (NTFS) itself.

There is another big difference as well, shortcuts are quite "intelligent" in that if the target of a shortcut moves (for example, where it is on a remote drive which changes its drive letter), Windows can often track the change and update the shortcut file "on the fly". Nothing like this happens with Reparse Points - they specify a target path, but have no knowledge of whether that path exits, or even whether it is a well-formed Windows path.

There are four flavours of Reparse Points that I know of - Symbolic Links, Junction Points, Mount Points, and Remote Storage Servers. I am going to concentrate on Symbolic Links and Junction Points, with a glance at Mount Points. About Remote Storage Servers, I'm afraid I know nothing.

Symbolic Links
The concept of a Symbolic Link will be familiar to Unix users. A Symbolic Link is a "shortcut" to a file or folder elsewhere on the system.

Junction Points
A Junction Point is very much like a Symbolic Link, except that it can only point to a folder, not to a file.

Mount Points
A Mount Point points to a disk volume. This allows an entire drive or partition to be addressed as if it were a folder on another drive. This allows a system to exceed the alphabetical limitation of 26 drives.

Reparse Points on Vista
Anyone who has taken the plunge and installed Vista will almost certainly have come across Reparse Points. The old favourite Documents and Settings, for example, is no longer a folder, but a Junction Point that points to the new folder c:\Users. Within C:\Users, we find that the default user folder is now called Default, but there is a Junction Point called Default User that points to it. Similarly, the All Users folder is now a Symbolic Link to a brand new folder way across the bay at C:\Program Data. Why one of these is a Junction Point and one is a Symbolic Link is a mystery to me.

We can see better what is going on here if we open a command prompt. Running DIR /? informs us that the /A parameter now has a new option /AL. This lists the Reparse Points, and if we run it in c:\Users, we see the following:

Hide   Copy Code
C:\Users>dir /al
Volume in drive C has no label.
Volume Serial Number is 8C6D-6991
Directory of C:\Users
02/11/2006 13:02 <symlinkd> All Users [C:\ProgramData]
02/11/2006 13:02 <junction> Default User [C:\Users\Default]
0 File(s) 0 bytes
2 Dir(s) 117,946,601,472 bytes free
All Users is marked as a <symlinkd> (i.e., a Symbolic Link to a directory) and Default User as a <junction>. The target directories are also shown. (Strangely, Default Users has been given, by default, a set of security properties that actually make it inaccessible from Explorer, even when run with Admin privileges, although I can get at it fine with Total Commander, my Explorer-substitute of choice.)

Vista also provides a utility called MKLINK which allows you to create your very own Junction Points and Symbolic Links. I created several, and discovered some interesting things. First of all, if you look at the properties of a Symbolic Link, you will get a Shortcut tab telling you the target, whereas with a Junction Point, you won't. Secondly, you can specify pretty much anything for the target of a Symbolic Link or Junction Point - it is only when the system tries to access it that it will fail if it doesn't exist or is an invalid path. This will become significant when we look at the programming aspects.

There is another potentially scary consequence of all this. Have a look at C:\Program Data. This contains a Junction Point called Application Data, and its target is . . . C:\Program Data. Now, if you're a developer, and you've written a nice little recursive method to build a directory tree, you need to go back and look at your code before you incur some really serious stack overflow. And don't forget, theoretically at least, these little beasties can pop up on XP and 2000 too. I didn't have the courage to try setting up a Symbolic Link that actually points to itself - if anyone is brave enough to try it, please let me know what happens.

There is also a utility on Vista called MOUNTVOL which allows you to set up Mount Points. I've not tried this - anyone who has should feel free to add a post.

Reparse Points on XP
The MKLINK and MOUNTVOL utilities do not exist under XP (there are ways of creating Reparse Points under XP, but they involve some serious under-the-bonnet* fiddling). Interestingly, however, the /AL parameter to DIR, although it doesn't show up in the help, does actually work, although it shows all Reparse Points as <junction>s.

It is, however, possible to set up a Mount Point under XP by creating a partition under Disk Management and specifying that it should be a mounted partition rather than a logical drive. You give it a destination directory, and lo and behold, up it pops in Explorer, looking just like a directory. I did this on a local non-system disk that was visible by both XP and Vista, by creating two partitions, one a logical drive (H:), and one a mounted drive in the root of H:, called H:\MountedDrive. And guess what - when I booted Vista, it seemed like it couldn't see the mounted drive at all, just H:. Then, I had another look and discovered that, even more bizarrely, it was the base drive it couldn't see, and the mounted drive that it could. Files created on the base drive in XP were completely invisible to Vista, while files created in H:\ under Vista appeared in H:\MountedDrive\ under XP. Weird!

Another interesting discovery was that, having created a load of Reparse Points on my shared drive under Vista, when I returned to XP, although they were all visible both from the command prompt and from Explorer, they didn't actually work. Double-clicking them just gives a bong, and programmatic access throws an IOException: "The file cannot be accessed by the system".

[* As a Brit, I have a bonnet and a boot, rather than a hood and a trunk].

Reparse Points for the Developer
As stated above, my primary requirement was to find a way for my C# program to get at the properties, specifically the target path, of a Reparse Point, and I must immediately credit the purveyors of FlexHex for their excellent article, NTFS Hard Links, Directory Junctions, and Windows Shortcuts, for giving me the initial leg-up that I needed.

Accessing the properties of a Reparse Point turned out not to be trivial. There are no managed API calls to cover it (no doubt, someone will now pop up and tell me there are!), and so a hefty dose of Platform Invoke was required. In fact, there is not even an unmanaged function for the purpose; it turns out that you have to call DeviceIoControl, passing FSCTL_GET_REPARSE_POINT as the control code.

To complicate matters, there are two different versions of the REPARSE_DATA_BUFFER structure published on the web. This is the structure that is filled by DeviceIoControl, and Microsoft defines one way here while the FlexHex guys use a different version. In the end, I used the Microsoft version, but taking out the Mount Point stuff, which was implemented as a union (not available in C#) and was only a naming convenience anyway. My version looks like this (note the use of CharSet = CharSet.Unicode, which is very important):

Hide   Copy Code
[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
private struct REPARSE_DATA_BUFFER
{
    public uint ReparseTag;
    public short ReparseDataLength;
    public short Reserved;
    public short SubsNameOffset;
    public short SubsNameLength;
    public short PrintNameOffset;
    public short PrintNameLength;
    [MarshalAs(UnmanagedType.ByValArray,
               SizeConst = MAXIMUM_REPARSE_DATA_BUFFER_SIZE)]
    public char[] ReparseTarget;
}
Before calling DeviceIoControl, it is necessary to open the file with CreateFile, passing both FILE_FLAG_OPEN_REPARSE_POINT and FILE_FLAG_BACKUP_SEMANTICS as flags. FILE_FLAG_BACKUP_SEMANTICS is required in order to get a directory handle; this means that before opening the file, we have to adjust the privileges, thus:

Hide   Copy Code
bool success;
IntPtr token;
TOKEN_PRIVILEGES tokenPrivileges = new TOKEN_PRIVILEGES();
tokenPrivileges.Privileges = new LUID_AND_ATTRIBUTES[1];
success = OpenProcessToken(GetCurrentProcess(), TOKEN_ADJUST_PRIVILEGES,
                           out token);
if (success)
{
    // null for local system

    success = LookupPrivilegeValue(null, SE_BACKUP_NAME,
                                   out tokenPrivileges.Privileges[0].Luid);
    if (success)
    {
        tokenPrivileges.PrivilegeCount = 1;
        tokenPrivileges.Privileges[0].Attributes = SE_PRIVILEGE_ENABLED;
        success = AdjustTokenPrivileges(
            token,
            false,
            ref tokenPrivileges,
            Marshal.SizeOf(tokenPrivileges),
            IntPtr.Zero,
            IntPtr.Zero);
    }
    CloseHandle(token);
}
Then we open the file:

Hide   Copy Code
IntPtr handle = CreateFile(
                 path,
                 FileAccess.Read,
                 FileShare.None,
                 0, FileMode.Open,
                 FILE_FLAG_OPEN_REPARSE_POINT | FILE_FLAG_BACKUP_SEMANTICS,
                 IntPtr.Zero);
and then we get the reparse buffer:

Hide   Copy Code
REPARSE_DATA_BUFFER buffer = new REPARSE_DATA_BUFFER();
// Make up the control code - see CTL_CODE on ntddk.h

uint controlCode = (
    FILE_DEVICE_FILE_SYSTEM << 16) | (FILE_ANY_ACCESS << 14) |
    (FSCTL_GET_REPARSE_POINT << 2) | METHOD_BUFFERED;
uint bytesReturned;
success = DeviceIoControl(
            handle,
            controlCode,
            IntPtr.Zero,
            0,
            out buffer,
            MAXIMUM_REPARSE_DATA_BUFFER_SIZE,
            out bytesReturned,
            IntPtr.Zero);
Now, the fun starts. Following a successful call, the buffer contains an array of Unicode characters called ReparseTarget. Do not be tempted to define this as a string, because it actually contains two strings, which may or may not be null terminated. These are referred to as the Print Name and the Subs Name, and the offset and length of each are in the buffer structure. However, there is a problem. For some reason, Symbolic Links have two extra characters on the front. These seem to be either '\1',\'0\ or '\0','\0'. I have no idea what they are doing there, and if anyone can explain them, I would be glad to hear.

The type of the Reparse Point is held in the ReparseTag field. WINNT.H defines several constants that may appear here:

Hide   Copy Code
private const uint IO_REPARSE_TAG_MOUNT_POINT = 0xA0000003;
private const uint IO_REPARSE_TAG_HSM = 0xC0000004;
private const uint IO_REPARSE_TAG_SIS = 0x80000007;
private const uint IO_REPARSE_TAG_DFS = 0x8000000A;
private const uint IO_REPARSE_TAG_FILTER_MANAGER = 0x8000000B;
The only ones we are interested in are IO_REPARSE_TAG_MOUNT_POINT, which also defines a Junction Point, and IO_REPARSE_TAG_SYMLINK which isn't defined in WINNT.H but turns out to have a value of 0xA000000C. I don't know what the others are - again those more knowledgeable than I are invited to post.

The code to get the two strings and the tag is thus:

Hide   Copy Code
if (buffer.ReparseTag == IO_REPARSE_TAG_SYMLINK)
{
    subsString = new string(
        buffer.ReparseTarget,
        (buffer.SubsNameOffset / 2 + 2),
        buffer.SubsNameLength / 2);
    printString = new string(
        buffer.ReparseTarget,
        (buffer.PrintNameOffset / 2 + 2),
        buffer.PrintNameLength / 2);
    tag = TagType.SymbolicLink;
}
else if (buffer.ReparseTag == IO_REPARSE_TAG_MOUNT_POINT)
{
    subsString = new string(
        buffer.ReparseTarget,
        buffer.SubsNameOffset/2, buffer.SubsNameLength/2);
    printString = new string(
        buffer.ReparseTarget,
        buffer.PrintNameOffset / 2, buffer.PrintNameLength / 2);
    tag = subsString.StartsWith(@"\??\Volume") ?
        TagType.MountPoint :
        TagType.JunctionPoint;
}
Now, according to various web articles, Symbolic Links store relative paths, while Junctions use absolute paths. This is not true. Symbolic Links basically store whatever string you put into them; it is up to whoever decodes them to decide if the target is relative, absolute, or just garbage. Junction Points are slightly different in that they always return an absolute path, which, as far as I can tell, is worked out when the Junction Point is created. Nevertheless, there is still no guarantee that it is a valid path, or that it exists when the Junction point is accessed (remember that the actual target may have been deleted or moved since the Reparse Point was created). The function I have implemented takes the path and, if it is a symbolic link and a relative path, "normalises" it by appending it to the drive and path of the passed Reparse Point to convert it to an absolute path. Note, however, that the target path may quite legally contain .s or ..s. These could also be "normalised", but I don't bother.

The difference between the Print Name and the Subs Name appears to be that the Subs Name, if it contains an absolute path, is an "unparsed path", which means that it starts with /??/ before the drive letter. Now, as far as I am concerned, it is all pretty much guess-work from here on in. I don't know if both names will always exist, or whether they will always be the same (except for the /??/), so I have tried to cater for all possibilities. I use the Print Name if it exists; otherwise, I use the Subs Name and strip off the unwanted stuff.

The third possibility is that it is a Mount Point. This has the same tag as a Junction, but seems to return no Print String and a subs string that begins with "\\??\\Volume". Again, this is sheer guesswork, and I would welcome any documented facts.

Finally, note that my program does not deal with Symbolic Links that point to files. Reparse Points that point to directories, or look like directories (Mount Points), behave in code like directories, i.e., they will be included in a call to Directory.GetDirectories(path), which is what I use.

The Demo Program
I have provided a demonstration program, both as a full VS2005 project and as an EXE file. The demo program basically builds a treelist of drives and directories - that is anything that looks like a directory. It then instantiates a ReparsePoint class which extracts the target from the directory if it is, in fact, a Reparse Point.

The program GUI presents the treelist, with the Reparse Points coloured to indicate what they are. Two labels at the bottom show the actual target path, and the path after my function has "normalised" it, i.e., made it into an absolute path. Finally, I added a radio button to control whether the program uses the Symbolic Link or its target to access the folder that it targets. The results should be the same, but, as stated, XP cannot actually access the Symbolic Link, so the target must be used.

Screenshot

Addenda
Now, here's a funny thing. While running further tests, I discovered (you can try this at home) that if a folder is being viewed in Explorer (or similar), the call to CreateFile returns an error 32 (ERROR_SHARING_VIOLATION). Unfortunately, my error reporting wasn't brilliant, but judicious insertion of System.Windows.Forms.MessageBox.Show() will reveal the problem (if there is sufficient demand, I'll post up a revised version of the program).

Anyway, the solution to this problem appears to be to replace the FileShare.None parameter in the CreateFile call with any other FileShare (we are not reading or writing the file, so it seems quite reasonable to use FileShare.ReadWrite). Now, I can't explain this - my understanding of the FileShare value is that it specifies what other programs are allowed to do while I have the file open. If anyone can shed any light on this, I'd love to hear from them.


License
This article, along with any associated source code and files, is licensed under The Code Project Open License (CPOL)

 Dave Midgley
Software Developer
Subscribe
this Member
United Kingdom United Kingdom
 */
