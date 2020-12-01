﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static PauseMenu instance;

    [Header("Menu Settings")]
    public KeyCode MenuKey;

    [Space]
    public GameObject MenuObject;

    private void Awake() {

        if(instance != null && instance != this){

            Destroy(this.gameObject);
        }else{

            instance = this;
        }

        DontDestroyOnLoad(this.gameObject);
    }

    private void Update(){
        
        if(Input.GetKeyDown(MenuKey)){

            ToggleMenu(true);
        }
    }

    public void ToggleMenu(bool toggleBool){

        MenuObject.SetActive(toggleBool);
    }

    public void LoadScene(int Index){

        ToggleMenu(false);
        SceneManager.LoadScene(Index);
    }
}