using System;

namespace nilnul.fs._address.division.op_.unary_
{
	public class Shrink : UnaryI
	{
		public DivisionI _op_assumeDiv0document(DivisionI par)
		{
			switch (par)
			{
				case DocumentI document:
					return document;
				case DivI div:
					if (_address.div.be_.Rt.Singleton.be(div) )
					{
						return div;
					}
					return nilnul.fs._address.div_.nonEmpty.to_.Document.Singleton.to(div);
					


				default:



					break;
			}
			throw new NotImplementedException();
		}
		public DivisionI op(DivisionI par)
		{
			return _op_assumeDiv0document( DivisionA.Normal(par) );
	
		}

		public _address.Denotation toDenotation(DivisionI par) {
			var shrunk = op(par);
			return shrunk switch
			{
				DocumentI document =>  _address.denotation._OfDocumentX.Denotation(document)
				,
				DivI div =>  _address.div.be_.Rt.Singleton.be(div)?throw new InvalidOperationException($"{div} is rt, unable to be cast to a denotation"): nilnul.fs._address.div_.nonEmpty.to_.Denotation.Singleton.to(div)


		};
		}


		static public Shrink Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Shrink>.Instance;
			}
		}

	}
}
