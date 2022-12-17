using nilnul.fs.address.co._traject;
using System;
using System.Collections.Generic;
using System.Linq;

namespace nilnul.fs.address_.shield.co
{
	static public class _RelPathX
	{

		static public nilnul.fs.address.co._traject.IShortcut Anchor(ShieldI from, ShieldI to)
		{
			if (nilnul.fs.address_.shield.re_.equiv_._SameVolX.Re(from,to))
			{
				return nilnul.fs._address.route_.stem.co.RelPathX.RelPath(from.stem, to.stem);
				
			}
			return to;
		}

		/// <summary>
		/// div or shield
		/// </summary>
		/// <param name="from"></param>
		/// <param name="to"></param>
		/// <returns></returns>
		static public nilnul.fs.IPath Path(ShieldI from, ShieldI to)
		{
			if (nilnul.fs.address_.shield.re_.equiv_._SameVolX.Re(from,to))
			{
				return nilnul.fs._address.route_.stem.co.RelPathX.Path(from.stem, to.stem);
				
			}
			return to;
		}


		static public nilnul.fs.address.co._traject.IShortcut Shortcut(ShieldI from, ShieldI to)
		{
			return Anchor(from, to);
		}

		public static IShortcut Shortcut_ofTargetIsAddress(Shield parentInShield, string target)
		{
			return Anchor(
				parentInShield
				,
				nilnul.fs.address_.Shield.FroAddress(target)
			);

		}


	}
}
