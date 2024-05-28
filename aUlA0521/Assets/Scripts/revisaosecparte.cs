using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class revisaosecparte : MonoBehaviour
{
    public float valor1;
    public float valor2;
    public float valor3;
    public float somaPrimQuest;
    public float mediaPrimQuest;
    public float terMaisOito;
    public float segMaisTerc;

    public string nomeSegQuest;

    public int num1;
    public int num2;
    public int num3;
    public float mediaTercQuest;

    public int valorQuartaQuest;
    public int antec, sucec;

    public float ladoQuinta;
    public float areaQuadrado;

    public float numSext;
    public float dobroSext;
    public float tercoSext;

    public float larguraParede;
    public float alturaParede;
    public float areaParede;
    public float qntTinta;

    public float valorCarteira;
    public float valorDolar;

    public float valorProduto;
    public float valorDesconto;
    public float valorDescontado;

    public float salario;
    public float acrescimo;
    public float salarioAcrecimo;

    public float nota1, nota2, nota3, nota4;
    public float media;

    public float numDecSeg, num2DecSeg;

    public int senha;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PrimQuest();
        SecQuest();
        TercQuest();
        QuarQuest();
        QuintQuest();
        SextQuest();
        SetmQuest();
        OitQuest();
        NonaQuest();
        DecimaQuest();
        DecimaPrimQuest();
        DecimaSegQuest();
        DecTerQuest();
    }    
    public void PrimQuest()
    {
        somaPrimQuest = valor1 + valor2 + valor3;
        mediaPrimQuest = somaPrimQuest / 3;
        terMaisOito = valor3 + 8;
        segMaisTerc = valor2 + valor3;
        Debug.Log("A soma dos tr�s n�meros � " + somaPrimQuest);
        Debug.Log("A m�dia dos tr�s n�meros � " + mediaPrimQuest);
        Debug.Log("A soma do terceiro n�mero mais 8 � " + terMaisOito);
        Debug.Log("A soma do segundo n�mero com o terceiro � " + segMaisTerc);
    }
    public void SecQuest()
    {
        Debug.Log("Ol�, " + nomeSegQuest);
    }
    public void TercQuest()
    {
        mediaTercQuest = num1 + num2 + num3;
        mediaTercQuest = mediaTercQuest / 3;
        Debug.Log("A m�dia entre esses tr�s n�meros � " + mediaTercQuest);
    }
    public void QuarQuest()
    {
        antec = valorQuartaQuest - 1;
        sucec = valorQuartaQuest + 2;
        Debug.Log("O antecessor de " + valorQuartaQuest + " � " + antec + " e o sucessor � " + sucec);
    }
    public void QuintQuest()
    {
        areaQuadrado = ladoQuinta * ladoQuinta;
        Debug.Log("A �rea do quadrado de lado " + ladoQuinta + " � " + areaQuadrado);
    }
    public void SextQuest()
    {
        dobroSext = numSext * 2;
        tercoSext = numSext/3;
        Debug.Log("O dobro de " + numSext + " � " + dobroSext + " e a ter�a parte � " + tercoSext);
    }
    public void SetmQuest()
    {
        areaParede = larguraParede * alturaParede;
        qntTinta = areaParede * 2;
        Debug.Log("A �rea da parede a ser pintada � de " + areaParede + " e a quantidade em,litros ,de tinta necess�ria para pintar � de " + qntTinta);
    }
    public void OitQuest()
    {
        valorCarteira = valorDolar * 5.16f;
        Debug.Log("Voc� tem R$" + valorCarteira + " na carteira e com eles, pode comprar U$D" + valorDolar);
    }
    public void NonaQuest()
    {
        valorDesconto = valorProduto * 0.05f;
        valorDescontado = valorProduto - valorDesconto;
        Debug.Log("O valor do produto � de "+valorProduto+ " e com o desconto de 5% fica por "+ valorDescontado);
    }
    public void DecimaQuest()
    {
        acrescimo = salario * 0.15f;
        salarioAcrecimo = salario + acrescimo;
        Debug.Log("O valor do sal�rio com o acrescimo � de " + salarioAcrecimo);
    }
    public void DecimaPrimQuest()
    {
        media = nota1 + nota2 + nota3 + nota4;
        media = media / 4;
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
    public void DecimaSegQuest()
    {
        if (numDecSeg == num2DecSeg)
        {
            Debug.Log("Os dois n�mros s�o Iguais");
        }
        else
        {
            Debug.Log("Os dois n�mros s�o Diferentes");
        }
    }
    public void DecTerQuest()
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
}
