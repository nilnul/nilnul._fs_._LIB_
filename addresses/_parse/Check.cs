using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.addresses._parse
{
	/// <summary>
	/// discard insignificant whites:
	///		white line
	///		leading or trainling whites
	/// </summary>
	public class Check:nilnul.obj._parse.CheckI
	{
		public string check(string obj)
		{

			string[] linesNonblank = nilnul.txt.split_._LineX.Line(obj).ToArray();

			List<string> errMessages = new List<string>();

			//var parsed = new Dictionary<int, nilnul.fs.AddressI>();

			for (int i = 0; i < linesNonblank.Count(); i++)
			{

				if (string.IsNullOrWhiteSpace(linesNonblank.ElementAt(i)))
				{
					continue;
				}
				var lineCheck = nilnul.fs.address._parse.Check.Singleton.check(
					linesNonblank.ElementAt(i).Trim()
				);
				if (lineCheck != "")
				{
					errMessages.Add(
						$"line#{i} parsed err:{lineCheck}"
					);

				}

			}
			if (errMessages.Any())
			{
				return new nilnul.txt.accumulate_.Join(";").accumulate(errMessages);
			}
			else
			{
				return  "";
			}
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
