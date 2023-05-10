using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class naveatributos : MonoBehaviour
{
    private CharacterController character;
    private Animator animator;
    private Vector3 inputs;
    
    private float velocidade;

    public atirar atirarPrefab;
    private float intervaloTiro;

    void Start()
    {
        character = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();
        velocidade = 5f; 

        this.intervaloTiro = 0;
    }


    void Update()
    {
        this.intervaloTiro += Time.deltaTime;
        if(this.intervaloTiro >= 0.35f){
            this.intervaloTiro = 0;
            Atirar();
        }
        inputs.Set(Input.GetAxis("Horizontal"),Input.GetAxis("Vertical"), 0);
        character.Move(inputs * Time.deltaTime * velocidade);
    }

    private void Atirar() {
    // Define a rotação desejada para o míssil
    Vector3 rotacaoDesejada = new Vector3(0, 90, 90);
    
    // Cria uma rotação a partir do vetor de rotação desejada
    Quaternion rotacao = Quaternion.Euler(rotacaoDesejada);
    
    // Instancia o míssil com a rotação desejada
    Instantiate(this.atirarPrefab, this.transform.position, rotacao);
}
}
