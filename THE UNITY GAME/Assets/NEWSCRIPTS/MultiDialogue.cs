using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MultiDialogue : MonoBehaviour
{
    // Variable which is what the NPC will say
    [SerializeField] List<string> dialogueToSay = new List<string>();

    int pointInDialogue = 0;


    bool isStoodInFront = false;

    // Reference to the text element which will show on the screen
    [SerializeField] Text dialogueWidget;

    void OnTriggerEnter2D(Collider2D other)
    {
        isStoodInFront = true;
    }

    void OnTriggerExit2D(Collider2D other)
    {
        isStoodInFront = false;
        dialogueWidget.text = "";
        pointInDialogue = 0;
    }

    private void Update()
    {
        if(isStoodInFront && Input.GetKeyDown(KeyCode.E))
        {
            // if point in dialogue is more than the number of things we have to say
            if (pointInDialogue >= dialogueToSay.Count)
            {
                pointInDialogue = 0;
                dialogueWidget.text = "";
                return;
            }

            dialogueWidget.text = dialogueToSay[pointInDialogue];
            pointInDialogue++;

          
        }
    }

}