using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    public AudioSource tingSource;
    // Start is called before the first frame update
    void Start()
    {
        tingSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Switch");

        tingSource.Play();
    }
}
