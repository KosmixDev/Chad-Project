using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RagdollPhysics : MonoBehaviour
{
    public Collider2D[] RagdollColls;
    // Start is called before the first frame update
    void Start()
    {
        RagdollColls = this.gameObject.GetComponentsInChildren<Collider2D>();
        for (int i = 0; i < RagdollColls.Length; i++)
        {
            for (int i2 = 0; i2 < RagdollColls.Length; i2++)
            {
                if (i2 != i)
                {
                    Physics2D.IgnoreCollision(RagdollColls[i], RagdollColls[i2]);
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
