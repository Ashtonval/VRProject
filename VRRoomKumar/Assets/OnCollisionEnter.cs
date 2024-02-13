using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce : MonoBehaviour
{
    public AudioSource audioSource;
    private bool isPlaying = false;

    public void Start()
    {
        GetComponent<AudioSource>();
        GetComponent<SphereCollider>();
    }
    public void OnCollisionEnter (Collision other)
    {
        if(other.gameObject.tag == "Floor")
        {
            audioSource.Play();
        }
    }
}
