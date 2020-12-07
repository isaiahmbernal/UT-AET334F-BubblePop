using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Author : Isaiah Bernal
public class UI_ObjectToggle : MonoBehaviour
{
    private Button myButton;
    [SerializeField] private GameObject objectToToggle;

    void Start()
    {
        myButton = GetComponent<Button>();
        myButton.onClick.AddListener(Toggle);
    }

    // Depending on whether the assigned game object is on or off, set it to the opposite of what it was
    void Toggle()
    {
        if (objectToToggle.active == true)
            objectToToggle.SetActive(false);
        else if (objectToToggle.active == false)
            objectToToggle.SetActive(true);
    }
}
