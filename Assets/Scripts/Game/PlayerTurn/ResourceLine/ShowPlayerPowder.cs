using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ShowPlayerPowder : MonoBehaviour
{
    [SerializeField]
    private ResourceSystem Resources;

    [SerializeField]
    private TMP_Text TextMesh;

    void Start()
    {
        TextMesh.text = Resources.Powder.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        TextMesh.text = Resources.Powder.ToString();
    }
}
