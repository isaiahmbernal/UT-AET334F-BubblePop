using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Author : Isaiah Bernal
public class UI_GameLoad : MonoBehaviour
{
    private Button myButton;

    // Variables to load either singleplayer or multiplayer
    [SerializeField] private GameObject singleplayer;
    [SerializeField] private GameObject multiplayer;
    [SerializeField] private Config_Info configInfo;

    void Start()
    {
        myButton = GetComponent<Button>();
        myButton.onClick.AddListener(Load);
    }

    // Depending on whether multiplayer is toggled on or not, launch either singleplayer or multiplayer
    void Load()
    {
        if (configInfo.isMulti == false)
        {
            singleplayer.SetActive(true);
            configInfo.isPlaying = true;
        }
        else
        {
            multiplayer.SetActive(true);
            configInfo.isPlaying = true;
        }
    }
}
