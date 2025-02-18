using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Geral : MonoBehaviour
{
    internal int placarJogadorNum, recordeNum;
    public Text placarJogadorTexto, recordeTexto;
    public AudioSource somPontoGanho, audiofundo;

    public GameObject telaBoasVindas, TelaGameOver;
    public Boladev  objetoVoador;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        placarJogadorNum = 0;
        AtualizarTextoPlacar();

        Time.timeScale = 0;
    }

    public void MarcarPonto()
    {
        placarJogadorNum += 1;
        if (recordeNum < placarJogadorNum)
            recordeNum += 1;


        AtualizarTextoPlacar();

        somPontoGanho.Play();
    }


    public void AtualizarTextoPlacar()
    {
        placarJogadorTexto.text = "Itens coletados: " + placarJogadorNum;
        recordeTexto.text = "Rcorde Atual: " + recordeNum; 
    }

    public void ComeçarJogo()

    {   // Descongelar o tempo 
        Time.timeScale = 1;

        // Sumir com as telas de boas vindas OU game over 
        telaBoasVindas.SetActive(false);
        TelaGameOver.SetActive(false);

        // VOltar obejto voador a posiçao original 
        objetoVoador.deslocamentoAbs = objetoVoador.deslocamentoObjeto;
        objetoVoador.posicaoObj.x = objetoVoador.posInicialX;

        // Zerar o placar
        placarJogadorNum = 0;
        AtualizarTextoPlacar ();

        audiofundo.Play();
    }

    public void CarregarCena(string nomeDaCena)
    {
        SceneManager.LoadScene(nomeDaCena); 
    }
}   



