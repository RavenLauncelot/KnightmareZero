//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.11.2
//     from Assets/PlayerControls/PlayerControls.inputactions
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

public partial class @PlayerControls: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""BattleCamera"",
            ""id"": ""a736fc36-e2a7-475e-941f-54ac79a230fe"",
            ""actions"": [
                {
                    ""name"": ""Orbit"",
                    ""type"": ""Button"",
                    ""id"": ""f54f9eff-6fb9-4f4e-b129-d45b659be2f9"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""MouseInput"",
                    ""type"": ""Value"",
                    ""id"": ""38a8ad03-1a73-4f94-b29a-a8394f5a037d"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Zoom"",
                    ""type"": ""Value"",
                    ""id"": ""579f5d86-5433-41c4-ae32-9513584e5ff6"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""CameraMovement"",
                    ""type"": ""Value"",
                    ""id"": ""ccbce9a7-9374-47bc-b376-90e3d4e2c970"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""290c8ba6-37ec-4a9d-af32-026732fbb0e5"",
                    ""path"": ""<Mouse>/middleButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Orbit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ca76d551-f8c2-48f8-a686-8108e7a837b9"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": ""InvertVector2(invertX=false)"",
                    ""groups"": """",
                    ""action"": ""MouseInput"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""faf0b266-2e2f-492b-be5b-0031abcf5176"",
                    ""path"": ""<Mouse>/scroll/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Zoom"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""9c4f97dc-311d-4e7d-b44d-7eeedc141039"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CameraMovement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""9cfd4fa5-e8ef-4a14-a85b-0f68fc692370"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CameraMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""fc390193-9d22-4f5c-aa95-ddd92e8000d0"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CameraMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""5737f430-9d4d-4f39-9a86-170bf4d471c0"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CameraMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""7a9a619e-673b-4c62-bbd9-c9f909bbe59c"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CameraMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // BattleCamera
        m_BattleCamera = asset.FindActionMap("BattleCamera", throwIfNotFound: true);
        m_BattleCamera_Orbit = m_BattleCamera.FindAction("Orbit", throwIfNotFound: true);
        m_BattleCamera_MouseInput = m_BattleCamera.FindAction("MouseInput", throwIfNotFound: true);
        m_BattleCamera_Zoom = m_BattleCamera.FindAction("Zoom", throwIfNotFound: true);
        m_BattleCamera_CameraMovement = m_BattleCamera.FindAction("CameraMovement", throwIfNotFound: true);
    }

    ~@PlayerControls()
    {
        UnityEngine.Debug.Assert(!m_BattleCamera.enabled, "This will cause a leak and performance issues, PlayerControls.BattleCamera.Disable() has not been called.");
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

    // BattleCamera
    private readonly InputActionMap m_BattleCamera;
    private List<IBattleCameraActions> m_BattleCameraActionsCallbackInterfaces = new List<IBattleCameraActions>();
    private readonly InputAction m_BattleCamera_Orbit;
    private readonly InputAction m_BattleCamera_MouseInput;
    private readonly InputAction m_BattleCamera_Zoom;
    private readonly InputAction m_BattleCamera_CameraMovement;
    public struct BattleCameraActions
    {
        private @PlayerControls m_Wrapper;
        public BattleCameraActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Orbit => m_Wrapper.m_BattleCamera_Orbit;
        public InputAction @MouseInput => m_Wrapper.m_BattleCamera_MouseInput;
        public InputAction @Zoom => m_Wrapper.m_BattleCamera_Zoom;
        public InputAction @CameraMovement => m_Wrapper.m_BattleCamera_CameraMovement;
        public InputActionMap Get() { return m_Wrapper.m_BattleCamera; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(BattleCameraActions set) { return set.Get(); }
        public void AddCallbacks(IBattleCameraActions instance)
        {
            if (instance == null || m_Wrapper.m_BattleCameraActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_BattleCameraActionsCallbackInterfaces.Add(instance);
            @Orbit.started += instance.OnOrbit;
            @Orbit.performed += instance.OnOrbit;
            @Orbit.canceled += instance.OnOrbit;
            @MouseInput.started += instance.OnMouseInput;
            @MouseInput.performed += instance.OnMouseInput;
            @MouseInput.canceled += instance.OnMouseInput;
            @Zoom.started += instance.OnZoom;
            @Zoom.performed += instance.OnZoom;
            @Zoom.canceled += instance.OnZoom;
            @CameraMovement.started += instance.OnCameraMovement;
            @CameraMovement.performed += instance.OnCameraMovement;
            @CameraMovement.canceled += instance.OnCameraMovement;
        }

        private void UnregisterCallbacks(IBattleCameraActions instance)
        {
            @Orbit.started -= instance.OnOrbit;
            @Orbit.performed -= instance.OnOrbit;
            @Orbit.canceled -= instance.OnOrbit;
            @MouseInput.started -= instance.OnMouseInput;
            @MouseInput.performed -= instance.OnMouseInput;
            @MouseInput.canceled -= instance.OnMouseInput;
            @Zoom.started -= instance.OnZoom;
            @Zoom.performed -= instance.OnZoom;
            @Zoom.canceled -= instance.OnZoom;
            @CameraMovement.started -= instance.OnCameraMovement;
            @CameraMovement.performed -= instance.OnCameraMovement;
            @CameraMovement.canceled -= instance.OnCameraMovement;
        }

        public void RemoveCallbacks(IBattleCameraActions instance)
        {
            if (m_Wrapper.m_BattleCameraActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IBattleCameraActions instance)
        {
            foreach (var item in m_Wrapper.m_BattleCameraActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_BattleCameraActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public BattleCameraActions @BattleCamera => new BattleCameraActions(this);
    public interface IBattleCameraActions
    {
        void OnOrbit(InputAction.CallbackContext context);
        void OnMouseInput(InputAction.CallbackContext context);
        void OnZoom(InputAction.CallbackContext context);
        void OnCameraMovement(InputAction.CallbackContext context);
    }
}
