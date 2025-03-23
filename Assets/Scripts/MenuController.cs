using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class MenuController : MonoBehaviour
{
    private UIDocument menu;

    private Button Jugar;

    private Button Ayuda;

    private Button Creditos;

    
    private Button SalirJuego;

    void OnEnable()
    {
        menu  = GetComponent<UIDocument>();
        var root = menu.rootVisualElement;

        Jugar= root.Q<Button>("Jugar");
        Ayuda= root.Q<Button>("Ayuda");
        Creditos= root.Q<Button>("Creditos");
        SalirJuego= root.Q<Button>("Salir");


        Jugar.RegisterCallback<ClickEvent,String>(JugarB,"SampleScene");
        Ayuda.RegisterCallback<ClickEvent,String>(JugarB,"MenuAyuda");
        Creditos.RegisterCallback<ClickEvent,String>(JugarB,"Creditos");

    }

    private void JugarB(ClickEvent evt, String nombreEscena){

        SceneManager.LoadScene(nombreEscena);
    }

    


}