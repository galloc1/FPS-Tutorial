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
        Time.timeScale = 0.25f;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer >= projectileLife)
        {
            Time.timeScale = 1f;
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        Time.timeScale = 1f;
        Destroy(gameObject);
    }
}
