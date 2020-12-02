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
    public AudioSource Music;
    public Slider SfxSlider;
    public AudioSource Sfx;

    //float Mvolume;

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
        //get previous PlayerPref values
        Music.volume = PlayerPrefs.GetFloat("current volume", Music.volume);
        Sfx.volume = PlayerPrefs.GetFloat("current SFX volume", Sfx.volume);
        MusicSlider.value = Music.volume;
        SfxSlider.value = Sfx.volume;
    }


    // Update is called once per frame
    void Update()
    {
        //set volume levels equal to sliders
        Music.volume = MusicSlider.value;
        Sfx.volume = SfxSlider.value;
        //Default();

    }

    public void SaveSettings()
    {
        //save player prefs of volumes. use button
        PlayerPrefs.SetFloat("current volume", Music.volume);
        PlayerPrefs.SetFloat("current SFX volume", Sfx.volume);

        Debug.Log("save");
        PlayerPrefs.Save();
    }

   public void Default()
    {
        //reset volume settings to 50% . For button.
        Debug.Log("SET TO DEFAULT");

        Sfx.volume= 0.5f;
        SfxSlider.value = 0.5f;
        Sfx.volume = SfxSlider.value;

        Music.volume = 0.5f;
        MusicSlider.value = 0.5f;
        Music.volume = MusicSlider.value;
    }
}
