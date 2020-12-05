using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_SongPlay : MonoBehaviour
{
    private Button myButton;
    [SerializeField] private GameObject musicObject;
    [SerializeField] private AudioSource songToPlay;

    void Start()
    {
        myButton = GetComponent<Button>();
        myButton.onClick.AddListener(PlaySong);
    }

    void PlaySong()
    {
        musicObject.SetActive(true);
        songToPlay.Play(); 
    }
}