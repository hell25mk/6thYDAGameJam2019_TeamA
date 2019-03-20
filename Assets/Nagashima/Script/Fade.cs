using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Fade : MonoBehaviour
{
    [SerializeField]
    public GameObject imageObject;

    

    private float alphaValue;
    // Start is called before the first frame update
    void Start()
    {
        alphaValue =1.0f;
        
    }

    public void FadeOut() {

        if(alphaValue < 0) {
            return;
        }

        alphaValue-=0.01f;

        imageObject.GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, alphaValue);

    }

    // Update is called once per frame
    void Update()
    {
        FadeOut();
        //Debug.Log(alphaValue);
    }

    

}
