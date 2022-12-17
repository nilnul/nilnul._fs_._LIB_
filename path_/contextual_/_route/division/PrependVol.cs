namespace nilnul.fs.path_.division
{
	/*
C:\Projects\apilibrary\apilibrary.sln
An absolute path to a file from the root of drive C:

C:Projects\apilibrary\apilibrary.sln
A relative path from the current directory of the C: drive.

Important
Note the difference between the last two paths. Both specify the optional volume specifier (C: in both cases), but the first begins with the root of the specified volume, whereas the second does not. As result, the first is an absolute path from the root directory of drive C:, whereas the second is a relative path from the current directory of drive C:. Use of the second form when the first is intended is a common source of bugs that involve Windows file paths.*/
	public interface IPrependVol
	{
	}
}
