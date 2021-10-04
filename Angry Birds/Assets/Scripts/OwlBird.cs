using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OwlBird : Bird
{
    public Explosion explosionPrefab;

    private bool _isExploded = false;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!_isExploded)
        {
            Instantiate(explosionPrefab, transform.position, Quaternion.identity);
            _isExploded = true;
        }
    }
}
