using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Interactablity;

public class PlayerInteraction : MonoBehaviour
{
    public GameObject currentInteractable;

    public Interactablity currentInteractableScript;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E) && currentInteractable != null)
        {
            if (currentInteractable.GetComponent<Interactablity>().interaction == Interaction.Info)
            {
                currentInteractableScript.InfoText();
                //Debug.Log("Sign");
            }
            if (currentInteractable.GetComponent<Interactablity>().interaction == Interaction.Coin)
            {
                currentInteractableScript.CoinInteraction();
                Debug.Log("Coin");
            }
            else if (currentInteractable.GetComponent<Interactablity>().interaction == Interaction.Gem)
            {
                currentInteractableScript.GemInteraction();
                Debug.Log("Gem");
            }
        }
    }

    public void DoInteraction()
    {

    }

    public void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Interactable") == true)
        {
            currentInteractable = other.gameObject;
            currentInteractableScript = currentInteractable.GetComponent<Interactablity>();
        }
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Interactable") == true)
        {
            currentInteractable = null;
            currentInteractableScript = null;
        }
    }

}
