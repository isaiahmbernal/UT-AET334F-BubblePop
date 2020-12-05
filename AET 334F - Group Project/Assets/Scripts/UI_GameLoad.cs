using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Author : Isaiah Bernal
public class UI_GameLoad : MonoBehaviour
{
    private Button myButton;

    [SerializeField] private GameObject singleplayer;
    [SerializeField] private GameObject multiplayer;
    [SerializeField] private Config_Info configInfo;

    void Start()
    {
        myButton = GetComponent<Button>();
        myButton.onClick.AddListener(Load);
    }

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
