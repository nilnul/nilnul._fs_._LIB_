using nilnul.exception_;
using System;

namespace nilnul.txt.be_.fs_.address_
{
	public class Spear
		: nilnul.txt.BeI
	{
		public bool be(string obj)
		{
			try
			{
				nilnul.fs.address_.Spear.Parse(obj);
			}
#pragma warning disable CS0168 // The variable 'e' is declared but never used
			catch (ParseException e)
#pragma warning restore CS0168 // The variable 'e' is declared but never used
			{
				return false;
				//throw;
			}
#pragma warning disable CS0168 // The variable 'ex' is declared but never used
			catch (Exception ex)
#pragma warning restore CS0168 // The variable 'ex' is declared but never used
			{
				return false;
			}
			return true;
			//throw new NotImplementedException();
		}

		public bool be_ifArgTrimmed(string s)
		{
			return be(s.Trim());
		}


		static public Spear Singleton
		{
			get
			{
#pragma warning disable CS0618 // 'Singleton1<Spear>' is obsolete: 'nilnul.obj_.'
				return nilnul.Singleton1<Spear>.Instance;
#pragma warning restore CS0618 // 'Singleton1<Spear>' is obsolete: 'nilnul.obj_.'
			}
		}

	}
}
