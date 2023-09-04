using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayer : MonoBehaviour
{
    [Header("Shooting")]
    [SerializeField] AudioClip shootingClip;
    [SerializeField] [Range(0f, 1f)] float shootingVolume = 1f;

    [Header("Damage Taken Voice")]
    [SerializeField] AudioClip damageClip;
    [SerializeField] [Range(0f, 1f)] float damageVolume = 1f;

    [Header("Dying Voice")]
    [SerializeField] AudioClip dyingClip;
    [SerializeField] [Range(0f, 1f)] float dyingVolume = 1f;

    void Awake()
    {
        ManageSingleton();
    }

    void ManageSingleton()
    {
        int instanceCount = FindObjectsOfType(GetType()).Length;
        if(instanceCount > 1)
        {
            gameObject.SetActive(false);
            Destroy(gameObject);
        }
    }

    public void PlayShootingClip()
    {
        if(shootingClip != null)
        {
            AudioSource.PlayClipAtPoint(shootingClip,
                                        Camera.main.transform.position,
                                        shootingVolume);

        }
    }

    public void PlayDamageClip()
    {
        if(damageClip != null)
        {
            AudioSource.PlayClipAtPoint(damageClip,
                                        Camera.main.transform.position,
                                        damageVolume);

        }
    }

    public void PlayDyingClip()
    {
        if(dyingClip != null)
        {
            AudioSource.PlayClipAtPoint(dyingClip,
                                        Camera.main.transform.position,
                                        dyingVolume);

        }
    }
}
