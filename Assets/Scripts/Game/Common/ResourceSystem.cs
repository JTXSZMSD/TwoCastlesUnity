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

    public void income()
    {
        //Gold
        Gold += GoldIncome();
        if (Gold > ResourceLimit)
        {
            Gold = ResourceLimit;
        }

        //    //Lumber
        //    Lumber += LumberIncome();
        //    if (Lumber > ResourceLimit) 
        //    { 
        //        Lumber = ResourceLimit;
        //    }

        //    //Iron
        //    Iron += IronIncome();
        //    if (Iron > ResourceLimit) 
        //    { 
        //        Iron = ResourceLimit;
        //    }

        //    //Stone
        //    Stone += StoneIncome();
        //    if (Stone > ResourceLimit)
        //    { 
        //        Stone = ResourceLimit; 
        //    }

        //    //People
        //    People += PeopleIncome();
        //    if (People > PeopleLimit)
        //    {
        //        People = PeopleLimit;
        //    }
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

    //private uint LumberIncome()
    //{
    //    uint temp;
    //    return temp;
    //}

    //private uint IronIncome()
    //{
    //    uint temp;
    //    return temp;
    //}

    //private uint StoneIncome() 
    //{
    //    uint temp;
    //    return temp;
    //}

    //private uint PeopleIncome()
    //{
    //    uint temp;
    //    return temp;
    //}
}
