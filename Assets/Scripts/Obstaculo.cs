using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaculo : MonoBehaviour
{
    [SerializeField] private float velocidade = 0.05f;
    
    void Update()
    {
        // Translação para a esquerda
        this.transform.Translate(Vector3.left * this.velocidade);
    }
}
