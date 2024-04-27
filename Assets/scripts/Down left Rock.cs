using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DownleftRock : MonoBehaviour
{
    
    public Animator animator;
    public AudioClip RockDown;

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
            animator.SetTrigger("open");
            gameObject.GetComponent<AudioSource>().PlayOneShot(RockDown);
        }
    }

}
