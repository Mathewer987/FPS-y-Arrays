using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class InteractionArea : MonoBehaviour
{

    public Text txtScore;
    public int Score;
    public int Ganaste;
    void Start()
    {
        txtScore.text = "0";
    }

    private void OnCollisionEnter(Collision collision)
    {
        
            Debug.Log("Contacto");
            AlimentoScript alimento;
            alimento = collision.gameObject.GetComponent<AlimentoScript>();
            Score += alimento.valorAlimentario;
        if (Ganaste > Score)
        {
            txtScore.text = Score.ToString();
            Destroy(collision.gameObject);
        }

        else 
        {
            txtScore.text = "Ganaste";
        }
    }
}
