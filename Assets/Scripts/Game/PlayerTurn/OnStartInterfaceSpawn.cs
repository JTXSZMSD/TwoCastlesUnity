using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnStartInterfaceSpawn : MonoBehaviour
{
    [SerializeField]
    private GameObject resLinePrefab;
    [SerializeField]
    private GameObject FirstStepButtonsMain;

    private void Start()
    {
        Instantiate(resLinePrefab, this.transform);
        Instantiate(FirstStepButtonsMain, this.transform);
    }
}
