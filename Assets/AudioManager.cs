using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource SfxSource; 
    public AudioClip background;
    public AudioClip jump;
    // Start is called before the first frame update
    private void Start()
    {
        musicSource.clip=background;
        musicSource.Play();
    }

    // Update is called once per frame
   public void PlaySfx(AudioClip clip)
    {
        SfxSource.PlayOneShot(clip);
    }
}
