using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateText : MonoBehaviour
{
    public List<string> dialogueText = new List<string>();
    public int index = 0;
    public Text dialogueTextbox;

    private void Start()
    {
        dialogueText.Add("Hello! Welcome to Bubble Pop!");
        dialogueText.Add("Pop bubbles by using the arrow keys to hit beats when the bubbles pass the arrows at the top of the screen");
        dialogueText.Add("Be careful, miss too many bubbles and you will lose.");
        dialogueText.Add("Ready? Hit Play to choose a song!");

        Display();

    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            LoadNextLine();
        }
    }

    public void LoadNextLine()
    {
        index += 1;

        if (index >= dialogueText.Count)
        {
            dialogueTextbox.text = dialogueText[dialogueText.Count - 1];
        }
        else
        {
            Display();

        }

    }

    public void Display()
    {
        StopAllCoroutines();

        StartCoroutine(TypeSentence(dialogueText[index]));
    }

    IEnumerator TypeSentence(string sentence)
    {
        dialogueTextbox.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            dialogueTextbox.text += letter;
            yield return null;

        }
    }
}
