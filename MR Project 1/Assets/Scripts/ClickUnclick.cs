using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickUnclick : MonoBehaviour

{
    private Animator animatorGreen;
    private bool isAnimating = false;

    private void Start()
    {
        animatorGreen = GetComponent<Animator>();
    }
    private void Update()
    {
        
    }

}
