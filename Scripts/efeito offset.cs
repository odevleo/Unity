// O efeito offset serve para movimentar certos objetos no background

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveOffset : MonoBehaviour
{

	// criando uma variável do tipo Renderer, para poder pegar os componetes de qualquer Renderer
    private Renderer meshRenderer;
    // criação de uma variável para atribuir o material criado na Unity
    private Material currentMaterial;

    // variavel para incrementar a velocidade dos objetos
    public float incrementoOffset;
    // variavel para definir a velocidade dos objetos
    public float speed;

    // variavel para criar uma layer na Unity
    public string sortingLayer;
    // variavel para definir a order da layer na Unity
    public int orderInLayer;
    // variavel para trabalhar com o offset
    private float offset;

    

    // Start is called before the first frame update
    void Start()
    {
    	// sempre que trabalhamos com Renderer é preciso usar esse comando para pegar os componentes
    	// usamos a variavel criada meseRenderer do tipo Renderer 
        meshRenderer = GetComponent<MeshRenderer>();
        meshRenderer.sortingLayerName = sortingLayer;
        meshRenderer.sortingOrder = orderInLayer;

        currentMaterial = meshRenderer.material;


    }

    // Update is called once per frame
    void FixedUpdate()
    {
    	// a variavel offset criada atribuimos o incremento
        offset += incrementoOffset;
        currentMaterial.SetTextureOffset("_MainTex", new Vector2(offset * speed, 0));
        
    }
}