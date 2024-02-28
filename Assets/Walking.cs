using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walking : MonoBehaviour
{
    private AudioSource audioSource;
    private Vector3 lastPosition;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        lastPosition = transform.position;
    }
       void Update()
    {
        // If the character has moved and the audio is not currently playing
        if (transform.position != lastPosition && !audioSource.isPlaying)
        {
            // Randomly change the playback speed a small amount
            audioSource.pitch = Random.Range(2.8f, 3.5f);
            // Play the step sound
            audioSource.Play();
        }
        // Update lastPosition for the next frame
        lastPosition = transform.position;
    }
}
