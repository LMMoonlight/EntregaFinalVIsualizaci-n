using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LookAtPersonitas : MonoBehaviour
{
    Vector3 mousePos;
    Vector3 diference;
    float radians, degrees;
    [SerializeField] Image photo;
    [SerializeField] Sprite front, up, down, left, right, upRight, upLeft, downRight, downLeft;

    void Update() {
        mousePos = GetMousePosition();
        diference = mousePos - transform.position;
        radians = Mathf.Atan2(diference.y, diference.x);
        degrees = radians * Mathf.Rad2Deg;

        if (diference.magnitude < 120)
        {
            photo.sprite = front;
        }
        else
        {
            if (degrees > -30 && degrees < 30)
            {
                photo.sprite = right;
            }
            else if (degrees > 30 && degrees < 60)
            {
                photo.sprite = upRight;
            }
            else if (degrees > 60 && degrees < 120)
            {
                photo.sprite = up;
            }
            else if (degrees > 120 && degrees < 150)
            {
                photo.sprite = upLeft;
            }
            else if (degrees > 150 || degrees < -150)
            {
                photo.sprite = left;
            }
            else if (degrees > -150 && degrees < -120)
            {
                photo.sprite = downLeft;
            }
            else if (degrees > -120 && degrees < -60)
            {
                photo.sprite = down;
            }
            else if (degrees > -60 && degrees < -30)
            {
                photo.sprite = downRight;
            }
        }
    }

    private Vector3 GetMousePosition() {
        Camera camera = Camera.main;
        Vector3 screenPos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, camera.nearClipPlane);
        screenPos.z = 0;

        return screenPos;
    }
}
