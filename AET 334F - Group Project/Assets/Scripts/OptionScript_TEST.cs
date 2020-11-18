using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;


public class OptionScript_TEST : MonoBehaviour
{
    public Slider MusicSlider;
    public AudioSource Music;
    public Slider SfxSlider;
    public AudioSource Sfx;

    float Mvolume;

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
        Music.volume = PlayerPrefs.GetFloat("current volume", Mvolume);
        //SfxSlider.value = PlayerPrefs.GetFloat("current difficulty", SfxSlider.value);
        MusicSlider.value = Mvolume;
    }

    // Update is called once per frame
    void Update()
    {
        CtrlMusic();
        CtrlSfx();
    }

    public void CtrlMusic()
    {
        Mvolume = Music.volume;
        Music.volume = MusicSlider.value;
    }

    public void CtrlSfx()
    {
        Sfx.volume = SfxSlider.value;
    }

    public void SaveSettings()
    {
        PlayerPrefs.SetFloat("current volume", Mvolume);
        PlayerPrefs.SetFloat("current difficulty", SfxSlider.value);
        Debug.Log("save");
        PlayerPrefs.Save();
    }

    public void Default()
    {
        Sfx.volume = 5.0f;
        Sfx.volume = SfxSlider.value;

        Music.volume = 5.0f;
        Music.volume= MusicSlider.value;
    }
}
