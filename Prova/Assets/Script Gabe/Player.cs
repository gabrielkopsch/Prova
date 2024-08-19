using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Content;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Player : MonoBehaviour
{
// Declara uma vari�vel `rigidbody2d` do tipo `Rigidbody2D`, que ser� usada para aplicar f�sica ao jogador.
   Rigidbody2D rigidbody2D;

    // Declara uma vari�vel `managerUI` do tipo `UIManager`, que ser� usada para gerenciar a interface do usu�rio.
   // UIManager managerUI;
    // Start � chamado antes da primeira atualiza��o do frame
    // M�todo `Start`, que � chamado uma vez quando o script � iniciado.
    private void Start()
    {
        // Obt�m e armazena o componente `Rigidbody2D` anexado ao objeto do jogador.
       rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        // Verifica se a tecla do bot�o esquerdo do mouse foi pressionada.
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
    // M�todo chamado quando o jogador entra em colis�o com um objeto com o qual ele pode interagir.
    //{
    // Verifica se o objeto colidido tem a tag "Obstacle".
    //{
    // Se for um obst�culo, chama o m�todo `GameOver`.
    //}
    // Verifica se o objeto colidido tem a tag "Score".
    //{
    // Incrementa a pontua��o no `GameManager`.
    // Atualiza o texto da pontua��o na interface do usu�rio.
    //  }
    //}

    void GameOver()
    {

        // Verifica se a pontua��o atual � maior que o recorde armazenado.
       // if (Score > recorde)
        {
            // Se for maior, atualiza o recorde nas prefer�ncias do jogador.
            //recorde = Score; 
            // Chama o m�todo `GameOver` no `UIManager` para exibir a tela de Game Over.
            
        }
    }

 
}
