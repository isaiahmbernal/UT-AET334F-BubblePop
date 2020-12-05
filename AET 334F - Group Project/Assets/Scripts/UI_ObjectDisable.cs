using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Author : Isaiah Bernal
public class UI_ObjectDisable : MonoBehaviour
{
    private Button myButton;

    [SerializeField] private GameObject objectToDisable;

    void Start()
    {
        myButton = GetComponent<Button>();
        myButton.onClick.AddListener(Disable);
    }

    void Disable()
    {
        objectToDisable.SetActive(false);
    }
}
