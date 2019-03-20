using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeVal : MonoBehaviour
{
    [SerializeField]
    public Text CText;
    public double TVal = 10.00;

    // Start is called before the first frame update
    void Start()
    {
        CText.GetComponent<Text>().enabled = false;//非表示
    }

    // Update is called once per frame
    void Update()
    {
     
    }

    public void CheckText()
    {
        CText.GetComponent<Text>().enabled = true;//表示
    }
}
