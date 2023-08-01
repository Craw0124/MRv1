using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerGreenBall : MonoBehaviour
{
    public Animator greenBallAnimator;
    private bool hasTriggered = false;

    private void OnTriggerEnter(Collider other)
    {
        if (!hasTriggered && other.CompareTag("Fist"))
        {
            greenBallAnimator.SetTrigger("ActivateAnimation");
            hasTriggered = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (hasTriggered && other.CompareTag("Fist"))
        {
            hasTriggered = false;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
