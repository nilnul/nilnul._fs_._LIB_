using System.Linq;

namespace nilnul.fs._address.route_.sprig._parse
{

	public class Check : nilnul.obj._parse.CheckI
	{

		public string check(string s)
		{
			if (nilnul.seq.be_._NoneX1.Be(s))
			{
				return
					$@"{s} is empty.";
			}


			var deckCheck = _address._route.sep._parse.Check.Singleton.check(s.First());
			if (deckCheck != "")
			{
				return "must start with path separator";
			}


			var divisionChecked = fs._address.document._parse.Check.Singleton.check(s.Substring(1));

			if (divisionChecked != "")
			{
				return $"aft initial separator, err:{divisionChecked}";
			}
			return "";


		}


		static public Check Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Check>.Instance;
			}
		}


	}
}
