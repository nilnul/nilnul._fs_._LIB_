using nilnul.obj_.xpn_;
using System;
using System.Linq;

namespace nilnul.fs.address_.shield.sups_.existed
{
	/// <summary>
	/// 
	/// </summary>
	static public class _NearestFolderX
	{
		static public nilnul.fs.address_.ShieldI ShieldNulable(nilnul.fs.address_.ShieldI _shieldAddress)
		{
			return nilnul.fs.address_.shield.sups_._ExistedX.Seq(_shieldAddress).FirstOrDefault();
		}

		static public nilnul.fs.address_.ShieldI ShieldNulable_ofAddress(string _shieldAddress)
		{
			return ShieldNulable(
				nilnul.fs.address_.Shield.FroAddress(_shieldAddress)
			);
		}

		static public nilnul.fs.address_.ShieldI ShieldNulable_ofMaybeAddress(string _shieldAddress)
		{
			try
			{
				return ShieldNulable(
					nilnul.fs.address_.Shield.FroAddress(_shieldAddress)
				);

			}
			catch (ParseException ex)
			{
				return null;

			}
			catch (System.Exception)
			{

				return null;
			}
		}
		static public string ShieldTxtNulable_ofMaybeAddress(string _shieldAddress)
		{
			return ShieldNulable_ofMaybeAddress(_shieldAddress)?.ToString();
		}


	}
}
