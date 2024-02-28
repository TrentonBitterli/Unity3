using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerup : MonoBehaviour
{
    public AudioSource powerup;

    void Start()
    {
        powerup.pitch = 1.0f;
    }

    private void OnCollisionEnter(Collision coll)
    {
        if (coll.gameObject.CompareTag("Powerup1"))
        {
            powerup.pitch = 1;
            powerup.Play();
            Destroy(coll.gameObject);
        }

        if (coll.gameObject.CompareTag("Powerup2"))
        {
            powerup.pitch = 2;
            powerup.Play();
            Destroy(coll.gameObject);
        }

        if (coll.gameObject.CompareTag("Powerup3"))
        {
            powerup.pitch = 0.5f;
            powerup.Play();
            Destroy(coll.gameObject);
        }
    }
}
