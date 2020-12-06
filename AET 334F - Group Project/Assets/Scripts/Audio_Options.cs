using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.Audio;

// Author : Melina Rosales
public class Audio_Options : MonoBehaviour
{
    //get the Sliders and Audio Sources
    public Slider MusicSlider;
    public AudioSource song1;
    public AudioSource song2;
    public Slider SfxSlider;
    public AudioSource sfx1;
    public AudioSource sfx2;
    public AudioSource sfx3;

    //float Mvolume;

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
        //get previous PlayerPref values
        song1.volume = PlayerPrefs.GetFloat("current volume", song1.volume);
        song2.volume = PlayerPrefs.GetFloat("current volume", song2.volume);
        sfx1.volume = PlayerPrefs.GetFloat("current SFX volume", sfx1.volume);
        sfx2.volume = PlayerPrefs.GetFloat("current SFX volume", sfx2.volume);
        sfx3.volume = PlayerPrefs.GetFloat("current SFX volume", sfx3.volume);
        MusicSlider.value = song1.volume;
        MusicSlider.value = song2.volume;
        SfxSlider.value = sfx1.volume;
        SfxSlider.value = sfx2.volume;
        SfxSlider.value = sfx3.volume;
    }


    // Update is called once per frame
    void Update()
    {
        //set volume levels equal to sliders
        song1.volume = MusicSlider.value;
        song2.volume = MusicSlider.value;
        sfx1.volume = SfxSlider.value;
        sfx2.volume = SfxSlider.value;
        sfx3.volume = SfxSlider.value;
        //Default();

    }

    public void SaveSettings()
    {
        //save player prefs of volumes. use button
        PlayerPrefs.SetFloat("current volume", song1.volume);
        PlayerPrefs.SetFloat("current volume", song2.volume);
        PlayerPrefs.SetFloat("current SFX volume", sfx1.volume);
        PlayerPrefs.SetFloat("current SFX volume", sfx2.volume);
        PlayerPrefs.SetFloat("current SFX volume", sfx3.volume);

        Debug.Log("save");
        PlayerPrefs.Save();
    }

   public void Default()
    {
        //reset volume settings to 50% . For button.
        Debug.Log("SET TO DEFAULT");

        sfx1.volume = 0.5f;
        SfxSlider.value = sfx1.volume;
        sfx2.volume = 0.5f;
        SfxSlider.value = sfx2.volume;
        sfx3.volume = 0.5f;
        SfxSlider.value = sfx3.volume;

        song1.volume = 0.5f;
        song2.volume = 0.5f;
        MusicSlider.value = song1.volume;
        MusicSlider.value = song2.volume;
    }
}
