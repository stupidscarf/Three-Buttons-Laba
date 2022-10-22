using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JumpButton : MonoBehaviour
{
    [SerializeField] private Button _jumpButton;

    private void OnEnable()
    {
        _jumpButton.onClick.AddListener(Jump); 
        Debug.Log("enable");
    }
    private void Jump()
    {
        Debug.Log("JUMP");
    }
    private void OnDisable()
    {
        _jumpButton.onClick.RemoveListener(Jump); //RemoveAllListeners
        Debug.Log("disable");
    }
}
