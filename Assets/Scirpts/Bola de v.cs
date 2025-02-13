using UnityEngine;
using UnityEngine.UI;

public class Boladev : MonoBehaviour
{

    public float deslocamentoObjeto; // Determinar a velocidade inical do obj 
    public float incrementoVelocidade; // Determinar o aumento da velocidade por segundo 
    public Sprite[] imagensobjetos; // Determinar quantas imagens irao aparacer

    internal int sentidoV; // Para qual "lado" o objeto vai na vertical 
    internal Vector3 posicaoObj; // A variavel 
    internal float deslocamentoAbs;
    internal int numImagemAtual = 0;    

    public float posInicialX;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Movimentação : VElocidade do DEslocamento do objeto vezes  sentido(vertical) 
        // sentido (vertical),vezes "Time.DeltaTime", vezes velocidade dinamica

        sentidoV = 1;
        posicaoObj = transform.position;
        posInicialX = transform.position.x;

        deslocamentoAbs = deslocamentoObjeto;
    }

    // Update is called once per frame
    void Update()
    {
        posicaoObj.y += deslocamentoAbs * sentidoV * Time.deltaTime;
        posicaoObj.x += deslocamentoAbs * Time.deltaTime;

        deslocamentoAbs += incrementoVelocidade * Time.deltaTime;

        transform.position = posicaoObj;

        //Limitador vertical
        if (transform.position.y > 478)
            sentidoV = -1;
        else if (transform.position.y < 30)
            sentidoV = 1;

    }


    public void MudarImagem()
    {
        numImagemAtual += 1;

        if (numImagemAtual == imagensobjetos.Length)
            numImagemAtual = 0;

        GetComponent<Image>().sprite = imagensobjetos[numImagemAtual];

    }

}