using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ShowPlayerLumber : MonoBehaviour
{
    [SerializeField]
    private ResourceSystem Resources;

    [SerializeField]
    private TMP_Text TextMesh;

    // Start is called before the first frame update
    void Start()
    {
        TextMesh.text = Resources.Lumber.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        TextMesh.text = Resources.Lumber.ToString();
    }
}
