using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Content;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Player : MonoBehaviour
{
// Declara uma variável `rigidbody2d` do tipo `Rigidbody2D`, que será usada para aplicar física ao jogador.
   Rigidbody2D rigidbody2D;

    // Declara uma variável `managerUI` do tipo `UIManager`, que será usada para gerenciar a interface do usuário.
   // UIManager managerUI;
    // Start é chamado antes da primeira atualização do frame
    // Método `Start`, que é chamado uma vez quando o script é iniciado.
    private void Start()
    {
        // Obtém e armazena o componente `Rigidbody2D` anexado ao objeto do jogador.
       rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        // Verifica se a tecla do botão esquerdo do mouse foi pressionada.
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
          //Define a velocidade do `Rigidbody2D`, aplicando um impulso para cima.
           rigidbody2D.velocity = new Vector2(0.0f, 2.0f);
        }
    }
    void PlayerColider(Collision collision)
    {
        if(collision.gameObject.tag == "Obstacle")
        {
            GameOver();
        }
        if(collision.gameObject.tag == "Score")
        {
      //      GameManager.Score++; 
        }
       
    }
    // Método chamado quando o jogador entra em colisão com um objeto com o qual ele pode interagir.
    //{
    // Verifica se o objeto colidido tem a tag "Obstacle".
    //{
    // Se for um obstáculo, chama o método `GameOver`.
    //}
    // Verifica se o objeto colidido tem a tag "Score".
    //{
    // Incrementa a pontuação no `GameManager`.
    // Atualiza o texto da pontuação na interface do usuário.
    //  }
    //}

    void GameOver()
    {

        // Verifica se a pontuação atual é maior que o recorde armazenado.
       // if (Score > recorde)
        {
            // Se for maior, atualiza o recorde nas preferências do jogador.
            //recorde = Score; 
            // Chama o método `GameOver` no `UIManager` para exibir a tela de Game Over.
            
        }
    }

 
}
