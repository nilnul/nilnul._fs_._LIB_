using nilnul.fs._address;
using nilnul.fs.address_;
using nilnul.txt_._vered;
using System;

namespace nilnul.fs.folder.dst_.vered_
{
	public class _NewestX
	{
		

		internal static _address._route.division_._div.DstI VeredOrNul(FolderI parent, DocI doc)
		{
			var vered = nilnul.txt_.Vered2.Parse(doc.ToString());




			var newest=
				nilnul.txt_.vereds.NewestOrDefaultX.Vered(
					new nilnul.fs.folder.dnt_.Vereds(parent).seq(vered)
				)
			;

			if (newest is null)
			{
				return null;
			}

			var dst= nilnul.fs.folder._DstX.Dst_dntAssumeExists(
				parent,newest
			);
			return dst;
			//switch (dst)
			//{
			//	case _address._route.division_._div.DirI dir:
					
			//	default:
			//		break;
			//}

		}

		public static _address._route.division_._div.DstI Dst0nul(FolderI1 parent, Name denote)
		{





			return  nilnul.objs._MaxOrDefaultX.Max(
					new nilnul.fs.folder.dst_.Vereds(parent).dsts(denote)
					,
					d=> nilnul.txt_.vered._VerX.Dec(d.caption)
					,
					nilnul.txt_.num_.radix.prefixed_.dec.ComparerWithPrefixCount.Singleton

				)
			;

			
		}

		internal static _address._route.division_._div.DstI VeredOrNul(ShieldI parent, DocI doc)
		{
			return VeredOrNul(
				new nilnul.fs.Folder(parent)
				,
				doc
			);
		}

	}
}
