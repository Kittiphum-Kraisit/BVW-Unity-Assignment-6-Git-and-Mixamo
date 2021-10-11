using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script : MonoBehaviour
{
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void dance1() {
        animator.SetInteger("dance",1);
    }
    public void dance2() {
        animator.SetInteger("dance",2);
    }
    public void dance3() {
        animator.SetInteger("dance",3);
    }
}
