namespace nilnul.fs._address
{
	/// <summary>
	/// </summary>
	static public class DestinationIX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="division"></param>
		/// <returns></returns>
		static public DestinationI Downcast(DivisionI division)
		{
			switch (division)
			{
				case DestinationI destination:
					return destination;
				default:
					return DestinationA.Parse(division.ToString()); //may throw exception for ""
#pragma warning disable CS0162 // Unreachable code detected
					break;
#pragma warning restore CS0162 // Unreachable code detected
			}
		}

	}
}
