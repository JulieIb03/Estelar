using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BotonCrearFrase : MonoBehaviour {
    public Button boton;
    public CrearFrase crearFrase;

    void Start(){
        Button btn = boton.GetComponent<Button>();
        btn.onClick.AddListener(crearFrase.Crear);
    }
}