using UnityEngine;
using TMPro;

public class NPCDialogue : MonoBehaviour
{
    private Collider2D col;
    [SerializeField] PlayerController pC;
    [SerializeField] GameObject dialogBox;
    [SerializeField] TMP_Text dialogueText;
    [SerializeField] TMP_Text buttonText1;
    [SerializeField] TMP_Text buttonText2;
    [SerializeField] TMP_Text buttonText3;

    void Start()
    {
        col = GetComponent<Collider2D>();
        dialogBox.SetActive(false);
    }



    public void StartDialogue()
    {
        pC.CutsceneStart();
        dialogBox.SetActive(true);
        
    }

    public void StopDialogue()
    {
        dialogBox.SetActive(false);
    }


}
