using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Bumper : MonoBehaviour
{

    public Collider Ball;
    public Color color;
    public float multiplier;
    public AudioManager audioManager;
    public ScoreManager scoreManager;
    public float score;

    public VFXManager vfxManager;

    private Renderer renderer;
    private Animator animator;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider == Ball)
        {
            Rigidbody BallRig = Ball.GetComponent<Rigidbody>();
            BallRig.velocity *= multiplier;

            //animasikeun
            animator.SetTrigger("hit");

            //playsfx
            audioManager.PlaySFX(collision.transform.position);

            //Score add
            scoreManager.AddScore(score);

            //VFX
            vfxManager.PlayVFX(collision.transform.position);
        }
    }

    // Start is called before the first frame update
    private void Start()
    {
        renderer = GetComponent<Renderer>();
        animator = GetComponent<Animator>();
        
        renderer.material.color = color;
    }

}
