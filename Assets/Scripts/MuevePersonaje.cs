using UnityEngine;
using UnityEngine.InputSystem;

public class MuevePersonaje : MonoBehaviour
{
    

    // Para las 4 direcciones
     [SerializeField]
    private InputAction moveAction;

    private const float SPEED = 10.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      
        moveAction.Enable();
    }

    // Update is called once per frame
    void Update()
    {
    
        Vector2 move = moveAction.ReadValue<Vector2>();
        transform.position = (Vector2)transform.position + SPEED * Time.deltaTime * move;

        
    }
}