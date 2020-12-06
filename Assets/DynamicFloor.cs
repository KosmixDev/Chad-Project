using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DynamicFloor : MonoBehaviour
{
    public BoxCollider2D BColl2D;
    public SpriteRenderer SRender;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        BColl2D.size = new Vector2(SRender.size.x, SRender.size.y);
    }
}
