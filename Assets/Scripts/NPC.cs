using System;
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class NPC : MonoBehaviour
{
    [SerializeField] PlayerController pC;
    [SerializeField] Player player;
    [SerializeField] NPCDialogue dData, b1Data, b2Data, b3Data;
    [SerializeField] GameObject dialogueBox, button1, button2, button3, kiwi;
    [SerializeField] TMP_Text dText, bText1, bText2, bText3;
    public int dialogueIndex, button1Index, button2Index, button3Index;




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

            dialogueIndex = player.dialogueIndex;
        
        pC.CutsceneStart();
        dialogueBox.SetActive(true);

        TypeLine();
    }

    public void TypeLine()
    {
        dText.SetText(dData.dialogueLines[dialogueIndex]);
        bText1.SetText(b1Data.dialogueLines[button1Index]);
        bText2.SetText(b2Data.dialogueLines[button2Index]);
        bText3.SetText(b3Data.dialogueLines[button3Index]);
        //Save Dialogue spot
        player.dialogueIndex = dialogueIndex;
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
            button1Index = 1;
            button2Index = 1;
            button3.SetActive(false);
            TypeLine();
        }
        else if (dialogueIndex == 1||dialogueIndex == 3)
        {
            dialogueIndex = 2;
            button1Index = 2;
            button2.SetActive(false);
            TypeLine();
        }
        else if (dialogueIndex == 2|| dialogueIndex == 4)
        {
            pC.CutsceneEnd();
            dialogueIndex = 4;
            button1Index = 2;
            button2.SetActive(false);
            dialogueBox.SetActive(false);
            if (kiwi != null && player.kiwi1Get==false)
            {
                kiwi.SetActive(true);
            }
        }
        else if (dialogueIndex == 5)
        {
            dialogueIndex = 6;
            button1Index = 2;
            button2.SetActive(false);
            TypeLine();

        }
        else if (dialogueIndex == 6||dialogueIndex == 7|| dialogueIndex == 8)
        {
            pC.CutsceneEnd();
            dialogueIndex = 8;
            button1Index = 2;
            button2.SetActive(false);
            dialogueBox.SetActive(false);
            if (kiwi != null && player.kiwi1Get == false)
            {
                kiwi.SetActive(true);
            }
        }
        else if (dialogueIndex == 9)
        {
            dialogueIndex = 10;
            button1Index = 7;
            button2.SetActive(false);
            TypeLine(); 

        }
        else if (dialogueIndex == 10 || dialogueIndex == 11 || dialogueIndex == 12)
        {
            pC.CutsceneEnd();
            dialogueIndex = 12;
            button1Index = 7;
            button2.SetActive(false);
            dialogueBox.SetActive(false);
            if (kiwi != null && player.kiwi1Get == false)
            {
                kiwi.SetActive(true);
            }
        }
    }

    public void DialogueB()
    {
        if (dialogueIndex == 0)
        {
            dialogueIndex = 5;
            button1Index = 4;
            button2Index = 3;
            TypeLine();
            button3.SetActive(false);
        }
        else if (dialogueIndex == 1||dialogueIndex ==3)
        {
            dialogueIndex = 3;
            button1Index = 3;
            button2Index = 2;
            TypeLine();
        }
        else if (dialogueIndex == 5)
        {
            dialogueIndex = 7;
            button1Index = 0;
            button2.SetActive(false);
            TypeLine();
        }
        else if (dialogueIndex == 9)
        {
            dialogueIndex = 11;
            button1Index = 7;
            button2.SetActive(false);
            TypeLine();
        }
    }

    public void DialogueC()
    {
        dialogueIndex = 9;
        button1Index = 5;
        button2Index = 4;
        TypeLine();

        button3.SetActive(false);

    }


}
