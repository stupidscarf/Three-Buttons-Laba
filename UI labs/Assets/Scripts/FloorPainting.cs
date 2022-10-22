using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorPainting : MonoBehaviour
{
    [SerializeField] private Color _tileColorToChange;
    [SerializeField] private LayerMask _groundLayerMask;
    private GameObject currTriggerGO;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if ((_groundLayerMask.value & (1 << collision.gameObject.layer)) > 0)
        {
            currTriggerGO = collision.gameObject;
            currTriggerGO.GetComponent<SpriteRenderer>().color = _tileColorToChange;
        }
    }
}
