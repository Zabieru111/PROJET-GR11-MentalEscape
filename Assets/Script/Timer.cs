using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    // Start is called before the first frame update
    public Text temps;
    public Text TXTkeyNumber;
    // Update is called once per frame

    private void Start()
    {
        
        TXTkeyNumber.text = "0";
    }

 //prend le temps du manager et le copie pour modifier le texte

    void Update()
    {
        temps.text = GameManager.instance.tempRestant;
        TXTkeyNumber.text =  GameManager.instance.keyTakenNumber.ToString();

    }
}
