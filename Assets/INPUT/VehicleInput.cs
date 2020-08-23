// GENERATED AUTOMATICALLY FROM 'Assets/INPUT/VehicleInput.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @VehicleInput : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @VehicleInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""VehicleInput"",
    ""maps"": [
        {
            ""name"": ""Move"",
            ""id"": ""62da9e56-9045-4f82-bb6e-ff2ba5cadae0"",
            ""actions"": [
                {
                    ""name"": ""Drive"",
                    ""type"": ""Value"",
                    ""id"": ""d2757cba-83f8-47a1-b056-7fc6e424ff9f"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Steering"",
                    ""type"": ""Value"",
                    ""id"": ""487fcc72-7137-4940-b835-40869f250267"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Brake"",
                    ""type"": ""Button"",
                    ""id"": ""5e048549-92c5-451c-b0f3-dfa9ed5c0e2b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Boost"",
                    ""type"": ""Button"",
                    ""id"": ""2c3f42e8-ff07-4598-be50-846d0862e680"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Controller"",
                    ""id"": ""9d4b52bf-ed78-4aad-803f-e141c3083d4e"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Drive"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""5b44616f-ba58-41d1-ad90-f7a8a89fc3d4"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Drive"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""c3126742-f931-4340-b07f-5a41142e1886"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Drive"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Arrows"",
                    ""id"": ""f4d0e638-bd7e-4ef6-ba8c-678582659025"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Drive"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""ec824e42-63d6-4c27-9600-af15fc5c011d"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Drive"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""b7800c32-c773-4429-a361-f2f3da784bd8"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Drive"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""4726e4df-468e-4af2-9d43-b47302e73f54"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Drive"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""f9472525-dd07-4658-a345-2c4390229d86"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Drive"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""95e9fc49-1f82-4177-9ea1-cbc573b3823b"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Drive"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Controller"",
                    ""id"": ""ab14d5bd-745c-4871-ba94-fdee89bcacf4"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Steering"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""b75f9fce-a00a-4a5f-b7a9-67d249b8c5e5"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Steering"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""fc5da6a0-06cc-486e-8c05-9c1e468aaba1"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Steering"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Arrows"",
                    ""id"": ""7fe2f088-b4aa-444b-97e4-2c24f9e3f306"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Steering"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""b7a60bc5-e61c-4041-9355-9d35c2d52202"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Steering"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""cd960c96-6bca-4a57-a944-5768c0b6859e"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Steering"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""38cb37c5-7544-42b5-9740-0ca442d623fd"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Steering"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""4134623c-cfa7-480d-8f0f-0f572bece98e"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Steering"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""9600c15e-82a8-4179-a87a-eae3aca6c8f1"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Steering"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""494ee473-17d2-4257-9d5b-d8b1ad927824"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Brake"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a5e9f839-fdd6-4d33-a3b5-3a45c0159642"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Brake"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""abb40711-0e10-461a-9802-bec9d8fe2108"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Boost"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e9c037f5-f1a4-41fe-877b-a1e97d7fda34"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": ""MultiTap"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Boost"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Attack"",
            ""id"": ""ded20730-95fe-40dc-bdb2-f17500756b48"",
            ""actions"": [
                {
                    ""name"": ""ShootPrimary"",
                    ""type"": ""Button"",
                    ""id"": ""79d2e694-253b-46f5-b026-fcd9457e92bf"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ShootSecondary"",
                    ""type"": ""Button"",
                    ""id"": ""b0cf961d-dab5-4d87-b42c-7a5abdfa9def"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Special"",
                    ""type"": ""Button"",
                    ""id"": ""9e2f0e52-bdd7-4aee-b53c-41cd6f70614a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""a400fad3-5128-4e1e-9bf3-1471fd3ef3a0"",
                    ""path"": ""<Keyboard>/z"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ShootPrimary"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""16a5cbb8-09bb-4fbc-b403-e6d7e10d862a"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ShootPrimary"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6e64aba0-549d-4f4b-b5f9-5150c480fb79"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ShootPrimary"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5b91d48a-3d70-4bed-8d4c-03d244a4cb77"",
                    ""path"": ""<Keyboard>/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ShootSecondary"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""dc0599c7-d96f-4fe4-9978-f83b376935ef"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ShootSecondary"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a13b7a6c-6196-4e7b-a4ae-8b12950df726"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ShootSecondary"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e732f16a-e862-4960-8ae3-d31a2202eca5"",
                    ""path"": ""<Keyboard>/c"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Special"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""76f36727-0ddd-4c61-a106-d1b689384ab9"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Special"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Move
        m_Move = asset.FindActionMap("Move", throwIfNotFound: true);
        m_Move_Drive = m_Move.FindAction("Drive", throwIfNotFound: true);
        m_Move_Steering = m_Move.FindAction("Steering", throwIfNotFound: true);
        m_Move_Brake = m_Move.FindAction("Brake", throwIfNotFound: true);
        m_Move_Boost = m_Move.FindAction("Boost", throwIfNotFound: true);
        // Attack
        m_Attack = asset.FindActionMap("Attack", throwIfNotFound: true);
        m_Attack_ShootPrimary = m_Attack.FindAction("ShootPrimary", throwIfNotFound: true);
        m_Attack_ShootSecondary = m_Attack.FindAction("ShootSecondary", throwIfNotFound: true);
        m_Attack_Special = m_Attack.FindAction("Special", throwIfNotFound: true);
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

    // Move
    private readonly InputActionMap m_Move;
    private IMoveActions m_MoveActionsCallbackInterface;
    private readonly InputAction m_Move_Drive;
    private readonly InputAction m_Move_Steering;
    private readonly InputAction m_Move_Brake;
    private readonly InputAction m_Move_Boost;
    public struct MoveActions
    {
        private @VehicleInput m_Wrapper;
        public MoveActions(@VehicleInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Drive => m_Wrapper.m_Move_Drive;
        public InputAction @Steering => m_Wrapper.m_Move_Steering;
        public InputAction @Brake => m_Wrapper.m_Move_Brake;
        public InputAction @Boost => m_Wrapper.m_Move_Boost;
        public InputActionMap Get() { return m_Wrapper.m_Move; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MoveActions set) { return set.Get(); }
        public void SetCallbacks(IMoveActions instance)
        {
            if (m_Wrapper.m_MoveActionsCallbackInterface != null)
            {
                @Drive.started -= m_Wrapper.m_MoveActionsCallbackInterface.OnDrive;
                @Drive.performed -= m_Wrapper.m_MoveActionsCallbackInterface.OnDrive;
                @Drive.canceled -= m_Wrapper.m_MoveActionsCallbackInterface.OnDrive;
                @Steering.started -= m_Wrapper.m_MoveActionsCallbackInterface.OnSteering;
                @Steering.performed -= m_Wrapper.m_MoveActionsCallbackInterface.OnSteering;
                @Steering.canceled -= m_Wrapper.m_MoveActionsCallbackInterface.OnSteering;
                @Brake.started -= m_Wrapper.m_MoveActionsCallbackInterface.OnBrake;
                @Brake.performed -= m_Wrapper.m_MoveActionsCallbackInterface.OnBrake;
                @Brake.canceled -= m_Wrapper.m_MoveActionsCallbackInterface.OnBrake;
                @Boost.started -= m_Wrapper.m_MoveActionsCallbackInterface.OnBoost;
                @Boost.performed -= m_Wrapper.m_MoveActionsCallbackInterface.OnBoost;
                @Boost.canceled -= m_Wrapper.m_MoveActionsCallbackInterface.OnBoost;
            }
            m_Wrapper.m_MoveActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Drive.started += instance.OnDrive;
                @Drive.performed += instance.OnDrive;
                @Drive.canceled += instance.OnDrive;
                @Steering.started += instance.OnSteering;
                @Steering.performed += instance.OnSteering;
                @Steering.canceled += instance.OnSteering;
                @Brake.started += instance.OnBrake;
                @Brake.performed += instance.OnBrake;
                @Brake.canceled += instance.OnBrake;
                @Boost.started += instance.OnBoost;
                @Boost.performed += instance.OnBoost;
                @Boost.canceled += instance.OnBoost;
            }
        }
    }
    public MoveActions @Move => new MoveActions(this);

    // Attack
    private readonly InputActionMap m_Attack;
    private IAttackActions m_AttackActionsCallbackInterface;
    private readonly InputAction m_Attack_ShootPrimary;
    private readonly InputAction m_Attack_ShootSecondary;
    private readonly InputAction m_Attack_Special;
    public struct AttackActions
    {
        private @VehicleInput m_Wrapper;
        public AttackActions(@VehicleInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @ShootPrimary => m_Wrapper.m_Attack_ShootPrimary;
        public InputAction @ShootSecondary => m_Wrapper.m_Attack_ShootSecondary;
        public InputAction @Special => m_Wrapper.m_Attack_Special;
        public InputActionMap Get() { return m_Wrapper.m_Attack; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(AttackActions set) { return set.Get(); }
        public void SetCallbacks(IAttackActions instance)
        {
            if (m_Wrapper.m_AttackActionsCallbackInterface != null)
            {
                @ShootPrimary.started -= m_Wrapper.m_AttackActionsCallbackInterface.OnShootPrimary;
                @ShootPrimary.performed -= m_Wrapper.m_AttackActionsCallbackInterface.OnShootPrimary;
                @ShootPrimary.canceled -= m_Wrapper.m_AttackActionsCallbackInterface.OnShootPrimary;
                @ShootSecondary.started -= m_Wrapper.m_AttackActionsCallbackInterface.OnShootSecondary;
                @ShootSecondary.performed -= m_Wrapper.m_AttackActionsCallbackInterface.OnShootSecondary;
                @ShootSecondary.canceled -= m_Wrapper.m_AttackActionsCallbackInterface.OnShootSecondary;
                @Special.started -= m_Wrapper.m_AttackActionsCallbackInterface.OnSpecial;
                @Special.performed -= m_Wrapper.m_AttackActionsCallbackInterface.OnSpecial;
                @Special.canceled -= m_Wrapper.m_AttackActionsCallbackInterface.OnSpecial;
            }
            m_Wrapper.m_AttackActionsCallbackInterface = instance;
            if (instance != null)
            {
                @ShootPrimary.started += instance.OnShootPrimary;
                @ShootPrimary.performed += instance.OnShootPrimary;
                @ShootPrimary.canceled += instance.OnShootPrimary;
                @ShootSecondary.started += instance.OnShootSecondary;
                @ShootSecondary.performed += instance.OnShootSecondary;
                @ShootSecondary.canceled += instance.OnShootSecondary;
                @Special.started += instance.OnSpecial;
                @Special.performed += instance.OnSpecial;
                @Special.canceled += instance.OnSpecial;
            }
        }
    }
    public AttackActions @Attack => new AttackActions(this);
    public interface IMoveActions
    {
        void OnDrive(InputAction.CallbackContext context);
        void OnSteering(InputAction.CallbackContext context);
        void OnBrake(InputAction.CallbackContext context);
        void OnBoost(InputAction.CallbackContext context);
    }
    public interface IAttackActions
    {
        void OnShootPrimary(InputAction.CallbackContext context);
        void OnShootSecondary(InputAction.CallbackContext context);
        void OnSpecial(InputAction.CallbackContext context);
    }
}
