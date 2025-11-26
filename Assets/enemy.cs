using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public int hp = 1;
    public Rigidbody rb;
    public float deathForce = 200f;


    public void TakeDamage(int dmg)
    {
        hp -= dmg;
        if (hp <= 0) Die();
    }


    void Die()
    {
        if (rb == null) rb = GetComponent<Rigidbody>();
        rb.isKinematic = false; // permitir física
        rb.AddForce(Vector3.up * deathForce);
        Destroy(gameObject, 2f);
    }
}