using Nancy;

namespace MyApi
{
	public class DocModule : NancyModule
	{
		public DocModule()
		{
			Get ["/doc"] = _ => {
				return View ["index.html"];
			};

		}
	}
}