using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeTexture : MonoBehaviour
{
    [SerializeField]
    private GameObject Personaje;

    [SerializeField]
    private Texture[] Texturas;

    private Renderer personajeRenderer;

    private int randomTextureIndex;

    // Start is called before the first frame update
    void Start()
    {
        personajeRenderer = Personaje.GetComponent<Renderer>();
        gameObject.GetComponent<Button>().onClick.AddListener(ChangePersonajeTextura);
    }

    // Update is called once per frame
    private void ChangePersonajeTextura()
    {
        randomTextureIndex = Random.Range(0, Texturas.Length);
        personajeRenderer.material.mainTexture = Texturas[randomTextureIndex];
    }
}

