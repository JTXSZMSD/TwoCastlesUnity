using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceSystem : MonoBehaviour
{

    public uint Gold = 0;
    public uint Lumber = 0;
    public uint Iron = 0;
    public uint Stone = 0;
    public uint People = 0;
    public uint PeopleLimit = 10;
    public uint Horses = 5;
    public uint ArmyLimit = 10;
    public uint WallsLimit = 10;
    public uint Powder = 0;
    public uint ResourceLimit = 500;

    public byte GoldMineImprovementTurn = 0;
    public byte LumberMillImprovementTurn = 0;
    public byte IronMineImprovementTurn = 0;
    public byte StoneQuarryImprovementTurn = 0;

    public void income()
    {
        GoldIncome();
        LumberIncome();
        IronIncome();
        StoneIncome();
        PeopleIncome();
    }

    private void GoldIncome()
    {
        //if (GoldMineImprovementTurn > 0)
        //{
        //    Gold += (BuildingSystem.GoldMineLevel * 30 + 140) * 1.25;
        //    GMIturn -= 1;
        //}
        //else
        //{
        //    PlayerGold += PlayerGMlvl * 30 + 140;
        //}
        //if (PlayerGold > PlayerResourceLimit)
        //{
        //    PlayerGold = PlayerResourceLimit;
        //}
    }

    private void LumberIncome()
    {

    }

    private void IronIncome()
    {

    }

    private void StoneIncome() 
    { 
        
    }

    private void PeopleIncome()
    {

    }
}
