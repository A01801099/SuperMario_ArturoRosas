using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class BotonRegresp : MonoBehaviour
{
    private UIDocument menu;

    private Button Regreso;


    void OnEnable()
    {
        menu  = GetComponent<UIDocument>();
        var root = menu.rootVisualElement;

        Regreso= root.Q<Button>("Regreso");
       


        Regreso.RegisterCallback<ClickEvent,String>(JugarB,"MenuPrincipal");
        

    }

    private void JugarB(ClickEvent evt, String nombreEscena){

        SceneManager.LoadScene(nombreEscena);
    }

    


}