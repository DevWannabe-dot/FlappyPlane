using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Pontuacao : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI Pontuacao_Texto;
    private int pontos;
    private AudioSource audioPontuacao;

    private void Awake()
    {
        this.audioPontuacao = this.GetComponent<AudioSource>();
    }
    public void AdicionarPontos()
    {
        this.pontos++;
        this.Pontuacao_Texto.text = this.pontos.ToString();
    }
    public void Reiniciar()
    {
        this.pontos = 0;
        this.Pontuacao_Texto.text = this.pontos.ToString();
        this.audioPontuacao.Play();
    }
}
