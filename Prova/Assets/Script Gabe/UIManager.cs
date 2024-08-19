using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.Build.Content;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    // Declaração da classe `UIManager`, que herda de `MonoBehaviour` (base para scripts Unity).

    TextMeshProUGUI scoreText, finalScoreText, recordText;
    // Declaração de três variáveis do tipo `TextMeshProUGUI`, que serão usadas para exibir o texto da pontuação, pontuação final, e recorde.
    GameObject gameOverWindow;

    // Declara uma variável do tipo `GameObject` chamada `gameOverWindow`, que representará a janela de Game Over.
    // Método público `UpdateScoreText`, que será usado para atualizar o texto da pontuação.
    public void UpdateScoreText()
    {
        // Atualiza o texto de `scoreText` com a pontuação atual do `GameManager`.
        //scoreText = GameManager();
    }
    
    
       
    public void GameOver(bool Active)
    {
        finalScoreText = pontuaçao final;
        recordText = Player record;
        gameOverWindow.SetActive(Active);
        
    }

    // Método público `GameOver`, que será chamado quando o jogo terminar.
    
        // Atualiza o texto de `finalScoreText` com a pontuação final.
       // Atualiza o texto de `recordText` com o recorde armazenado nas preferências do jogador.
        // Ativa a janela de Game Over.
        // Pausa o jogo definindo o tempo de jogo para 0.
    
    public void Restart()
    {

    }

    // Método público `Restart`, que será usado para reiniciar o jogo.
    
        // Retoma o tempo de jogo, definindo-o de volta para 1.
        // Carrega a cena atual para reiniciar o jogo.
    


}
