using nilnul.exception_;
using System;

namespace nilnul.txt.be_.fs_
{
	public class Address
		: nilnul.txt.BeI
	{
		public bool be(string obj)
		{
			try
			{
				nilnul.fs.AddressA.Parse(obj);
			}
#pragma warning disable CS0168 // The variable 'e' is declared but never used
			catch (ParseException e)
#pragma warning restore CS0168 // The variable 'e' is declared but never used
			{
				return false;
				//throw;
			}
			catch (nilnul.obj_.xpn_.ParseException e)
#pragma warning restore CS0168 // The variable 'e' is declared but never used
			{
				return false;
				//throw;
			}
			catch (Exception x) {
				return false;
			}

			return true;
			//throw new NotImplementedException();
		}

		public bool be_ifArgTrimmed(string s)
		{
			return be(s.Trim());
		}


		static public Address Singleton
		{
			get
			{
#pragma warning disable CS0618 // 'Singleton1<Address>' is obsolete: 'nilnul.obj_.'
				return nilnul.Singleton1<Address>.Instance;
#pragma warning restore CS0618 // 'Singleton1<Address>' is obsolete: 'nilnul.obj_.'
			}
		}

	}
}
