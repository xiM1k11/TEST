using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainController : MonoBehaviour
{
    public ParticleSystem _particl;
    private void Start()
    {
        _particl.Stop();
    }
}
