//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.3.0
//     from Assets/Input/PlayerInput.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @PlayerInput : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInput"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""4e200285-2243-4280-8b35-be201a77b237"",
            ""actions"": [
                {
                    ""name"": ""Btn Ltr 1"",
                    ""type"": ""Button"",
                    ""id"": ""3383b71e-ded4-4415-8907-5675ed00c601"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Btn Ltr 2"",
                    ""type"": ""Button"",
                    ""id"": ""61d5f875-3fbb-4c24-9657-69922b69403b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Btn Ltr 3"",
                    ""type"": ""Button"",
                    ""id"": ""3f5ad02d-70ab-4c27-90d2-c2ab63279027"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Btn Num 1"",
                    ""type"": ""Button"",
                    ""id"": ""7f1e45b5-16df-431e-a615-fd90967c2e30"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Btn Num 2"",
                    ""type"": ""Button"",
                    ""id"": ""a35781dd-1ca1-46a8-a2e3-d88039b0fc73"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Btn Num 3"",
                    ""type"": ""Button"",
                    ""id"": ""c50f7238-c63b-4de6-bf6e-f6acd35a2707"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Btn Num 4"",
                    ""type"": ""Button"",
                    ""id"": ""9ac997f5-bc0d-41eb-bf75-435d4ffa1b09"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""7888b722-8c1e-4876-9018-27b01c571832"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KMB Scheme"",
                    ""action"": ""Btn Ltr 1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""caefd657-2815-4da6-a835-8595e842ebda"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Btn Ltr 2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fc064616-b219-46e4-89c1-f2c6fa1d942b"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Btn Ltr 3"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1754d66f-7d49-483c-8008-cba864f4fb56"",
                    ""path"": ""<Keyboard>/1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Btn Num 1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""aa2bd875-172e-4ae4-ad25-43635481bbb3"",
                    ""path"": ""<Keyboard>/2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Btn Num 2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""14e02289-aa6b-417d-9bec-083d4db7a376"",
                    ""path"": ""<Keyboard>/3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Btn Num 3"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4b50fc96-83f8-4fdc-bd0a-892950f868b8"",
                    ""path"": ""<Keyboard>/4"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Btn Num 4"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""KMB Scheme"",
            ""bindingGroup"": ""KMB Scheme"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_BtnLtr1 = m_Player.FindAction("Btn Ltr 1", throwIfNotFound: true);
        m_Player_BtnLtr2 = m_Player.FindAction("Btn Ltr 2", throwIfNotFound: true);
        m_Player_BtnLtr3 = m_Player.FindAction("Btn Ltr 3", throwIfNotFound: true);
        m_Player_BtnNum1 = m_Player.FindAction("Btn Num 1", throwIfNotFound: true);
        m_Player_BtnNum2 = m_Player.FindAction("Btn Num 2", throwIfNotFound: true);
        m_Player_BtnNum3 = m_Player.FindAction("Btn Num 3", throwIfNotFound: true);
        m_Player_BtnNum4 = m_Player.FindAction("Btn Num 4", throwIfNotFound: true);
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
    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_BtnLtr1;
    private readonly InputAction m_Player_BtnLtr2;
    private readonly InputAction m_Player_BtnLtr3;
    private readonly InputAction m_Player_BtnNum1;
    private readonly InputAction m_Player_BtnNum2;
    private readonly InputAction m_Player_BtnNum3;
    private readonly InputAction m_Player_BtnNum4;
    public struct PlayerActions
    {
        private @PlayerInput m_Wrapper;
        public PlayerActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @BtnLtr1 => m_Wrapper.m_Player_BtnLtr1;
        public InputAction @BtnLtr2 => m_Wrapper.m_Player_BtnLtr2;
        public InputAction @BtnLtr3 => m_Wrapper.m_Player_BtnLtr3;
        public InputAction @BtnNum1 => m_Wrapper.m_Player_BtnNum1;
        public InputAction @BtnNum2 => m_Wrapper.m_Player_BtnNum2;
        public InputAction @BtnNum3 => m_Wrapper.m_Player_BtnNum3;
        public InputAction @BtnNum4 => m_Wrapper.m_Player_BtnNum4;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @BtnLtr1.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnBtnLtr1;
                @BtnLtr1.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnBtnLtr1;
                @BtnLtr1.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnBtnLtr1;
                @BtnLtr2.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnBtnLtr2;
                @BtnLtr2.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnBtnLtr2;
                @BtnLtr2.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnBtnLtr2;
                @BtnLtr3.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnBtnLtr3;
                @BtnLtr3.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnBtnLtr3;
                @BtnLtr3.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnBtnLtr3;
                @BtnNum1.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnBtnNum1;
                @BtnNum1.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnBtnNum1;
                @BtnNum1.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnBtnNum1;
                @BtnNum2.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnBtnNum2;
                @BtnNum2.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnBtnNum2;
                @BtnNum2.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnBtnNum2;
                @BtnNum3.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnBtnNum3;
                @BtnNum3.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnBtnNum3;
                @BtnNum3.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnBtnNum3;
                @BtnNum4.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnBtnNum4;
                @BtnNum4.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnBtnNum4;
                @BtnNum4.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnBtnNum4;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @BtnLtr1.started += instance.OnBtnLtr1;
                @BtnLtr1.performed += instance.OnBtnLtr1;
                @BtnLtr1.canceled += instance.OnBtnLtr1;
                @BtnLtr2.started += instance.OnBtnLtr2;
                @BtnLtr2.performed += instance.OnBtnLtr2;
                @BtnLtr2.canceled += instance.OnBtnLtr2;
                @BtnLtr3.started += instance.OnBtnLtr3;
                @BtnLtr3.performed += instance.OnBtnLtr3;
                @BtnLtr3.canceled += instance.OnBtnLtr3;
                @BtnNum1.started += instance.OnBtnNum1;
                @BtnNum1.performed += instance.OnBtnNum1;
                @BtnNum1.canceled += instance.OnBtnNum1;
                @BtnNum2.started += instance.OnBtnNum2;
                @BtnNum2.performed += instance.OnBtnNum2;
                @BtnNum2.canceled += instance.OnBtnNum2;
                @BtnNum3.started += instance.OnBtnNum3;
                @BtnNum3.performed += instance.OnBtnNum3;
                @BtnNum3.canceled += instance.OnBtnNum3;
                @BtnNum4.started += instance.OnBtnNum4;
                @BtnNum4.performed += instance.OnBtnNum4;
                @BtnNum4.canceled += instance.OnBtnNum4;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    private int m_KMBSchemeSchemeIndex = -1;
    public InputControlScheme KMBSchemeScheme
    {
        get
        {
            if (m_KMBSchemeSchemeIndex == -1) m_KMBSchemeSchemeIndex = asset.FindControlSchemeIndex("KMB Scheme");
            return asset.controlSchemes[m_KMBSchemeSchemeIndex];
        }
    }
    public interface IPlayerActions
    {
        void OnBtnLtr1(InputAction.CallbackContext context);
        void OnBtnLtr2(InputAction.CallbackContext context);
        void OnBtnLtr3(InputAction.CallbackContext context);
        void OnBtnNum1(InputAction.CallbackContext context);
        void OnBtnNum2(InputAction.CallbackContext context);
        void OnBtnNum3(InputAction.CallbackContext context);
        void OnBtnNum4(InputAction.CallbackContext context);
    }
}