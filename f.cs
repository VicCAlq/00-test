
using Unity.VisualScripting;
using UnityEngine;

public class ControleJogador : MonoBehaviour
{
    [Header("Variáveis de Movimento")]
    [SerializeField] private float velocidadeBase = 1f;
    [SerializeField] private float multiplicadorVelocidade = 1.5f;
    [SerializeField] private float suavidadeRotacao = 2f;
    [SerializeField] private float inercia = 1.5f;
    [SerializeField] private float inerciaAngulo = 1.5f;

    [Header("Configurações do mouse")]
    [SerializeField] private float sensibilidadeMouse = 2f;

    [Header("Referências de objetos")]
    [SerializeField] private Camera cameraJogador;

    private float multiplicadorVelocidadeAtual = 1f;
    private UnityEngine.Vector3 direcao;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        rb = GetComponent<Rigidbody>();
        if (rb == null)
        {
            rb = gameObject.AddComponent<Rigidbody>();
            if (rb == null)
            {
                Debug.LogError("Não foi possível anexar um corpo rígido.");
            }
        }

        rb.useGravity = false;
        rb.drag = inercia;
        rb.angularDrag = inerciaAngulo;

        if (cameraJogador == null)
        {
            cameraJogador = Camera.main;
            if (cameraJogador == null)
            {
                Debug.LogError("Não foi encontrada uma câmera principal.");
            }
        }

        direcao = transform.forward;
    }

    // Update is called once per frame
    void Update()
    {
        ControlarMouse();
        ControlarAceleracao();
        AtualizarDirecao();
    }

    void FixedUpdate()
    {
        MoverSubmarino();
    }

    void ControlarMouse()
    {
        float mouseX = Input.GetAxis("Mouse X") * sensibilidadeMouse;
        float mouseY = Input.GetAxis("Mouse Y") * sensibilidadeMouse;

        if (mouseX != 0 || mouseY != 0)
        {
            UnityEngine.Vector3 rotacao = transform.eulerAngles;
            rotacao.y += mouseX;
            rotacao.x -= mouseY;

            transform.eulerAngles = rotacao;
        }
    }

    void ControlarAceleracao()
    {
        if (Input.GetMouseButtonDown(0))
        {
            multiplicadorVelocidadeAtual = multiplicadorVelocidade;
        }

        if (Input.GetMouseButtonUp(0))
        {
            multiplicadorVelocidadeAtual = 1f;
        }
    }

    void MoverSubmarino()
    {
        float velocidadeAtual = 
            velocidadeBase * multiplicadorVelocidadeAtual;

        UnityEngine.Vector3 movimento = 
            Time.fixedDeltaTime * velocidadeAtual * direcao;

        rb.MovePosition(rb.position + movimento);

        if (movimento.magnitude > 0.01f)
        {
            UnityEngine.Quaternion rotacaoAlvo =
                UnityEngine.Quaternion.LookRotation(movimento);
            rb.MoveRotation(UnityEngine.Quaternion.Slerp(
                transform.rotation, 
                rotacaoAlvo,
                suavidadeRotacao * Time.fixedDeltaTime
            ));
        }
    }

    void AtualizarDirecao()
    {
        if (cameraJogador != null)
        {
            UnityEngine.Vector3 cameraParaFrente = 
                cameraJogador.transform.forward;
            direcao = cameraParaFrente.normalized;
        } else
        {
            direcao = transform.forward;
        }
    }
}
