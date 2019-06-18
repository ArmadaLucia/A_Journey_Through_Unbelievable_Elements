using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangMatBut : MonoBehaviour
{

    public Material[] materials; //what kind of material?
    public Renderer rend; //what kind of object?

    private int index;

    private void Start()
    {
        index = PlayerPrefs.GetInt("CharacterSelected");

        //materials = new Material[22];

        rend.sharedMaterial = materials[index];
    }



    public void ToggleLeft()
    {

        if (materials.Length == 0)// if there are no materials nothing happens
        {
            return;
        }

        index--; //index -=1; index = -1;

        if (index < 0)
        {
            index = materials.Length -1;
        }

        print(index); //for debugging

        rend.sharedMaterial = materials[index]; //sets the material inside the index list

    }

    public void ToggleRight()
    {

        if (materials.Length == 0)// if there are no materials nothing happens
        {
            return;
        }

        index++; //index -=1; index = -1;

        if (index == materials.Length)
        {
            index = 0;
        }

        Debug.Log(index); //for debugging

        rend.sharedMaterial = materials[index]; //sets the material inside the index list
    }

    public void ConfirmButton()
    {
        PlayerPrefs.SetInt("CharacterSelected", index);
        SceneManager.LoadScene("DuckJourney");
    }
}