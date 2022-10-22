using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ThirdButton : MonoBehaviour
{
    [SerializeField] private Button _button;
    [SerializeField] private GameObject _currentImage;
    [SerializeField] private List<GameObject> _imageToDisables;
    private void OnEnable()
    {
        _button.onClick.AddListener(SussyImageActivation);
    }
    private void SussyImageActivation()
    {
        _currentImage.SetActive(true);
        foreach (GameObject item in _imageToDisables)
        {
            item.SetActive(false);
        }
    }
    private void OnDisable()
    {
        _button.onClick.RemoveAllListeners();
    }
}
