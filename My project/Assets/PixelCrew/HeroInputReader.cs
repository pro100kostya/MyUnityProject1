using UnityEngine;
using UnityEngine.InputSystem;

public class HeroInputReader : MonoBehaviour
{
    [SerializeField] private Hero _hero;
    private HeroInputAction _inputActions;
    private Vector2 _direction = new Vector2(0, 0);

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
        _direction.x = context.ReadValue<float>();
        _hero.SetDirection(_direction);
    }

    private void OnVerticalMovement(InputAction.CallbackContext context)
    {
        _direction.y = context.ReadValue<float>();
        _hero.SetDirection(_direction);
    }

    private void OnSaySomething(InputAction.CallbackContext context)
    {
            Debug.Log("Something");
    }
}
