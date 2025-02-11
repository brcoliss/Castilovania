using UnityEngine;

public class Boladev : MonoBehaviour
{

    public float deslocamentoObjeto;
    internal int sentidoV;
    internal Vector3 posicaoObj;

    public float posInicialX;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        sentidoV = 1;
        posicaoObj = transform.position;
        posInicialX = transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        posicaoObj.y += (deslocamentoObjeto * sentidoV * Time.deltaTime);
        posicaoObj.x += (deslocamentoObjeto * Time.deltaTime);

        transform.position = posicaoObj;

        //Limitador vertical
        if (transform.position.y > 478)
            sentidoV = -1;
        else if (transform.position.y < 30)
            sentidoV = 1;

    }

}