using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationScript : MonoBehaviour
{
    public Animator anim;
    public GameObject Chad;
    public ChadMainScript chadmainscript;
    // Start is called before the first frame update
    void Start()
    {
        if (Chad == null)
        {
            Chad = GameObject.FindGameObjectWithTag("Chad");
        }

        if (chadmainscript == null)
        {
            chadmainscript = Chad.GetComponent<ChadMainScript>();
        }

        if (anim == null)
        {
            anim = Chad.GetComponent<Animator>();
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (chadmainscript.ChadDirection == ChadMainScript.Direction.Right)
        {
            transform.localScale = new Vector3(.4f, transform.localScale.y, transform.localScale.z);
        } else
        {
            transform.localScale = new Vector3(-.4f, transform.localScale.y, transform.localScale.z);
        }
        
        anim.SetBool("Walking", chadmainscript.ChadState == ChadMainScript.State.walking);
        anim.SetBool("Crouching", chadmainscript.ChadState == ChadMainScript.State.crouch);
    }
}
