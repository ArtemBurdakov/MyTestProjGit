//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.6.3
//     from Assets/MyProject/newInputSystem/MyInputActions.inputactions
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

namespace MyInputActions
{
    public partial class @MyInputActions: IInputActionCollection2, IDisposable
    {
        public InputActionAsset asset { get; }
        public @MyInputActions()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""MyInputActions"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""2e3ef9a2-26b1-4dfc-9768-ff7c53605df7"",
            ""actions"": [
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""bd1e7749-6500-4c9f-94e6-0b01dee353ef"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Fire1"",
                    ""type"": ""Button"",
                    ""id"": ""56306b45-d6fe-4174-853f-cf675b27c972"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""SelectWeapon1"",
                    ""type"": ""Button"",
                    ""id"": ""f3db5d47-e965-4ba4-a2bc-2e1a5d9f8d6e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""SelectWeapon2"",
                    ""type"": ""Button"",
                    ""id"": ""d7b5f787-fd98-4b40-960b-a6d019d5d7ce"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""SelectWeapon3"",
                    ""type"": ""Button"",
                    ""id"": ""84bb972e-4551-4469-8b38-cab237ef4944"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""f13c0bcf-f05e-48ec-828a-b10dc91d8979"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3e580e80-106d-4fa6-b8ba-d25287f13526"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0550d8d6-3928-4313-b763-6e0494e8ad02"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Fire1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5f0382c6-36b2-4f45-ab5c-ff7ab81dc6ef"",
                    ""path"": ""<Keyboard>/1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SelectWeapon1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7af45559-9aa3-4a95-b8ef-d25819af493a"",
                    ""path"": ""<Keyboard>/2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SelectWeapon2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ba46d857-3fde-4ade-a344-7ec591eea92f"",
                    ""path"": ""<Keyboard>/3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SelectWeapon3"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
            // Player
            m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
            m_Player_Jump = m_Player.FindAction("Jump", throwIfNotFound: true);
            m_Player_Fire1 = m_Player.FindAction("Fire1", throwIfNotFound: true);
            m_Player_SelectWeapon1 = m_Player.FindAction("SelectWeapon1", throwIfNotFound: true);
            m_Player_SelectWeapon2 = m_Player.FindAction("SelectWeapon2", throwIfNotFound: true);
            m_Player_SelectWeapon3 = m_Player.FindAction("SelectWeapon3", throwIfNotFound: true);
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
        private List<IPlayerActions> m_PlayerActionsCallbackInterfaces = new List<IPlayerActions>();
        private readonly InputAction m_Player_Jump;
        private readonly InputAction m_Player_Fire1;
        private readonly InputAction m_Player_SelectWeapon1;
        private readonly InputAction m_Player_SelectWeapon2;
        private readonly InputAction m_Player_SelectWeapon3;
        public struct PlayerActions
        {
            private @MyInputActions m_Wrapper;
            public PlayerActions(@MyInputActions wrapper) { m_Wrapper = wrapper; }
            public InputAction @Jump => m_Wrapper.m_Player_Jump;
            public InputAction @Fire1 => m_Wrapper.m_Player_Fire1;
            public InputAction @SelectWeapon1 => m_Wrapper.m_Player_SelectWeapon1;
            public InputAction @SelectWeapon2 => m_Wrapper.m_Player_SelectWeapon2;
            public InputAction @SelectWeapon3 => m_Wrapper.m_Player_SelectWeapon3;
            public InputActionMap Get() { return m_Wrapper.m_Player; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
            public void AddCallbacks(IPlayerActions instance)
            {
                if (instance == null || m_Wrapper.m_PlayerActionsCallbackInterfaces.Contains(instance)) return;
                m_Wrapper.m_PlayerActionsCallbackInterfaces.Add(instance);
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Fire1.started += instance.OnFire1;
                @Fire1.performed += instance.OnFire1;
                @Fire1.canceled += instance.OnFire1;
                @SelectWeapon1.started += instance.OnSelectWeapon1;
                @SelectWeapon1.performed += instance.OnSelectWeapon1;
                @SelectWeapon1.canceled += instance.OnSelectWeapon1;
                @SelectWeapon2.started += instance.OnSelectWeapon2;
                @SelectWeapon2.performed += instance.OnSelectWeapon2;
                @SelectWeapon2.canceled += instance.OnSelectWeapon2;
                @SelectWeapon3.started += instance.OnSelectWeapon3;
                @SelectWeapon3.performed += instance.OnSelectWeapon3;
                @SelectWeapon3.canceled += instance.OnSelectWeapon3;
            }

            private void UnregisterCallbacks(IPlayerActions instance)
            {
                @Jump.started -= instance.OnJump;
                @Jump.performed -= instance.OnJump;
                @Jump.canceled -= instance.OnJump;
                @Fire1.started -= instance.OnFire1;
                @Fire1.performed -= instance.OnFire1;
                @Fire1.canceled -= instance.OnFire1;
                @SelectWeapon1.started -= instance.OnSelectWeapon1;
                @SelectWeapon1.performed -= instance.OnSelectWeapon1;
                @SelectWeapon1.canceled -= instance.OnSelectWeapon1;
                @SelectWeapon2.started -= instance.OnSelectWeapon2;
                @SelectWeapon2.performed -= instance.OnSelectWeapon2;
                @SelectWeapon2.canceled -= instance.OnSelectWeapon2;
                @SelectWeapon3.started -= instance.OnSelectWeapon3;
                @SelectWeapon3.performed -= instance.OnSelectWeapon3;
                @SelectWeapon3.canceled -= instance.OnSelectWeapon3;
            }

            public void RemoveCallbacks(IPlayerActions instance)
            {
                if (m_Wrapper.m_PlayerActionsCallbackInterfaces.Remove(instance))
                    UnregisterCallbacks(instance);
            }

            public void SetCallbacks(IPlayerActions instance)
            {
                foreach (var item in m_Wrapper.m_PlayerActionsCallbackInterfaces)
                    UnregisterCallbacks(item);
                m_Wrapper.m_PlayerActionsCallbackInterfaces.Clear();
                AddCallbacks(instance);
            }
        }
        public PlayerActions @Player => new PlayerActions(this);
        public interface IPlayerActions
        {
            void OnJump(InputAction.CallbackContext context);
            void OnFire1(InputAction.CallbackContext context);
            void OnSelectWeapon1(InputAction.CallbackContext context);
            void OnSelectWeapon2(InputAction.CallbackContext context);
            void OnSelectWeapon3(InputAction.CallbackContext context);
        }
    }
}
