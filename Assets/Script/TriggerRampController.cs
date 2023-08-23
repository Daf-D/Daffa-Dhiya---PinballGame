using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerRampController : MonoBehaviour
{
    public float score;

    public Collider Ball;
    public ScoreManager scoreManager;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other == Ball)
        {
            scoreManager.AddScore(score);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
