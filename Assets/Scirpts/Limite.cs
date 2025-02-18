using UnityEngine;

public class Limite : MonoBehaviour
{
    public GameObject objetoGameOver;
    public AudioSource audiofundo;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "Voador")
        {
            objetoGameOver.SetActive(true);
            audiofundo.Stop(); 
        }
    }
}
