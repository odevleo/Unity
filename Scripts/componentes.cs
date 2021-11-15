using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class componentes : MonoBehaviour
{
    private SpriteRenderer sRenderer;
    //private Color colorSprite;
    //private Material material;
    public Color corSprite;            
    
    // Start is called before the first frame update
    void Start()
    {
        // print(this.gameObject.name);      para dar print no nome do objeto via script
        // this.gameObject.SetActive(false);          (desativar um objeto da cena, )

        sRenderer = GetComponent<SpriteRenderer>();             // ao criar a variavel do SpriteRenderer sempre fazer isso para ter acesso

        //sRenderer.color = Color.blue;     // 1 forma de mudar a cor de um objeto
        //sRenderer.color = new Color(255, 0, 5);  // 2 forma de mudar a cor
        //sRenderer.color = corSprite;            // 3 forma de mudar a cor, essa é preciso criar uma variavel do tipo Color
        

        //sRenderer.flipX = true;




    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
