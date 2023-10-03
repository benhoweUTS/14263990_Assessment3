using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ghostDemo : MonoBehaviour
{
    public Animator ghostAnimator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow)) {
            ghostAnimator.SetTrigger("blueUp");
        }
        if (Input.GetKeyDown(KeyCode.DownArrow)) {
            ghostAnimator.SetTrigger("blueDown");
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow)) {
            ghostAnimator.SetTrigger("blueLeft");
        }
        if (Input.GetKeyDown(KeyCode.RightArrow)) {
            ghostAnimator.SetTrigger("blueRight");
        }
        if (Input.GetKeyDown(KeyCode.Return)) {
            ghostAnimator.SetTrigger("blueScared");
        }
        if (Input.GetKeyDown(KeyCode.RightShift)) {
            ghostAnimator.SetTrigger("blueDeath");
        }
    }
}
