using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Botones : MonoBehaviour
{
   public void Iniciar(){
       SceneManager.LoadScene(1);
   }

   public void Regresar(){
       SceneManager.LoadScene(0);
   }
   public void Salir(){
       Application.Quit();
       Debug.Log("Saliendo");
   }
}
