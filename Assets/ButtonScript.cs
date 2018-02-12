using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ButtonScript : MonoBehaviour {

    public UnityEvent onClickEvent = new UnityEvent();
    public Color onColor;
    public Color offColor;

    public bool triger = false;
    
    void Start()
    {

        changeColor();

    }

    void OnTriggerEnter(Collider other)
    {
        triger = !triger;
        onClickEvent.Invoke();
    }

    void changeColor() {
        if (triger)
            this.transform.GetComponent<Renderer>().material.color = onColor;
        else
            this.transform.GetComponent<Renderer>().material.color = offColor;


    }
    
}
