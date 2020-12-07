using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateText : MonoBehaviour
{

    //Author: Brinnah Welmaker

    //create dialogue list, set index to 0
    public List<string> dialogueText = new List<string>();
    public int index = 0;
    public Text dialogueTextbox;

    private void Start()
    {
        //add each line of dialogue to the list
        dialogueText.Add("Hello! Welcome to Bubble Pop!");
        dialogueText.Add("Pop bubbles by using the arrow keys to hit beats when the bubbles pass the arrows at the top of the screen");
        dialogueText.Add("Be careful, miss too many bubbles and you will lose.");
        dialogueText.Add("Ready? Hit Play to choose a song!");

        // call display function
        Display();

    }

    public void Update()
    {
        //if return is hit, the next line of dalogue starts
        if (Input.GetKeyDown(KeyCode.Return))
        {
            LoadNextLine();
        }
    }

    public void LoadNextLine()
    {
        //changes index of dialogue to show next line
        index += 1;

        if (index >= dialogueText.Count)
        {
            //if at the end of dialogue, keeps it at the last line
            dialogueTextbox.text = dialogueText[dialogueText.Count - 1];
        }
        else
        {
            //animates and plays the line
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
        //makes dialogue animate the typing of text
        dialogueTextbox.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            dialogueTextbox.text += letter;
            yield return null;

        }
    }
}
