using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    float clock;
    // Declara uma variável `clock` do tipo `float`, que será usada como cronômetro para controlar o tempo entre as instâncias.
    float cooldown = 2f;
    // Declara uma variável `cooldown` do tipo `float` e define seu valor inicial como 2. Isso representa o tempo de espera entre a criação de novos objetos.
    GameObject prefab;

    // Declara uma variável `prefab` do tipo `GameObject`, que armazenará o prefab (modelo) a ser instanciado.

    // Update é chamado uma vez por frame
    // Método `Update`, que é chamado a cada frame.
    private void Update()
    {
        //{
        // Verifica se o cronômetro `clock` atingiu zero ou menos.
        if (clock <= 0)
        {
           
            // Reseta o cronômetro `clock` para o valor de `cooldown`.
            clock =cooldown;

            // Instancia o prefab na posição x correspondente ao limite da tela (lado direito) e em uma posição y aleatória entre -2 e 2.
            // A rotação do prefab é definida como `Quaternion.identity`, ou seja, sem rotação.
            //Quaternion.identity();
            //}
        }
        // Se o cronômetro ainda não atingiu zero, subtrai o valor de `Time.deltaTime` do cronômetro (equivalente ao tempo do último frame).
        if (clock != 0)
        {
            clock -= Time.deltaTime;
        }
    
    }
   
}


