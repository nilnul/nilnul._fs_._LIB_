using System;

namespace nilnul.fs._disk._part.vol_.xpN_
{
	static public class _DiscFullX
	{
		/*
System.IO uses _Error.WinIOError function to raise unhandled exception. If we look into the disassemblied codes from reflector, we can see these,

[SecurityCritical]
internal static void WinIOError(int errorCode, string maybeFullPath)
{
    bool isInvalidPath = (errorCode == 0x7b) || (errorCode == 0xa1);
    string displayablePath = GetDisplayablePath(maybeFullPath, isInvalidPath);
    switch (errorCode)
    {
        case 0x20:
            if (displayablePath.Length == 0)
            {
		//...
		When your disk out of space, the exception is thrown by the last line. Win32Native.GetMessage will return the specified error code.


		//bibliograyph:
		-)
https://social.msdn.microsoft.com/Forums/vstudio/en-US/4c456806-1cb6-4dad-be1b-a1a77b334552/disk-out-of-space-exception-handling?forum=csharpgeneral

	*/
		const int HR_ERROR_HANDLE_DISK_FULL = unchecked((int)0x80070027);
		const int HR_ERROR_DISK_FULL = unchecked((int)0x80070070);

		///stackoverflow.com/questions/9293227/how-to-check-if-ioexception-is-not-enough-disk-space-exception-type
		///answered Feb 15, 2012 at 13:34
		///Justin
		///edited May 23, 2017 at 12:25
		///CommunityBot
		/// <summary>
		/// 
		/// </summary>
		/// <param name="ex"></param>
		/// <returns></returns>
		public static bool IsDiskFull_ofHresult(int hResult)
		{
			return hResult == HR_ERROR_HANDLE_DISK_FULL
				|| hResult == HR_ERROR_DISK_FULL;
		}

		static public bool IsDiskFull(Exception ex)
		{
			return IsDiskFull_ofHresult(ex.HResult);
		}


		static public bool IsDiskFull(System.IO.IOException ex)
		{
			return IsDiskFull_ofHresult(ex.HResult);
		}

		static public void Rethrow(System.IO.IOException ex)
		{
			if (IsDiskFull(ex))
			{
				throw new DiscFullException($"Triaged as diskFull:{ex}", ex);
			}
			throw ex;
		}
		static public void Rethrow(System.Exception ex)
		{
			if (IsDiskFull(ex))
			{
				throw new DiscFullException($"Triaged as diskFull:{ex}", ex);
			}
			throw ex;
		}


	}
}
