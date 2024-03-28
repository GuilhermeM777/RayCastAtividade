using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDestroyer : MonoBehaviour
{
    public Transform target; // O objeto que o raycast vai mirar
    public float destroyDistance = 20f; // A distância em que o objeto será destruído

    private void Update()
    {
        // Lança um raycast a partir da posição deste objeto na direção do objeto alvo
        RaycastHit hit;
        if (Physics.Raycast(transform.position, (target.position - transform.position).normalized, out hit))
        {
            // Verifica se o objeto atingido pelo raycast é o objeto alvo
            if (hit.transform == target)
            {
                // Verifica se a distância entre os dois objetos é menor ou igual à distância de destruição
                if (Vector3.Distance(transform.position, target.position) <= destroyDistance)
                {
                    // Se a condição for atendida, destrói o objeto alvo
                    Destroy(target.gameObject);
                }
            }
        }
    }
}