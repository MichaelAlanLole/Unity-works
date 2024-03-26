using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class treesad : MonoBehaviour
{
    
    public AudioClip treeDown;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            gameObject.GetComponent<AudioSource>().PlayOneShot(treeDown);
        }
    }

}
