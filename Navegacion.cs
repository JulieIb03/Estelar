using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Navegacion : MonoBehaviour
{
    //Pantalla de Inicio
    public void Jugar() {
        SceneManager.LoadScene("Personalizacion");
    }
    //Header
    public void Inicio() {
        SceneManager.LoadScene("Inicio");
    }
    public void Ayuda() {
        SceneManager.LoadScene("Ayuda");
    }
    public void Informacion() {
        SceneManager.LoadScene("Informacion");
    }
}