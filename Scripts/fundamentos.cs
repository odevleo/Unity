using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fundamentos : MonoBehaviour
{
    //PascalCase = funções/comandos nativos/utilizadas pela Unity (primeira letra Maiúsculo)

    //camelCase = funções/variáveis criadas por mim ... ex: atacarChefe()

    // toda variável booleana criar da seguinte forma como padrão:    public bool isAprovado;    // is verbo estar

    public string nomeAluno;
    public int idadeAluno;
    public bool isAprovado;

    public float mediaBimestreA;
    public float mediaBimestreB;
    public float mediaBimestreC;
    public float mediaBimestreD;
    public int frequencia;

    public float mediaNecessaria;
    public int frequenciaNecessaria;

    


// MODIFICADORES DE ACESSO
// PUBLIC  - NÃO POSSUI RESTRIÇÃO DE ACESSO
// PRIVATE - ACESSÍVEL APENAS PELA CLASSE A QUAL ELE PERTENCE

// INTERNAL
// PROTECTED
// PROTECTED INTERNAL
// PRIVATE PROTECTED


    // Start is called before the first frame update
    void Start()
    {
        calcularMediaFinal();

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void calcularMediaFinal()
    {
        float mediaFinal = (mediaBimestreA + mediaBimestreB + mediaBimestreC + mediaBimestreD) / 4;
            if (frequencia >= frequenciaNecessaria && mediaFinal >= mediaNecessaria)
        {
            print("O aluno " + nomeAluno + " foi aprovado com média: " + mediaFinal + " e frequencia de " + frequencia + "%");    
        }
            else if (frequencia < frequenciaNecessaria && mediaFinal>= mediaNecessaria)
        {
            print("O aluno " + nomeAluno + " foi reprovado por não ter a frequencia necessária atingida: " + frequencia + "%");
        }
            else if (mediaFinal < mediaNecessaria && frequencia>=frequenciaNecessaria)
        {
            print("O aluno " + nomeAluno + " foi reprovado por não ter a nota media necessária: " + mediaFinal);
        }
            else
        {
            print("O aluno " + nomeAluno + " foi reprovado com média: " + mediaFinal + " e frequencia de " + frequencia + "%");
        }
    }
}



