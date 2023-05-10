using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controlador3 : MonoBehaviour
{
    public Inimigo3 Inimigo3;
    private float tempoDecorrido;
    

    // Start is called before the first frame update
    void Start()
    {
        this.tempoDecorrido = 0;
    }

    // Update is called once per frame
    void Update()
    {
        this.tempoDecorrido += Time.deltaTime;
        if(this.tempoDecorrido >= 3f){
            this.tempoDecorrido = 0;
            //cria novo inimigo
            Instantiate(this.Inimigo3);
        }
    }
}
