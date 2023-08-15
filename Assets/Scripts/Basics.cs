using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

public class Basics : MonoBehaviour
{
    [NonSerialized] public int _num = 5;
    public string world;
    [SerializeField]private float nums;

    public List<string> words = new List<string>();
    
    public int[] numbers = new int[3];
    void Start()
    {
        if(_num != 5)
        Debug.Log(world + nums);

        Botik();
    }

    void Botik()
    {

    }
}
