using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pontuacao : MonoBehaviour
{
    [SerializeField] private Text Pontuacao_Texto;
    private int pontos;

    public void AdicionarPontos()
    {
        this.pontos++;
        this.Pontuacao_Texto.text = this.pontos.ToString();
    }
    public void Reiniciar()
    {
        this.pontos = 0;
        this.Pontuacao_Texto.text = this.pontos.ToString();
    }
}
