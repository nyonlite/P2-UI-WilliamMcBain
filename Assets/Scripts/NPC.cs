using System;
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class NPC : MonoBehaviour
{
    [SerializeField] PlayerController pC;
    [SerializeField] NPCDialogue dData, b1Data, b2Data, b3Data;
    [SerializeField] GameObject dialogueBox;
    [SerializeField] TMP_Text dText, bText1, bText2, bText3;
    private int dialogueIndex, button1Index, button2Index, button3Index;




    void Awake()
    {
        dialogueBox.SetActive(false);
        dialogueIndex = 0;
        button1Index = 0;
        button2Index = 0;
        button3Index = 0;
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
        if (dialogueIndex == 0)
        {
            dialogueIndex = 1;
            TypeLine();
        }
        else if (dialogueIndex == 1||dialogueIndex == 3)
        {
            dialogueIndex = 2;
            TypeLine();
        }
        else if (dialogueIndex == 2|| dialogueIndex == 4)
        {
            pC.CutsceneEnd();
            dialogueIndex = 4;
            dialogueBox.SetActive(false);
        }
        else if (dialogueIndex == 5)
        {
            dialogueIndex = 6;
            TypeLine();
        }
        else if (dialogueIndex == 6||dialogueIndex == 7|| dialogueIndex == 8)
        {
            pC.CutsceneEnd();
            dialogueIndex = 8;
            dialogueBox.SetActive(false);
        }
        else if (dialogueIndex == 8)
        {
            pC.CutsceneEnd();
            dialogueBox.SetActive(false);
        }
    }

    public void DialogueB()
    {

    }

    public void DialogueC()
    {

    }


}
