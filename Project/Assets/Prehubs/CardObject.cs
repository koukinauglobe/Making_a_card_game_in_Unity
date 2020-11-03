using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardObject : MonoBehaviour
{
    SpriteRenderer spriterenderer;

    public Sprite[] faces;
    public Sprite cardback;

    public int cardindex;

    public void ToggleFace(bool showface)
    {
        if (showface) {
            spriterenderer.sprite = faces[cardindex];
        } else
        {
            spriterenderer.sprite = cardback;
        }
    }

    public void SetCardIndex(int index)
    {
        cardindex = index;
    }

    void Awake()
    {
        spriterenderer = GetComponent<SpriteRenderer>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
