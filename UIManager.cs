using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class UIManager : MonoBehaviour
{
    [SerializeField] RectTransform menuPrincipal;
    [SerializeField] GameObject menuguardado;
    [SerializeField] GameObject[] botones = new GameObject[3];
    [SerializeField] GameObject[] partidas = new GameObject[3];
    [SerializeField] GameObject[] partidasNuevas = new GameObject[3];
    [SerializeField] RectTransform nuevaPartidaButton, regresarButton, continuarPartidaButton;
    [SerializeField] RectTransform[] slots = new RectTransform[3];
    [SerializeField] RectTransform[] slotsNuevos = new RectTransform[3];
    [SerializeField] RectTransform escalable;
    bool escalada = false;
    // Start is called before the first frame update
    void Start()
    {
        menuPrincipal.DORotate(Vector3.zero, 0.25f);
    }

    // Update is called once per frame
    public void PlayButton() {
        foreach (var item in botones)
        {
            item.GetComponent<Button>().interactable = false;

        }
        menuPrincipal.DOLocalRotate(new Vector3(0, 0, -45), 0.25f, RotateMode.FastBeyond360);
        menuguardado.SetActive(true);
        foreach (var item in partidas)
        {
            item.SetActive(false);
        }
    }

    public void BackButton()
    {
        menuguardado.transform.GetChild(1).GetComponent<RectTransform>().anchoredPosition = new Vector3(10, -981, 0);
        menuPrincipal.DOLocalRotate(Vector3.zero, 0.25f);
        menuguardado.SetActive(false);
        foreach (var item in botones)
        {
            item.GetComponent<Button>().interactable = true;
        }
        nuevaPartidaButton.DOAnchorPos(new Vector3(-987.8815f, -42.82691f, 0), 0.25f);
        foreach (var item in slots)
        {
            item.DOAnchorPos(new Vector3(-978, -23.99f, 0), 0.25f);
        }
        continuarPartidaButton.DOAnchorPos(new Vector3(990, 3, 0), 0.25f);
        foreach (var item in slotsNuevos)
        {
            item.DOAnchorPos(new Vector3(985, -17, 0), 0.25f);
        }
        if (escalada == true) {
            escalable.DOScaleX(0f, 0.5f);
            escalable.DOScaleY(0f, 0.5f);
            escalada = false;
        }
       

    }
    public void NuevaPartidaButton() {

        nuevaPartidaButton.DOAnchorPos(new Vector3(-989, 192, 0), 0.25f).SetEase(Ease.InOutCubic);
        foreach (var item in partidas)
        {
            item.SetActive(true);
        }
        slots[2].DOAnchorPos(new Vector3(-1007,-242, 0), 0.3f).OnComplete(() =>
        {
            slots[1].DOAnchorPos(new Vector3(-834, -57, 0), 0.3f).OnComplete(() =>
            {
                slots[0].DOAnchorPos(new Vector3(-1124, -25, 0), 0.3f);
            });
        });
        foreach (var item in slotsNuevos)
        {
            item.DOAnchorPos(new Vector3(985, -17, 0), 0.25f);

        }
        continuarPartidaButton.DOAnchorPos(new Vector3(990, 3, 0), 0.25f).SetEase(Ease.InOutCubic);
    }

    public void ContinuarPartidaPartidaButton()
    {
        continuarPartidaButton.DOAnchorPos(new Vector3(957, 213, 0), 0.25f).SetEase(Ease.InOutCubic);
        foreach (var item in partidasNuevas)
        {
            item.SetActive(true);
        }
        
        slotsNuevos[2].DOAnchorPos(new Vector3(980.9998f, -209, 0), 0.3f).OnComplete(() =>
        {
            slotsNuevos[1].DOAnchorPos(new Vector3(1137, -20, 0), 0.3f).OnComplete(() =>
            {
                slotsNuevos[0].DOAnchorPos(new Vector3(862, -17, 0), 0.3f);
            });
        });
        foreach (var item in slots)
        {
            item.DOAnchorPos(new Vector3(-978, -23.99f, 0), 0.25f);
            
        }
        nuevaPartidaButton.DOAnchorPos(new Vector3(-987.8815f, -42.82691f, 0), 0.25f).SetEase(Ease.InOutCubic);
    }

    public void CreditosButton()
    {
        escalada = true;
        escalable.DOScaleX(1.8f,0.5f);
        escalable.DOScaleY(1.8f, 0.5f);
        menuguardado.SetActive(true);
        regresarButton.DOAnchorPos(new Vector3(15, 0, 0),0.5f);
    }

}
