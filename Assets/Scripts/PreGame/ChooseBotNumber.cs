using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChooseBotNumber : MonoBehaviour
{
    public GameObject InterfaceToUnactive;
    public GameObject InterfaceToActive;
    
    public GameObject SetModel2;
    public GameObject SetModel3;
    public GameObject SetModel4;
    public GameObject SetModel5;
    public GameObject SetModel6;
    public GameObject SetModel7;
    public GameObject SetModel8;
    
    public void ChooseNumber(int number)
    {
        InterfaceToUnactive.SetActive(false);
        InterfaceToActive.SetActive(true);

        if (number == 1)
        {
            ChooseGameModel.GameModel = "1v1";
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        else if (number == 2) 
        {
            SetModel2.SetActive(true);
        }
        else if (number == 3)
        {
            SetModel3.SetActive(true);
        }
        else if (number == 4)
        {
            SetModel4.SetActive(true);
        }
        else if (number == 5)
        {
            SetModel5.SetActive(true);
        }
        else if (number == 6)
        {
            SetModel6.SetActive(true);
        }
        else if (number == 7)
        {
            SetModel7.SetActive(true);
        }
        else if (number == 8)
        {
            SetModel8.SetActive(true);
        }
    }


}
