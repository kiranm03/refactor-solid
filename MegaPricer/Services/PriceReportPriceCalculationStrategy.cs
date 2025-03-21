using MegaPricer.Data;

namespace MegaPricer.Services;

public class PriceReportPriceCalculationStrategy : IPriceCalculationStrategy, IDisposable
{
  private StreamWriter _streamWriter;
  public void Create(Kitchen kitchen)
  {
    // Start writing to the report file
    string baseDirectory = AppContext.BaseDirectory;
    string path = baseDirectory + "Orders.csv";
    _streamWriter = new StreamWriter(path);
    _streamWriter.WriteLine($"{kitchen.Name} ({kitchen.KitchenId}) - Run time: {DateTime.Now.ToLongTimeString()} ");
    _streamWriter.WriteLine("");
    _streamWriter.WriteLine("Part Name,Part SKU,Height,Width,Depth,Color,Sq Ft $, Lin Ft $,Per Piece $,# Needed,Part Price,Add On %,Total Part Price");
  }

  public void AddPart(Part part, decimal userMarkup)
  {
    // write out required part(s) to the report file
    _streamWriter.WriteLine($"{part.SKU},{part.Height},{part.Width},{part.Depth},{part.ColorName},{part.ColorPerSquareFootCost},{part.LinearFootCost},{part.Cost},{part.Quantity},{part.Cost * part.Quantity},{part.ColorMarkup},{GlobalHelpers.Format(part.MarkedUpCost)}");
  }

  public void AddFeature(Feature feature, decimal userMarkup)
  {
    // write out required part(s) to the report file
    _streamWriter.WriteLine($"{feature.SKU},{feature.Height},{feature.Width},{feature.ColorName},{feature.ColorPerSquareFootCost},{feature.LinearFootCost},{feature.WholesalePrice},{feature.Quantity},{feature.WholesalePrice * feature.Quantity},{feature.ColorMarkup},{GlobalHelpers.Format(feature.MarkedUpCost)}");
  }

  public void AddWallTreatment(Part part, decimal userMarkup, float wallHeight, float wallWidth)
  {
    // write out required part(s) to the report file
    _streamWriter.WriteLine($"{part.SKU},{wallHeight},{wallWidth},{part.ColorName},{part.ColorPerSquareFootCost} , {part.LinearFootCost},{part.Cost},{part.Quantity},{part.Cost * part.Quantity},{part.ColorMarkup},{GlobalHelpers.Format(part.MarkedUpCost)}");
  }

  public void Dispose()
  {
    if(_streamWriter != null)
    {
      _streamWriter.Close();
      _streamWriter.Dispose();
    }
  }
}
