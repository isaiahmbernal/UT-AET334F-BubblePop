using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Input_CanvasLoad : MonoBehaviour
{
    private Button myButton;

    [SerializeField] private GameObject myCanvas;
    [SerializeField] private GameObject canvasToLoad;
    [SerializeField] private bool disableSelf;

    void Start()
    {
        myButton = GetComponent<Button>();
        myButton.onClick.AddListener(Load);
        if (myCanvas == null)
            disableSelf = false;
    }

    void Load()
    {
        canvasToLoad.SetActive(true);

        if ((myCanvas != null) && disableSelf == true)
            myCanvas.SetActive(false);
    }
}
