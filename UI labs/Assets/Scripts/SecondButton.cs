using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SecondButton : MonoBehaviour
{
    [SerializeField] private GameObject _currentImage;
    [SerializeField] private List<GameObject> _imageToDisables;
    public void SussyImageActivation()
    {
        _currentImage.SetActive(true);
        foreach (GameObject item in _imageToDisables)
        {
            item.SetActive(false);
        }
    }
}
