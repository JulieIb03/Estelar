using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CrearFrase : MonoBehaviour {
    public Dropdown dropdown1;
    public Dropdown dropdown2;
    public Dropdown dropdown3;
    public Dropdown dropdown4;
    public Text labelFrase;
    
    public void Crear() {
    string frase = dropdown1.options[dropdown1.value].text + " " + dropdown2.options[dropdown2.value].text + " " + dropdown3.options[dropdown3.value].text + " " + dropdown4.options[dropdown4.value].text;
    labelFrase.text = frase;
    }
}