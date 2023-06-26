using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ShowPlayerIron : MonoBehaviour
{
    [SerializeField]
    private ResourceSystem Resources;

    [SerializeField]
    private TMP_Text TextMesh;
    
    void Start()
    {
        TextMesh.text = Resources.Iron.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        TextMesh.text = Resources.Iron.ToString();
    }
}
