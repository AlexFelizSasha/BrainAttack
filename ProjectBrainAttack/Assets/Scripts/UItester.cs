using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Coffee;
using Coffee.UIExtensions;

public class UItester : MonoBehaviour
{
    private UIParticle _myUIParticle;

    private void Start()
    {
        _myUIParticle = GetComponent<UIParticle>();
        _myUIParticle.Play();
    }
}
