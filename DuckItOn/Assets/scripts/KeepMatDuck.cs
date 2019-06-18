using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeepMatDuck : MonoBehaviour
{
    public Material[] materials; //what kind of material?
    public Renderer rend; //what kind of object?

    private int index;

    private void Start()
    {
        index = PlayerPrefs.GetInt("CharacterSelected");

    }



}