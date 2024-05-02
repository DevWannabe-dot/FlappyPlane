using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaculo : MonoBehaviour
{
    [SerializeField] private float velocidade = 5f;
    private float variacaoDaPosicaoY = 1f;
    
    private void Awake()
    {
        this.transform.Translate(Vector3.up *
                                Random.Range(-variacaoDaPosicaoY, variacaoDaPosicaoY));
    }

    void Update()
    {
        this.transform.Translate(Vector3.left * this.velocidade * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D outro)
    {
        Debug.Log("Colidiu.");
        this.Destruir();
    }

    private void Destruir()
    {
        GameObject.Destroy(this.gameObject);
    }
}
