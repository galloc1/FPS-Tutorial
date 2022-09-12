using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StarterAssets;

public class FireProjectile : MonoBehaviour
{
    public GameObject projectile;
    public Transform spawnTransform;
    public float force;

    private StarterAssetsInputs inputs;



    // Start is called before the first frame update
    void Start()
    {
        inputs = GetComponent<StarterAssetsInputs>();
    }

    // Update is called once per frame
    void Update()
    {
        if (inputs.fire)
        {
            GameObject temp = Instantiate(projectile, spawnTransform.position, spawnTransform.rotation);
            temp.GetComponent<Rigidbody>().AddForce(temp.transform.forward * force);
            inputs.fire = false;
        }
    }
}
