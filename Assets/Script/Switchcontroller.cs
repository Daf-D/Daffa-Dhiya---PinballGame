using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SocialPlatforms;
using UnityEngine.VFX;

public class Switchcontroller : MonoBehaviour
{
    public Collider Ball;
    public Material offMaterial;
    public Material onMaterial;

    public VFXManager vfxManager;
    public float score;
    public ScoreManager scoreManager;


    private SwitchState state;
    private Renderer renderer;


    private enum SwitchState
    {
        off,
        on,
        blink
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other == Ball)
        {
            Toggle();
            //playVFX
            vfxManager.PlayVFX(other.transform.position);
        }
    }
    // Start is called before the first frame update
    private void Start()
    {
        renderer = GetComponent<Renderer>();

        Set(false);

        StartCoroutine(BlinkTimerStart(5));
    }
    private IEnumerator BlinkTimerStart(float time)
    {
        yield return new WaitForSeconds(time);
        StartCoroutine(Blink(2));
    }
        
    private void Set(bool active)
    {

        if (active == true)
        {
            state = SwitchState.on;
            renderer.material = onMaterial;
            StopAllCoroutines();
        }
        else
        {
            state = SwitchState.off;
            renderer.material = offMaterial;
            StartCoroutine(BlinkTimerStart(5));
        }
    }

    private void Toggle()
    {
        if (state == SwitchState.on)
        {
            Set(false);
        }
        else
        {
            Set(true);
        }
    }
    private IEnumerator Blink(int times)
    {
        state = SwitchState.blink;

        for (int i = 0; i < times;  i++)
        {
            renderer.material = onMaterial;
            yield return new WaitForSeconds(0.5f);
            renderer.material = offMaterial;
            yield return new WaitForSeconds(0.5f);
        }
        state = SwitchState.off;

        StartCoroutine(BlinkTimerStart(5));
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
