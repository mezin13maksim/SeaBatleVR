using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy_and_Damage : MonoBehaviour {

    public int damage;
    

    public void OnCollisionEnter(Collision col)
    {
        switch (col.gameObject.tag) {
            case "Player":
                col.gameObject.GetComponent<Life>().life = col.gameObject.GetComponent<Life>().life - damage;
                Destroy(this.gameObject);
                break;
            case "Plane":
                Destroy(this.gameObject);
                break;
            case "Bot":
                col.gameObject.GetComponent<Life>().life = col.gameObject.GetComponent<Life>().life - damage;
                Destroy(this.gameObject);
                break;
        }
    }
}
