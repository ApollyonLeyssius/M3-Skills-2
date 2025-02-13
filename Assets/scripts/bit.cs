using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bit : MonoBehaviour
{
    // Start is called before the first frame update
    SpriteRenderer spriteRenderer;
    bool state = false;
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.color = Color.red;
    }

    // Update is called once per frame

    private void OnMouseUp()
    {
        state = !state;
    }
    void Update()
    {
        if (state)
        {
            spriteRenderer.color = Color.green;
        }
        else
        {
            spriteRenderer.color = Color.red;
        }
    }
}
