// GENERATED AUTOMATICALLY FROM 'Assets/UserInput/HeroInputAction.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @HeroInputAction : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @HeroInputAction()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""HeroInputAction"",
    ""maps"": [
        {
            ""name"": ""Hero"",
            ""id"": ""92c454b9-0d11-4ab5-8f93-557762833aee"",
            ""actions"": [
                {
                    ""name"": ""SaySomething"",
                    ""type"": ""Button"",
                    ""id"": ""4ba74e1d-b8d5-45cb-9e3a-86c18ce4ef8b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""movement"",
                    ""type"": ""Value"",
                    ""id"": ""1597acea-d97a-4192-a40f-5cc4fc58acb7"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""05c761a3-4681-4e1f-99b5-afb23e119c25"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""b6f50a6b-d6ca-47c9-9340-96ebd539a90e"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SaySomething"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""ac868da2-12a7-49b6-96ce-fa27d33c6e26"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""58f000eb-4807-4662-b16d-083755a7967f"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""53746db0-9196-4a55-a451-77db450b1a78"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""e8ad2b1d-ea3f-4246-b225-6fe4fc084776"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""b21f9276-b69e-425e-998a-1f7f56bf16b8"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""c2c27748-ce74-4aa1-a379-452a0b2ccbcb"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Hero
        m_Hero = asset.FindActionMap("Hero", throwIfNotFound: true);
        m_Hero_SaySomething = m_Hero.FindAction("SaySomething", throwIfNotFound: true);
        m_Hero_movement = m_Hero.FindAction("movement", throwIfNotFound: true);
        m_Hero_Interact = m_Hero.FindAction("Interact", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // Hero
    private readonly InputActionMap m_Hero;
    private IHeroActions m_HeroActionsCallbackInterface;
    private readonly InputAction m_Hero_SaySomething;
    private readonly InputAction m_Hero_movement;
    private readonly InputAction m_Hero_Interact;
    public struct HeroActions
    {
        private @HeroInputAction m_Wrapper;
        public HeroActions(@HeroInputAction wrapper) { m_Wrapper = wrapper; }
        public InputAction @SaySomething => m_Wrapper.m_Hero_SaySomething;
        public InputAction @movement => m_Wrapper.m_Hero_movement;
        public InputAction @Interact => m_Wrapper.m_Hero_Interact;
        public InputActionMap Get() { return m_Wrapper.m_Hero; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(HeroActions set) { return set.Get(); }
        public void SetCallbacks(IHeroActions instance)
        {
            if (m_Wrapper.m_HeroActionsCallbackInterface != null)
            {
                @SaySomething.started -= m_Wrapper.m_HeroActionsCallbackInterface.OnSaySomething;
                @SaySomething.performed -= m_Wrapper.m_HeroActionsCallbackInterface.OnSaySomething;
                @SaySomething.canceled -= m_Wrapper.m_HeroActionsCallbackInterface.OnSaySomething;
                @movement.started -= m_Wrapper.m_HeroActionsCallbackInterface.OnMovement;
                @movement.performed -= m_Wrapper.m_HeroActionsCallbackInterface.OnMovement;
                @movement.canceled -= m_Wrapper.m_HeroActionsCallbackInterface.OnMovement;
                @Interact.started -= m_Wrapper.m_HeroActionsCallbackInterface.OnInteract;
                @Interact.performed -= m_Wrapper.m_HeroActionsCallbackInterface.OnInteract;
                @Interact.canceled -= m_Wrapper.m_HeroActionsCallbackInterface.OnInteract;
            }
            m_Wrapper.m_HeroActionsCallbackInterface = instance;
            if (instance != null)
            {
                @SaySomething.started += instance.OnSaySomething;
                @SaySomething.performed += instance.OnSaySomething;
                @SaySomething.canceled += instance.OnSaySomething;
                @movement.started += instance.OnMovement;
                @movement.performed += instance.OnMovement;
                @movement.canceled += instance.OnMovement;
                @Interact.started += instance.OnInteract;
                @Interact.performed += instance.OnInteract;
                @Interact.canceled += instance.OnInteract;
            }
        }
    }
    public HeroActions @Hero => new HeroActions(this);
    public interface IHeroActions
    {
        void OnSaySomething(InputAction.CallbackContext context);
        void OnMovement(InputAction.CallbackContext context);
        void OnInteract(InputAction.CallbackContext context);
    }
}
