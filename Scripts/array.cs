using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class array : MonoBehaviour 
{

    public float[] mediaBimestral;

    /*int indice = 0;                                 leitura de um array usando o while *obs* importante nao usar o <=, apenas o < ou >
          while (indice<mediaBimestral.Length)
          {
              print(mediaBimestral[indice]);
      indice += 1;
          }
    */



    /*                                                          leitura de um array utilizando o for
      for (int i = 0; i < mediaBimestral.Length; i += 1) 
        {
            print(mediaBimestral[i]);
        }
    */



    /*                           leitura de um array utilizando o foreach
        foreach (float media in mediaBimestral)
        {
            print(media);
        }
    */




    // Start is called before the first frame update
    void Start()
    {
        print(mediaFinal(0));
    }
    // Update is called once per frame
    void Update()
    {
        
    }



    float mediaFinal(int modo)                  //metodo usando laços para fazer a media   
    {
        float media = 0;
        float mFinal = 0;

        switch (modo)
        {
            case 0:
                int indice = 0;
                while (indice < mediaBimestral.Length)
                {
                    media += mediaBimestral[indice];
                    indice += 1;
                }
                break;

            case 1:
                for (int i = 0; i < mediaBimestral.Length; i += 1)
                {
                    media += mediaBimestral[i];
                }
                break;

            case 2:
                foreach (float m in mediaBimestral)
                {
                    media += m;
                }
                break;
        }


        
        mFinal = media / mediaBimestral.Length;
        return mFinal;
    }




  /*float mediaFinal() //função com retorno, diferente da com void
    {
        float media = (mediaBimestral[0] + mediaBimestral[1] + mediaBimestral[2] + mediaBimestral[3]) / 4;
        return media;
    }
  */
}
