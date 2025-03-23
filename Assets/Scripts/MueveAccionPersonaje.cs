using UnityEngine;
using UnityEngine.InputSystem;

public class MueveAccionPersonaje : MonoBehaviour
{
    // Definir la accion
    [SerializeField]
    private InputAction leftAction;

    // Para las 4 direcciones
     [SerializeField]
    private InputAction moveAction;

    private const float SPEED = 10.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        leftAction.Enable();
        moveAction.Enable();
    }

    // Update is called once per frame
    void Update()
    {
       /*if(leftAction.IsPressed()){

        }*/

        Vector2 move = moveAction.ReadValue<Vector2>();
        transform.position = (Vector2)transform.position + SPEED * Time.deltaTime * move;

        
    }
}
