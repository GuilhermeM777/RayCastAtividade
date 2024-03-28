using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f; // Velocidade de movimento
    public float turnSpeed = 3f; // Velocidade de rota��o da c�mera
    private Camera playerCamera; // Refer�ncia para a c�mera

    private void Start()
    {
        // Obt�m a refer�ncia da c�mera
        playerCamera = Camera.main;
    }

    private void Update()
    {
        // Movimento do jogador
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector3 movementDirection = new Vector3(horizontalInput, 0f, verticalInput).normalized;
        transform.Translate(movementDirection * moveSpeed * Time.deltaTime);

        // Rota��o da c�mera com o mouse
        float mouseX = Input.GetAxis("Mouse X") * turnSpeed;
        transform.Rotate(Vector3.up, mouseX);

        // Rota��o vertical da c�mera com o mouse (inverter mouseY para controlar a dire��o)
        float mouseY = Input.GetAxis("Mouse Y") * -turnSpeed;
        playerCamera.transform.Rotate(Vector3.right, mouseY);
    }
}