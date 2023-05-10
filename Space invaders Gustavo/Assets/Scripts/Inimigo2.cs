using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inimigo2 : MonoBehaviour
{
    public Rigidbody rigidbody;
    public float velocidadeMinima;
    public float velocidadeMaxima;

    private float velocidadeX; // mudamos de velocidadeY para velocidadeX
    // Start is called before the first frame update
    void Start()
    {
        // mudamos o eixo de Y para X
        this.velocidadeX = Random.Range(-this.velocidadeMaxima, -this.velocidadeMinima);
    }

    // Update is called once per frame
    void Update()
    {
        // mudamos o vetor de velocidade para usar velocidadeX em vez de velocidadeY
        this.rigidbody.velocity = new Vector3(this.velocidadeX, 0);
    }

 

}
