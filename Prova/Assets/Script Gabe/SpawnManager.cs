using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    float clock;
    // Declara uma vari�vel `clock` do tipo `float`, que ser� usada como cron�metro para controlar o tempo entre as inst�ncias.
    float cooldown = 2f;
    // Declara uma vari�vel `cooldown` do tipo `float` e define seu valor inicial como 2. Isso representa o tempo de espera entre a cria��o de novos objetos.
    GameObject prefab;

    // Declara uma vari�vel `prefab` do tipo `GameObject`, que armazenar� o prefab (modelo) a ser instanciado.

    // Update � chamado uma vez por frame
    // M�todo `Update`, que � chamado a cada frame.
    private void Update()
    {
        //{
        // Verifica se o cron�metro `clock` atingiu zero ou menos.
        if (clock <= 0)
        {
           
            // Reseta o cron�metro `clock` para o valor de `cooldown`.
            clock =cooldown;

            // Instancia o prefab na posi��o x correspondente ao limite da tela (lado direito) e em uma posi��o y aleat�ria entre -2 e 2.
            // A rota��o do prefab � definida como `Quaternion.identity`, ou seja, sem rota��o.
            //Quaternion.identity();
            //}
        }
        // Se o cron�metro ainda n�o atingiu zero, subtrai o valor de `Time.deltaTime` do cron�metro (equivalente ao tempo do �ltimo frame).
        if (clock != 0)
        {
            clock -= Time.deltaTime;
        }
    
    }
   
}


