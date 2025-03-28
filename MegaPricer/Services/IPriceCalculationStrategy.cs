﻿using MegaPricer.Data;

namespace MegaPricer.Services;

public interface IPriceCalculationStrategy
{
  void Create(Kitchen kitchen);
  void AddPart(Part part, decimal userMarkup);
  void AddFeature(Feature feature, decimal userMarkup);
  void AddWallTreatment(Part part, decimal userMarkup, float wallHeight, float wallWidth);
}
