using UnityEngine;
using UnityEngine.InputSystem;

public class HeroInputReader : MonoBehaviour
{
    [SerializeField] private Hero _hero;
    private HeroInputAction _inputActions;

    private void Awake()
    {
        _inputActions = new HeroInputAction();
        _inputActions.Hero.HorizontalMovement.performed += OnHorizontalMovement;
        _inputActions.Hero.HorizontalMovement.canceled += OnHorizontalMovement;
        _inputActions.Hero.VerticalMovement.performed += OnVerticalMovement;
        _inputActions.Hero.VerticalMovement.canceled += OnVerticalMovement;

        _inputActions.Hero.SaySomething.performed += OnSaySomething;
    }

    private void OnEnable()
    {
        _inputActions.Enable();
    }


    private void OnHorizontalMovement(InputAction.CallbackContext context)
    {
        var direction = context.ReadValue<float>();
        _hero.SetDirection(new Vector2(direction, 0));
    }

    private void OnVerticalMovement(InputAction.CallbackContext context)
    {
        var direction = context.ReadValue<float>();
        _hero.SetDirection(new Vector2(0, direction));
    }

    private void OnSaySomething(InputAction.CallbackContext context)
    {
            Debug.Log("Something");
    }
}
