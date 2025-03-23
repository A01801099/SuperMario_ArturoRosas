using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class BotonCredititos: MonoBehaviour
{
    private UIDocument menu;

    private Button Regreso3;


    void OnEnable()
    {
        menu  = GetComponent<UIDocument>();
        var root = menu.rootVisualElement;

        Regreso3= root.Q<Button>("Regreso3");
       


        Regreso3.RegisterCallback<ClickEvent,String>(JugarB,"MenuPrincipal");
        

    }

    private void JugarB(ClickEvent evt, String nombreEscena){

        SceneManager.LoadScene(nombreEscena);
    }

    


}