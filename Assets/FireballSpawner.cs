using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballSpawner : MonoBehaviour
{
    public GameObject fireball; 
    public GameObject fireballParent; 

    public float originOffset = 10;

    // Start is called before the first frame update
    void Start()
    {
        spawnFireball();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q)){
            spawnFireball();    
        }
    }


    void spawnFireball(){
        Instantiate(fireball, new Vector3(fireballParent.transform.position.x + originOffset, fireballParent.transform.position.y, 0), transform.rotation);
    }
}
