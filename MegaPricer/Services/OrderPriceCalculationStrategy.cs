using MegaPricer.Data;

namespace MegaPricer.Services;

public class OrderPriceCalculationStrategy(IOrderDataService orderDataService) : IPriceCalculationStrategy
{
  private Order _order = new();
  public void Create(Kitchen kitchen)
  {
    // create a new order
    _order.KitchenId = kitchen.KitchenId;
    orderDataService.CreateNewOrder(_order);
  }

  public void AddPart(Part part, decimal userMarkup)
  {
    // add this part to the order
    orderDataService.InsertOrderItemRecord(_order, part, userMarkup, part.MarkedUpCost);
  }

  public void AddFeature(Feature feature, decimal userMarkup)
  {
    orderDataService.AddOrderItem(_order, userMarkup, feature);
  }

  public void AddWallTreatment(Part part, decimal userMarkup, float wallHeight, float wallWidth)
  {
    orderDataService.AddWallTreatmentToOrder(_order, part, userMarkup);
  }
}
