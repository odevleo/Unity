using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swtich : MonoBehaviour
{

    
    public string comandos;
    

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            comandos += "E"; 
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            comandos += "D";
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            comandos += "F";
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            comandos += "B";
        }
        if(Input.GetKeyDown(KeyCode.Space))
        {
            executaComando();
        }
        



    }


    void executaComando()
    {
        switch (comandos)
        {
            case "BD":
                print("voadora doida");
                break;
            case "FE":
                print("murro seguro");
                break;
        }

        comandos = "";
    }

   

}
