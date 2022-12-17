using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs._address._route.seps_
{

	/*
Actually it means nothing and is ignored.

This often happens when output from multiple places is combined and it isn't clear who's job it is to add the slashes, so both parties do it and you end up with two of them. Semantically in the case of a directory path is has no meaning and will be ignored by most programs.

There are other situations in the unix world where they have meaning. Sometimes at the start of a path they could trigger a search for a samba path instead of a local file system path, or after a protocol in nfs they can indicate a hostname, however particularly in the case of a trailing slash like you gave as an example, it shouldn't matter much.

For the sake of your sanity as an administrator or programmer you should still avoid these cases wherever possible. You never know when something will be parsed incorrectly, but if one comes your way don't worry about it.

I believe POSIX specifies any number of consecutive slashes collapse into one, but I'm uncertain, I do know both Linux and FreeBSD do it in the kernel. It's not the shell that cares. The cases where multiple slashes affects the interpretation are not local filenames. The example caleb gives of a samba path is actually a UNC path and it how Windows (which does not allow multiple slashes) interpret the path. This does not occur normally on UNIX systems as they don't natively support UNC paths. URLs are a different matter and multiple slashes do affect interpretations. –

		Reference: pubs.opengroup.org/onlinepubs/009695399/basedefs/… "Multiple successive slashes are considered to be the same as one slash. "

		Most operating systems allow the inclusion of multiple slashes between file name or directory components of a file path. This is true of both Windows and most *nix operating systems. The only exception is slashes used in conjunction with a UNC. Only two backward slashes are allowed with the UNC.
		 */

	/*Apparently, Windows (or at least some part of Windows) ignores multiple backslashes in a path and treats them as a single backslash. For example, executing any of these commands from a command prompt or the Run window opens Notepad:

C:\Windows\System32\Notepad.exe
C:\Windows\System32\\Notepad.exe
C:\Windows\System32\\\Notepad.exe
C:\Windows\System32\\\\Notepad.exe
C:\\Windows\\System32\\Notepad.exe
C:\\\Windows\\\System32\\\Notepad.exe
This can even work with arguments passed on the command line:

notepad "C:\Users\username\Desktop\\\\myfile.txt"
Is this behavior documented anywhere? I tried several searches, and only found this SO question that even mentions the behavior.

Note: I am not asking about UNC paths (\\servername), the \\?\ prefix, or the \\" double-quote escape.

Note: I stumbled upon this behavior while working with a batch file. One line in the batch file looked something like this:

"%SOME_PATH%\myapp.exe"
After variable expansion, the command looked like:

"C:\Program Files\Vendor\MyApp\\myapp.exe"
To my surprise, the batch file executed as desired and did not fail with some kind of "path not found" error.

		Microsoft, like most any software vendor, never documents their "it is wrong but I'll accept it anyway" workarounds. Documenting it legitimizes doing it wrong. 
 */

	/*So something like

c:\documents\..\code.\\working\.\myprogram\\\runme.exe..
will wind up interpreted as

c:\code\working\myprogram\runme.exe

		In fact that entire paragraph was incorrect, I'd been misled by the behaviour of the the command interpreter.
 */

	/*This is not correct. You can dir c:\ , but you can not dir c:\\ – MC ND Oct 9 '15 at 9:13 
dir C:\\ does not work, but dir C:\Windows\\ does work. The dir command must use slightly different logic

 Yes, many built-in commands parse pathnames themselves, and therefore have slightly different rules to the Win32 API. Presumably this is for backwards compatibility with DOS. If you say dir c:\\Users\xyzzy you get "The network path was not found" so it seems the double-backslash being so close to the start is confusing cmd.exe into thinking it is a UNC path. notepad.exe on the other hand is perfectly happy with the same syntax. – Harry Johnston Oct 9 '15 at 20:38
@MCND But in fact, the following code works for %a in ("C:\\") do dir %~dpna also mkdir c:\\folder too. cd "c:\\" Only DIR command is confused. */
	class Started
	{
	}
}

/*http://example.com/something/somewhere//somehow/script.js

HTTP RFC 2396 defines path separator to be single slash.

However, unless you're using some kind of URL rewriting (in which case the rewriting rules may be affected by the number of slashes), the uri maps to a path on disk, but in (most?) modern operating systems (Linux/Unix, Windows), multiple path separators in a row do not have any special meaning, so /path/to/foo and /path//to////foo would eventually map to the same file.

An additional thing that might be affected is caching. Since both your browser and the server cache individual pages (according to their caching settings), requesting same file multiple times via slightly different URIs might affect the caching (depending on server and client implementation).

shareeditfollow
answered Apr 15 '12 at 10:37

poncha
6,98811 gold badge2929 silver badges3434 bronze badges
You have to look at section 3.3 of the document you quoted (or RFC3986 which obsoletes it, but agrees on discussed behavior here), which specified through ABNF how path_segments consists of at least one segment token, which itself may be of empty length. This means that sequences of characters like // are perfectly valid in URIs.
Re "unless you're using some kind of URL rewriting", It also matters for relative URLs. http://host/a/b/c/d + ../../e = http://host/a/e, while http://host/a/b/c//d + ../../e = http://host/a/b/e 	 */

/*As amn explains, it therefore implies an empty URI segment. Note however that RFC 2396 only defines the syntax, not semantics of paths, including empty path segments, so it is up to your server to decide the semantics of the empty path.*/
/*You may be surprised for example when building links for resources in your app.

<script src="mysite.com/resources/jquery//../angular/script.js"></script>
will not resolve to mysite.com/resources/angular/script.js but to mysite.com/resources/jquery/angular/script.js what you probably didn't want

Double slashes are evil, try to avoid them.*/

/*in my experience, this works just fine in practice. As a matter of fact, even dropping to a command prompt and executing cd c:\\\\\\windows\\\ works in practice.*/
