using MegaPricer.Data;
using MegaPricer.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MegaPricer.Pages;

public class PlaceOrderModel : PageModel
{
  private readonly ILogger<PlaceOrderModel> _logger;
  private readonly IPricingService _pricingService;
  private readonly OrderPriceCalculationStrategy _orderPriceCalculationStrategy;

  public PlaceOrderModel(ILogger<PlaceOrderModel> logger, IPricingService pricingService, OrderPriceCalculationStrategy orderPriceCalculationStrategy)
  {
    _logger = logger;
    _pricingService = pricingService;
    _orderPriceCalculationStrategy = orderPriceCalculationStrategy;
  }

  public void OnGet()
  {
    if (!(User is null) && User.Identity.IsAuthenticated)
    {
      if (!Context.Session.ContainsKey(User.Identity.Name))
      {
        Context.Session.Add(User.Identity.Name, new Dictionary<string, object>());
      }
      if (!Context.Session[User.Identity.Name].ContainsKey("CompanyShortName"))
      {
        Context.Session[User.Identity.Name].Add("CompanyShortName", "Acme");
      }
      if (!Context.Session[User.Identity.Name].ContainsKey("PricingOff"))
      {
        Context.Session[User.Identity.Name].Add("PricingOff", "N");
      }
    }

    string userName = User.Identity.Name;
    _pricingService.CalculatePrice( new PriceRequest(1, 1, userName), _orderPriceCalculationStrategy);
  }
}
