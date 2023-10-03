using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getPellet : MonoBehaviour
{
    public Animator pelletAnimator;
    public AudioSource eatPellet;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            pelletAnimator.SetTrigger("eat");
            eatPellet.Play();
        }
    }
}
