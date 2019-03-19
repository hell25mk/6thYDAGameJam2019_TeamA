
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class beem : MonoBehaviour
{

    private bool isPlaying;
    [SerializeField] ParticleSystem particle;

    //public void Switch()
    //{
    //    if (isPlaying)
    //    {
    //        particle.Play(true);
    //    }
    //    else
    //    {
    //        particle.Stop(true, ParticleSystemStopBehavior.StopEmitting);
    //    }
    //    isPlaying = !isPlaying;
    //}

    void OnTriggerEnter(Collider other)
    {
        string layerName = LayerMask.LayerToName(other.gameObject.layer);

        if (layerName == "Goal")
        {
            particle.Stop();
            Debug.Log("atari");
        }
    }

}
