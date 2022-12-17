using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs._address.doc.be_.exT_
{
	public class SevenZee : nilnul.fs._address.doc.be_.Ext
	{
		public const string EXT = ".7z";
		

		public SevenZee() : base(EXT)
		{
		}

		static public SevenZee Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<SevenZee>.Instance;
			}
		}

	}
}
