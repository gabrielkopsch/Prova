using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.Build.Content;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    // Declara��o da classe `UIManager`, que herda de `MonoBehaviour` (base para scripts Unity).

    TextMeshProUGUI scoreText, finalScoreText, recordText;
    // Declara��o de tr�s vari�veis do tipo `TextMeshProUGUI`, que ser�o usadas para exibir o texto da pontua��o, pontua��o final, e recorde.
    GameObject gameOverWindow;

    // Declara uma vari�vel do tipo `GameObject` chamada `gameOverWindow`, que representar� a janela de Game Over.
    // M�todo p�blico `UpdateScoreText`, que ser� usado para atualizar o texto da pontua��o.
    public void UpdateScoreText()
    {
        // Atualiza o texto de `scoreText` com a pontua��o atual do `GameManager`.
        //scoreText = GameManager();
    }
    
    
       
    public void GameOver(bool Active)
    {
        finalScoreText = pontua�ao final;
        recordText = Player record;
        gameOverWindow.SetActive(Active);
        
    }

    // M�todo p�blico `GameOver`, que ser� chamado quando o jogo terminar.
    
        // Atualiza o texto de `finalScoreText` com a pontua��o final.
       // Atualiza o texto de `recordText` com o recorde armazenado nas prefer�ncias do jogador.
        // Ativa a janela de Game Over.
        // Pausa o jogo definindo o tempo de jogo para 0.
    
    public void Restart()
    {

    }

    // M�todo p�blico `Restart`, que ser� usado para reiniciar o jogo.
    
        // Retoma o tempo de jogo, definindo-o de volta para 1.
        // Carrega a cena atual para reiniciar o jogo.
    


}
