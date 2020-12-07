using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scaleTween : MonoBehaviour
{

    //invoke("name of whatever void function", 2.0f);

    private GameObject UIToMove;
    private void Start()
    {
        LeanTween.scale(gameObject, new Vector3(0, 0, 0), 0);
        LeanTween.scale(gameObject, new Vector3(0.90f, 0.90f, 0.90f), 2f).setEaseInBounce();
    }
    public void OnClose()
    {
        LeanTween.scale(gameObject, new Vector3(0, 0, 0), 0.5f).setOnComplete(DestroyMe);
    }

    void DestroyMe()
    {
        Destroy(gameObject);
    }
}
