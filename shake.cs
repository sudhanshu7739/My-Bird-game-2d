﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shake : MonoBehaviour
{
    public Animator camAnim;
    public void Camshake()
    {
        camAnim.SetTrigger("shake");
    }
}
