using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    public Transform sprite;
    public float spriteSize = 25;
    public float timer = 0.2f;

    private float _timer;
    private Vector2 targetScale;

    private void Start()
    {
        _timer = timer;
        sprite.localScale = Vector2.zero;
        targetScale = new Vector2(spriteSize, spriteSize);
    }

    private void Update()
    {
        _timer -= Time.deltaTime;

        if(_timer >= 0)
        {
            float ratio = 1 - (_timer / timer);
            Vector2 newScale = Vector2.Lerp(Vector2.zero, targetScale, ratio);
            sprite.localScale = newScale;
        }

        if(_timer <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}
