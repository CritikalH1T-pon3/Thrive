﻿using System;
using Newtonsoft.Json;

[JSONAlwaysDynamicType]
public class CellPlacementActionData : HexPlacementActionData<HexWithData<CellTemplate>, MulticellularSpecies>
{
    [JsonConstructor]
    public CellPlacementActionData(HexWithData<CellTemplate> hex, Hex location, int orientation) : base(hex, location,
        orientation)
    {
    }

    public CellPlacementActionData(HexWithData<CellTemplate> hex) : base(hex, hex.Position,
        hex.Data?.Orientation ?? throw new ArgumentException("Hex with no data"))
    {
    }

    protected override double CalculateCostInternal()
    {
        return PlacedHex.Data?.CellType.MPCost ?? throw new InvalidOperationException("Hex with no data");
    }

    protected override CombinableActionData CreateDerivedMoveAction(HexRemoveActionData<HexWithData<CellTemplate>,
        MulticellularSpecies> data)
    {
        return new CellMoveActionData(data.RemovedHex, data.Location, Location,
            data.Orientation, Orientation);
    }

    protected override CombinableActionData CreateDerivedPlacementAction(
        HexMoveActionData<HexWithData<CellTemplate>, MulticellularSpecies> data)
    {
        return new CellPlacementActionData(PlacedHex, data.NewLocation, data.NewRotation);
    }
}
