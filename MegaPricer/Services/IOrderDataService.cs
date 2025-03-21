using MegaPricer.Data;

namespace MegaPricer.Services;

public interface IOrderDataService
{
  void CreateNewOrder(Order order);
  void AddOrderItem(Order order, decimal thisUserMarkup, Feature thisFeature);
  void InsertOrderItemRecord(Order order, Part thisPart, decimal thisUserMarkup, decimal thisTotalPartCost);
  void AddWallTreatmentToOrder(Order order, Part thisPart, decimal thisUserMarkup);
}
