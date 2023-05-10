using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ControlePontuacao : MonoBehaviour
{
    private int pontos = 0;
    public TextMeshProUGUI  pontosText;

    void Start()
    {
        // Inicializa o componente de texto com a pontuação atual
        pontosText.text = "Pontuação: " + pontos.ToString();
    }

    public void AumentarPontuacao()
    {
        pontos++;
        // Atualiza o componente de texto com a pontuação atualizada
        pontosText.text = "Pontuação: " + pontos.ToString();
    }
}
