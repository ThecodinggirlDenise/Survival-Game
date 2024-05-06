using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerLook : MonoBehaviour
{
    public Camera cam;
    private float xRotation = 0f;
    public float xSensitivity = 30f;
    public float ySensitivity = 30f;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked; // Lock cursor to center of screen
    }

    // Process camera rotation based on input
    public void ProcessLook(Vector2 input)
    {
        // Extract mouse input values
        float mouseX = input.x * xSensitivity * Time.deltaTime;
        float mouseY = input.y * ySensitivity * Time.deltaTime;

        // Adjust camera rotation around the X-axis (up/down)
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f); // Limit vertical rotation to prevent flipping

        // Rotate the camera locally around the X-axis
        cam.transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);

        // Rotate the player object horizontally (left/right)
        transform.Rotate(Vector3.up * mouseX);
    }
}
