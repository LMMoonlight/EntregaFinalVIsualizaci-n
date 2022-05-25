using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class RotacionAros : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.DORotate(new Vector3(0, 360, 0), Random.Range(30,60), RotateMode.LocalAxisAdd).SetLoops(-1, LoopType.Restart).SetEase(Ease.Linear); 

    }

    // Update is called once per frame
    void Update()
    {
    }
}
