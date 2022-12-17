using System;
using System.Linq;

namespace nilnul.fs._address.div_.nonEmpty.to_
{
#pragma warning disable CS0618 // 'ParRet<NonEmptyI, DocumentI>' is obsolete: 'RetI'
	public class Document : nilnul.obj._cast_.ParRet<NonEmptyI, DocumentI>
#pragma warning restore CS0618 // 'ParRet<NonEmptyI, DocumentI>' is obsolete: 'RetI'
		, nonEmpty.ToI<DocumentI>
	{
		public DocumentI op(NonEmptyI input)
		{
			return to(input);
			//throw new NotImplementedException();
		}

		public DocumentI to(DivI div)
		{
			return op(
				 NonEmpty.Coerce(div)
			);
			//throw new NotImplementedException();
		}

		public DocumentI to(NonEmptyI input)
		{
			return new _address.Document(input.dirs.Take(input.dirs.Count() - 1), input.dirs.Last());

			//throw new NotImplementedException();
		}


		static public Document Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Document>.Instance;
			}
		}


	}
}
