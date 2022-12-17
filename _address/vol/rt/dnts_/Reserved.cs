using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs._address.vol.rt.dnts_
{
	/****************
	 https://docs.microsoft.com/en-us/openspecs/windows_protocols/ms-fscc/b04c3bd0-79dc-4e58-b8ed-74f19fc2ea0a

NTFS uses a number of names as part of the file system internals. The names used by NTFS within the root directory are listed in the following table:

5.3 NTFS RESERVED FILE NAMES
Filename

Description

\$Mft

Master File Table (MFT) - an index of every file

\$MftMirr

A backup copy of the first 4 records of the MFT

\$LogFile

Transactional logging file

\$Volume

Serial number, creation time, dirty flag

\$AttrDef

Attribute definitions

\$Bitmap

Contains the volume's cluster map (in-use vs. free)

\$Boot

Boot record of the volume

\$BadClus

Lists bad clusters on the volume

\$Secure

Security descriptors used by the volume

\$UpCase

Table of uppercase characters used for collating

\$Extend

A directory



An additional set of names are found in the system directory as follows:

TABLE 2
Filename

Description

\$Extend\$Config

Use for NTFS repair activity

\$Extend\$Delete

Delete file name

\$Extend\$ObjId

Unique Ids given to every file

\$Extend\$Quota

Quota information

\$Extend\$Repair

Repair name

\$Extend\$Repair.log

Repair log name

\$Extend\$Reparse

Reparse point information

\$Extend\$RmMetadata

Transactional NTFS resource manager metadata name

\$Extend\$Tops

Transactional NTFS Old Page Stream, used to store data that has been overwritten inside a currently active transaction

\$Extend\$Txf

Transactional NTFS

\$Extend\$TxfLog

Transactional NTFS log
	 
	 */
	class Reserved
	{
	}
}
