using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shot_script : MonoBehaviour
{
    public GameObject bulletObj;
    public float impulse;
    private bool reload;
    public float cooldown = 1;
    private float waitTime = 0;


    public void ShootWithCooldown()
    {
        if (waitTime <= 0)
        {
            GameObject bullet = Instantiate(bulletObj);
            bullet.transform.position = this.gameObject.transform.position;
            bullet.GetComponent<Rigidbody>().AddForce(transform.forward * impulse, ForceMode.Impulse);
            waitTime = cooldown;
        }
    }


    public void Update()
    {
        if (waitTime > 0)
        {
            waitTime -= Time.deltaTime;

        }

    }

    public void Shoot()
    {
        GameObject bullet = Instantiate(bulletObj);
        bullet.transform.position = this.gameObject.transform.position;
        bullet.GetComponent<Rigidbody>().AddForce(transform.forward * impulse, ForceMode.Impulse);
    }
}
