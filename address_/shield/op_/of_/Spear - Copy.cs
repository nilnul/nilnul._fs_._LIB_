using System;

namespace nilnul.fs.address_.shield_
{
	[Obsolete()]
	static public class _SpearX
	{
		static public ShieldI Shield(spear_.ParentDoc spear)
		{
			return new nilnul.fs.address_.shield_.BaseDir(spear.parent, spear.doc);
		}

		static public ShieldI Shield(SpearI spear)
		{
			return Shield(new spear_.ParentDoc(spear));
		}
	}
}
