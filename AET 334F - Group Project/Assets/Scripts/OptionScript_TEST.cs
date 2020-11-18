using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionScript_TEST : MonoBehaviour
{
    public Slider MusicSlider;
    public AudioSource Music;
    public Slider SfxSlider;
    public AudioSource Sfx;

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
        MusicSlider.value = PlayerPrefs.GetFloat("current volume", MusicSlider.value);
        SfxSlider.value = PlayerPrefs.GetFloat("current difficulty", SfxSlider.value);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void CtrlMusic()
    {
        MusicSlider.value = Music.volume;
    }

    public void CtrlSfx()
    {
        SfxSlider.value = Sfx.volume;
    }

    public void SaveSettings()
    {
        PlayerPrefs.SetFloat("current volume", MusicSlider.value);
        PlayerPrefs.SetFloat("current difficulty", SfxSlider.value);
        Debug.Log("save");
        PlayerPrefs.Save();
    }

    public void Default()
    {
        MusicSlider.value = 50;
        MusicSlider.value = Music.volume;

        SfxSlider.value = 50;
        SfxSlider.value = Sfx.volume;
    }
}
