using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.file._address_.doc_._dotted_._ext.txt.be_
{

	public class XlsXlsx : nilnul.txt.BeI
	{
		public bool be(string obj)
		{
			return new nilnul.txt.set_.BothCasesOnStr("xls", "xlsx").contains(obj);
			//throw new NotImplementedException();
		}

		static public readonly XlsXlsx Singleton = nilnul.obj.SingletonByDefault<XlsXlsx>.Instance;

	}
}

