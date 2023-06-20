using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingsSystem : MonoBehaviour
{
    public uint GoldMineLevel = 1;
    public uint LumberMillLevel = 1;
    public uint IronMineLevel = 1;
    public uint StoneQuarryLevel = 1;
    public uint StorehouseLevel = 1;
    public uint HousesLevel = 1;
    public uint BarracksLevel = 1;
    public uint WallsLevel = 1;
    public uint StableLevel = 1;

    public void UpgradeGoldMine()
    {
        uint GoldCost = GoldMineLevel * 20;
        uint IronCost = GoldMineLevel * 20;
        uint LumberCost = GoldMineLevel * 20;

    }

    public void UpgradeLumberMill() 
    {
        uint GoldCost = LumberMillLevel * 20;
        uint IronCost = LumberMillLevel * 20;
        uint LumberCost = LumberMillLevel * 20;
        uint StoneCost = LumberMillLevel * 20;

    }

    public void UpgradeIronMine() 
    {
        uint GoldCost = IronMineLevel * 20;
        uint IronCost = IronMineLevel * 20;
        uint LumberCost = IronMineLevel * 20;

    }

    public void UpgradeStoneQuarry() 
    {
        uint GoldCost = StoneQuarryLevel * 20;
        uint IronCost = StoneQuarryLevel * 20;
        uint LumberCost = StoneQuarryLevel * 20;

    }

    public void UpgradeStorehouse() 
    {
        uint GoldCost = StorehouseLevel * 20;
        uint IronCost = StorehouseLevel * 20;
        uint LumberCost = StorehouseLevel * 20;
        uint StoneCost = StorehouseLevel * 20;
    }

    public void UpgradeHouses() 
    {
        uint GoldCost = HousesLevel * 20;
        uint IronCost = HousesLevel * 20;
        uint LumberCost = HousesLevel * 20;
        uint StoneCost = HousesLevel * 20;
    }

    public void UpgradeBarracks() 
    {
        uint GoldCost = BarracksLevel * 20;
        uint IronCost = BarracksLevel * 20;
        uint LumberCost = BarracksLevel * 20;
        uint StoneCost = BarracksLevel * 20;
    }

    public void UpgradeWalls() 
    {
        uint GoldCost = WallsLevel * 20;
        uint IronCost = WallsLevel * 20;
        uint LumberCost = WallsLevel * 20;
        uint StoneCost = WallsLevel * 60;

    }

    public void UpgradeStable() 
    {
        uint GoldCost = StableLevel * 20;
        uint IronCost = StableLevel * 20;
        uint LumberCost = StableLevel * 20;
        uint StoneCost = StableLevel * 20;
    }
}
