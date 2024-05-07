using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomDial : MonoBehaviour
{
    public AudioClip[] sounds;
    private AudioSource source;
    // Start is called before the first frame update
    void Start()
    {
      source = GetComponent<AudioSource>();  
    }

    // Update is called once per frame
    void Update()
    {
     
    }

private void OnTriggerEnter(Collider other)
{
    source.clip = sounds[Random.Range(0, sounds.Length)];
    source.Play();
}

}
