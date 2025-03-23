using UnityEngine;
using UnityEngine.InputSystem;

public class SaltoPersonaje : MonoBehaviour
{
    [SerializeField] private 
    InputAction jumpAction;

    private const float JUMP_FORCE = 15f;
    private const float GRAVEDAD_SIMULADA = -5f; // Simula gravedad
    private Rigidbody2D rb;

    void Start()
    {
        jumpAction.Enable();
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float movVertical = jumpAction.ReadValue<float>();

        if (movVertical > 0)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, JUMP_FORCE);
        }
        else
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, GRAVEDAD_SIMULADA);
        }
    }
}
