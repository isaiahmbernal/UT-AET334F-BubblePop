using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Author : Isaiah Bernal
public class UI_ObjectEnable : MonoBehaviour
{
    private Button myButton;

    [SerializeField] private GameObject objectToEnable;

    void Start()
    {
        myButton = GetComponent<Button>();
        myButton.onClick.AddListener(Enable);
    }

    void Enable()
    {
        objectToEnable.SetActive(true);
    }
}