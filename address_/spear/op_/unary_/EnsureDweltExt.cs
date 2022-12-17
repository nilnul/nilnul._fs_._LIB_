using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.address_.spear.op_.unary_
{
	static public class _EnsureDweltExtX
	{
		static public string Txt(
			string address,
			nilnul.fs._address.doc_._exted.Ext ext
		) {
			var spearExt=nilnul.fs.address_.spear._DocExtX.Ext(address);
			if (_address.doc_._exted.ext.eq.Ne.Singleton.ne( spearExt,ext ) )
			{
				return address + ext;
			}
			return address;


		}
		static public string Txt(
			string address,
			string ext
		) {
			
			return Txt(address, new _address.doc_._exted.Ext(ext) );


		}


	}
}
