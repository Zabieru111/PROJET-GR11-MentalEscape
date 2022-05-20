using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeText : MonoBehaviour
{
    public Slider sensitivity;
    //change la valeur du texte pour la valeur de la sensibilité du manager
    public void ChangeValue()
    {
        int value = (int)sensitivity.value;
        this.GetComponent<TMPro.TextMeshProUGUI>().text = value.ToString();
        GameManager.instance.changeSensitivity(sensitivity.value);
    }
}
