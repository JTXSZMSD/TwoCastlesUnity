using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ChooseGameModel : MonoBehaviour
{
    public static string GameModel;

    public void ChooseModel(string model)
    {
        GameModel = model;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
