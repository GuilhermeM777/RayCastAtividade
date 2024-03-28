using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f; // Velocidade de movimento
    public float turnSpeed = 3f; // Velocidade de rotação da câmera
    private Camera playerCamera; // Referência para a câmera

    private void Start()
    {
        // Obtém a referência da câmera
        playerCamera = Camera.main;
    }

    private void Update()
    {
        // Movimento do jogador
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector3 movementDirection = new Vector3(horizontalInput, 0f, verticalInput).normalized;
        transform.Translate(movementDirection * moveSpeed * Time.deltaTime);

        // Rotação da câmera com o mouse
        float mouseX = Input.GetAxis("Mouse X") * turnSpeed;
        transform.Rotate(Vector3.up, mouseX);

        // Rotação vertical da câmera com o mouse (inverter mouseY para controlar a direção)
        float mouseY = Input.GetAxis("Mouse Y") * -turnSpeed;
        playerCamera.transform.Rotate(Vector3.right, mouseY);
    }
}