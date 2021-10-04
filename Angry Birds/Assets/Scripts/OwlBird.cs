using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OwlBird : Bird
{
    public Explosion explosionPrefab;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Instantiate(explosionPrefab, transform.position, Quaternion.identity);
    }
}
