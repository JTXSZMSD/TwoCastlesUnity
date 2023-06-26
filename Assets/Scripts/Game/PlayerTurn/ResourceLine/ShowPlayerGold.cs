using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ShowPlayerGold : MonoBehaviour
{
    [SerializeField]
    private ResourceSystem Resources;

    [SerializeField]
    private TMP_Text TextMesh;

    // Start is called before the first frame update
    void Start()
    {
        TextMesh.text = Resources.Gold.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        TextMesh.text = Resources.Gold.ToString();
    }
}
