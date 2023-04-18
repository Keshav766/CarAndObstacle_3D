using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObsticleCollision : MonoBehaviour
{
    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision other)
        {
            if(other.gameObject.tag == "Player")
            {
                if(!audioSource.isPlaying)
                    audioSource.Play();
            }
        }
}
