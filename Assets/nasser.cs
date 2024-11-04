using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nasser : MonoBehaviour
{
    public int nasser2 = 1;
    public int nasser3 = 1;
    private Transform transform_;
    private SpriteRenderer spriteRenderer_;
    // Start is called before the first frame update
    void Start()
    {
        transform_ = GetComponent<Transform>();
        spriteRenderer_ = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        transform_.position = new Vector2(transform_.position.x + nasser2 * Time.deltaTime, transform_.position.y + nasser3 * Time.deltaTime);
        
        if (transform_.position.x >= 7.878f)
        {
            nasser2 = nasser2 * -1;
            spriteRenderer_.flipX = true;
        }
        if (transform_.position.x <= -7.878f)
        {
            nasser2 = nasser2 * -1;
            spriteRenderer_.flipX = false;
        }
        if (transform_.position.y >= 3.735f)
        {
            nasser3 = nasser3 * -1;
            spriteRenderer_.flipY = true;
        }
        if (transform_.position.y <= -3.735f)
        {
            nasser3 = nasser3 * -1;
            spriteRenderer_.flipY = false;
        }
    }
}
