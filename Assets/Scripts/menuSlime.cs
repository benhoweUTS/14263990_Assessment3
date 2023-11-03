using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menuSlime : MonoBehaviour
{
    private bool movingLeft;
    public Animator blueSlimeAnim;

    // Start is called before the first frame update
    void Start()
    {
        movingLeft = true;   
    }

    // Update is called once per frame
    void Update()
    {
        if(movingLeft){
            if(transform.position.x <= 400){
                movingLeft = false;
            } else  {
                transform.position = new Vector3(transform.position.x - 0.5f, transform.position.y, transform.position.z);
                blueSlimeAnim.SetTrigger("movingLeft");
            }
        } else {
            if(transform.position.x >= 800){
                movingLeft = true;
            } else  {
                transform.position = new Vector3(transform.position.x + 0.5f, transform.position.y, transform.position.z);
                blueSlimeAnim.SetTrigger("movingRight");
            }
        }
    }
}