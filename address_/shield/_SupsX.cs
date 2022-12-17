using System.Collections.Generic;

namespace nilnul.fs.address_.shield
{
	/// <summary>
	/// return sups (self, parent, )
	/// </summary>
	public class _SupsX
	{
		/// <summary>
		/// returns self, parent, grandparent, ...,etc
		/// </summary>
		/// <param name="origin"></param>
		/// <returns></returns>
		static public IEnumerable<nilnul.fs.address_.ShieldI> Sups(nilnul.fs.address_.ShieldI origin)
		{

			yield return origin;


			while (!nilnul.fs.address_.shield.be_.Root.Singleton.be(origin))
			{
				origin = nilnul.fs.address_.shield_.nonRt._ParentX._Parent(origin);
				yield return origin;
			}
		}
		static public IEnumerable<nilnul.fs.address_.ShieldI> Sups_ofAddress(string origin)
		{
			return Sups(nilnul.fs.address_.shield_._AddressX1.Create(origin));
		}

	}
}
