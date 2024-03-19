using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Interactablity : MonoBehaviour
{
    [Header ("Text Stuff")]
    public string message;
    public TextMeshProUGUI infoText;

    public enum Interaction {Info, Coin, Gem, Dialog}
    [Header ("Enum Stuff")]
    public Interaction interaction;

    public void Start()
    {
        infoText = GameObject.Find("InfoText").GetComponent<TextMeshProUGUI>();
    }

    public void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)) 
        {
            //infoText.text = message;
        }
    }


    public void InfoText()
    {
        infoText.text = message;
        StartCoroutine(ShowInfo(message, 2.5f));
        Debug.Log(message);
    }

    IEnumerator ShowInfo(string message, float duration)
    {
        infoText.text = message;
        yield return new WaitForSeconds(duration);
        infoText.text = null;
    }



    public void CoinInteraction()
    {
        this.gameObject.SetActive(false);
    }

    public void GemInteraction()
    {
        this.gameObject.SetActive(false);
    }

    public void DialogInteraction()
    {

    }
}
