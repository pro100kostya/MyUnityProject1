using UnityEngine;
using UnityEngine.InputSystem;

public class HeroInputReader : MonoBehaviour
{
    [SerializeField] private Hero _hero;
    private HeroInputAction _inputActions;


    public void OnMovement(InputAction.CallbackContext context)
    {
        _hero.SetDirection(context.ReadValue<Vector2>());
    }

    public void OnSaySomething(InputAction.CallbackContext context)
    {
        if (context.canceled)
        {
            Debug.Log("Something");
        }
    }

    public void OnInteract(InputAction.CallbackContext context)
    {
        if (context.canceled)
        {
            _hero.Interact();
        }
    }
}
