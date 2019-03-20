using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ParticleCheck : MonoBehaviour
{
    [SerializeField]
    private GameObject switchObject;
    private ParticleSystem particle;

    // Start is called before the first frame update
    void Start()
    {
        particle = GetComponent<ParticleSystem>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnParticleCollision(GameObject obj)
    {

        if (obj.tag == "Goal")
        {
            //Debug.Log("衝突");
            particle.Pause();
            switchObject.GetComponent<SwitchObject>().IsColorChange = true;
        }

    }

}
