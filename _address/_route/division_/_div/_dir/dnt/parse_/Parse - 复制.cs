﻿using System;

namespace nilnul.fs._address._dst.denote
{
	[Obsolete()]
	static public class _ParseX
	{
		static public void Parse(string s)
		{

			_parse.scan_._WordX.Parse(s);
		}

		static public bool Success(string s)
		{
			try
			{
				Parse(s);
				return true;
			}
#pragma warning disable CS0168 // The variable 'xpn' is declared but never used
			catch (nilnul.obj_.xpn_.parse_.ScanException xpn)
#pragma warning restore CS0168 // The variable 'xpn' is declared but never used
			{

				return false;
			}
		}
	}
	public class Parse
	{

	}
}
