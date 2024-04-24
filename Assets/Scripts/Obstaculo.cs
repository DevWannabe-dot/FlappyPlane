using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaculo : MonoBehaviour
{
    [SerializeField]
    private float velocidade = 0.5f;
    
    private void Awake()
    {
        this.transform.Translate(Vector3.up * Random.Range(-1, 1));
    }
    void Update()
    {
        // Translação para a esquerda
        this.transform.Translate(Vector3.left * this.velocidade);
    }
}
