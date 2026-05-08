using TMPro;
using UnityEngine;

public class DialogueStrings : MonoBehaviour
{
    [SerializeField] TMP_Text dText;
    [SerializeField] TMP_Text bText1;
    [SerializeField] TMP_Text bText2;
    [SerializeField] TMP_Text bText3;
    private string path;


    string DSA = "Great to hear!";
    string DSB = "I'm sorry to hear that...";
    string DSC = "Maybe I do...";

    public void SetDialogue(string dialogue)
    {
        path = dialogue;
        ChangeDText();
    }

    private void ChangeDText()
    {
        if (path != null) 
        {
            
            
        }
    }

}
