using System.Security.Cryptography;
using UnityEngine;

public class ControladorJogador : MonoBehaviour
{
    public float taxaMovimentacao;
    public Geral JuizdoJogo;

    // Update is called once per frame
    void Update()
    {

        float altX, altY;

        // Para cima e para baixo
        if (Input.GetKey(KeyCode.UpArrow) && transform.position.y < 478)
            altY = 60 * Time.deltaTime * taxaMovimentacao;
        else if (Input.GetKey(KeyCode.DownArrow) && transform.position.y > 23)
            altY = -60 * Time.deltaTime * taxaMovimentacao;
        else
            altY = 0;

        // Para os lados
        if (Input.GetKey(KeyCode.LeftArrow) && transform.position.x > 23)
            altX = -60 * Time.deltaTime * taxaMovimentacao;
        else if (Input.GetKey(KeyCode.RightArrow) && transform.position.x < 938)
            altX = 60 * Time.deltaTime * taxaMovimentacao;
        else
            altX = 0;

        // Modificar posição:

        Vector3 novaPos = new Vector3(altX, altY, 0);
        transform.position += novaPos;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "Voador")
        {
            JuizdoJogo.MarcarPonto();
            collision.GetComponent<Boladev>().posicaoObj.x =
                collision.GetComponent<Boladev>().posInicialX;
        }
    }

}
