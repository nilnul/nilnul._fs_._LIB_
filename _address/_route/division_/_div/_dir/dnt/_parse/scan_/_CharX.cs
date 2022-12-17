namespace nilnul.fs._address._dst.denote._parse.scan_
{
	/*
	SimonSapin commented on Sep 17 2014 
I suggest calling this WTF-8: an encoding that uses the same algorithm as UTF-8, but has the "value space" of UCS-2. (That is, bigger than Unicode since unpaired surrogates are allowed.) We can decide later what the name an acronym for.
Note: I call UCS-2 here any sequence of 16 bit units. Surrogate pairs have a special meaning, but unpaired surrogates are allowed.
To convert UCS-2 to WTF-8:
Valid surrogate pairs are interpreted as a non-BMP code point and encoded as a 4-byte UTF-8 sequence
Any other 16 bit code unit, including lone surrogates, are encoded as sequence of 1 to 3 bytes using UTF-8’s algorithm. This is invalid UTF-8 for lone surrogates, but valid WTF-8.
To convert WTF-8 to UCS-2:
4-byte sequences are interpreted as a non-BMP code point and encoded as a surrogate pair of 16 bit units
1 to 3 bytes sequences in UTF-8’s algorithm, including surrogates, are encoded as a one 16 bit unit
Consecutive 3-byte sequences for a lead surrogate followed by a trail surrogate are invalid in WTF-8. A 4-byte sequence should be used instead. (This ensures that the WTF-8 encoding of any UCS-2 string is unique.)
WTF-8 has the same "value space" as UCS-2, which is bigger than Unicode (since they include unpaired surrogates.)
Any valid UTF-8 string is also valid WTF-8, with the same byte representation. A WTF-8 string is also valid UTF-8 if and only if its UCS-2 conversion is valid UTF-16.
To convert a WTF-8 to UTF-8, either:
Strictly: return an error if the string contains a 3-byte sequence for a surrogate code point, otherwise return the string unchanged
Lossily: replace any 3-byte sequence for a surrogate code point by 0xEF 0xBF 0xBD, the UTF-8 representation of the replacement character U+FFFD.
To concatenate two WTF-8 strings: if the earlier one ends with a lead surrogate and the latter one starts with a trail surrogate, both surrogate need to be removed and replaced with a 4-byte sequence.
Note: WTF-8 is different from CESU-8.
In terms of Rust implementation, WTF-8 data should be kept in a dedicated type that wraps a private Vec<u8> field, with APIs that maintain the encoding invariants, like String does for UTF-8.

 
 SimonSapin referenced this issue on Sep 25 2014 
 Closed 
Support document.write #6 
 
   
Contributor 
SimonSapin commented on Sep 26 2014 
I’m gonna work of WTF-8 anyway, for Servo to interact with JavaScript. ECMAScript clearly says that strings are sequences of 16-bit integers.
For Windows however, it’s not so clear to me that this is actually needed. MSDN claims that the encoding used in Windows is UTF-16. The documentation for functions converting to and from UTF-16 says:
Starting with Windows Vista, this function fully conforms with the Unicode 4.1 specification for UTF-8 and UTF-16. The function used on earlier operating systems encodes or decodes lone surrogate halves or mismatched surrogate pairs.
I believe (by opposition to the following sentence) that "fully conforms" here means replaces unpaired surrogates with U+FFFD. (I haven’t tested it, though.)
Now, we’ve seen that it’s possible to create a file with an invalid UTF-16 name. But it’s not easy, we’re sometimes prevented from doing it. It may be considered a bug that it was possible. The question is, and I couldn’t find an answer on MSDN, are Windows applications expected to handle such files correctly?

 
   
Member 
retep998 commented on Sep 27 2014 
According to MSDN
There is no need to perform any Unicode normalization on path and file name strings for use by the Windows file I/O API functions because the file system treats path and file names as an opaque sequence of WCHARs.
This isn't exactly UTF-16. So while the rest of WinAPI uses UTF-16, the file API doesn't. I've tested creating filenames with invalid surrogates in their name and I was able to create them and manipulate them easily through both code, and numerous applications including cmd.exe Notepad and Windows explorer. So far Windows 8.1 hasn't tried to stop me from using invalid surrogates for files, so I definitely think Windows applications are expected to handle such files correctly.

 
   
Contributor 
SimonSapin commented on Sep 27 2014 
"Unicode normalization" refers to something else, but "opaque sequence of WCHARs" does indeed imply that unpaired surrogates can occur. Alright then, WTF-8 for Path it is.

 for example: è®¢å5180628362605563çµå­åç¥¨
 */
	/// <summary>
	/// 
	/// </summary>
	static public class _CharX
	{
		static public void Scan(string x)
		{
			try
			{
				new nilnul.obj._parse.scan_.Char(_denote.txt.be_._valid.cha.Be.Singleton).scan(x);

			}
			catch (nilnul.obj_.xpn_.parse_.scan_.CharException e)
			{

				throw new nilnul.obj_.xpn_.parse_.scan_.CharException($"while scanning {x}:{e.Message}",e);
			}
		}
	}
}
