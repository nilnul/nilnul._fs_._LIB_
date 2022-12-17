using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.path_.division_._div._dir.steps
{
	public class Shrink : nilnul.obj.op_.UnaryI<IEnumerable<IStep>>
	{
		public IEnumerable<IStep> op(IEnumerable<IStep> par)
		{
			return _op(par);
		}

		public List<IStep> _op(IEnumerable<IStep> par)
		{
			var queue = new List<IStep>();

			foreach (var item in par)
			{
				if (
					item is _address.IDnt /*.DntI1*/ dnt

				)
				{
					queue.Add(dnt);
				}
				else if (item is _address._route.division_._div._dir.IDnt dnt1) {
					queue.Add(dnt1);

				}
				else if (item is path_.division_._div._dir.step_.Up)
				{
					if (queue.Any())
					{
						if (queue.Last() is _address.IDnt)
						{
							queue.RemoveAt(queue.Count - 1);
						}
						else
						{
							queue.Add(step_.Up.Singleton);
						}
					}
					else
					{
						queue.Add(step_.Up.Singleton);

					}

				}
				else
				{
					nilnul.bit.vow_.True1.Vow(
					 item is step_.Self
					 ,
					 $"item is expected to be of type {typeof(step_.Self)}"
					);// self is not processed
				}
				
			}
			return queue;
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
