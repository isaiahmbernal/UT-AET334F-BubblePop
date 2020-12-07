using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//enum variables defining the states of the UI animation types.
public enum UIAnimationTypes
{
    //moving from a vector position, to one specific point
    Move,
    //scaling the collider encapsulating the sprite or 
    Scale,
    ScaleX,
    ScaleY,
    Fade
}
public class objectBounceBetween : MonoBehaviour
{
    public GameObject objectToAnimate;

    public UIAnimationTypes animationType;
    public LeanTweenType easeType;
    public float duration;
    public float delay;

    public bool loop;
    public bool pingpong;

    public bool startPostionOffSet;
    public Vector3 from;
    public Vector3 to;

    private LTDescr _tweenObject;

    public bool showOnEnable;
    public bool workOnDisable;

    public void OnEnable()
    {
        if (showOnEnable)
        {
            Show();
        }
    }

    public void Show()
    {
        HandleTween();
    }

    public void HandleTween()
    {
        if (objectToAnimate == null)
        {
            objectToAnimate = gameObject;
        }

        switch (animationType)
        {
            case UIAnimationTypes.Fade:
                Fade();
                break;
            case UIAnimationTypes.Move:
                MoveAbsolute();
                break;
            case UIAnimationTypes.Scale:
                Scale();
                break;
            case UIAnimationTypes.ScaleX:
                Scale();
                break;
            case UIAnimationTypes.ScaleY:
                Scale();
                break;
        }

        _tweenObject.setDelay(delay);
        _tweenObject.setEase(easeType);

        if (loop)
        {
            _tweenObject.loopCount = int.MaxValue;
        }
        if (pingpong)
        {
            _tweenObject.setLoopPingPong();
        }
    }

    public void Fade()
    {
        if(gameObject.GetComponent<CanvasGroup>() == null)
        {
            gameObject.AddComponent<CanvasGroup>();
        }

        if (startPostionOffSet)
        {
            objectToAnimate.GetComponent<CanvasGroup>().alpha = from.x;
        }
        _tweenObject = LeanTween.alphaCanvas(objectToAnimate.GetComponent<CanvasGroup>(), to.x, duration);
    }

    public void MoveAbsolute()
    {
        objectToAnimate.GetComponent<RectTransform>().anchoredPosition = from;


        _tweenObject = LeanTween.move(objectToAnimate.GetComponent<RectTransform>(), to, duration);
    }

    public void Scale()
    {
        if (startPostionOffSet)
        {
            objectToAnimate.GetComponent<RectTransform>().localScale = from;
        }
        _tweenObject = LeanTween.scale(objectToAnimate, to, duration);
    }

    void SwapDirection()
    {
        var temp = from;
        from = to;
        to = temp;
    }

    public void OnDisable()
    {
        SwapDirection();

        HandleTween();

        _tweenObject.setOnComplete(() =>
        {
            SwapDirection();

            gameObject.SetActive(false);
        });

    }
}
