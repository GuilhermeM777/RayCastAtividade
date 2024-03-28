using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDestroyer : MonoBehaviour
{
    public Transform target; // O objeto que o raycast vai mirar
    public float destroyDistance = 20f; // A dist�ncia em que o objeto ser� destru�do

    private void Update()
    {
        // Lan�a um raycast a partir da posi��o deste objeto na dire��o do objeto alvo
        RaycastHit hit;
        if (Physics.Raycast(transform.position, (target.position - transform.position).normalized, out hit))
        {
            // Verifica se o objeto atingido pelo raycast � o objeto alvo
            if (hit.transform == target)
            {
                // Verifica se a dist�ncia entre os dois objetos � menor ou igual � dist�ncia de destrui��o
                if (Vector3.Distance(transform.position, target.position) <= destroyDistance)
                {
                    // Se a condi��o for atendida, destr�i o objeto alvo
                    Destroy(target.gameObject);
                }
            }
        }
    }
}