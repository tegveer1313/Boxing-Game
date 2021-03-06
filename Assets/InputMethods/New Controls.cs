// GENERATED AUTOMATICALLY FROM 'Assets/InputMethods/New Controls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @NewControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @NewControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""New Controls"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""ab03f37e-df83-4437-a14c-a00e9e2a377a"",
            ""actions"": [
                {
                    ""name"": ""move"",
                    ""type"": ""PassThrough"",
                    ""id"": ""3db628ae-e14a-45a5-bb47-84dafc8408f0"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""roll"",
                    ""type"": ""Button"",
                    ""id"": ""67580c60-34cf-438b-9d98-23ba5c2b1f9a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""60ec1a73-d1c8-4f61-9b62-6663e227582f"",
                    ""path"": ""2DVector(mode=2)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""612e4ec2-dd04-4358-b82c-4bb6177d845b"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""b54f5b2e-42ae-41d3-b47c-3fa97a5b9078"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""fa120ad4-046b-40fb-b019-c51b326519f4"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""e9acce15-1e26-4597-b3f5-aa6cbd7c0ea8"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""LeftStik"",
                    ""id"": ""d4a002f4-d09d-4e99-aab5-0fccc4f4329c"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""1308c0b5-ba5e-43b5-bb68-a13ee6b46a59"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""18803608-4ac8-4ce6-b5a1-82448ddb5e3f"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""80160581-4dac-4214-a8b5-6246e33ba819"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""3b275b89-88de-4974-9279-57218e4a8061"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""978ddbea-a828-43ef-acb5-3ce5697d1105"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""roll"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b84012ac-9742-4bed-9a1b-1180bb99e084"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""roll"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""PlayerAction"",
            ""id"": ""99e9acba-4206-4524-8a58-067dd5947a73"",
            ""actions"": [
                {
                    ""name"": ""leftPunch"",
                    ""type"": ""Button"",
                    ""id"": ""5cbecfdf-317f-4c00-a939-0f9ad31fccda"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""rightPunch"",
                    ""type"": ""Button"",
                    ""id"": ""d66dcb11-d1a2-4b8b-b6e4-9134c8b08bd2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""leftLeg"",
                    ""type"": ""Button"",
                    ""id"": ""a738c3b4-bcf3-47e2-9fab-a29649094a89"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""rightLeg"",
                    ""type"": ""Button"",
                    ""id"": ""76a35775-87e3-4dba-a256-c78afe458d96"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""block"",
                    ""type"": ""Button"",
                    ""id"": ""b109c47e-8d0e-44eb-8763-8d3b4db3a694"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""5a311b44-03b3-43f8-8bf5-33011536132d"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""leftPunch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""42b90dc1-dcbb-4002-8f89-00fab2ff270f"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""leftPunch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4d97b6a5-2eed-43c7-910f-b4a07407ea95"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""rightPunch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""656f4c83-097f-46dc-b37d-9d0b6b566593"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""rightPunch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d7f2f71f-d2fe-4edc-8a19-bb36ee1f3c98"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""leftLeg"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0fed34da-cf44-4a96-99e3-9f22613934fa"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""leftLeg"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2ef6403e-5356-476e-b1ad-c634834e1d0f"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""rightLeg"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6385d888-e3b8-4abe-9175-87f11d0443f0"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""rightLeg"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""205a646b-c8fe-4333-8c5d-46af57e9499c"",
                    ""path"": ""<Keyboard>/alt"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""block"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0a53518b-478d-49dc-96f6-f3d980f9b4b0"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""block"",
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
        m_Player_move = m_Player.FindAction("move", throwIfNotFound: true);
        m_Player_roll = m_Player.FindAction("roll", throwIfNotFound: true);
        // PlayerAction
        m_PlayerAction = asset.FindActionMap("PlayerAction", throwIfNotFound: true);
        m_PlayerAction_leftPunch = m_PlayerAction.FindAction("leftPunch", throwIfNotFound: true);
        m_PlayerAction_rightPunch = m_PlayerAction.FindAction("rightPunch", throwIfNotFound: true);
        m_PlayerAction_leftLeg = m_PlayerAction.FindAction("leftLeg", throwIfNotFound: true);
        m_PlayerAction_rightLeg = m_PlayerAction.FindAction("rightLeg", throwIfNotFound: true);
        m_PlayerAction_block = m_PlayerAction.FindAction("block", throwIfNotFound: true);
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

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_move;
    private readonly InputAction m_Player_roll;
    public struct PlayerActions
    {
        private @NewControls m_Wrapper;
        public PlayerActions(@NewControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @move => m_Wrapper.m_Player_move;
        public InputAction @roll => m_Wrapper.m_Player_roll;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @move.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @move.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @move.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @roll.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRoll;
                @roll.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRoll;
                @roll.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRoll;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @move.started += instance.OnMove;
                @move.performed += instance.OnMove;
                @move.canceled += instance.OnMove;
                @roll.started += instance.OnRoll;
                @roll.performed += instance.OnRoll;
                @roll.canceled += instance.OnRoll;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);

    // PlayerAction
    private readonly InputActionMap m_PlayerAction;
    private IPlayerActionActions m_PlayerActionActionsCallbackInterface;
    private readonly InputAction m_PlayerAction_leftPunch;
    private readonly InputAction m_PlayerAction_rightPunch;
    private readonly InputAction m_PlayerAction_leftLeg;
    private readonly InputAction m_PlayerAction_rightLeg;
    private readonly InputAction m_PlayerAction_block;
    public struct PlayerActionActions
    {
        private @NewControls m_Wrapper;
        public PlayerActionActions(@NewControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @leftPunch => m_Wrapper.m_PlayerAction_leftPunch;
        public InputAction @rightPunch => m_Wrapper.m_PlayerAction_rightPunch;
        public InputAction @leftLeg => m_Wrapper.m_PlayerAction_leftLeg;
        public InputAction @rightLeg => m_Wrapper.m_PlayerAction_rightLeg;
        public InputAction @block => m_Wrapper.m_PlayerAction_block;
        public InputActionMap Get() { return m_Wrapper.m_PlayerAction; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActionActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActionActions instance)
        {
            if (m_Wrapper.m_PlayerActionActionsCallbackInterface != null)
            {
                @leftPunch.started -= m_Wrapper.m_PlayerActionActionsCallbackInterface.OnLeftPunch;
                @leftPunch.performed -= m_Wrapper.m_PlayerActionActionsCallbackInterface.OnLeftPunch;
                @leftPunch.canceled -= m_Wrapper.m_PlayerActionActionsCallbackInterface.OnLeftPunch;
                @rightPunch.started -= m_Wrapper.m_PlayerActionActionsCallbackInterface.OnRightPunch;
                @rightPunch.performed -= m_Wrapper.m_PlayerActionActionsCallbackInterface.OnRightPunch;
                @rightPunch.canceled -= m_Wrapper.m_PlayerActionActionsCallbackInterface.OnRightPunch;
                @leftLeg.started -= m_Wrapper.m_PlayerActionActionsCallbackInterface.OnLeftLeg;
                @leftLeg.performed -= m_Wrapper.m_PlayerActionActionsCallbackInterface.OnLeftLeg;
                @leftLeg.canceled -= m_Wrapper.m_PlayerActionActionsCallbackInterface.OnLeftLeg;
                @rightLeg.started -= m_Wrapper.m_PlayerActionActionsCallbackInterface.OnRightLeg;
                @rightLeg.performed -= m_Wrapper.m_PlayerActionActionsCallbackInterface.OnRightLeg;
                @rightLeg.canceled -= m_Wrapper.m_PlayerActionActionsCallbackInterface.OnRightLeg;
                @block.started -= m_Wrapper.m_PlayerActionActionsCallbackInterface.OnBlock;
                @block.performed -= m_Wrapper.m_PlayerActionActionsCallbackInterface.OnBlock;
                @block.canceled -= m_Wrapper.m_PlayerActionActionsCallbackInterface.OnBlock;
            }
            m_Wrapper.m_PlayerActionActionsCallbackInterface = instance;
            if (instance != null)
            {
                @leftPunch.started += instance.OnLeftPunch;
                @leftPunch.performed += instance.OnLeftPunch;
                @leftPunch.canceled += instance.OnLeftPunch;
                @rightPunch.started += instance.OnRightPunch;
                @rightPunch.performed += instance.OnRightPunch;
                @rightPunch.canceled += instance.OnRightPunch;
                @leftLeg.started += instance.OnLeftLeg;
                @leftLeg.performed += instance.OnLeftLeg;
                @leftLeg.canceled += instance.OnLeftLeg;
                @rightLeg.started += instance.OnRightLeg;
                @rightLeg.performed += instance.OnRightLeg;
                @rightLeg.canceled += instance.OnRightLeg;
                @block.started += instance.OnBlock;
                @block.performed += instance.OnBlock;
                @block.canceled += instance.OnBlock;
            }
        }
    }
    public PlayerActionActions @PlayerAction => new PlayerActionActions(this);
    public interface IPlayerActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnRoll(InputAction.CallbackContext context);
    }
    public interface IPlayerActionActions
    {
        void OnLeftPunch(InputAction.CallbackContext context);
        void OnRightPunch(InputAction.CallbackContext context);
        void OnLeftLeg(InputAction.CallbackContext context);
        void OnRightLeg(InputAction.CallbackContext context);
        void OnBlock(InputAction.CallbackContext context);
    }
}
