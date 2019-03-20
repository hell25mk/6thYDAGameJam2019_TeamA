using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwitchObject : MonoBehaviour
{
    [SerializeField]
    private GameObject imageObject;
    [SerializeField]
    private GameObject sceneMove;
    private float colorValue;

    private bool isColorChange;

    public bool IsColorChange {
        set { isColorChange = value; }
    }

    // Start is called before the first frame update
    void Start() {
        colorValue = 0.0f;
        isColorChange = false;

    }

    // Update is called once per frame
    void Update() {

        if(isColorChange) {
            if(colorValue > 2.0f) {
                sceneMove.GetComponent<SceneMove>().GoToScene();
                return;
            }

            colorValue += 0.005f;

            imageObject.GetComponent<SpriteRenderer>().color = new Color(colorValue, colorValue, 0.0f, 1.0f);
        }
    }
}
