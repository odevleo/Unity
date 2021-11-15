using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class metodos : MonoBehaviour
{


    // ACONTECE IMEDIATAMENTE ANTES DA EXECUÇÃO DO PRIMEIRO FRAME DO UPDATE
    // O START É SÓ EXECUTADO APENAS UMA UNICA VEZ!!!!!
    // Start is called before the first frame update
    void Start()
    {
        /* como limitar o fps do jogo    (deve ficar uma unica vez no start)
        /  QualitySettings.vSyncCount = 0;            //desabilita o vSync   
        /Application.targetFrameRate = 60;
        */
    }

    // NORMALMENTE UTILIZADO PARA COMANDOS QUE ENVOLVEM FÍSICA
    void FixedUpdate()
    {

    }

    // RESONSÁVEL PELA LÓGICA DO JOGO
    // GERALMENTE OS INPUT SÃO NO UPTADE
    // Update is called once per frame


    // COMANDO Input.GetButton  ==> enquanto estiver apertando o botao
    // COMANDO Input.GetButtonDown    ==> quando o botao é apertado, executa uma unica vez
    // COMANDO Input.GetButtonUp    ==> quando o botao é soltado
    // if (Input.GetMouseButtonDown(0))      botao esquerdo do mouse
    // if (Input.GetMouseButtonDown(1))      botao direito do mouse
    // if (Input.GetMouseButtonDown(2))      botao do meio do mouse
    void Update()
    {
       if (Input.GetMouseButtonDown(0))
        {
            print("Estou apertando o  botao esquerdo do mouse");
        }
    }


    // NORMALMENTE UTILIZADO PARA CONTROLE DE CAMERA, ANIMAÇÕES,
    void LateUpdade ()
    {

    }
}
