using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueTree : MonoBehaviour
{
    public Text nameText;
    public Text dialogueText;
    public Animator animator;

    public Text response1;
    public Text response2;


    private Queue<string> replies1;
    private Queue<string> replies2;


    private Queue<string> sentences;

    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue<string>();
        replies1 = new Queue<string>();
        replies2 = new Queue<string>();
    }

    public void StartDialogue(Dialogue dialogue, Dialogue reply1, Dialogue reply2)
    {
        animator.SetBool("IsOpen", true);

        nameText.text = dialogue.name;

        sentences.Clear();

        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

        replies1.Clear();
        replies2.Clear();

        foreach (string sentence in reply1.sentences)
        {
            replies1.Enqueue(sentence);
            
        }
        foreach(string sentence in reply2.sentences)
        {
            replies2.Enqueue(sentence);
        }

        DisplayNextSentence();
        
    }

    public void DisplayNextSentence()
    {
        if (sentences.Count == 0)
        {
            EndDialogue();
            return; 
        }

        string reply1 = replies1.Dequeue();
        string reply2 = replies2.Dequeue();
        string sentence = sentences.Dequeue();

        response1.text = reply1;
        response2.text = reply2;

        StopAllCoroutines();

        StartCoroutine(TypeSentence(sentence));
    }

    IEnumerator TypeSentence(string sentence)
    {
        dialogueText.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            dialogueText.text += letter;
            yield return null;

        }
    }

    public void EndDialogue()
    {
        animator.SetBool("IsOpen", false);
        Debug.Log("End of Conversation.");
    }

}
