using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisionsX : MonoBehaviour
{
    public int points = 1;

    private void OnTriggerEnter(Collider other)
    {
        ScoreManager.instance.AddScore(points);
        Destroy(gameObject);
    }
}
