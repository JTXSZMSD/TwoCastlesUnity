using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingsButtonScript : MonoBehaviour
{
    [SerializeField]
    private GameObject parentObjectToDestroy;
    [SerializeField]
    private GameObject prefabInterfaceToSpawn;
    private GameObject canvas;

    public void OnClickAction()
    {
        canvas = GameObject.Find("Canvas");
        Instantiate(prefabInterfaceToSpawn, canvas.transform);
        Destroy(parentObjectToDestroy);
        
    }

}
