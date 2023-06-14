using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnScreenPointerController : MonoBehaviour
{
    [SerializeField]
    private Camera m_playerCamera;
    [SerializeField]
    private RectTransform m_uiContainerOfPointers;
    public Camera playerCamera
    {
        get { return m_playerCamera; }
    }
    public RectTransform uiContainerOfPointers
    {
        get { return m_uiContainerOfPointers; }
    }

    public static OnScreenPointerController Instance { get; private set; }

   
    private void Awake()
    {
        Instance = this;
        if (m_playerCamera == null) {
            m_playerCamera = Camera.main;
        }
    }

}
