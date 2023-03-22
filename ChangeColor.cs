using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeColor : MonoBehaviour
{
    [SerializeField]
    private GameObject Personaje;
    private GameObject btnPiel1, btnPiel2, btnPiel3, btnPiel4, btnPiel5, btnPiel6;
    private Renderer PersonajeRenderer;
    private Color newPersonajeColor;
    private float randomChannelOne, randomChannelTwo, randomChannelThree;

    // Start is called before the first frame update
    void Start()
    {
        PersonajeRenderer = Personaje.GetComponent<Renderer>();
        btnPiel1 = GameObject.Find("Piel1");
        btnPiel2 = GameObject.Find("Piel2");
        btnPiel3 = GameObject.Find("Piel3");
        btnPiel4 = GameObject.Find("Piel4");
        btnPiel5 = GameObject.Find("Piel5");
        btnPiel6 = GameObject.Find("Piel6");

        gameObject.GetComponent<Button>().onClick.AddListener(ChangePielRandom);
        btnPiel.GetComponent<Button>().onClick.AddListener(ChangePiel);
        btnPiel2.GetComponent<Button>().onClick.AddListener(ChangePiel2);
        btnPiel3.GetComponent<Button>().onClick.AddListener(ChangePiel3);
        btnPiel4.GetComponent<Button>().onClick.AddListener(ChangePiel4);
        btnPiel5.GetComponent<Button>().onClick.AddListener(ChangePiel5);
        btnPiel6.GetComponent<Button>().onClick.AddListener(ChangePiel6);
    }

    private void ChangePielRandom()
    {
        randomChannelOne = Random.Range(0f, 1f);
        randomChannelTwo = Random.Range(0f, 1f);
        randomChannelThree = Random.Range(0f, 1f);

        newPersonajeColor = new Color(randomChannelOne, randomChannelTwo, randomChannelThree, 1f);

        PersonajeRenderer.material.SetColor("_Color", newPersonajeColor);
        PlayerPrefs.SetString("Piel", "random");
    }
    private void ChangePiel()
    {
        randomChannelOne = 255 / 255f;
        randomChannelTwo = 218 / 255f;
        randomChannelThree = 194 / 255f;

        newPersonajeColor = new Color(randomChannelOne, randomChannelTwo, randomChannelThree, 1f);

        PersonajeRenderer.material.SetColor("_Color", newPersonajeColor);
        PlayerPrefs.SetString("Piel", "piel1");
    }
    private void ChangePiel2()
    {
        randomChannelOne = 237 / 255f;
        randomChannelTwo = 198 / 255f;
        randomChannelThree = 171 / 255f;

        newPersonajeColor = new Color(randomChannelOne, randomChannelTwo, randomChannelThree, 1f);

        PersonajeRenderer.material.SetColor("_Color", newPersonajeColor);
        PlayerPrefs.SetString("Piel", "piel2");
    }
    private void ChangePiel3()
    {
        randomChannelOne = 210 / 255f;
        randomChannelTwo = 159 / 255f;
        randomChannelThree = 120 / 255f;

        newPersonajeColor = new Color(randomChannelOne, randomChannelTwo, randomChannelThree, 1f);

        PersonajeRenderer.material.SetColor("_Color", newPersonajeColor);
        PlayerPrefs.SetString("Piel", "piel3");
    }
    private void ChangePiel4()
    {
        randomChannelOne = 149 / 255f;
        randomChannelTwo = 98 / 255f;
        randomChannelThree = 68 / 255f;

        newPersonajeColor = new Color(randomChannelOne, randomChannelTwo, randomChannelThree, 1f);

        PersonajeRenderer.material.SetColor("_Color", newPersonajeColor);
        PlayerPrefs.SetString("Piel", "piel4");
    }
    private void ChangePiel5()
    {
        randomChannelOne = 127 / 255f;
        randomChannelTwo = 79 / 255f;
        randomChannelThree = 54 / 255f;

        newPersonajeColor = new Color(randomChannelOne, randomChannelTwo, randomChannelThree, 1f);

        PersonajeRenderer.material.SetColor("_Color", newPersonajeColor);
        PlayerPrefs.SetString("Piel", "piel5");
    }
    private void ChangePiel6()
    {
        randomChannelOne = 97 / 255f;
        randomChannelTwo = 57 / 255f;
        randomChannelThree = 41 / 255f;

        newPersonajeColor = new Color(randomChannelOne, randomChannelTwo, randomChannelThree, 1f);

        PersonajeRenderer.material.SetColor("_Color", newPersonajeColor);
        PlayerPrefs.SetString("Piel", "piel6");
    }
}
