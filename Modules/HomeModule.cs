using Nancy;
using System.Collections.Generic;

namespace Shipping
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => "Hello World!";
    }
  }
}
