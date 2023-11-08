using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{public AudioSource sound_death;
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.transform.tag=="Enemy")
        {
            PlayerManager.isGameOver = true;
            gameObject.SetActive(false);
            sound_death.Play();
        }
    }
}
