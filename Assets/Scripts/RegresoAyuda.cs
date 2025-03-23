using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class RegresoAyuda : MonoBehaviour
{
    private UIDocument menu;

    private Button Regreso2;


    void OnEnable()
    {
        menu  = GetComponent<UIDocument>();
        var root = menu.rootVisualElement;

        Regreso2= root.Q<Button>("Regreso2");
       


        Regreso2.RegisterCallback<ClickEvent,String>(JugarB,"MenuPrincipal");
        

    }

    private void JugarB(ClickEvent evt, String nombreEscena){

        SceneManager.LoadScene(nombreEscena);
    }

    


}