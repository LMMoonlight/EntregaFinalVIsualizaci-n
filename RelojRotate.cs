using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class RelojRotate : MonoBehaviour
{
    //[SerializeField] private Transform ParteReloj;
    void Start()
    {
        transform.DORotate(new Vector3(0, 0, 360), 40, RotateMode.LocalAxisAdd).SetLoops(-1, LoopType.Restart).SetEase(Ease.Linear);
    }

    // Update is called once per frame

}
