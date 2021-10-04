using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    //public PointEffector2D effector;
    public float timer = 0.2f;

    private float _timer;

    private void Start()
    {
        _timer = timer;
    }

    private void Update()
    {
        _timer -= Time.deltaTime;
        if(_timer <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}
