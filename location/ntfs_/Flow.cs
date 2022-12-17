using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.location.ntfs_
{
	/**********
docs.microsoft.com/en-us/openspecs/windows_protocols/ms-fscc/c54dec26-1551-4d3a-a0ea-4fa40f848eb3

	All files on an NTFS volume consist of at least one stream - the main stream – this is the normal, viewable file in which data is stored. The full name of a stream is of the form below.

<filename>:<stream name>:<stream type>

The default data stream has no name. That is, the fully qualified name for the default stream for a file called "sample.txt" is "sample.txt::$DATA" since "sample.txt" is the name of the file and "$DATA" is the stream type.

A user can create a named stream in a file and "$DATA" as a legal name. That means that for this stream, the full name is sample.txt:$DATA:$DATA. If the user had created a named stream of name "bar", its full name would be sample.txt:bar:$DATA. Any legal characters for a file name are legal for the stream name (including spaces). For more information about the naming format for streams, see [MS-FSCC]. For more information about the attributes of a stream, see [MS-FSA].

In the case of directories, there is no default data stream, but there is a default directory stream. Directories are the stream type $INDEX_ALLOCATION. The default stream name for the type $INDEX_ALLOCATION (a directory stream) is $I30. (This contrasts with the default stream name for a $DATA stream, which has an empty stream name.) The following are equivalent:

Dir C:\Users

Dir C:\Users:$I30:$INDEX_ALLOCATION

Dir C:\Users::$INDEX_ALLOCATION

Although directories do not have a default data stream, they can have named data streams. These alternate data streams are not normally visible, but can be observed from a command line using the /R option of the DIR command.





	Windows Internet Explorer uses the stream name Zone.Identifier for storage of URL security zones.

The fully qualified form is sample.txt: Zone.Identifier:$DATA

The stream is a simple text stream of the form:

[ZoneTransfer]

ZoneId=3
	*/
	/*************************
Windows Shell uses the stream name "encryptable" to store attributes relating to thumbnails in the thumbnails database.

The fully qualified name would be as follows:

Thumbs.db:encryptable:$DATA	 */
	class Flow
	{
	}
}
