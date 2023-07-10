using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GoldMineParameters : MonoBehaviour
{

    [SerializeField]
    private BuildingsSystem Buildings;

    [SerializeField]
    private TMP_Text CurrentLVL;

    [SerializeField]
    private TMP_Text CurrentIncome;

    [SerializeField]
    private TMP_Text GoldCost;

    [SerializeField]
    private TMP_Text LumberCost;

    [SerializeField]
    private TMP_Text IronCost;

    // Update is called once per frame
    void Update()
    {
        CurrentLVL.text = Buildings.GoldMineLevel.ToString() + "/12";

        CurrentIncome.text = (Buildings.GoldMineLevel * 30 + 140).ToString();

        GoldCost.text = (Buildings.GoldMineLevel * 20).ToString();

        LumberCost.text = (Buildings.GoldMineLevel * 20).ToString();

        IronCost.text = (Buildings.GoldMineLevel * 20).ToString();
    }
}
