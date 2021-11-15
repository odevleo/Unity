using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testeRun : MonoBehaviour
{
    // Start is called before the first frame update
    // 0.363
    private Rigidbody2D playerRb;
    public float velocidadeMovimento;  // criando essa variavel para controlar a velocidade, para nao utilizar
    //o delta.time
    public float limiteMaxY;
    public float limiteMinY;
    void Start()
    {
        playerRb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        /* o GetAxisRaw é como se fosse o deslocamento do analogico de um controle
        ao descolar o eixo x (horizontal), temos os valores -1 para esquerda e 1 para direita, 0 parado
        por isso utilizamos o velocity abaixo e multiplicamos a variavel horizontal do GetAxisRaw com a variavel
        de velocidadeMovimento(essa definimos o valor na unity ou por script mesmo, whatever)*/
        float vertical = Input.GetAxisRaw("Vertical");

        float posY = transform.position.y;
        float posX = transform.position.x;
        playerRb.velocity = new Vector2(horizontal * velocidadeMovimento, vertical * velocidadeMovimento);

        //limitar o eixo y
        if (transform.position.y > limiteMaxY)
        {
            posY = limiteMaxY;
        }
        else if (transform.position.y < limiteMinY)
        {
            posY = limiteMinY;
        }

        transform.position = new Vector3(posX, posY, 0);
               
    }
}
