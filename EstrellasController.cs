using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class EstrellasController : MonoBehaviour {
    [GradientUsage(true)]
    [SerializeField] Gradient emissionGradient;
     // Start is called before the first frame update
    void Start()
    {

        this.GetComponent<MeshRenderer>().material.DOGradientColor(emissionGradient, "_EmissionColor", Random.Range(0,70)).SetLoops(-1,LoopType.Restart);

        this.transform.DOShakePosition(Random.Range(50,90), 2, 0, 70).SetLoops(-1, LoopType.Yoyo);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
