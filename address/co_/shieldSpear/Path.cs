using nilnul.fs.address_;
using System.Collections.Generic;
using System.Linq;

namespace nilnul.fs.address.co_.shieldSpear
{
	static public class _RelPathX
	{
		static public nilnul.fs.address.co._traject.IShortcut Anchor(ShieldI from, nilnul.fs.address_.SpearI to)
		{
			var shieldAnchor = nilnul.fs.address_.shield.co._RelPathX.Anchor(
				from ,
				nilnul.fs.address_.spear._ContainerX.Shield(to)
				);

			switch (shieldAnchor)
			{
				case nilnul.fs._address.division.co._duct._pass.step.Suffixeds relPath:
					return new nilnul.fs._address.division.co._duct.pass_.SuffixedsDoc(
						relPath
						,
						to.sprig.document.doc
					);
				case nilnul.fs.address_.ShieldI shield:
					return new nilnul.fs.address_.spear_.ParentDoc(shield,to.sprig.document. doc);
				default:
					throw new UnexpectedTypeException();
					break;
			}


		}

		static public nilnul.fs.IPath Path(ShieldI from, nilnul.fs.address_.SpearI to)
		{
			var shieldAnchor = nilnul.fs.address_.shield.co._RelPathX.Path(
				from ,
				nilnul.fs.address_.spear._ContainerX.Shield(to)
				);

			switch (shieldAnchor)
			{
				case nilnul.fs.path_.division_.Div relPath:
					return new nilnul.fs.path_.division_.div.StepAppended(
						relPath
						,
						to.sprig.document.doc
					);
				case nilnul.fs.address_.ShieldI shield:
					return new nilnul.fs.address_.spear_.ParentDoc(shield,to.sprig.document. doc);
				default:
					throw new UnexpectedTypeException();
					break;
			}


		}

	}
}
