using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    private static AudioSource src;
    public AudioClip song;

    // Start is called before the first frame update
    void Start()
    {
        src = GetComponent<AudioSource>();
        src.clip = song;
        src.Play();
    }

    public static void PlaySound (AudioClip clip)
    {
        src.PlayOneShot(clip);
    }
}
