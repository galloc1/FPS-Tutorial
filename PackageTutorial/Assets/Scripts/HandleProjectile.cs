using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandleProjectile : MonoBehaviour
{
    public float projectileLife;
    private float timer;

    public int damage;

    // Start is called before the first frame update
    void Start()
    {
        timer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer >= projectileLife)
        {
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }
}
