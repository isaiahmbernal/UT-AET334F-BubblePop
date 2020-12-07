using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detectParentTween : MonoBehaviour
{
    private float parentX;
    private float thisX;
    private GameObject uiMovement;
    void Start()
    {
        //parentX = GetComponentInParent<RectTransform>().rect.x;
        parentX = 0;
        thisX = GetComponent<RectTransform>().localPosition.x;
        //uiMovement = this.GetComponent<GameObject>();

        if (thisX >= parentX)
        {
            parentX = 440;
        }
        else
        {
            parentX = -440;
        }
    }

    void Update()
    {
        if(thisX+440 > parentX)
        {
            scanFromRight();
        } else if(thisX-440 < parentX)
        {
            scanFromLeft();
        }
        else
        {
            thisX = parentX;
        }
    }

    void scanFromLeft()
    {
        if (thisX < parentX)
        {
            LeanTween.moveY(gameObject, 1, 2).setEaseInOutBack();
            thisX = parentX;
        } else if (thisX > parentX)
        {
            parentX += 1.01f;
        }
        else
        {
            thisX = parentX;
        }
    }

    void scanFromRight()
    {
        if (thisX > parentX)
        {
            LeanTween.moveY(gameObject, 1, 2).setEaseInOutBack();
            thisX = parentX;
        } else if(thisX < parentX)
        {
            parentX -= 1.01f;
        }
        else
        {
            thisX = parentX;
        }
    }
}
