using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public Dialogue dialogue;

    public Dialogue reply1;

    public Dialogue reply2;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            TriggerDialogue();
        }
    }

    public void TriggerDialogue()
    {
        FindObjectOfType<DialogueTree>().StartDialogue(dialogue, reply1, reply2);
    }
}
