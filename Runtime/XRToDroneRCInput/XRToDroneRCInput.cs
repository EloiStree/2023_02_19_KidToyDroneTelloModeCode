     
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @XRToDroneRCInput: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @XRToDroneRCInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""XRToDroneRCInput"",
    ""maps"": [
        {
            ""name"": ""XRToDroneRCFull"",
            ""id"": ""4565c30d-0a52-4aac-a919-6dc4b5ef1b78"",
            ""actions"": [
                {
                    ""name"": ""LeftRight"",
                    ""type"": ""Value"",
                    ""id"": ""ceabf02e-8598-4c54-9ccc-7c4208690d1b"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""DownUp"",
                    ""type"": ""Value"",
                    ""id"": ""cda92494-1a7c-46d9-9175-2d20e12650d7"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""BackFront"",
                    ""type"": ""Value"",
                    ""id"": ""b60743ce-0c3c-48d5-b918-8548b7b74572"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""LeftRigthRotation"",
                    ""type"": ""Value"",
                    ""id"": ""50bc415f-5785-49f7-a43e-32411c94b520"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""3fb3f538-c074-4c47-9d23-9ec09ba07af7"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""BackFront"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""8e8de32c-4aa9-40ce-a49b-c98e05766285"",
                    ""path"": ""<Keyboard>/k"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""BackFront"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""a7c76ca3-4ad8-4465-a7d4-1c5f0f93705f"",
                    ""path"": ""<Keyboard>/i"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""BackFront"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""73c86fbc-7e5d-40e7-a353-98a3e2aadf3a"",
                    ""path"": ""<Gamepad>/leftStick/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftRigthRotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""b9238826-bfff-48e9-bc7e-72d7e3c661d5"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftRigthRotation"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""466a0c44-e156-4311-bd83-a35d9e1d17d6"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftRigthRotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""895c19a6-3438-42c4-a521-34c5077d26c0"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftRigthRotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""544ebecf-8c10-42a8-b1d6-9f72f3b52969"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DownUp"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""e4c3ebb5-83c9-4fda-8d79-2e6e32867cd9"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DownUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""01ee1f9d-32b8-4454-8cca-7d075a380985"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DownUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""7e66388f-bd27-4140-a83d-d1c83db0b592"",
                    ""path"": ""<OculusTouchController>{LeftHand}/thumbstick/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftRigthRotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""50fedf7e-b302-4ff9-ab80-4adab39ae272"",
                    ""path"": ""<WMRSpatialController>{LeftHand}/joystick/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftRigthRotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3b343553-177b-41d4-9333-2361c9552a61"",
                    ""path"": ""<OculusTouchController>{RightHand}/thumbstick/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""BackFront"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5279c23d-f9c9-4d9b-b210-85c39f8d9301"",
                    ""path"": ""<WMRSpatialController>{RightHand}/joystick/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""BackFront"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5dba2daf-9265-4dc2-b7d9-775473ad511f"",
                    ""path"": ""<Gamepad>/rightStick/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""BackFront"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ac2f03cf-dbe6-48ac-91f9-b494c57d81b0"",
                    ""path"": ""<OculusTouchController>{LeftHand}/thumbstick/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DownUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""68ff494c-0d5c-4988-b42e-c42682166c31"",
                    ""path"": ""<WMRSpatialController>{LeftHand}/joystick/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DownUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6ee6e3ab-c98e-4728-b3a8-59cbb03063c4"",
                    ""path"": ""<Gamepad>/leftStick/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DownUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""8b7a820b-de07-49af-9bb5-b05ee0c72da7"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftRight"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""ae20d90b-63ab-44a7-ae30-2dac84d02c6c"",
                    ""path"": ""<Keyboard>/j"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""089e55ef-34f8-4d96-a1cf-572b8091d267"",
                    ""path"": ""<Keyboard>/l"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""57a0ca35-4390-475b-8487-766c6d72d0da"",
                    ""path"": ""<Gamepad>/rightStick/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""732472b8-3b85-449b-bf7f-acab51fd3c54"",
                    ""path"": ""<OculusTouchController>{RightHand}/thumbstick/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""36d71dc2-161e-46b9-b840-6851d87a1c5b"",
                    ""path"": ""<WMRSpatialController>{RightHand}/joystick/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // XRToDroneRCFull
        m_XRToDroneRCFull = asset.FindActionMap("XRToDroneRCFull", throwIfNotFound: true);
        m_XRToDroneRCFull_LeftRight = m_XRToDroneRCFull.FindAction("LeftRight", throwIfNotFound: true);
        m_XRToDroneRCFull_DownUp = m_XRToDroneRCFull.FindAction("DownUp", throwIfNotFound: true);
        m_XRToDroneRCFull_BackFront = m_XRToDroneRCFull.FindAction("BackFront", throwIfNotFound: true);
        m_XRToDroneRCFull_LeftRigthRotation = m_XRToDroneRCFull.FindAction("LeftRigthRotation", throwIfNotFound: true);
    }

    ~@XRToDroneRCInput()
    {
        UnityEngine.Debug.Assert(!m_XRToDroneRCFull.enabled, "This will cause a leak and performance issues, XRToDroneRCInput.XRToDroneRCFull.Disable() has not been called.");
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

    // XRToDroneRCFull
    private readonly InputActionMap m_XRToDroneRCFull;
    private List<IXRToDroneRCFullActions> m_XRToDroneRCFullActionsCallbackInterfaces = new List<IXRToDroneRCFullActions>();
    private readonly InputAction m_XRToDroneRCFull_LeftRight;
    private readonly InputAction m_XRToDroneRCFull_DownUp;
    private readonly InputAction m_XRToDroneRCFull_BackFront;
    private readonly InputAction m_XRToDroneRCFull_LeftRigthRotation;
    public struct XRToDroneRCFullActions
    {
        private @XRToDroneRCInput m_Wrapper;
        public XRToDroneRCFullActions(@XRToDroneRCInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @LeftRight => m_Wrapper.m_XRToDroneRCFull_LeftRight;
        public InputAction @DownUp => m_Wrapper.m_XRToDroneRCFull_DownUp;
        public InputAction @BackFront => m_Wrapper.m_XRToDroneRCFull_BackFront;
        public InputAction @LeftRigthRotation => m_Wrapper.m_XRToDroneRCFull_LeftRigthRotation;
        public InputActionMap Get() { return m_Wrapper.m_XRToDroneRCFull; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(XRToDroneRCFullActions set) { return set.Get(); }
        public void AddCallbacks(IXRToDroneRCFullActions instance)
        {
            if (instance == null || m_Wrapper.m_XRToDroneRCFullActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_XRToDroneRCFullActionsCallbackInterfaces.Add(instance);
            @LeftRight.started += instance.OnLeftRight;
            @LeftRight.performed += instance.OnLeftRight;
            @LeftRight.canceled += instance.OnLeftRight;
            @DownUp.started += instance.OnDownUp;
            @DownUp.performed += instance.OnDownUp;
            @DownUp.canceled += instance.OnDownUp;
            @BackFront.started += instance.OnBackFront;
            @BackFront.performed += instance.OnBackFront;
            @BackFront.canceled += instance.OnBackFront;
            @LeftRigthRotation.started += instance.OnLeftRigthRotation;
            @LeftRigthRotation.performed += instance.OnLeftRigthRotation;
            @LeftRigthRotation.canceled += instance.OnLeftRigthRotation;
        }

        private void UnregisterCallbacks(IXRToDroneRCFullActions instance)
        {
            @LeftRight.started -= instance.OnLeftRight;
            @LeftRight.performed -= instance.OnLeftRight;
            @LeftRight.canceled -= instance.OnLeftRight;
            @DownUp.started -= instance.OnDownUp;
            @DownUp.performed -= instance.OnDownUp;
            @DownUp.canceled -= instance.OnDownUp;
            @BackFront.started -= instance.OnBackFront;
            @BackFront.performed -= instance.OnBackFront;
            @BackFront.canceled -= instance.OnBackFront;
            @LeftRigthRotation.started -= instance.OnLeftRigthRotation;
            @LeftRigthRotation.performed -= instance.OnLeftRigthRotation;
            @LeftRigthRotation.canceled -= instance.OnLeftRigthRotation;
        }

        public void RemoveCallbacks(IXRToDroneRCFullActions instance)
        {
            if (m_Wrapper.m_XRToDroneRCFullActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IXRToDroneRCFullActions instance)
        {
            foreach (var item in m_Wrapper.m_XRToDroneRCFullActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_XRToDroneRCFullActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public XRToDroneRCFullActions @XRToDroneRCFull => new XRToDroneRCFullActions(this);
    public interface IXRToDroneRCFullActions
    {
        void OnLeftRight(InputAction.CallbackContext context);
        void OnDownUp(InputAction.CallbackContext context);
        void OnBackFront(InputAction.CallbackContext context);
        void OnLeftRigthRotation(InputAction.CallbackContext context);
    }
}
