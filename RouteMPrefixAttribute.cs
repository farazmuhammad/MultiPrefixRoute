namespace System.Web.Http
{
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = true, Inherited = true)]
	public class RouteMPrefixAttribute : RoutePrefixAttribute
	{
		public RouteMPrefixAttribute(string prefix)
			: this(prefix, 0)
		{
		}


		public RouteMPrefixAttribute(string prefix, int order)
			: base(prefix)
		{
			Order = order;
		}

		
		public int Order { get; set; }
	}
}