using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameClear : MonoBehaviour
{
    private int lightHitCount;

    // Start is called before the first frame update
    void Start()
    {
        lightHitCount = 61;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnParticleCollision(GameObject obj) {

        if(obj.tag == "Light") {

            Debug.Log("当たった");
            if(lightHitCount > 60) {
                SceneManager.LoadScene("ResultScene");
            }

            lightHitCount++;
        }

    }

}
