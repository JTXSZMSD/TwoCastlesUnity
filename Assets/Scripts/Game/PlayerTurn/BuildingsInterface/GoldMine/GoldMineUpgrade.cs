using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoldMineUpgrade : MonoBehaviour
{
    [SerializeField]
    private BuildingsSystem Buildings;

    [SerializeField]
    private ResourceSystem Resources;

    [SerializeField]
    private GameObject SelfButton;

    private Button ButtonComponent;


    private void Start()
    {
        ButtonComponent = GetComponent<Button>();
    }


    private void Update()
    {
        if (Resources.Gold < Buildings.GoldMineLevel * 20 
            || Resources.Lumber < Buildings.GoldMineLevel * 20 
            || Resources.Iron < Buildings.GoldMineLevel * 20)
        {
            ButtonComponent.interactable = false;
        }
    }

    public void Upgrade()
    {
        Resources.Gold -= Buildings.GoldMineLevel * 20;
        Resources.Lumber -= Buildings.GoldMineLevel * 20;
        Resources.Iron -= Buildings.GoldMineLevel * 20;
        Buildings.GoldMineLevel += 1;
        
        if (Buildings.GoldMineLevel >= 12)
        {
            SelfButton.SetActive(false);
        }
    }
}
