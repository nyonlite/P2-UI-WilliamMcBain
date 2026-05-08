using System;
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class NPC : MonoBehaviour
{
    [SerializeField] PlayerController pC;
    [SerializeField] NPCDialogue dData;
    [SerializeField] GameObject dialogueBox;
    [SerializeField] TMP_Text dText, bText1, bText2, bText3;
    private int dialogueIndex;
    private bool isTyping;



    void Start()
    {
        dialogueBox.SetActive(false);
        dialogueIndex = 0;

    }

    public void StartDialogue()
    {
        pC.CutsceneStart();
        dialogueBox.SetActive(true);

        TypeLine();

    }

    public void TypeLine()
    {
        dText.SetText(dData.dialogueLines[dialogueIndex]);

    }

    public void StopDialogue()
    {
        dialogueBox.SetActive(false);
        pC.CutsceneEnd();
    }

    public void DialogueA()
    {

    }

    public void DialogueB()
    {

    }

    public void DialogueC()
    {

    }


}
