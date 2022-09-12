using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetHealth : MonoBehaviour
{
    public int maxHealth;
    private int currentHealth;


    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }
    private void TargetDestroy()
    {
        gameObject.SetActive(false);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Projectile"))
        {
            currentHealth -= collision.gameObject.GetComponent<HandleProjectile>().damage;
            if(currentHealth <= 0)
            {
                TargetDestroy();
            }
        }
    }
}
