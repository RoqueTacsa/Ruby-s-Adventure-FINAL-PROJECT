using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CucumberCollectible : MonoBehaviour
{
    public AudioClip collectedClip;
    
    void OnTriggerEnter2D(Collider2D other)
    {
        RubyController controller = other.GetComponent<RubyController>();

        if (controller != null)
        {
            controller.speed = 1f;
            Destroy(gameObject);
            controller.PlaySound(collectedClip);
        }

    }
}
