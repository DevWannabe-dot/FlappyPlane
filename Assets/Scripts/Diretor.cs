using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diretor : MonoBehaviour
{
    [SerializeField] private GameObject imagemGameOver;
    public void finalizarJogo(){
        Time.timeScale = 0;
        // habilitar a imagem de Game Over
        this.imagemGameOver.SetActive(true);
    }
}
