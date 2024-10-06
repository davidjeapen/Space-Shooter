using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soundclick : MonoBehaviour
{
    AudioSource mySource;
    int Pitch = 0;
    // Start is called before the first frame update
    void Start()
    {
        mySource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown() {
        mySource.pitch = Pitch;
        mySource.Play();
        Pitch++;
    }
}
