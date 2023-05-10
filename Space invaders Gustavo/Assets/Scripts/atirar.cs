using UnityEngine;

public class atirar : MonoBehaviour
{
    public float velocidade = 15f; // velocidade da bala
    public float tempoVida = 4f; // tempo de vida da bala
    public Vector3 direcao = Vector3.forward; // direção da bala (por padrão, para a frente)
    private ControlePontuacao controlePontuacao;

    private void Start()
    {
        // aplica uma velocidade inicial na bala
        GetComponent<Rigidbody>().velocity = direcao.normalized * velocidade;
        
        // destroi a bala após o tempo de vida
        //Destroy(gameObject, tempoVida);
        controlePontuacao = GameObject.FindObjectOfType<ControlePontuacao>();
    }
    
   void OnCollisionEnter(Collision other) {
        if (other.gameObject.CompareTag("colisao")) {
            Destroy(other.gameObject);
            Destroy(gameObject); 
            controlePontuacao.AumentarPontuacao();
        }


    }
}
