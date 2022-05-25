using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class LookAtSeleccionador : MonoBehaviour
{
    [SerializeField] RectTransform lupa;
    
    // Start is called before the first frame update
    void Start()
    {
        lupa.DORotate(new Vector3(0,0,-0.6f), 0.25f);
    
    }

}
