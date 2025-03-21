using MegaPricer.Data;

namespace MegaPricer.Services;

public class DefaultPriceCalculationStrategy : IPriceCalculationStrategy
{
  public void Create(Kitchen kitchen)
  {
    // do nothing
  }

  public void AddPart(Part part, decimal userMarkup)
  {
    // do nothing
  }

  public void AddFeature(Feature feature, decimal userMarkup)
  {
    // do nothing
  }

  public void AddWallTreatment(Part part, decimal userMarkup, float wallHeight, float wallWidth)
  {
    // do nothing
  }
}
