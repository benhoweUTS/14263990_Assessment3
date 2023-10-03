using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pacStudentDemo : MonoBehaviour
{
    public Animator pacAnimator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W)) {
            pacAnimator.SetTrigger("moveUp");
        }

        if (Input.GetKeyDown(KeyCode.S)) {
            pacAnimator.SetTrigger("moveDown");
        }

        if (Input.GetKeyDown(KeyCode.A)) {
            pacAnimator.SetTrigger("moveLeft");
        }

        if (Input.GetKeyDown(KeyCode.D)) {
            pacAnimator.SetTrigger("moveRight");
        }

        if (Input.GetKeyDown(KeyCode.K)) {
            pacAnimator.SetTrigger("ghostCollision");
        }
    }
}
