using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class revisao : MonoBehaviour
{
    [Header("")]
    public float valor1;
    public float valor2;
    public float soma;

    [Header("")]
    public int num1;
    public int num2;
    public int num3;
    public int media;

    [Header("Primeira Quest�o Atividade 1")]
    public int nume1;
    public int nume2;

    [Header("Segunda Quest�o Atividade 1")]
    public int numer1;
    public int numer2;

    [Header("Terceira Quest�o Atividade 1")]
    public int senha;

    [Header("Quarta Quest�o")]
    public string Opcao1 = "� Hamb�rguer Gourmet R$ 20,00";
    public string Opcao2 = "- Pizza R$ 56,00";
    public string Opcao3 = "� Macarronada R$ 35,00";
    public string Opcao4 = "� Feijoada R$ 40,00";
    public int pedido;
    public int qntPedido;

    [Header("Quinta Quest�o Atividade 1")]
    public float valorQuinta;
    public float testeValor;

    [Header("Sexta Quest�o Atividade 1")]
    public float valorSexta;
    public float testeValorSexta;

    [Header("Setima Quest�o Atividade 1")]
    public string nome;
    public float nota1Setima;
    public float nota2Setima;
    public float nota3Setima;
    public float mediaSetima;

    [Header("Oitava Quest�O Atividade 1")]
    public string Opcao1Oit = "1. Residencial, pre�o por kWh = 1.30 \r\n2. Comercial, pre�o por kWh = 2.20 \r\n3. Industrial, pre�o do kWh = 3.10\r\n";
    public float qntKWh;
    public int codigoCons;
    public float valoraTotaL;

    //[Header("Nona Quest�O Atividade 1")]

    void Start()
    {
        Somar();
        Media();
        PrimQuest();
        SecQuest();
        TerQuest();
        QuarQuest();
        QuiQuest();
        SexQuest();
        SetQuest();
        OitQuest();
        NonQuest();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Somar()
    {
        soma = valor1 + valor2;
        Debug.Log(soma);
    }
    public void Media()
    {
        media = num1 + num2 + num3;
        media = media / 3;
        Debug.Log(media);

        if (media >= 6.0f)
        {
            Debug.Log("Aprovado");
        }
        else
        {
            Debug.Log("Reprovado");
        }        
    }
    public void PrimQuest()
    {
        if (nume1 == nume2)
        {
            Debug.Log("Os dois n�mros s�o Iguais");
        }
        else
        {
            Debug.Log("Os dois n�mros s�o Diferentes");
        }
    }
    public void SecQuest()
    {
        if (numer1 >= numer2)
        {
            Debug.Log("O maior n�mero � o " + numer1);
        }
        else
        {
            Debug.Log("O maior n�mero � o " + numer2);
        }
    }
    public void TerQuest()
    {
        if (senha == 1234)
        {
            Debug.Log("ACESSO PERMITIDO");
        }
        else
        {
            Debug.Log("ACESSO NEGADO");
        }
    }
    public void QuarQuest()
    {
        if (pedido == 1)
        {
            Debug.Log("Voc� escolheu o Hamb�rguer Gourmet no valor de R$ 20,00 ");
        }
        if (pedido == 2)
        {
            Debug.Log("Voc� escolheu a Pizza no valor de R$ 56,00 ");
        }
        if (pedido == 3)
        {
            Debug.Log("Voc� escolheu a Macarronada no valor de R$ 35,00 ");
        }
        if (pedido == 4)
        {
            Debug.Log("Voc� escolheu a Feijoada no valor de R$ 40,00 ");
        }
    }
    public void QuiQuest()
    {
        testeValor = valorQuinta % 2;
        if (testeValor == 0)
        {
            Debug.Log("O valor indicado � Par");
        }
        else
        {
            Debug.Log("O valor indicado � Impar");
        }
    }
    public void SexQuest()
    {
        testeValorSexta = valorQuinta % 5;
        if (testeValorSexta == 0)
        {
            Debug.Log(valorSexta + " � Divisivel por 5");
        }
        else
        {
            Debug.Log(valorSexta + " n�o � Divisivel por 5");
        }
    }
    public void SetQuest()
    {
        mediaSetima = nota1Setima + nota2Setima + nota3Setima;
        mediaSetima = mediaSetima / 3;

        if (mediaSetima >= 6.0f)
        {
            Debug.Log("O Aluno " + nome + " foi Aprovado");
        }
        
        if (mediaSetima <= 6.0f)
        {
            Debug.Log("O Aluno " + nome + " est� de Recupera��o");
        }
        if(mediaSetima <= 4)
        {
            Debug.Log("O Aluno " + nome + " est� de Reprovado");
        }
    }
    public void OitQuest()
    {
        if(codigoCons == 1)
        {
            valoraTotaL = qntKWh * 1.30f;
            Debug.Log("O cliente � Residencial e valor total da conta foi de " + valoraTotaL);
        }
        if (codigoCons == 2)
        {
            valoraTotaL = qntKWh * 2.20f;
            Debug.Log("O cliente � Comercial e valor total da conta foi de " + valoraTotaL);
        }
        if (codigoCons == 3)
        {
            valoraTotaL = qntKWh * 3.10f;
            Debug.Log("O cliente � Industrial e valor total da conta foi de " + valoraTotaL);
        }
    }
    public void NonQuest()
    {

    }
}
