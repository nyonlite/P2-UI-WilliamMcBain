using TMPro;
using UnityEngine;

public class DialogueManager : MonoBehaviour
{
    [SerializeField] GameObject dPanel;
    [SerializeField] TMP_Text dText, bText1, bText2, bText3;
    public static DialogueManager Instance { get; private set; }

    private void Awake()
    {
        if (Instance == null) Instance = this;
        else Destroy(gameObject);
    }

    public void ShowDialogue(bool show)
    {
        dPanel.SetActive(show);
    }

    public void SetDialogueText(string text)
    {
        dText.text = text;
    }

}
