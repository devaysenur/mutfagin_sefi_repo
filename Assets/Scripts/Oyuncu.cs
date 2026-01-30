using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oyuncu : MonoBehaviour
{
    [SerializeField] private float hareketHizi = 7f;
    //private Animator anim;

    private bool isWalking;


    private void Update() {
        Vector2 inputVector = new Vector2(0, 0);
        if (Input.GetKey(KeyCode.W)) {
            inputVector.y = +1;
        }
        if (Input.GetKey(KeyCode.S)) {
            inputVector.y = -1;
        }
        if (Input.GetKey(KeyCode.A)) {
            inputVector.x = -1;
        }
        if (Input.GetKey(KeyCode.D)) {
            inputVector.x = +1;
        }
        inputVector = inputVector.normalized; /*x ve y aynı anda 1 olunca bu diagonal vektör daha 
                                               büyük olur,normalizasyon sağlandı */
        Vector3 hareketYonu = new Vector3(inputVector.x, 0f, inputVector.y);
        transform.position += hareketYonu * hareketHizi * Time.deltaTime; //vector3

        isWalking = hareketYonu != Vector3.zero;
        float donusHizi = 10f;
        transform.forward = Vector3.Slerp(transform.forward, hareketYonu, Time.deltaTime * donusHizi);


        Debug.Log(inputVector);
        Debug.Log(Time.deltaTime);

    }
    public bool IsWalking() {
        return isWalking;   
    }
}

