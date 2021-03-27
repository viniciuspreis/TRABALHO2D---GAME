using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScript : MonoBehaviour
{
    private float screenWidth;

    void Start()
    {
        Rigidbody2D body = GetComponent<Rigidbody2D>();

        SpriteRenderer renderer = GetComponent<SpriteRenderer>();

        float imageWidth = renderer.sprite.bounds.size.x;
        float imageHeight = renderer.sprite.bounds.size.y;
        
        float screenHeight = Camera.main.orthographicSize * 2;

        screenWidth = screenHeight /  Screen.height * Screen.width;

        Vector2 newScale = this.transform.localScale;

        newScale.x = screenWidth / imageWidth + 0.25f;
        newScale.y = screenHeight / imageHeight;

        this.transform.localScale = newScale;

        body.velocity = new Vector2(-3, 0);

        if (this.name == "Background2")
        {
            this.transform.position = new Vector2(screenWidth, 0);
        }
    }

    void Update()
    {
        if (this.transform.position.x <= -screenWidth)
        {
            this.transform.position = new Vector2(screenWidth, 0);
        }
    }
}
