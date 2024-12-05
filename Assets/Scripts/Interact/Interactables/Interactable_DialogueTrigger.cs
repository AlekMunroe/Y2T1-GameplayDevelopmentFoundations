using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Animations;

public class Interactable_DialogueTrigger : MonoBehaviour, IInteractable
{
    public string hintInfo = "Press E to talk";
    public string HintInformation => hintInfo;

    public void Interact()
    {
        this.GetComponent<DialogueTrigger>().enabled = true;

        this.GameObject().tag = "Untagged";
        
        this.GetComponent<Interactable_DialogueTrigger>().enabled = false;
    }
}
