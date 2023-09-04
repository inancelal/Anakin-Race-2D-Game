using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamagerDealer : MonoBehaviour
{
    [SerializeField] int damage =10;
    AudioPlayer audioPlayer;

    void Awake()
    {
        audioPlayer = FindObjectOfType<AudioPlayer>();
    }

    public int GetDamage()
    {   
        audioPlayer.PlayDamageClip();
        return damage;
    }

    public void Hit()
    {
        audioPlayer.PlayDyingClip();
        Destroy(gameObject);
    }
}
