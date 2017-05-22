using Nancy;
using ParcelObjects;
using System.Collections.Generic;

namespace Shipping
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => View["parcel_form.cshtml"];
      Get["/parcel_receipt"] = _ => {
        Parcel myParcel = new Parcel(Request.Query["length"], Request.Query["width"], Request.Query["height"], Request.Query["weight"]);
        return View["parcel_receipt.cshtml", myParcel];
      };
    }
  }
}
