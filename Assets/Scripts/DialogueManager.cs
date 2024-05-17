using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{

    public GameObject dBox;
    public Text dText;

    public bool dialogueActive;

    public string[] dialogueLines;
    public int currentLine;

    private PlayerController thePlayer;

    // Start is called before the first frame update
    void Start()
    {
        thePlayer = FindObjectOfType<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if(dialogueActive && Input.GetKeyDown(KeyCode.Space))
        {
            // dBox.SetActive(false);
            // dialogueActive = false;

            currentLine++;
        }

        if(currentLine >= dialogueLines.Length)
        {
            dBox.SetActive(false);
            dialogueActive = false;

            currentLine = 0;
            thePlayer.canMove = true;
        }

        dText.text = dialogueLines[currentLine];
    }

    public void ShowDialogue()
    {
        dialogueActive = true;
        dBox.SetActive(true);
        thePlayer.canMove = false;
    }
}
