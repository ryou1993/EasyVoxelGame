using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalTrigger : MonoBehaviour
{
    private ParticleSystem system;
    private AudioSource audio;
    private bool isGoal = false;
    // Start is called before the first frame update
    void Start()
    {
        system = GetComponent<ParticleSystem>();
        audio = GetComponent<AudioSource>();
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!isGoal && other.tag == "Player")
        {
            isGoal = true;
            system.Play();
            audio.Play();
        }
    }
}
