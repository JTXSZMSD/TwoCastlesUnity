using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceSystem : MonoBehaviour
{
    public BuildingsSystem Buildings;

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

    private void Awake()
    {
        income();
    }

    public void income()
    {
        //Gold
        Gold += GoldIncome();
        if (Gold > ResourceLimit)
        {
            Gold = ResourceLimit;
        }

        //Lumber
        Lumber += LumberIncome();
        if (Lumber > ResourceLimit)
        {
            Lumber = ResourceLimit;
        }

        //Iron
        Iron += IronIncome();
        if (Iron > ResourceLimit)
        {
            Iron = ResourceLimit;
        }

        //Stone
        Stone += StoneIncome();
        if (Stone > ResourceLimit)
        {
            Stone = ResourceLimit;
        }

        //People
        People += PeopleIncome();
        if (People > PeopleLimit)
        {
            People = PeopleLimit;
        }
    }

    private uint GoldIncome()
    {
        uint temp;
        if (GoldMineImprovementTurn > 0)
        {
            temp = Convert.ToUInt32((Buildings.GoldMineLevel * 30 + 140) * 1.25);
            GoldMineImprovementTurn -= 1;
        }
        else
        {
            temp = Buildings.GoldMineLevel * 30 + 140;
        }
        return temp;
    }

    private uint LumberIncome()
    {
        uint temp;
        if (LumberMillImprovementTurn > 0)
        {
            temp = Convert.ToUInt32((Buildings.LumberMillLevel * 30 + 140) * 1.25);
            LumberMillImprovementTurn -= 1;
        }
        else
        {
            temp = Buildings.LumberMillLevel * 30 + 140;
        }
        return temp;
    }

    private uint IronIncome()
    {
        uint temp;
        if (IronMineImprovementTurn > 0)
        {
            temp = Convert.ToUInt32((Buildings.IronMineLevel * 30 + 140) * 1.25);
            IronMineImprovementTurn -= 1;
        }
        else
        {
            temp = Buildings.IronMineLevel * 30 + 140;
        }
        return temp;
    }

    private uint StoneIncome()
    {
        uint temp;
        if (StoneQuarryImprovementTurn > 0)
        {
            temp = Convert.ToUInt32((Buildings.StoneQuarryLevel * 30 + 140) * 1.25);
            StoneQuarryImprovementTurn -= 1;
        }
        else
        {
            temp = Buildings.StoneQuarryLevel * 30 + 140;
        }
        return temp;
    }

    private uint PeopleIncome()
    {
        uint temp;
        if (Buildings.HousesLevel <= 4)
        {
            temp = 5;
        }
        else if (Buildings.HousesLevel > 4 && Buildings.HousesLevel <= 8)
        {
            temp = 20;
        }
        else
        {
            temp = 40;
        }

        return temp;
    }
}
